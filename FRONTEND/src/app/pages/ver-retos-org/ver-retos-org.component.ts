import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';

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

  informacionA=[];

  username: string;


  constructor(
    private router: Router,
    private _route: ActivatedRoute,
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    //Obtener informacion de los retos ya creados
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

  goRetoInfo(id){
    this.router.navigate(['crearReto',this.username,'true',id]);
  }

  goRetoInfoN(){
    this.router.navigate(['crearReto',this.username,'false','']);
  }

}
