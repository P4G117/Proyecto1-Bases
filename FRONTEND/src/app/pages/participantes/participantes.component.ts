import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router';
@Component({
  selector: 'app-participantes',
  templateUrl: './participantes.component.html',
  styleUrls: ['./participantes.component.css']
})
export class ParticipantesComponent implements OnInit {
  carrera : string;
  participantes = []; 

  constructor(private router: Router) { }

  ngOnInit(): void {
    this.carrera="Lets run",
    this.participantes = ["Participante 1","Participante 2","Participante 3"]
  }
  retosGo(){
    this.router.navigate(['verRetos']);
  }

  competenciasGo(){
    this.router.navigate(['verCompetencias']);
  }
  gruposGo(){
    this.router.navigate(['gesgrupos']);
  }

}
