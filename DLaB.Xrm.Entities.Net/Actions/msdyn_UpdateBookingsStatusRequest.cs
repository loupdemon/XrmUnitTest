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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/msdyn/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_UpdateBookingsStatus")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class msdyn_UpdateBookingsStatusRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string ReloadStartDate = "ReloadStartDate";
			public const string ReloadEndDate = "ReloadEndDate";
			public const string Timescale = "Timescale";
			public const string BookingStatusChangeContext = "BookingStatusChangeContext";
			public const string TimeZoneCode = "TimeZoneCode";
			public const string SchedulerSettings = "SchedulerSettings";
		}
		
		public const string ActionLogicalName = "msdyn_UpdateBookingsStatus";
		
		public System.DateTime ReloadStartDate
		{
			get
			{
				if (this.Parameters.Contains("ReloadStartDate"))
				{
					return ((System.DateTime)(this.Parameters["ReloadStartDate"]));
				}
				else
				{
					return default(System.DateTime);
				}
			}
			set
			{
				this.Parameters["ReloadStartDate"] = value;
			}
		}
		
		public System.DateTime ReloadEndDate
		{
			get
			{
				if (this.Parameters.Contains("ReloadEndDate"))
				{
					return ((System.DateTime)(this.Parameters["ReloadEndDate"]));
				}
				else
				{
					return default(System.DateTime);
				}
			}
			set
			{
				this.Parameters["ReloadEndDate"] = value;
			}
		}
		
		public int Timescale
		{
			get
			{
				if (this.Parameters.Contains("Timescale"))
				{
					return ((int)(this.Parameters["Timescale"]));
				}
				else
				{
					return default(int);
				}
			}
			set
			{
				this.Parameters["Timescale"] = value;
			}
		}
		
		public string BookingStatusChangeContext
		{
			get
			{
				if (this.Parameters.Contains("BookingStatusChangeContext"))
				{
					return ((string)(this.Parameters["BookingStatusChangeContext"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["BookingStatusChangeContext"] = value;
			}
		}
		
		public int TimeZoneCode
		{
			get
			{
				if (this.Parameters.Contains("TimeZoneCode"))
				{
					return ((int)(this.Parameters["TimeZoneCode"]));
				}
				else
				{
					return default(int);
				}
			}
			set
			{
				this.Parameters["TimeZoneCode"] = value;
			}
		}
		
		public string SchedulerSettings
		{
			get
			{
				if (this.Parameters.Contains("SchedulerSettings"))
				{
					return ((string)(this.Parameters["SchedulerSettings"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["SchedulerSettings"] = value;
			}
		}
		
		public msdyn_UpdateBookingsStatusRequest()
		{
			this.RequestName = "msdyn_UpdateBookingsStatus";
			this.Timescale = default(int);
			this.BookingStatusChangeContext = default(string);
		}
	}
}