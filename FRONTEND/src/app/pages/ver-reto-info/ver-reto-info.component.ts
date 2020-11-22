import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Retos } from 'src/app/models/Retos';
import { RetosService } from '../../services/Retos/retos.service';

@Component({
  selector: 'app-ver-reto-info',
  templateUrl: './ver-reto-info.component.html',
  styleUrls: ['./ver-reto-info.component.css'],
  providers: [RetosService],
})
export class VerRetoInfoComponent implements OnInit {
  informacion = {
    Nombre: 'Milla',
    Descripcion: 'Debe hacer una milla para completar el reto',
    Horas: '10',
    Min: '5',
    Seg: '0',
  };

  informacionA = {
    Nombre: 'retos.nombre',
    Descripcion: '',
    Periodo: 'retos.periodo'
  };
  patrocinadores = [];

  source1: string = '';
  source2: string = '';
  username: string;
  id: string;
  reto:Retos = new Retos();

  progresValue: number;

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private retosSvc: RetosService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.id = this._route.snapshot.paramMap.get('id');
    //Obtener información del reto
    this.retosSvc.getReto(this.id).subscribe(res => {
      this.reto = res[0];
      this.setRetosPublicos(this.reto)
    });
  }

  ngOnInit(): void {
    this.progresValue = 30;
    this.source1 = '../../../assets/images/image1.png';
    this.source2 = '../../../assets/images/image2.png';
    this.patrocinadores.push(this.source1);
    this.patrocinadores.push(this.source2);
  }

  setRetosPublicos(retos: Retos) {
    this.informacionA = {
      Nombre: retos.nombre,
      Descripcion: retos.tipoActividad + ', ' + retos.tipoReto,
      Periodo: retos.periodo
    };
  }

  iniciogo() {
    this.router.navigate(['inicio-deport', this.username]);
  }
  buscargo() {
    this.router.navigate(['buscar', this.username]);
  }

  retosGo() {
    this.router.navigate(['verRetos', this.username]);
  }

  competenciasGo() {
    this.router.navigate(['verCompetencias', this.username]);
  }

  actividadGo() {
    this.router.navigate(['actividad', this.username]);
  }
}
