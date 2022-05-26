namespace bulkybook.Models;

public class DestinyObjectiveProgress
{
    public UInt32 objectiveHash {get;set;}
    public UInt32 destinationHash {get;set;}
    public UInt32 activityHash {get;set;}
    public Int32 progress {get;set;}
    public Int32 completionValue {get;set;}
    public Boolean complete {get;set;}
    public Boolean visible {get;set;}
}