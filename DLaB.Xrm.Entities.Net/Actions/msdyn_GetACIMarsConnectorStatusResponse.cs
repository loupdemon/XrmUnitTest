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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_GetACIMarsConnectorStatus")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class msdyn_GetACIMarsConnectorStatusResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string MarsStatus = "MarsStatus";
		}
		
		public const string ActionLogicalName = "msdyn_GetACIMarsConnectorStatus";
		
		public msdyn_GetACIMarsConnectorStatusResponse()
		{
		}
		
		public string MarsStatus
		{
			get
			{
				if (this.Results.Contains("MarsStatus"))
				{
					return ((string)(this.Results["MarsStatus"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["MarsStatus"] = value;
			}
		}
	}
}