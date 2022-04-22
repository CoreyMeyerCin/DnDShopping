import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CityListComponent } from './classes/city/city-list/city-list.component';
import { CityDetailComponent } from './classes/city/city-detail/city-detail.component';
import { CityCreateComponent } from './classes/city/city-create/city-create.component';
import { E404Component } from './core/e404/e404/e404.component';
import { HomeComponent } from './core/home/home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    CityListComponent,
    CityDetailComponent,
    CityCreateComponent,
    E404Component,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
