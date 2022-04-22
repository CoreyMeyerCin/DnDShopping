import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CityListComponent } from './classes/city/city-list/city-list.component';
import { CityDetailComponent } from './classes/city/city-detail/city-detail.component';
import { CityCreateComponent } from './classes/city/city-create/city-create.component';
import { CityEditComponent } from './classes/city/city-edit/city-edit.component';
import { E404Component } from './core/e404/e404.component';

@NgModule({
  declarations: [
    AppComponent,
    CityListComponent,
    CityDetailComponent,
    CityCreateComponent,
    CityEditComponent,
    E404Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
