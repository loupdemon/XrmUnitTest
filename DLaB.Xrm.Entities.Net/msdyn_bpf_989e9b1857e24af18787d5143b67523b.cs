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
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public enum msdyn_bpf_989e9b1857e24af18787d5143b67523bState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Base entity for process Case to Work Order Business Process
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_bpf_989e9b1857e24af18787d5143b67523b")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class msdyn_bpf_989e9b1857e24af18787d5143b67523b : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ActiveStageId = "activestageid";
			public const string ActiveStageStartedOn = "activestagestartedon";
			public const string bpf_Duration = "bpf_duration";
			public const string bpf_incidentid = "bpf_incidentid";
			public const string bpf_msdyn_workorderid = "bpf_msdyn_workorderid";
			public const string bpf_name = "bpf_name";
			public const string BusinessProcessFlowInstanceId = "businessprocessflowinstanceid";
			public const string Id = "businessprocessflowinstanceid";
			public const string CompletedOn = "completedon";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ProcessId = "processid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TraversedPath = "traversedpath";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b = "bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b";
			public const string bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b = "bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b";
			public const string lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid = "lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid";
			public const string lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdby = "lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdby";
			public const string lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdonbehalfby = "lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdonbehalfby";
			public const string lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedby = "lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedby";
			public const string lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedonbehalfby = "lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedonbehalfby";
			public const string lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid = "lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid";
			public const string organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b = "organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_bpf_989e9b1857e24af18787d5143b67523b() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_bpf_989e9b1857e24af18787d5143b67523b";
		
		public const string PrimaryIdAttribute = "businessprocessflowinstanceid";
		
		public const string PrimaryNameAttribute = "bpf_name";
		
		public const int EntityTypeCode = 10118;
		
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
		/// Unique identifier of the active stage for the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestageid")]
		public Microsoft.Xrm.Sdk.EntityReference ActiveStageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activestageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActiveStageId");
				this.SetAttributeValue("activestageid", value);
				this.OnPropertyChanged("ActiveStageId");
			}
		}
		
		/// <summary>
		/// Date and time when current active stage is started
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestagestartedon")]
		public System.Nullable<System.DateTime> ActiveStageStartedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("activestagestartedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActiveStageStartedOn");
				this.SetAttributeValue("activestagestartedon", value);
				this.OnPropertyChanged("ActiveStageStartedOn");
			}
		}
		
		/// <summary>
		/// Duration of Business Process Flow
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bpf_duration")]
		public System.Nullable<int> bpf_Duration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("bpf_duration");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bpf_incidentid")]
		public Microsoft.Xrm.Sdk.EntityReference bpf_incidentid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("bpf_incidentid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bpf_incidentid");
				this.SetAttributeValue("bpf_incidentid", value);
				this.OnPropertyChanged("bpf_incidentid");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bpf_msdyn_workorderid")]
		public Microsoft.Xrm.Sdk.EntityReference bpf_msdyn_workorderid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("bpf_msdyn_workorderid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bpf_msdyn_workorderid");
				this.SetAttributeValue("bpf_msdyn_workorderid", value);
				this.OnPropertyChanged("bpf_msdyn_workorderid");
			}
		}
		
		/// <summary>
		/// Description
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bpf_name")]
		public string bpf_name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("bpf_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bpf_name");
				this.SetAttributeValue("bpf_name", value);
				this.OnPropertyChanged("bpf_name");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessprocessflowinstanceid")]
		public System.Nullable<System.Guid> BusinessProcessFlowInstanceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("businessprocessflowinstanceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessProcessFlowInstanceId");
				this.SetAttributeValue("businessprocessflowinstanceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("BusinessProcessFlowInstanceId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessprocessflowinstanceid")]
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
				this.BusinessProcessFlowInstanceId = value;
			}
		}
		
		/// <summary>
		/// Date and time when Business Process Flow instance is completed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedon")]
		public System.Nullable<System.DateTime> CompletedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("completedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CompletedOn");
				this.SetAttributeValue("completedon", value);
				this.OnPropertyChanged("CompletedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedBy");
				this.SetAttributeValue("createdby", value);
				this.OnPropertyChanged("CreatedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOn");
				this.SetAttributeValue("createdon", value);
				this.OnPropertyChanged("CreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
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
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedBy");
				this.SetAttributeValue("modifiedby", value);
				this.OnPropertyChanged("ModifiedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOn");
				this.SetAttributeValue("modifiedon", value);
				this.OnPropertyChanged("ModifiedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
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
		/// Unique identifier of the workflow associated to the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public Microsoft.Xrm.Sdk.EntityReference ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("processid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Status of the Case to Work Order Business Process
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<DLaB.Xrm.Entities.msdyn_bpf_989e9b1857e24af18787d5143b67523bState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((DLaB.Xrm.Entities.msdyn_bpf_989e9b1857e24af18787d5143b67523bState)(System.Enum.ToObject(typeof(DLaB.Xrm.Entities.msdyn_bpf_989e9b1857e24af18787d5143b67523bState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Case to Work Order Business Process
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
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
		/// Comma delimited string of process stage ids that represent visited stages of the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
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
		/// Version Number
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
		/// 1:N msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.AsyncOperation> msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations");
				this.SetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations", null, value);
				this.OnPropertyChanged("msdyn_bpf_989e9b1857e24af18787d5143b67523b_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.BulkDeleteFailure> msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures");
				this.SetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.MailboxTrackingFolder> msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.MailboxTrackingFolder>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders");
				this.SetRelatedEntities<DLaB.Xrm.Entities.MailboxTrackingFolder>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess> msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.ProcessSession> msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.ProcessSession>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession");
				this.SetRelatedEntities<DLaB.Xrm.Entities.ProcessSession>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession", null, value);
				this.OnPropertyChanged("msdyn_bpf_989e9b1857e24af18787d5143b67523b_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.SyncError> msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.SyncError>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors");
				this.SetRelatedEntities<DLaB.Xrm.Entities.SyncError>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors", null, value);
				this.OnPropertyChanged("msdyn_bpf_989e9b1857e24af18787d5143b67523b_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_989e9b1857e24af18787d5143b67523b_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_989e9b1857e24af18787d5143b67523b_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.UserEntityInstanceData> msdyn_bpf_989e9b1857e24af18787d5143b67523b_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_989e9b1857e24af18787d5143b67523b_UserEntityInstanceDatas");
				this.SetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("msdyn_bpf_989e9b1857e24af18787d5143b67523b_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.WorkflowLog> msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.WorkflowLog>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs");
				this.SetRelatedEntities<DLaB.Xrm.Entities.WorkflowLog>("msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs", null, value);
				this.OnPropertyChanged("msdyn_bpf_989e9b1857e24af18787d5143b67523b_WorkflowLogs");
			}
		}
		
		/// <summary>
		/// N:1 bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bpf_incidentid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b")]
		public DLaB.Xrm.Entities.Incident bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Incident>("bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Incident>("bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b", null, value);
				this.OnPropertyChanged("bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b");
			}
		}
		
		/// <summary>
		/// N:1 bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bpf_msdyn_workorderid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b")]
		public DLaB.Xrm.Entities.msdyn_workorder bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.msdyn_workorder>("bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b");
				this.SetRelatedEntity<DLaB.Xrm.Entities.msdyn_workorder>("bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b", null, value);
				this.OnPropertyChanged("bpf_msdyn_workorder_msdyn_bpf_989e9b1857e24af18787d5143b67523b");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid")]
		public DLaB.Xrm.Entities.ProcessStage lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.ProcessStage>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid");
				this.SetRelatedEntity<DLaB.Xrm.Entities.ProcessStage>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid", null, value);
				this.OnPropertyChanged("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdby", null, value);
				this.OnPropertyChanged("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedby", null, value);
				this.OnPropertyChanged("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid")]
		public DLaB.Xrm.Entities.Workflow lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Workflow>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Workflow>("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid", null, value);
				this.OnPropertyChanged("lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_processid");
			}
		}
		
		/// <summary>
		/// N:1 organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b")]
		public DLaB.Xrm.Entities.Organization organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Organization>("organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_bpf_989e9b1857e24af18787d5143b67523b(object anonymousType) : 
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
                        Attributes["businessprocessflowinstanceid"] = base.Id;
                        break;
                    case "businessprocessflowinstanceid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual msdyn_bpf_989e9b1857e24af18787d5143b67523b_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((msdyn_bpf_989e9b1857e24af18787d5143b67523b_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}