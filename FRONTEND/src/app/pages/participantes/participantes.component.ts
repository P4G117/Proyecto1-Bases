import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';
@Component({
  selector: 'app-participantes',
  templateUrl: './participantes.component.html',
  styleUrls: ['./participantes.component.css']
})
export class ParticipantesComponent implements OnInit {
  carrera : string;
  participantes = [];
  username:string;
  id:string;
  constructor(private router: Router,
    private _route: ActivatedRoute,) {
      this.username = this._route.snapshot.paramMap.get('username');
      this.id = this._route.snapshot.paramMap.get('id');
     }

  ngOnInit(): void {
    this.carrera="Lets run",
    this.participantes = ["Participante 1","Participante 2","Participante 3"]
  }
  goInicio(){
    this.router.navigate(['inicio-organizador',this.username]);
  }

  goRetos(){
    this.router.navigate(['verRetosOrg',this.username]);
  }

  goCompetencias(){
    this.router.navigate(['verCompeOrg',this.username]);
  }

  goGrupo(){
    this.router.navigate(['vergrupo',this.username]);
  }

  goTop(){
    //posiciones/:username/:id
    this.router.navigate(['posiciones',this.username,this.id]);
  }
}
