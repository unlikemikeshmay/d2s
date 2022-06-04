
export interface DestinyMaterialRequirement
{
      //mapped to destinyinventoryitemdefinition
      itemHash: number;
      deleteOnAction: boolean;
      count: number;
      countIsConstant: boolean;
      omitFromRequirements: boolean;
}