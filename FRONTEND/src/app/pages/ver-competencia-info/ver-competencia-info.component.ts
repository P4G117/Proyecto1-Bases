import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-ver-competencia-info',
  templateUrl: './ver-competencia-info.component.html',
  styleUrls: ['./ver-competencia-info.component.css']
})
export class VerCompetenciaInfoComponent implements OnInit {

  informacion = {
    Nombre: 'Milla',
    Descripcion: 'Debe hacer una milla para ganar el reto',
    Categorias : ['Junior','Sub-23','Open','Elite','Master A','Master B','Master C']
  };

  top = [
    {Nombre : 'Viviana', Edad:'12', Tiempo:'2h3min5seg'},
    {Nombre : 'Luis', Edad:'12', Tiempo:'2h3min5seg'},
    {Nombre : 'Fabian', Edad:'12', Tiempo:'2h3min5seg'},
    {Nombre : 'Samuel', Edad:'12', Tiempo:'2h3min5seg'},
    {Nombre : 'Lucia', Edad:'12', Tiempo:'2h3min5seg'},
    {Nombre : 'Natalia', Edad:'12', Tiempo:'2h3min5seg'},
    {Nombre : 'Enrique', Edad:'12', Tiempo:'2h3min5seg'},
    {Nombre : 'Pamela', Edad:'12', Tiempo:'2h3min5seg'},
    {Nombre : 'Estrella', Edad:'12', Tiempo:'2h3min5seg'},
    {Nombre : 'Nickolas', Edad:'12', Tiempo:'2h3min5seg'}
  ];
  username: string;
  id:string;


  constructor(
    private router: Router, private _route: ActivatedRoute
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.id = this._route.snapshot.paramMap.get('id');
    //Obtener información del competencia
   }

  ngOnInit(): void {
  }

  iniciogo() {
    this.router.navigate(['inicio-deport',this.username]);
  }
  buscargo() {
    this.router.navigate(['buscar',this.username]);
  }

  retosGo() {
    this.router.navigate(['verRetos',this.username]);
  }

  competenciasGo() {
    this.router.navigate(['verCompetencias',this.username]);
  }




}
