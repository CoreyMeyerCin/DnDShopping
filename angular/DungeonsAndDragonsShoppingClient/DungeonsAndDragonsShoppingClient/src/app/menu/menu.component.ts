import { Component, OnInit } from '@angular/core';
import { Menu } from './menu.class';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  menus:Menu[]=[
    new Menu("HOME","/home"),
    new Menu("ABOUT","/about"),
    new Menu("LOGIN","/login"),
    new Menu("CAMPAIGNS","/campaign/list"),
    new Menu("CHARACTERS","/character/list"),
    new Menu("CITY","/city/list"),
    new Menu("ITEMS","/item/list"),
    new Menu("NPCs","/npcharacter/list"),
    new Menu("PLAYER","/player/list"),
    new Menu("SHOPS","/shop/list")    
    
  ]



  constructor() { }

  ngOnInit(): void {
  }

}
