import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CityCreateComponent } from './classes/city/city-create/city-create.component';
import { CityDetailComponent } from './classes/city/city-detail/city-detail.component';
import { CityListComponent } from './classes/city/city-list/city-list.component';
import { E404Component } from './core/e404/e404/e404.component';

const routes: Routes = [
  {path:"", redirectTo: "/home", pathMatch: "full"},

  {path: "city/list", component:CityListComponent},
  {path: "city/create", component:CityCreateComponent},
  {path: "city/edit:id", component:CityListComponent},
  {path: "city/detail:id", component:CityDetailComponent},

  {path: "**", component:E404Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
