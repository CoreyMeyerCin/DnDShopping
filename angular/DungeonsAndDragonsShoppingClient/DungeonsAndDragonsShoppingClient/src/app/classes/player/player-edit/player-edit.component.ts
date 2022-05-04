import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Player } from '../player.class';
import { PlayerService } from '../player.service';

@Component({
  selector: 'app-player-edit',
  templateUrl: './player-edit.component.html',
  styleUrls: ['./player-edit.component.css']
})
export class PlayerEditComponent implements OnInit {
  player!:Player;
  constructor(
    private playersvc:PlayerService,
    private route:ActivatedRoute,
    private router:Router
  ) { }
  //temp note:      bn
  //This is not working atm because Character[] is not allowed to be null in the C# Player.Model
  save():void{
    this.playersvc.change(this.player).subscribe({
      next:(res)=>{
        console.debug("Player Updated");
        this.router.navigateByUrl("/player/list");
      },
      error:(err)=>{
        console.error(err);
      }
    })
  }

  ngOnInit(): void {
    let id=this.route.snapshot.params["id"];
    this.playersvc.get(id).subscribe({
      next:(res)=>{
        console.debug("Player updated");
        this.player=res;
      },
      error:(err)=>{
        console.error(err);
      }
    })
  }

}
