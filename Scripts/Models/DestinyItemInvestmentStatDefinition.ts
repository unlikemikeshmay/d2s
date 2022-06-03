
export interface DestinyItemInvestmentStatDefinition
{
    /*  The hash identifier for the DestinyStatDefinition defining this stat.
Type: uint32
Mapped to Manifest Database Definition: Destiny.Definitions.DestinyStatDefinition  */
statTypeHash: number;
value: number;
isConditionallyActive: boolean;
}