
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// Created via this command line: "C:\Users\ehabashraf\AppData\Roaming\MscrmTools\XrmToolBox\Plugins\DLaB.EarlyBoundGenerator\crmsvcutil.exe" /url:"http://blive-crm/ProMAX" /namespace:"CrmEarlyBound" /SuppressGeneratedCodeAttribute /out:"C:\Users\ehabashraf\source\repos\Entity\OptionSets.cs" /codecustomization:"DLaB.CrmSvcUtilExtensions.OptionSet.CustomizeCodeDomService,DLaB.CrmSvcUtilExtensions" /codegenerationservice:"DLaB.CrmSvcUtilExtensions.OptionSet.CustomCodeGenerationService,DLaB.CrmSvcUtilExtensions" /codewriterfilter:"DLaB.CrmSvcUtilExtensions.OptionSet.CodeWriterFilterService,DLaB.CrmSvcUtilExtensions" /namingservice:"DLaB.CrmSvcUtilExtensions.NamingService,DLaB.CrmSvcUtilExtensions" /metadataproviderservice:"DLaB.CrmSvcUtilExtensions.BaseMetadataProviderService,DLaB.CrmSvcUtilExtensions" 
//------------------------------------------------------------------------------

namespace CrmEarlyBound
{
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum task01_Food_02_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum task01_meal02_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum task01_mealtype
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("BreakFast", 1, "#0000ff")]
		BreakFast = 555120001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Dinner", 0, "#0000ff")]
		Dinner = 555120000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Lunch", 2, "#0000ff")]
		Lunch = 555120002,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum task01_order_002_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum task01_order_002_task01_orderstatus_002
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 1, "#0000ff")]
		Active = 555120001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Checkout", 0, "#0000ff")]
		Checkout = 555120000,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum task01_uniquecurrentnumber_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum crms_applications_crms_GeneralNotes
	{
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum you_employee_you_Title
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Manager", 0, "#0000ff")]
		Manager = 187150000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Kitchen Staff", 1, "#0000ff")]
		KitchenStaff = 187150001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Waiting Staff", 2, "#0000ff")]
		WaitingStaff = 187150002,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ham_order_ham_Status
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0, "#0000ff")]
		Active = 807000000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("check out", 1, "#0000ff")]
		checkout = 807000001,
	}
}