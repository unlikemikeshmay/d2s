namespace bulkybook.Models;

public class DestinyItemComponent
{
    /*  The identifier for the item's definition, which is where most of the useful static information for the item can be found.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 itemHash {get;set;}
    public Int64 itemInstanceId {get;set;}
    public Int32 quantity {get;set;}
    public Int32 bindStatus {get;set;}
    public Int32 location {get;set;}
    /*  The hash identifier for the specific inventory bucket in which the item is located.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryBucketDefinition  */
    public UInt32 bucketHash {get;set;}
    public Int32 transferStatus {get;set;}
    public Boolean lockable {get;set;}
    public Int32 state {get;set;}
    /*  If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.

If you don't do this, certain items whose styles are being overridden by socketed items - such as the "Recycle Shader" item - would show whatever their default icon/style is, and it wouldn't be pretty or look accurate.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
    public UInt32 overrideStyleItemHash {get;set;}
    public DateTime expirtationDate {get;set;}
    public Boolean isWrapper {get;set;}
    public List<Int32> tooltipNotificationIndexes {get;set;}
    public UInt32 metricHash {get;set;}
    public DestinyObjectiveProgress metricObjective {get;set;}
    public Int32 versionNumber{get;set;}
    public List<Boolean> itemValueVisibility {get;set;}

}