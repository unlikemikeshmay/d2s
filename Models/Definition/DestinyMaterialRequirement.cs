namespace bulkybook.Models;

public class DestinyMaterialRequirement
{
    //mapped to destinyinventoryitemdefinition
    public UInt32 itemHash {get;set;}
    public Boolean deleteOnAction {get;set;}
    public Int32 count {get;set;}
    public Boolean countIsConstant {get;set;}
    public Boolean omitFromRequirements {get;set;}
    
}