import { SingleComponentResponseOfDestinyInventoryComponent } from "./SingleComponentResponseOfDestinyInventoryComponent";
import { SingleComponentResponseOfDestinyCharacterComponent } from "./SingleComponentResponseOfDestinyCharacterComponent";
import { SingleComponentResponseOfDestinyCharacterProgressionComponent } from "./SingleComponentResponseOfDestinyCharacterProgressionComponent";
import { SingleComponentResponseOfDestinyCharacterRenderComponent } from "./SingleComponentResponseOfDestinyCharacterRenderComponent";
import { SingleComponentResponseOfDestinyCharacterActivitiesComponent } from "./SingleComponentResponseOfDestinyCharacterActivitiesComponent";
import { SingleComponentResponseOfDestinyPlugSetsComponent } from "./SingleComponentResponseOfDestinyPlugSetsComponent";
import { SingleComponentResponseOfDestinyKiosksComponent } from "./SingleComponentResponseOfDestinyKiosksComponent";
import { SingleComponentResponseOfDestinyPresentationNodesComponent } from "./SingleComponentResponseOfDestinyPresentationNodesComponent";
import { SingleComponentResponseOfDestinyCharacterRecordsComponent } from "./SingleComponentResponseOfDestinyCharacterRecordsComponent";
import { SingleComponentResponseOfDestinyCollectiblesComponent } from "./SingleComponentResponseOfDestinyCollectiblesComponent";
import { DestinyItemComponentSetOfint64 } from "./DestinyItemComponentSetOfint64";
import { DestinyBaseItemComponentSetOfuint32 } from "./DestinyBaseItemComponentSetOfuint32";
import { SingleComponentResponseOfDestinyCurrenciesComponent } from "./SingleComponentResponseOfDestinyCurrenciesComponent";

export interface DestinyCharacterResponse
{
    inventory: SingleComponentResponseOfDestinyInventoryComponent;
    character: SingleComponentResponseOfDestinyCharacterComponent;
    progressions: SingleComponentResponseOfDestinyCharacterProgressionComponent;
    renderData: SingleComponentResponseOfDestinyCharacterRenderComponent;
    activities: SingleComponentResponseOfDestinyCharacterActivitiesComponent;
    equipment: SingleComponentResponseOfDestinyInventoryComponent;
    kiosks: SingleComponentResponseOfDestinyKiosksComponent;
    plugSets: SingleComponentResponseOfDestinyPlugSetsComponent;
    presentationNodes:SingleComponentResponseOfDestinyPresentationNodesComponent;
    records: SingleComponentResponseOfDestinyCharacterRecordsComponent;
    collectables: SingleComponentResponseOfDestinyCollectiblesComponent;
    itemComponents: DestinyItemComponentSetOfint64;
    uninstancedItemComponents: DestinyBaseItemComponentSetOfuint32;
    currencyLookups: SingleComponentResponseOfDestinyCurrenciesComponent;
}   
