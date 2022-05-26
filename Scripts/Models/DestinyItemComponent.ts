import { DestinyObjectiveProgress } from "./DestinyObjectiveProgress";
export interface DestinyItemComponent
{
      /*  The identifier for the item's definition, which is where most of the useful static information for the item can be found.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
itemHash:number;
itemInstanceId:number;
quantity:number;
bindStatus:number;
location:number;
/*  The hash identifier for the specific inventory bucket in which the item is located.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryBucketDefinition  */
bucketHash:number;
transferStatus:number;
lockable:boolean;
state:number;
/*  If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.

If you don't do this, certain items whose styles are being overridden by socketed items - such as the "Recycle Shader" item - would show whatever their default icon/style is, and it wouldn't be pretty or look accurate.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyInventoryItemDefinition  */
overrideStyleItemHash:number;
expirtationDate:Date;
isWrapper:boolean;
tooltipNotificationIndexes:Array<number>;
metricHash:number;
metricObjective:DestinyObjectiveProgress;
versionNumber:number;
itemValueVisibility:Array<boolean>;
}