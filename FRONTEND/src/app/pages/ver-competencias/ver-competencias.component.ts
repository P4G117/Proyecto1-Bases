import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router';

@Component({
  selector: 'app-ver-competencias',
  templateUrl: './ver-competencias.component.html',
  styleUrls: ['./ver-competencias.component.css']
})
export class VerCompetenciasComponent implements OnInit {

  informaciones = [
    {
      Nombre: 'Maratón',
      Descripcion: 'Maraton más importante de Costa Rica',
      tipo: 'competencia',
      id: 0,
    },
    {
      Nombre: '4 piscinas',
      Descripcion: '4 piscinas olímpicas',
      tipo: 'competencia',
      id: 1,
    },

  ];

  constructor(
    private router: Router
  ) { }

  ngOnInit(): void {
  }

  iniciogo(){
    this.router.navigate(['inicio-deport']);
  }
  buscargo(){
    this.router.navigate(['buscar']);
  }

  retosGo(){
    this.router.navigate(['verRetos']);
  }

  competenciasGo(){
    this.router.navigate(['verCompetencias']);
  }

  verInfo(id){
    this.router.navigate(['VerCompetenciaInfo']);
  }

}
