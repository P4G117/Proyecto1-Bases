import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Carrera, CarrerasPublicas } from 'src/app/models/Carreras';
import { CarrerasService } from '../../services/Carreras/carreras.service';

@Component({
  selector: 'app-crear-comp',
  templateUrl: './crear-comp.component.html',
  styleUrls: ['./crear-comp.component.css'],
  providers: [CarrerasService],
})
export class CrearCompComponent implements OnInit {
  creado: boolean;
  diaD: string;
  mesD: string;
  yearD: string;
  nombre: string;
  patrocinadores: string;
  privacidad: string;
  desde: string;
  boton: string;
  costo: string;
  categorias: string[] = [];

  username: string;
  id: string;

  //5432

  cate: string[] = [
    'Junior',
    'Sub-23',
    'Open',
    'Elite',
    'MasterA',
    'MasterB',
    'MasterC',
  ];

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private carrerasSvc: CarrerasService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    let crear = this._route.snapshot.paramMap.get('creado');
    if (crear == 'true') {
      this.creado = true;
      this.id = this._route.snapshot.paramMap.get('id');
    } else {
      this.creado = false;
    }
  }

  ngOnInit(): void {
    if (this.creado) {
      this.diaD = '2';
      this.mesD = '4';
      this.yearD = '2020';
      this.patrocinadores = 'Python';
      this.privacidad = 'Publico';
      this.boton = 'Guardar';
    } else {
      this.nombre = 'Nombre del Reto';
      this.patrocinadores = '';
      this.privacidad = '';
      this.desde = 'Desde';
      this.boton = 'Crear';
    }
  }

  goInicio() {
    this.router.navigate(['inicio-organizador', this.username]);
  }

  goRetos() {
    this.router.navigate(['verRetosOrg', this.username]);
  }

  goCompetencias() {
    this.router.navigate(['verCompeOrg', this.username]);
  }

  goGrupo() {
    this.router.navigate(['verGrupoOrg', this.username]);
  }

  desdeSet(dob) {
    this.yearD = dob[0] + dob[1] + dob[2] + dob[3];
    this.mesD = dob[5] + dob[6];
    this.diaD = dob[8] + dob[9];
  }

  nombreSet(nombre) {
    this.nombre = nombre;
  }

  privSet(priv) {
    this.privacidad = priv;
  }

  patroSet(patr) {
    this.patrocinadores = patr;
  }

  crear() {
    //Actualizar o crear comp
    if (!this.creado) {
      console.log(this.categorias);
      let carrera = new Carrera();
      carrera.nombre = this.nombre;
      carrera.idorganizador = this.username;
      carrera.fecha = this.yearD + '-' + this.mesD + '-' + this.diaD;
      carrera.recorrido = 'URL 25';
      (carrera.cuenta = 125698), (carrera.costo = Number(this.costo));
      carrera.privacidad = false;
      carrera.tipoactividad = 'Correr';

      this.carrerasSvc.postCarrera(carrera).subscribe((res) => {
        console.log('res ', res);
      });
    }
    else{
      console.log(this.categorias);
      let carrera = new Carrera();
      carrera.nombre = this.nombre;
      carrera.idorganizador = this.username;
      carrera.fecha = this.yearD + '-' + this.mesD + '-' + this.diaD;
      carrera.recorrido = 'URL 25';
      (carrera.cuenta = 125698), (carrera.costo = Number(this.costo));
      carrera.privacidad = false;
      carrera.tipoactividad = 'Correr';

      this.carrerasSvc.updateCarrera(this.id,carrera).subscribe((res) => {
        console.log('res ', res);
      });
    }
  }

  top() {
    this.router.navigate(['participantes', this.username, this.id]);
  }
}
