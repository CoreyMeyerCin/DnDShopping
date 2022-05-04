import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Player } from '../player.class';
import { PlayerService } from '../player.service';

@Component({
  selector: 'app-player-detail',
  templateUrl: './player-detail.component.html',
  styleUrls: ['./player-detail.component.css']
})
export class PlayerDetailComponent implements OnInit {

  player!:Player;

  constructor(private router: Router,
    private route: ActivatedRoute,
    private playersvc: PlayerService) { }

    showVerificationButton:boolean = false;

    remove():void{
      this.showVerificationButton = !this.showVerificationButton;
    }

    verifyRemove():void{
      this.showVerificationButton=false;
      this.playersvc.remove(this.player.id).subscribe({
        next:(res)=>{
          console.debug("Player is deleted");
          this.router.navigateByUrl("/player/list");
        },
        error:(err)=>{
          console.error(err);
        }
        }
      )
    }

  ngOnInit(): void {
    let id=+ this.route.snapshot.params["id"];
    this.playersvc.get(id).subscribe({
      next:(res)=>{
        console.debug("Player", res);
      },
      error:(err)=>{
        console.error(err);
      }
    })
  }

}
