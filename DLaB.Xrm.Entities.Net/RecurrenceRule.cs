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
	/// Recurrence Rule represents the pattern of incidence of recurring entities.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("recurrencerule")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class RecurrenceRule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DayOfMonth = "dayofmonth";
			public const string DaysOfWeekMask = "daysofweekmask";
			public const string Duration = "duration";
			public const string EffectiveEndDate = "effectiveenddate";
			public const string EffectiveStartDate = "effectivestartdate";
			public const string EndTime = "endtime";
			public const string FirstDayOfWeek = "firstdayofweek";
			public const string Instance = "instance";
			public const string Interval = "interval";
			public const string IsNthMonthly = "isnthmonthly";
			public const string IsNthYearly = "isnthyearly";
			public const string IsRegenerate = "isregenerate";
			public const string IsWeekDayPattern = "isweekdaypattern";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string MonthOfYear = "monthofyear";
			public const string ObjectId = "objectid";
			public const string Occurrences = "occurrences";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string PatternEndDate = "patternenddate";
			public const string PatternEndType = "patternendtype";
			public const string PatternStartDate = "patternstartdate";
			public const string RecurrencePatternType = "recurrencepatterntype";
			public const string RuleId = "ruleid";
			public const string Id = "ruleid";
			public const string StartTime = "starttime";
			public const string VersionNumber = "versionnumber";
			public const string activity_pointer_recurrencerule = "activity_pointer_recurrencerule";
			public const string business_unit_recurrencerule = "business_unit_recurrencerule";
			public const string lk_recurrencerule_createdby = "lk_recurrencerule_createdby";
			public const string lk_recurrencerule_modifiedby = "lk_recurrencerule_modifiedby";
			public const string lk_recurrencerulebase_createdonbehalfby = "lk_recurrencerulebase_createdonbehalfby";
			public const string lk_recurrencerulebase_modifiedonbehalfby = "lk_recurrencerulebase_modifiedonbehalfby";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public RecurrenceRule() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "recurrencerule";
		
		public const string PrimaryIdAttribute = "ruleid";
		
		public const int EntityTypeCode = 4250;
		
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
		/// Unique identifier of the user who created the recurrence rule.
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
		/// Date and time when the recurrence rule was created.
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
		/// Unique identifier of the delegate user who created the recurrence rule.
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
		/// The day of the month on which the recurring appointment or task occurs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dayofmonth")]
		public System.Nullable<int> DayOfMonth
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("dayofmonth");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DayOfMonth");
				this.SetAttributeValue("dayofmonth", value);
				this.OnPropertyChanged("DayOfMonth");
			}
		}
		
		/// <summary>
		/// Bitmask representing the days of the week on which the recurring appointment or task occurs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daysofweekmask")]
		public System.Nullable<int> DaysOfWeekMask
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("daysofweekmask");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DaysOfWeekMask");
				this.SetAttributeValue("daysofweekmask", value);
				this.OnPropertyChanged("DaysOfWeekMask");
			}
		}
		
		/// <summary>
		/// Duration of the recurrence pattern in minutes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duration")]
		public System.Nullable<int> Duration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("duration");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Duration");
				this.SetAttributeValue("duration", value);
				this.OnPropertyChanged("Duration");
			}
		}
		
		/// <summary>
		/// The actual end date for expansion of the recurrence pattern.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectiveenddate")]
		public System.Nullable<System.DateTime> EffectiveEndDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectiveenddate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EffectiveEndDate");
				this.SetAttributeValue("effectiveenddate", value);
				this.OnPropertyChanged("EffectiveEndDate");
			}
		}
		
		/// <summary>
		/// The actual start date for expansion of the recurrence pattern.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectivestartdate")]
		public System.Nullable<System.DateTime> EffectiveStartDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectivestartdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EffectiveStartDate");
				this.SetAttributeValue("effectivestartdate", value);
				this.OnPropertyChanged("EffectiveStartDate");
			}
		}
		
		/// <summary>
		/// End time of the associated activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("endtime")]
		public System.Nullable<System.DateTime> EndTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("endtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EndTime");
				this.SetAttributeValue("endtime", value);
				this.OnPropertyChanged("EndTime");
			}
		}
		
		/// <summary>
		/// First day Of week for the recurrence pattern.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstdayofweek")]
		public System.Nullable<int> FirstDayOfWeek
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("firstdayofweek");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FirstDayOfWeek");
				this.SetAttributeValue("firstdayofweek", value);
				this.OnPropertyChanged("FirstDayOfWeek");
			}
		}
		
		/// <summary>
		/// Specifies the count for which the recurrence pattern is valid for a given interval.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instance")]
		public Microsoft.Xrm.Sdk.OptionSetValue Instance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("instance");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Instance");
				this.SetAttributeValue("instance", value);
				this.OnPropertyChanged("Instance");
			}
		}
		
		/// <summary>
		/// Number of units of a given recurrence type between occurrences.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interval")]
		public System.Nullable<int> Interval
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("interval");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Interval");
				this.SetAttributeValue("interval", value);
				this.OnPropertyChanged("Interval");
			}
		}
		
		/// <summary>
		/// Specifies whether the monthly recurrence pattern is Nth monthly, valid only for monthly recurrence.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isnthmonthly")]
		public System.Nullable<bool> IsNthMonthly
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isnthmonthly");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsNthMonthly");
				this.SetAttributeValue("isnthmonthly", value);
				this.OnPropertyChanged("IsNthMonthly");
			}
		}
		
		/// <summary>
		/// Specifies whether the yearly recurrence pattern is Nth yearly, valid only for yearly recurrence.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isnthyearly")]
		public System.Nullable<bool> IsNthYearly
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isnthyearly");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsNthYearly");
				this.SetAttributeValue("isnthyearly", value);
				this.OnPropertyChanged("IsNthYearly");
			}
		}
		
		/// <summary>
		/// Valid only for task type recurrence,indicates whether task should be regenerated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregenerate")]
		public System.Nullable<bool> IsRegenerate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isregenerate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsRegenerate");
				this.SetAttributeValue("isregenerate", value);
				this.OnPropertyChanged("IsRegenerate");
			}
		}
		
		/// <summary>
		/// Specifies whether the weekly recurrence pattern is actually a daily every weekday pattern, valid only for weekly recurrence.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isweekdaypattern")]
		public System.Nullable<bool> IsWeekDayPattern
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isweekdaypattern");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsWeekDayPattern");
				this.SetAttributeValue("isweekdaypattern", value);
				this.OnPropertyChanged("IsWeekDayPattern");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the recurrence rule.
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
		/// Date and time when the recurrence rule was last modified.
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
		/// Unique identifier of the delegate user who modified the recurrence rule.
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
		/// Specifies the month of the year valid for the recurrence pattern.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("monthofyear")]
		public Microsoft.Xrm.Sdk.OptionSetValue MonthOfYear
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("monthofyear");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MonthOfYear");
				this.SetAttributeValue("monthofyear", value);
				this.OnPropertyChanged("MonthOfYear");
			}
		}
		
		/// <summary>
		/// Unique identifier of the object with which the recurrence rule is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		public Microsoft.Xrm.Sdk.EntityReference ObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ObjectId");
				this.SetAttributeValue("objectid", value);
				this.OnPropertyChanged("ObjectId");
			}
		}
		
		/// <summary>
		/// Number of occurrences of the recurrence pattern.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("occurrences")]
		public System.Nullable<int> Occurrences
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("occurrences");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Occurrences");
				this.SetAttributeValue("occurrences", value);
				this.OnPropertyChanged("Occurrences");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the recurrence rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the recurrence rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningBusinessUnit");
				this.SetAttributeValue("owningbusinessunit", value);
				this.OnPropertyChanged("OwningBusinessUnit");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningTeam");
				this.SetAttributeValue("owningteam", value);
				this.OnPropertyChanged("OwningTeam");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningUser");
				this.SetAttributeValue("owninguser", value);
				this.OnPropertyChanged("OwningUser");
			}
		}
		
		/// <summary>
		/// End date of the Recurrence Range.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("patternenddate")]
		public System.Nullable<System.DateTime> PatternEndDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("patternenddate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PatternEndDate");
				this.SetAttributeValue("patternenddate", value);
				this.OnPropertyChanged("PatternEndDate");
			}
		}
		
		/// <summary>
		/// Pattern End Type of a recurring series.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("patternendtype")]
		public Microsoft.Xrm.Sdk.OptionSetValue PatternEndType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("patternendtype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PatternEndType");
				this.SetAttributeValue("patternendtype", value);
				this.OnPropertyChanged("PatternEndType");
			}
		}
		
		/// <summary>
		/// Start date of the Recurrence Range.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("patternstartdate")]
		public System.Nullable<System.DateTime> PatternStartDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("patternstartdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PatternStartDate");
				this.SetAttributeValue("patternstartdate", value);
				this.OnPropertyChanged("PatternStartDate");
			}
		}
		
		/// <summary>
		/// Type of Recurrence.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrencepatterntype")]
		public Microsoft.Xrm.Sdk.OptionSetValue RecurrencePatternType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("recurrencepatterntype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RecurrencePatternType");
				this.SetAttributeValue("recurrencepatterntype", value);
				this.OnPropertyChanged("RecurrencePatternType");
			}
		}
		
		/// <summary>
		/// Unique identifier of the entity associated with recurrence rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ruleid")]
		public System.Nullable<System.Guid> RuleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ruleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RuleId");
				this.SetAttributeValue("ruleid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("RuleId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ruleid")]
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
				this.RuleId = value;
			}
		}
		
		/// <summary>
		/// Start time of the recurring activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("starttime")]
		public System.Nullable<System.DateTime> StartTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("starttime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StartTime");
				this.SetAttributeValue("starttime", value);
				this.OnPropertyChanged("StartTime");
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
		/// 1:N recurrencerule_recurringappointmentmaster
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurrencerule_recurringappointmentmaster")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.RecurringAppointmentMaster> recurrencerule_recurringappointmentmaster
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.RecurringAppointmentMaster>("recurrencerule_recurringappointmentmaster", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("recurrencerule_recurringappointmentmaster");
				this.SetRelatedEntities<DLaB.Xrm.Entities.RecurringAppointmentMaster>("recurrencerule_recurringappointmentmaster", null, value);
				this.OnPropertyChanged("recurrencerule_recurringappointmentmaster");
			}
		}
		
		/// <summary>
		/// N:1 activity_pointer_recurrencerule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_recurrencerule")]
		public DLaB.Xrm.Entities.ActivityPointer activity_pointer_recurrencerule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.ActivityPointer>("activity_pointer_recurrencerule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("activity_pointer_recurrencerule");
				this.SetRelatedEntity<DLaB.Xrm.Entities.ActivityPointer>("activity_pointer_recurrencerule", null, value);
				this.OnPropertyChanged("activity_pointer_recurrencerule");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_recurrencerule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_recurrencerule")]
		public DLaB.Xrm.Entities.BusinessUnit business_unit_recurrencerule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_recurrencerule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_recurrencerule");
				this.SetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_recurrencerule", null, value);
				this.OnPropertyChanged("business_unit_recurrencerule");
			}
		}
		
		/// <summary>
		/// N:1 lk_recurrencerule_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerule_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_recurrencerule_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_recurrencerule_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_recurrencerule_createdby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_recurrencerule_createdby", null, value);
				this.OnPropertyChanged("lk_recurrencerule_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_recurrencerule_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerule_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_recurrencerule_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_recurrencerule_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_recurrencerule_modifiedby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_recurrencerule_modifiedby", null, value);
				this.OnPropertyChanged("lk_recurrencerule_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_recurrencerulebase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerulebase_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_recurrencerulebase_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_recurrencerulebase_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_recurrencerulebase_createdonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_recurrencerulebase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_recurrencerulebase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_recurrencerulebase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerulebase_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_recurrencerulebase_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_recurrencerulebase_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_recurrencerulebase_modifiedonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_recurrencerulebase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_recurrencerulebase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public RecurrenceRule(object anonymousType) : 
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
                        Attributes["ruleid"] = base.Id;
                        break;
                    case "ruleid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instance")]
		public virtual RecurrenceRule_Instance? InstanceEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((RecurrenceRule_Instance?)(EntityOptionSetEnum.GetEnum(this, "instance")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Instance = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("monthofyear")]
		public virtual RecurrenceRule_MonthOfYear? MonthOfYearEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((RecurrenceRule_MonthOfYear?)(EntityOptionSetEnum.GetEnum(this, "monthofyear")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				MonthOfYear = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("patternendtype")]
		public virtual RecurrenceRule_PatternEndType? PatternEndTypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((RecurrenceRule_PatternEndType?)(EntityOptionSetEnum.GetEnum(this, "patternendtype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				PatternEndType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrencepatterntype")]
		public virtual RecurrenceRule_RecurrencePatternType? RecurrencePatternTypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((RecurrenceRule_RecurrencePatternType?)(EntityOptionSetEnum.GetEnum(this, "recurrencepatterntype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				RecurrencePatternType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}