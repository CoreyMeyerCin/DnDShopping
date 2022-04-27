import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Player } from './classes/player/player.class';
import { PlayerService } from './classes/player/player.service';

@Injectable({
  providedIn: 'root'
})
export class SystemService {

  baseUrl:string='http://localhost/8270/api/players';
  _player!:Player|null;

  constructor(
    private http: HttpClient,
    private router: Router,
    public playersvc: PlayerService
  ) { }
    getLoggedInPlayer
}
