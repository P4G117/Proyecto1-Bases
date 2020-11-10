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
      Nombre: 'Milla',
      Descripcion: 'Debe hacer una milla para completar el reto',
      tipo: 'reto',
      id: 0,
    },
    {
      Nombre: '4km de kayak',
      Descripcion: '4km de kayak para completar el reto',
      tipo: 'reto',
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

}
