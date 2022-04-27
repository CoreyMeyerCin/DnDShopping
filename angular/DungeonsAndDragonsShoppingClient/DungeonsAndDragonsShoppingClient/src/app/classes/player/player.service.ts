import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Player } from './player.class';
 

@Injectable({
  providedIn: 'root'
})
export class PlayerService {
 baseUrl = 'http//localhost:8270/api/players'

  constructor(public http: HttpClient) { }

  list():Observable <Player[]>{
    return this.http.get(`${this.baseUrl}`) as Observable<Player[]>;
  }
  get(id:number):Observable<Player>{
    return this.http.get(`${this.baseUrl}/${id}`) as Observable<Player>;
  }
  create(player:Player):Observable<Player>{
    return this.http.post(`${this.baseUrl}`, player) as Observable<Player>;
  }
  change(player:Player):Observable<Player>{
    return this.http.put(`${this.baseUrl}`, player) as Observable<any>;
  }
  remove(id:number): Observable<any>{
    return this.http.delete(`${this.baseUrl}/${id}`) as Observable<any>;
  }
}
