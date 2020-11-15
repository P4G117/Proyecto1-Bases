import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router';

@Component({
  selector: 'app-ver-retos-org',
  templateUrl: './ver-retos-org.component.html',
  styleUrls: ['./ver-retos-org.component.css']
})
export class VerRetosOrgComponent implements OnInit {

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

  goCompetencias(){
    this.router.navigate(['verCompeOrg']);
  }

  goRetoInfo(nombre){
    this.router.navigate(['crearReto','true',nombre]);
  }

  goRetoInfoN(){
    this.router.navigate(['crearReto','false','']);
  }

}
