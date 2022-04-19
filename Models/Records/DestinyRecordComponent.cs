namespace bulkybook.Models;

public class DestinyRecordComponent
{
    public Int32 state {get;set;}
    public List<DestinyObjectiveProgress> objectives {get;set;}
    public List<DestinyObjectiveProgress> internalObjectives {get;set;}
    public Int32 intervalsRedeemedCount {get;set;}
    public Int32 completedCount {get;set;}
    public List<Boolean> rewardVisibilty {get;set;}
    
}