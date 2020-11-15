import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-ver-competencia-org',
  templateUrl: './ver-competencia-org.component.html',
  styleUrls: ['./ver-competencia-org.component.css']
})
export class VerCompetenciaOrgComponent implements OnInit {

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

  goInicio(){
    this.router.navigate(['inicio-organizador']);
  }

  goRetos(){
    this.router.navigate(['verRetosOrg']);
  }

  goRetoInfo(nombre){
    this.router.navigate(['crearReto','true',nombre]);
  }

  goCompetencias(){
    this.router.navigate(['verCompeOrg']);
  }
  goRetoInfoN(){
    this.router.navigate(['crearReto','false','']);
  }


}
