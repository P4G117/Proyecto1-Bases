import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router';

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

  progresValue: number;

  constructor(
    private router: Router
  ) { }

  ngOnInit(): void {
    this.progresValue = 30;
    this.source1 = '../../../assets/images/image1.png';
    this.source2 = '../../../assets/images/image2.png';
    this.patrocinadores.push(this.source1);
    this.patrocinadores.push(this.source2);
  }

  iniciogo(){
    this.router.navigate(['inicio-deport']);
  }
  buscargo(){
    this.router.navigate(['buscar']);
  }

  retosGo(){
    this.router.navigate(['verRetos']);
  }

  competenciasGo(){
    this.router.navigate(['verCompetencias']);
  }



}
