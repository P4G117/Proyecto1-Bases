import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';
import { GrupoBusqueda } from 'src/app/models/Grupos';
import { CarrerasService } from '../../services/Carreras/carreras.service'

@Component({
  selector: 'app-ver-competencias',
  templateUrl: './ver-competencias.component.html',
  styleUrls: ['./ver-competencias.component.css'],
  providers: [CarrerasService]
})
export class VerCompetenciasComponent implements OnInit {

  informaciones = [
    {
      Nombre: 'Maratón',
      Descripcion: 'Maraton más importante de Costa Rica',
      tipo: 'competencia',
      id: 0,
    },
    {
      Nombre: '4 piscinas',
      Descripcion: '4 piscinas olímpicas',
      tipo: 'competencia',
      id: 1,
    },

  ];
  informacionA=[];

  username: string;

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private carrerasSvc:CarrerasService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    //Obtener información de las competencias en las que está inscrito
  }

  ngOnInit(): void {
    this.carrerasSvc.getCarrerasInscritas(this.username).subscribe(res => {
      this.setCarreras(res);
    });
  }

  setCarreras(carreras:GrupoBusqueda[]){
    carreras.forEach((element) => {
      let info = {

        Nombre: element.nombre,
        Descripcion: 'Carrera',
        tipo: 'competencia',
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
    this.router.navigate(['VerCompetenciaInfo',this.username,id.toString()]);
  }

}
