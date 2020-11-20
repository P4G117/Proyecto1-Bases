import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-ver-grupo-org',
  templateUrl: './ver-grupo-org.component.html',
  styleUrls: ['./ver-grupo-org.component.css']
})
export class VerGrupoOrgComponent implements OnInit {

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
    this.router.navigate(['verGrupoOrg',this.username]);
  }

  goGrupoInfo(id:number){
    this.router.navigate(['creargrupo',this.username,'true',id.toString()]);
  }

  goGrupoInfoN(){
    this.router.navigate(['creargrupo',this.username,'false','']);
  }
}
