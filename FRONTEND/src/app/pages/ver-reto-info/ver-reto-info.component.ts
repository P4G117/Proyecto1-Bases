import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-ver-reto-info',
  templateUrl: './ver-reto-info.component.html',
  styleUrls: ['./ver-reto-info.component.css'],
})
export class VerRetoInfoComponent implements OnInit {

  informacion = {
    Nombre: 'Milla',
    Descripcion: 'Debe hacer una milla para completar el reto',
    Horas: '10',
    Min: '5',
    Seg: '0'
  };

  patrocinadores=[];

  source1:string = '';
  source2:string = '';
  username: string;
  id:string;

  progresValue: number;

  constructor(
    private router: Router, private _route: ActivatedRoute,
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.id = this._route.snapshot.paramMap.get('id');
    //Obtener información del reto
   }

  ngOnInit(): void {
    this.progresValue = 30;
    this.source1 = '../../../assets/images/image1.png';
    this.source2 = '../../../assets/images/image2.png';
    this.patrocinadores.push(this.source1);
    this.patrocinadores.push(this.source2);
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

  actividadGo(){
    this.router.navigate(['actividad',this.username]);
  }



}
