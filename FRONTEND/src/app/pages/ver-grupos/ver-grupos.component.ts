import { Component } from '@angular/core';
import { Router} from '@angular/router';

@Component({
  selector: 'app-ver-grupos',
  templateUrl: './ver-grupos.component.html',
  styleUrls: ['./ver-grupos.component.css']
})
export class VerGruposComponent {
  nombre : string;
  admi: string;
  info : string;
  participantes = [];



  constructor(private router: Router) { 
    this.nombre = "Grupo",
    this.admi = "Lucy",
    this.info = "Se compite todas las semanas",
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
