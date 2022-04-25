import { City } from "../city/city.class";
import { Item } from "../item/item.class";

export class Character{
    id:number=0;
    name:string="";
    gold:number=0;
    cityId:number=0;
    city!:City;
    items:Item[]=[];
    constructor(){
        
    }
}