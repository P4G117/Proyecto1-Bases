import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

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

  informacionA=[];

  username: string;


  constructor(
    private router: Router,
    private _route: ActivatedRoute
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    //Ob
   }

  ngOnInit(): void {
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
  
  goCompetenciaInfo(id:number){
    this.router.navigate(['crearComp',this.username,'true',id.toString()]);
  }

  goCompetenciaInfoN(){
    this.router.navigate(['crearComp',this.username,'false','']);
  }


}
