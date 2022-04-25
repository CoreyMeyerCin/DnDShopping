import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CityListComponent } from './classes/city/city-list/city-list.component';
import { CityDetailComponent } from './classes/city/city-detail/city-detail.component';
import { CityCreateComponent } from './classes/city/city-create/city-create.component';
import { CityEditComponent } from './classes/city/city-edit/city-edit.component';
import { E404Component } from './core/e404/e404.component';
import { MenuComponent } from './menu/menu.component';
import { AboutComponent } from './core/about/about.component';
import { HomeComponent } from './core/home/home.component';
import { ShopEditComponent } from './classes/shop/shop-edit/shop-edit.component';
import { ShopListComponent } from './classes/shop/shop-list/shop-list.component';
import { ShopCreateComponent } from './classes/shop/shop-create/shop-create.component';
import { ShopDetailComponent } from './classes/shop/shop-detail/shop-detail.component';
import { NpcharacterCreateComponent } from './classes/npcharacter/npcharacter-create/npcharacter-create.component';
import { NpcharacterEditComponent } from './classes/npcharacter/npcharacter-edit/npcharacter-edit.component';
import { NpcharacterDetailComponent } from './classes/npcharacter/npcharacter-detail/npcharacter-detail.component';
import { NpcharacterListComponent } from './classes/npcharacter/npcharacter-list/npcharacter-list.component';
import { CampaignListComponent } from './classes/campaign/campaign-list/campaign-list.component';
import { CampaignEditComponent } from './classes/campaign/campaign-edit/campaign-edit.component';
import { CampaignDetailComponent } from './classes/campaign/campaign-detail/campaign-detail.component';
import { CampaignCreateComponent } from './classes/campaign/campaign-create/campaign-create.component';
import { PlayerListComponent } from './classes/player/player-list/player-list.component';
import { PlayerCreateComponent } from './classes/player/player-create/player-create.component';
import { PlayerEditComponent } from './classes/player/player-edit/player-edit.component';
import { PlayerDetailComponent } from './classes/player/player-detail/player-detail.component';
import { CharacterListComponent } from './classes/character/character-list/character-list.component';
import { CharacterEditComponent } from './classes/character/character-edit/character-edit.component';
import { CharacterCreateComponent } from './classes/character/character-create/character-create.component';
import { CharacterDetailComponent } from './classes/character/character-detail/character-detail.component';
import { ItemListComponent } from './classes/item/item-list/item-list.component';
import { ItemEditComponent } from './classes/item/item-edit/item-edit.component';
import { ItemCreateComponent } from './classes/item/item-create/item-create.component';
import { ItemDetailComponent } from './classes/item/item-detail/item-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    CityListComponent,
    CityDetailComponent,
    CityCreateComponent,
    CityEditComponent,
    E404Component,
    MenuComponent,
    AboutComponent,
    HomeComponent,
    ShopEditComponent,
    ShopListComponent,
    ShopCreateComponent,
    ShopDetailComponent,
    NpcharacterCreateComponent,
    NpcharacterEditComponent,
    NpcharacterDetailComponent,
    NpcharacterListComponent,
    CampaignListComponent,
    CampaignEditComponent,
    CampaignDetailComponent,
    CampaignCreateComponent,
    PlayerListComponent,
    PlayerCreateComponent,
    PlayerEditComponent,
    PlayerDetailComponent,
    CharacterListComponent,
    CharacterEditComponent,
    CharacterCreateComponent,
    CharacterDetailComponent,
    ItemListComponent,
    ItemEditComponent,
    ItemCreateComponent,
    ItemDetailComponent
  ],
  imports: [
    BrowserModule, FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
