namespace bulkybook.Models;

public class DestinyVendorActionDefinition
{
    public string description {get;set;}
    public Int32 executeSeconds {get;set;}
    public string icon {get;set;}
    public string name {get;set;}
    public string verb {get;set;}
    public Boolean isPositive {get;set;}
    public string actionId {get;set;}
    public UInt32 actionHash {get;set;}
    public Boolean autoPerformAction {get;set;}
    
}