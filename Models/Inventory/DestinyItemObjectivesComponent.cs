namespace bulkybook.Models;

public class DestinyItemObjectivesComponent
{
    public List<DestinyObjectiveProgress> objectives {get;set;}
    public DestinyObjectiveProgress flavorObjective {get;set;}
    public DateTime dateCompleted {get;set;}
    
}