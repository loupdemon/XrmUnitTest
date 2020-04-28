﻿using System;
using DLaB.Xrm.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace DLaB.Xrm.LocalCrm.Tests
{
    [TestClass]
    public class ConditionExpressionTests : BaseTestClass
    {

        [TestMethod]
        public void LocalCrmTests_ConditionExpression_LikeIsCaseInsensitive()
        {
            var service = GetService();
            service.Create(new Contact { FirstName = "Jimmy" });
            Assert.IsNotNull(service.GetFirstOrDefault<Contact>(new ConditionExpression(Contact.Fields.FirstName, ConditionOperator.Like, "JIM%")));
        }

        [TestMethod]
        public void LocalCrmTests_ConditionExpression_LastXDays()
        {
            var service = GetService();
            var id = service.Create(new Contact
            {
                LastUsedInCampaign = DateTime.UtcNow.AddDays(-2d)
            });

            var contact = service.GetFirstOrDefault<Contact>(new ConditionExpression(Contact.Fields.CreatedOn, ConditionOperator.LastXDays, 2));
            Assert.IsNotNull(contact, "Contact should have been found because it was created in the last 2 days");

            Entity GetContact(int days) => service.GetFirstOrDefault<Contact>(new ConditionExpression(Contact.Fields.LastUsedInCampaign, ConditionOperator.LastXDays, days));

            Assert.IsNull(GetContact(1));
            Assert.IsNotNull(GetContact(3));
            service.Update(new Contact { Id = id, LastUsedInCampaign = DateTime.UtcNow.AddDays(2d) });
            Assert.IsNull(GetContact(3));
        }

        [TestMethod]
        public void LocalCrmTests_ConditionExpression_Last7Days()
        {
            var service = GetService();
            var id = service.Create(new Contact
            {
                LastUsedInCampaign = DateTime.UtcNow.AddDays(-6d)
            });

            Entity GetContact() => service.GetFirstOrDefault<Contact>(new ConditionExpression(Contact.Fields.LastUsedInCampaign, ConditionOperator.Last7Days));

            Assert.IsNotNull(GetContact());
            service.Update(new Contact { Id = id, LastUsedInCampaign = DateTime.UtcNow.AddDays(-8d) });
            Assert.IsNull(GetContact());
        }
        
        [TestMethod]
        public void LocalCrmTests_ConditionExpression_Next7Days()
        {
            var service = GetService();
            var id = service.Create(new Contact
            {
                LastUsedInCampaign = DateTime.UtcNow.AddDays(6d)
            });

            Entity GetContact() => service.GetFirstOrDefault<Contact>(new ConditionExpression(Contact.Fields.LastUsedInCampaign, ConditionOperator.Next7Days));

            Assert.IsNotNull(GetContact());
            service.Update(new Contact { Id = id, LastUsedInCampaign = DateTime.UtcNow.AddDays(8d) });
            Assert.IsNull(GetContact());
        }

        [TestMethod]
        public void LocalCrmTests_ConditionExpression_NextXDays()
        {
            var service = GetService();
            var id = service.Create(new Contact
            {
                LastUsedInCampaign = DateTime.UtcNow.AddDays(2d)
            });

            Entity GetContact(int days) => service.GetFirstOrDefault<Contact>(new ConditionExpression(Contact.Fields.LastUsedInCampaign, ConditionOperator.NextXDays, days));

            Assert.IsNull(GetContact(1));
            Assert.IsNotNull(GetContact(2));
            Assert.IsNotNull(GetContact(3));
            service.Update(new Contact { Id = id, LastUsedInCampaign = DateTime.UtcNow.AddDays(-2d) });
            Assert.IsNull(GetContact(3));
        }

        [TestMethod]
        public void LocalCrmTests_ConditionExpression_OnOrAfter()
        {
            var service = GetService();
            var now = DateTime.UtcNow;
            var id = service.Create(new Contact
            {
                LastUsedInCampaign = now.AddDays(1d)
            });

            Contact GetContact(int days) => service.GetFirstOrDefault<Contact>(new ConditionExpression(Contact.Fields.LastUsedInCampaign, ConditionOperator.OnOrAfter, now.AddDays(days)));

            Assert.IsNotNull(GetContact(0));
            Assert.IsNotNull(GetContact(1));
            Assert.IsNull(GetContact(2));
            service.Update(new Contact { Id = id, LastUsedInCampaign = now.AddDays(2) });
            Assert.IsNotNull(GetContact(2));
        }

        [TestMethod]
        public void LocalCrmTests_ConditionExpression_OnOrBefore()
        {
            var service = GetService();
            var now = DateTime.UtcNow;
            var id = service.Create(new Contact
            {
                LastUsedInCampaign = now.AddDays(1d)
            });

            Contact GetContact(int days) => service.GetFirstOrDefault<Contact>(new ConditionExpression(Contact.Fields.LastUsedInCampaign, ConditionOperator.OnOrBefore, now.AddDays(days)));

            Assert.IsNull(GetContact(0));
            Assert.IsNotNull(GetContact(1));
            Assert.IsNotNull(GetContact(2));
            service.Update(new Contact { Id = id, LastUsedInCampaign = now.AddDays(-1) });
            Assert.IsNotNull(GetContact(0));
        }

        [TestMethod]
        public void LocalCrmTests_ConditionExpression_Today()
        {
            var service = GetService();
            var id = service.Create(new Contact
            {
                LastUsedInCampaign = DateTime.UtcNow
            });

            Entity GetContact() => service.GetFirstOrDefault<Contact>(new ConditionExpression(Contact.Fields.LastUsedInCampaign, ConditionOperator.Today));

            Assert.IsNotNull(GetContact());
            service.Update(new Contact { Id = id, LastUsedInCampaign = DateTime.UtcNow.AddDays(1d) });
            Assert.IsNull(GetContact());
            service.Update(new Contact { Id = id, LastUsedInCampaign = DateTime.UtcNow.AddDays(-1d) });
            Assert.IsNull(GetContact());
        }

        [TestMethod]
        public void LocalCrmTests_ConditionExpression_Tomorrow()
        {
            var service = GetService();
            var id = service.Create(new Contact
            {
                LastUsedInCampaign = DateTime.UtcNow
            });

            Entity GetContact() => service.GetFirstOrDefault<Contact>(new ConditionExpression(Contact.Fields.LastUsedInCampaign, ConditionOperator.Tomorrow));

            Assert.IsNull(GetContact());
            service.Update(new Contact { Id = id, LastUsedInCampaign = DateTime.UtcNow.AddDays(1d) });
            Assert.IsNotNull(GetContact());
            service.Update(new Contact { Id = id, LastUsedInCampaign = DateTime.UtcNow.AddDays(2d) });
            Assert.IsNull(GetContact());
        }

        [TestMethod]
        public void LocalCrmTests_ConditionExpression_Yesterday()
        {
            var service = GetService();
            var id = service.Create(new Contact
            {
                LastUsedInCampaign = DateTime.UtcNow
            });

            Entity GetContact() => service.GetFirstOrDefault<Contact>(new ConditionExpression(Contact.Fields.LastUsedInCampaign, ConditionOperator.Yesterday));

            Assert.IsNull(GetContact());
            service.Update(new Contact { Id = id, LastUsedInCampaign = DateTime.UtcNow.AddDays(-1d) });
            Assert.IsNotNull(GetContact());
            service.Update(new Contact { Id = id, LastUsedInCampaign = DateTime.UtcNow.AddDays(-2d) });
            Assert.IsNull(GetContact());
        }
    }
}
