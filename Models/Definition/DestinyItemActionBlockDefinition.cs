namespace bulkybook.Models;

public class DestinyItemActionBlockDefinition
{
    public string verbName {get;set;}
    public string verbDescription {get;set;}
    public Boolean isPositive {get;set;}
    public string overlayScreenName {get;set;}
    public string overlayIcon {get;set;}
    public Int32 requiredCooldownSeconds {get;set;}
    public List<DestinyItemActionRequiredItemDefinition> requiredItems {get;set;}
    public List<DestinyProgressionRewardDefinition> progressionRewards {get;set;}
    public string actionTypeLabel {get;set;}
    public string requiredLocation {get;set;}
    public UInt32 requiredCooldownHash {get;set;}
    public Boolean deleteOnAction {get;set;}
    public Boolean consumeEntireStack {get;set;}
    public Boolean useOnAcquire {get;set;}


}