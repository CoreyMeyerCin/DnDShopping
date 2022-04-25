import { City } from "../city/city.class";
import { NPCharacter } from "../npcharacter/npcharacter.class";
import { Player } from "../player/player.class";

export class Campaign{
    id:number=0;
    dungeonMasterId:number=0;
    players:Player[]=[];
    nPCharacters:NPCharacter[]=[];
    cities:City[]=[];
    constructor(){
        
    }
}