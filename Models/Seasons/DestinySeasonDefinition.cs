using System;

namespace bulkybook.Models;

public class DestinySeasonDefinition
{
    
    public DestinyDisplayPropertiesDefinition displayProperties {get;set;}
    public string backgroundImagePath {get;set;}
    public Int32 seasonNumber {get;set;}
    public DateTime startDate {get;set;}
    public DateTime endDate {get;set;}
    //mapped to DestinyProgressionDefinition
    public UInt32 seasonPassHash {get;set;}
    public UInt32 artifactItemHash {get;set;}
    public UInt32 sealPresentationNodeHash {get;set;}
    public UInt32 seasonalChallengesPresentationNodeHash {get;set;}
    public DestinySeasonPreviewDefinition preview {get;set;}
    public UInt32 hash {get;set;}
    public Int32 index {get;set;}
    public Boolean redacted {get;set;}
    
}