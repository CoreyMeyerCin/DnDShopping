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
    new Menu("CITY","/city/list"),
    new Menu("LOGIN","/login")
    
  ]



  constructor() { }

  ngOnInit(): void {
  }

}
