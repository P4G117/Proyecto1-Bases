import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';
import { GrupoBusqueda } from 'src/app/models/Grupos';
import { RetosService } from '../../services/Retos/retos.service';

@Component({
  selector: 'app-ver-retos',
  templateUrl: './ver-retos.component.html',
  styleUrls: ['./ver-retos.component.css'],
  providers: [RetosService]
})
export class VerRetosComponent implements OnInit {

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
  username:string;

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private retosSvc: RetosService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    //Pedir los retos en los que está inscrito
   }

  ngOnInit(): void {
    this.retosSvc.getRetosInscritos(this.username).subscribe(res => {
    });

  }

  setRetos(retos:GrupoBusqueda[]){
    retos.forEach((element) => {
      let info = {

        Nombre: element.nombre,
        Descripcion: 'Reto',
        tipo: 'reto',
        id: element.idgrupo
      };
      this.informacionA.push(info);
    });
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

  verInfo(id:number){
    this.router.navigate(['verRetosInfo',this.username, id.toString()]);
  }




}
