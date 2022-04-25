import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CampaignCreateComponent } from './classes/campaign/campaign-create/campaign-create.component';
import { CampaignDetailComponent } from './classes/campaign/campaign-detail/campaign-detail.component';
import { CampaignEditComponent } from './classes/campaign/campaign-edit/campaign-edit.component';
import { CampaignListComponent } from './classes/campaign/campaign-list/campaign-list.component';
import { CharacterCreateComponent } from './classes/character/character-create/character-create.component';
import { CharacterDetailComponent } from './classes/character/character-detail/character-detail.component';
import { CharacterEditComponent } from './classes/character/character-edit/character-edit.component';
import { CharacterListComponent } from './classes/character/character-list/character-list.component';
import { CityCreateComponent } from './classes/city/city-create/city-create.component';
import { CityDetailComponent } from './classes/city/city-detail/city-detail.component';
import { CityEditComponent } from './classes/city/city-edit/city-edit.component';
import { CityListComponent } from './classes/city/city-list/city-list.component';
import { NpcharacterCreateComponent } from './classes/npcharacter/npcharacter-create/npcharacter-create.component';
import { NpcharacterDetailComponent } from './classes/npcharacter/npcharacter-detail/npcharacter-detail.component';
import { NpcharacterEditComponent } from './classes/npcharacter/npcharacter-edit/npcharacter-edit.component';
import { NpcharacterListComponent } from './classes/npcharacter/npcharacter-list/npcharacter-list.component';
import { ShopCreateComponent } from './classes/shop/shop-create/shop-create.component';
import { ShopDetailComponent } from './classes/shop/shop-detail/shop-detail.component';
import { ShopEditComponent } from './classes/shop/shop-edit/shop-edit.component';
import { ShopListComponent } from './classes/shop/shop-list/shop-list.component';
import { AboutComponent } from './core/about/about.component';
import { E404Component } from './core/e404/e404.component';
import { HomeComponent } from './core/home/home.component';

const routes: Routes = [
  {path:"", redirectTo: "/home", pathMatch: "full"},
  {path: "about", component:AboutComponent},
  {path: "home", component:HomeComponent},

  {path: "city/list", component:CityListComponent},
  {path: "city/create", component:CityCreateComponent},
  {path: "city/edit:id", component:CityEditComponent},
  {path: "city/detail:id", component:CityDetailComponent},

  {path: "shop/list", component:ShopListComponent},
  {path: "shop/create", component:ShopCreateComponent},
  {path: "shop/edit:id", component:ShopEditComponent},
  {path: "shop/detail:id", component:ShopDetailComponent},

  {path: "npcharacter/list", component:NpcharacterListComponent},
  {path: "npcharacter/create", component:NpcharacterCreateComponent},
  {path: "npcharacter/edit:id", component:NpcharacterEditComponent},
  {path: "npcharacter/detail:id", component:NpcharacterDetailComponent},

  {path: "campaign/list", component:CampaignListComponent},
  {path: "campaign/create", component:CampaignCreateComponent},
  {path: "campaign/edit:id", component:CampaignEditComponent},
  {path: "campaign/detail:id", component:CampaignDetailComponent},

  {path: "character/list", component:CharacterListComponent},
  {path: "character/create", component:CharacterCreateComponent},
  {path: "character/edit:id", component:CharacterEditComponent},
  {path: "character/detail:id", component:CharacterDetailComponent},

  {path: "**", component:E404Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
