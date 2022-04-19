namespace bulkybook.Models;

public class DestinyCraftableComponent
{
    public Boolean visible {get;set;}
    public List<Int32> failedRequirementIndexes {get;set;}
    public List<DestinyCraftableSocketComponent> sockets {get;set;}
    
 }