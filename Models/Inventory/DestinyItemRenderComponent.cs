namespace bulkybook.Models;

public class DestinyItemRenderComponent
{
    public Boolean useCustomDyes {get;set;}
    //key = Art Arrangement Region Index

//value = The chosen Arrangement Index for the Region, based on the value of a stat on the item used for making the choice. 
    public Dictionary<Int32,Int32> artRegions {get;set;}
}