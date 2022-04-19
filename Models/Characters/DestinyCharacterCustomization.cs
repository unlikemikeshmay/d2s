namespace bulkybook.Models;

public class DestinyCharacterCustomization
{
    public UInt32 personality {get;set;}
    public UInt32 face {get;set;}
    public UInt32 skinColor {get;set;}
    public UInt32 lipColor {get;set;}
    public UInt32 eyeColor {get;set;}
    public List<UInt32> hairColors {get;set;}
    public List<UInt32> featureColors {get;set;}
    public UInt32 decalColor {get;set;}
    public Boolean wearHelmet {get;set;}
    public Int32 hairIndex {get;set;}
    public Int32 featureIndex {get;set;}
    public Int32 decalIndex {get;set;}
}