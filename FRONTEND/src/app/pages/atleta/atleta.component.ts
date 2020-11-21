import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Deportista } from 'src/app/models/Deportista';
import { DeportistaService } from '../../services/Deportista/deportista.service';


@Component({
  selector: 'app-atleta',
  templateUrl: './atleta.component.html',
  styleUrls: ['./atleta.component.css'],
  providers: [DeportistaService],

})
export class AtletaComponent implements OnInit {
  atleta : string;
  nacionalidad : string ;
  username: string;
  nombre:string;
  apellido1:string;
  es_amigo:string;
  amigo:string;
  username_friend:string;
  deportista: Deportista = new Deportista();
  source:string;


  constructor(private router: Router,
    private _route: ActivatedRoute, private deportistaSvc: DeportistaService) {
      this.username = this._route.snapshot.paramMap.get('username');
      this.username_friend = this._route.snapshot.paramMap.get('username_friend');
      this.es_amigo = this._route.snapshot.paramMap.get('amigo');

      this.deportistaSvc.getDeportista(this.username_friend).subscribe(res => {
        console.log('Res ', res);
        this.deportista = res[0];
        this.atleta = this.deportista.primernombre+" "+this.deportista.apellido1;
        this.nacionalidad = this.deportista.nacionalidad;
        this.source = this.deportista.foto;
        console.log('Deportista ', this.deportista);
      });
     }

  ngOnInit(): void {
    //this.atleta = "Nombre del grupo",

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
