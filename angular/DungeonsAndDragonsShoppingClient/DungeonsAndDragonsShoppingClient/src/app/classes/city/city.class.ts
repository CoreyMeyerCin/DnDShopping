import { NPCharacter } from "../npcharacter/npcharacter.class";
import { Shop } from "../shop/shop.class";
export class City{
    id:number=0;
    name:string="";
    shops:Shop[]=[]
    nPCharacters:NPCharacter[]=[];
    constructor(){
        
    }
}