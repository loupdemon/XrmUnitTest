//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLaB.Xrm.Entities
{
	
	/// <summary>
	/// User or facility/equipment that can be scheduled for a service.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("resource")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class Resource : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string BusinessUnitId = "businessunitid";
			public const string CalendarId = "calendarid";
			public const string DisplayInServiceViews = "displayinserviceviews";
			public const string EntityImage = "entityimage";
			public const string EntityImage_Timestamp = "entityimage_timestamp";
			public const string EntityImage_URL = "entityimage_url";
			public const string EntityImageId = "entityimageid";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsDisabled = "isdisabled";
			public const string Name = "name";
			public const string ObjectTypeCode = "objecttypecode";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ResourceId = "resourceid";
			public const string Id = "resourceid";
			public const string SiteId = "siteid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_resources = "business_unit_resources";
			public const string equipment_resources = "equipment_resources";
			public const string organization_resources = "organization_resources";
			public const string resourcespec_resources = "resourcespec_resources";
			public const string site_resources = "site_resources";
			public const string systemuser_resources = "systemuser_resources";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Resource() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "resource";
		
		public const string PrimaryIdAttribute = "resourceid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 4002;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// business_unit_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessUnitId");
				this.SetAttributeValue("businessunitid", value);
				this.OnPropertyChanged("BusinessUnitId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the calendar for the resource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
		public System.Nullable<System.Guid> CalendarId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("calendarid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CalendarId");
				this.SetAttributeValue("calendarid", value);
				this.OnPropertyChanged("CalendarId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayinserviceviews")]
		public System.Nullable<bool> DisplayInServiceViews
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("displayinserviceviews");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DisplayInServiceViews");
				this.SetAttributeValue("displayinserviceviews", value);
				this.OnPropertyChanged("DisplayInServiceViews");
			}
		}
		
		/// <summary>
		/// Shows the default image for the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Information about whether the resource is enabled.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
		public System.Nullable<bool> IsDisabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdisabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsDisabled");
				this.SetAttributeValue("isdisabled", value);
				this.OnPropertyChanged("IsDisabled");
			}
		}
		
		/// <summary>
		/// Name of the resource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Type of entity with which the resource is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
		public string ObjectTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("objecttypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ObjectTypeCode");
				this.SetAttributeValue("objecttypecode", value);
				this.OnPropertyChanged("ObjectTypeCode");
			}
		}
		
		/// <summary>
		/// organization_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OrganizationId");
				this.SetAttributeValue("organizationid", value);
				this.OnPropertyChanged("OrganizationId");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// systemuser_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourceid")]
		public System.Nullable<System.Guid> ResourceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("resourceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResourceId");
				this.SetAttributeValue("resourceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ResourceId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourceid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.ResourceId = value;
			}
		}
		
		/// <summary>
		/// site_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
		public Microsoft.Xrm.Sdk.EntityReference SiteId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("siteid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SiteId");
				this.SetAttributeValue("siteid", value);
				this.OnPropertyChanged("SiteId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version number of the resource.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N Resource_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Resource_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.AsyncOperation> Resource_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("Resource_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Resource_AsyncOperations");
				this.SetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("Resource_AsyncOperations", null, value);
				this.OnPropertyChanged("Resource_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N Resource_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Resource_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.BulkDeleteFailure> Resource_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("Resource_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Resource_BulkDeleteFailures");
				this.SetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("Resource_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("Resource_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N resource_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resource_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.MailboxTrackingFolder> resource_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.MailboxTrackingFolder>("resource_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("resource_MailboxTrackingFolders");
				this.SetRelatedEntities<DLaB.Xrm.Entities.MailboxTrackingFolder>("resource_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("resource_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N resource_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resource_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess> resource_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess>("resource_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("resource_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess>("resource_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("resource_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N Resource_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Resource_SyncErrors")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.SyncError> Resource_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.SyncError>("Resource_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Resource_SyncErrors");
				this.SetRelatedEntities<DLaB.Xrm.Entities.SyncError>("Resource_SyncErrors", null, value);
				this.OnPropertyChanged("Resource_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_resource
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_resource")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.UserEntityInstanceData> userentityinstancedata_resource
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_resource", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_resource");
				this.SetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_resource", null, value);
				this.OnPropertyChanged("userentityinstancedata_resource");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_resources")]
		public DLaB.Xrm.Entities.BusinessUnit business_unit_resources
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_resources", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_resources");
				this.SetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_resources", null, value);
				this.OnPropertyChanged("business_unit_resources");
			}
		}
		
		/// <summary>
		/// N:1 equipment_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourceid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_resources")]
		public DLaB.Xrm.Entities.Equipment equipment_resources
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Equipment>("equipment_resources", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("equipment_resources");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Equipment>("equipment_resources", null, value);
				this.OnPropertyChanged("equipment_resources");
			}
		}
		
		/// <summary>
		/// N:1 organization_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_resources")]
		public DLaB.Xrm.Entities.Organization organization_resources
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Organization>("organization_resources", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("organization_resources");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Organization>("organization_resources", null, value);
				this.OnPropertyChanged("organization_resources");
			}
		}
		
		/// <summary>
		/// N:1 resourcespec_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourceid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resourcespec_resources")]
		public DLaB.Xrm.Entities.ResourceSpec resourcespec_resources
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.ResourceSpec>("resourcespec_resources", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("resourcespec_resources");
				this.SetRelatedEntity<DLaB.Xrm.Entities.ResourceSpec>("resourcespec_resources", null, value);
				this.OnPropertyChanged("resourcespec_resources");
			}
		}
		
		/// <summary>
		/// N:1 site_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("site_resources")]
		public DLaB.Xrm.Entities.Site site_resources
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Site>("site_resources", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("site_resources");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Site>("site_resources", null, value);
				this.OnPropertyChanged("site_resources");
			}
		}
		
		/// <summary>
		/// N:1 systemuser_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourceid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_resources")]
		public DLaB.Xrm.Entities.SystemUser systemuser_resources
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("systemuser_resources", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("systemuser_resources");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("systemuser_resources", null, value);
				this.OnPropertyChanged("systemuser_resources");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Resource(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["resourceid"] = base.Id;
                        break;
                    case "resourceid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}