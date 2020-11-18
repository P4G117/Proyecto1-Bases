import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-atleta',
  templateUrl: './atleta.component.html',
  styleUrls: ['./atleta.component.css']
})
export class AtletaComponent implements OnInit {
  atleta : string;
  descripcion : string ;
  username: string;
  idGrupo: string;
  nombre:string;
  apellido1:string;
  es_amigo:string;
  amigo:string;


  constructor(private router: Router,
    private _route: ActivatedRoute) {
      this.username = this._route.snapshot.paramMap.get('username');
      this.idGrupo = this._route.snapshot.paramMap.get('id');
      this.es_amigo = this._route.snapshot.paramMap.get('amigo');
     }

  ngOnInit(): void {
    this.atleta = this.nombre+" "+this.apellido1;
    //this.atleta = "Nombre del grupo",
    this.descripcion = "Información del grupo"
    if(this.es_amigo == "false"){
      this.amigo = "Seguir";
    }
    else{
      this.amigo = "Dejar de seguir"
    }
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
