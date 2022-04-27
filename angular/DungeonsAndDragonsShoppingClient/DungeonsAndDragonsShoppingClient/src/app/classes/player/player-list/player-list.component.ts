import { Component, OnInit } from '@angular/core';
import { Player } from '../player.class';
import { PlayerService } from '../player.service';

@Component({
  selector: 'app-player-list',
  templateUrl: './player-list.component.html',
  styleUrls: ['./player-list.component.css']
})
export class PlayerListComponent implements OnInit {

 players:Player[]=[]
  constructor(private playersvc: PlayerService) { }

  ngOnInit(): void {
    this.playersvc.list().subscribe({
      next:(res)=>{
        this.players=res;
        console.debug("Players",res);
        error:(err: any)=>{
          console.error(err);
        }

      }
    })
  }

}
