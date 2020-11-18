import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-aso-grupo',
  templateUrl: './aso-grupo.component.html',
  styleUrls: ['./aso-grupo.component.css']
})
export class AsoGrupoComponent implements OnInit {
  grupo : string;
  descripcion : string ;
  username: string;
  idGrupo: string;


  constructor(private router: Router,
    private _route: ActivatedRoute) {
      this.username = this._route.snapshot.paramMap.get('username');
      this.idGrupo = this._route.snapshot.paramMap.get('id');
     }

  ngOnInit(): void {
    this.grupo = "Nombre del grupo",
    this.descripcion = "Información del grupo"
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
