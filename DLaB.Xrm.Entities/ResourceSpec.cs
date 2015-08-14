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
	/// Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("resourcespec")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0001.0117")]
	public partial class ResourceSpec : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string BusinessUnitId = "businessunitid";
			public const string Constraints = "constraints";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string EffortRequired = "effortrequired";
			public const string GroupObjectId = "groupobjectid";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string ObjectiveExpression = "objectiveexpression";
			public const string ObjectTypeCode = "objecttypecode";
			public const string OrganizationId = "organizationid";
			public const string RequiredCount = "requiredcount";
			public const string ResourceSpecId = "resourcespecid";
			public const string Id = "resourcespecid";
			public const string SameSite = "samesite";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_resource_specs = "businessunitid";
			public const string constraint_based_group_resource_specs = "groupobjectid";
			public const string lk_resourcespec_createdby = "createdby";
			public const string lk_resourcespec_createdonbehalfby = "createdonbehalfby";
			public const string lk_resourcespec_modifiedby = "modifiedby";
			public const string lk_resourcespec_modifiedonbehalfby = "modifiedonbehalfby";
			public const string organization_resource_specs = "organizationid";
			public const string team_resource_specs = "groupobjectid";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ResourceSpec() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "resourcespec";
		
		public const int EntityTypeCode = 4006;
		
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
		/// Unique identifier of the business unit with which the resource specification is associated.
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
		/// Additional constraints, specified as expressions, which are used to filter a set of valid resources.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("constraints")]
		public string Constraints
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("constraints");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Constraints");
				this.SetAttributeValue("constraints", value);
				this.OnPropertyChanged("Constraints");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the resource specification.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the resource specification was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the resourcespec.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Number that specifies the minimal effort required from resources.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effortrequired")]
		public System.Nullable<double> EffortRequired
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("effortrequired");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EffortRequired");
				this.SetAttributeValue("effortrequired", value);
				this.OnPropertyChanged("EffortRequired");
			}
		}
		
		/// <summary>
		/// Unique identifier of the scheduling group with which the resource specification is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("groupobjectid")]
		public System.Nullable<System.Guid> GroupObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("groupobjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GroupObjectId");
				this.SetAttributeValue("groupobjectid", value);
				this.OnPropertyChanged("GroupObjectId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the resource specification.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the resource specification was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the resourcespec.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the resource specification.
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
		/// Search strategy to use for the resource specification.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectiveexpression")]
		public string ObjectiveExpression
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("objectiveexpression");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ObjectiveExpression");
				this.SetAttributeValue("objectiveexpression", value);
				this.OnPropertyChanged("ObjectiveExpression");
			}
		}
		
		/// <summary>
		/// Type of entity with which the resource specification is associated.
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
		/// Unique identifier of the organization with which the resource specification is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Required number of resources that must be available. Use -1 to indicate all resources.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requiredcount")]
		public System.Nullable<int> RequiredCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("requiredcount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RequiredCount");
				this.SetAttributeValue("requiredcount", value);
				this.OnPropertyChanged("RequiredCount");
			}
		}
		
		/// <summary>
		/// Unique identifier of the resource specification.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
		public System.Nullable<System.Guid> ResourceSpecId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("resourcespecid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResourceSpecId");
				this.SetAttributeValue("resourcespecid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ResourceSpecId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
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
				this.ResourceSpecId = value;
			}
		}
		
		/// <summary>
		/// Value that specifies that all valid and available resources must be in the same site.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("samesite")]
		public System.Nullable<bool> SameSite
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("samesite");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SameSite");
				this.SetAttributeValue("samesite", value);
				this.OnPropertyChanged("SameSite");
			}
		}
		
		/// <summary>
		/// 
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
		/// 1:N ActivityPartyResourceSpec
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPartyResourceSpec")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.ActivityParty> ActivityPartyResourceSpec
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.ActivityParty>("ActivityPartyResourceSpec", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActivityPartyResourceSpec");
				this.SetRelatedEntities<DLaB.Xrm.Entities.ActivityParty>("ActivityPartyResourceSpec", null, value);
				this.OnPropertyChanged("ActivityPartyResourceSpec");
			}
		}
		
		/// <summary>
		/// 1:N resource_spec_services
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resource_spec_services")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.Service> resource_spec_services
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.Service>("resource_spec_services", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("resource_spec_services");
				this.SetRelatedEntities<DLaB.Xrm.Entities.Service>("resource_spec_services", null, value);
				this.OnPropertyChanged("resource_spec_services");
			}
		}
		
		/// <summary>
		/// 1:N ResourceSpec_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceSpec_Annotation")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.Annotation> ResourceSpec_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.Annotation>("ResourceSpec_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResourceSpec_Annotation");
				this.SetRelatedEntities<DLaB.Xrm.Entities.Annotation>("ResourceSpec_Annotation", null, value);
				this.OnPropertyChanged("ResourceSpec_Annotation");
			}
		}
		
		/// <summary>
		/// 1:N ResourceSpec_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceSpec_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.AsyncOperation> ResourceSpec_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("ResourceSpec_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResourceSpec_AsyncOperations");
				this.SetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("ResourceSpec_AsyncOperations", null, value);
				this.OnPropertyChanged("ResourceSpec_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N ResourceSpec_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceSpec_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.BulkDeleteFailure> ResourceSpec_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("ResourceSpec_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResourceSpec_BulkDeleteFailures");
				this.SetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("ResourceSpec_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("ResourceSpec_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N resourcespec_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resourcespec_resources")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.Resource> resourcespec_resources
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.Resource>("resourcespec_resources", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("resourcespec_resources");
				this.SetRelatedEntities<DLaB.Xrm.Entities.Resource>("resourcespec_resources", null, value);
				this.OnPropertyChanged("resourcespec_resources");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_resourcespec
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_resourcespec")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.UserEntityInstanceData> userentityinstancedata_resourcespec
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_resourcespec", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_resourcespec");
				this.SetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_resourcespec", null, value);
				this.OnPropertyChanged("userentityinstancedata_resourcespec");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_resource_specs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_resource_specs")]
		public DLaB.Xrm.Entities.BusinessUnit business_unit_resource_specs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_resource_specs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_resource_specs");
				this.SetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_resource_specs", null, value);
				this.OnPropertyChanged("business_unit_resource_specs");
			}
		}
		
		/// <summary>
		/// N:1 constraint_based_group_resource_specs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("groupobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraint_based_group_resource_specs")]
		public DLaB.Xrm.Entities.ConstraintBasedGroup constraint_based_group_resource_specs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.ConstraintBasedGroup>("constraint_based_group_resource_specs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("constraint_based_group_resource_specs");
				this.SetRelatedEntity<DLaB.Xrm.Entities.ConstraintBasedGroup>("constraint_based_group_resource_specs", null, value);
				this.OnPropertyChanged("constraint_based_group_resource_specs");
			}
		}
		
		/// <summary>
		/// N:1 lk_resourcespec_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_resourcespec_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_resourcespec_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_resourcespec_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_resourcespec_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_resourcespec_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_resourcespec_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_resourcespec_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_resourcespec_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_resourcespec_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_resourcespec_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_resourcespec_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 organization_resource_specs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_resource_specs")]
		public DLaB.Xrm.Entities.Organization organization_resource_specs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Organization>("organization_resource_specs", null);
			}
		}
		
		/// <summary>
		/// N:1 team_resource_specs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("groupobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_resource_specs")]
		public DLaB.Xrm.Entities.Team team_resource_specs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Team>("team_resource_specs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("team_resource_specs");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Team>("team_resource_specs", null, value);
				this.OnPropertyChanged("team_resource_specs");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ResourceSpec(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                if (p.PropertyType == typeof(System.Guid))
                {
                    // Type is Guid, must be Id
                    base.Id = (System.Guid)value;
                    Attributes["resourcespecid"] = base.Id;
                }
                else if (p.Name == "FormattedValues")
                {
                    // Add Support for FormattedValues
                    FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                }
                else
                {
                    Attributes[p.Name.ToLower()] = value;
                }
            }
		}
	}
}