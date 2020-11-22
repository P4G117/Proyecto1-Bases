import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Carrera } from 'src/app/models/Carreras';
import { CarrerasService } from '../../services/Carreras/carreras.service';

@Component({
  selector: 'app-ver-competencia-info',
  templateUrl: './ver-competencia-info.component.html',
  styleUrls: ['./ver-competencia-info.component.css'],
  providers: [CarrerasService],
})
export class VerCompetenciaInfoComponent implements OnInit {
  informacion = {
    Nombre: 'Milla',
    Descripcion: 'Debe hacer una milla para ganar el reto',
    Categorias: [
      'Junior',
      'Sub-23',
      'Open',
      'Elite',
      'Master A',
      'Master B',
      'Master C',
    ],
  };

  informacionA = {
    Nombre: 'Milla',
    Descripcion: 'Debe hacer una milla para ganar el reto',
    Categorias: [
      'Junior',
      'Sub-23',
      'Open',
      'Elite',
      'Master A',
      'Master B',
      'Master C',
    ],
  };

  carrera:Carrera = new Carrera();

  top = [
    { Nombre: 'Viviana', Edad: '12', Tiempo: '2h3min5seg' },
    { Nombre: 'Luis', Edad: '12', Tiempo: '2h3min5seg' },
    { Nombre: 'Fabian', Edad: '12', Tiempo: '2h3min5seg' },
    { Nombre: 'Samuel', Edad: '12', Tiempo: '2h3min5seg' },
    { Nombre: 'Lucia', Edad: '12', Tiempo: '2h3min5seg' },
    { Nombre: 'Natalia', Edad: '12', Tiempo: '2h3min5seg' },
    { Nombre: 'Enrique', Edad: '12', Tiempo: '2h3min5seg' },
    { Nombre: 'Pamela', Edad: '12', Tiempo: '2h3min5seg' },
    { Nombre: 'Estrella', Edad: '12', Tiempo: '2h3min5seg' },
    { Nombre: 'Nickolas', Edad: '12', Tiempo: '2h3min5seg' },
  ];
  username: string;
  id: string;

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private carrerasSvc: CarrerasService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.id = this._route.snapshot.paramMap.get('id');
    this.carrerasSvc.getCarrera(this.id).subscribe(res => {
      this.carrera = res[0];
      this.setRetosPublicos(this.carrera)
    });
    //Obtener información del competencia
  }

  ngOnInit(): void {}

  setRetosPublicos(retos: Carrera) {
    this.informacionA = {
      Nombre: retos.nombre,
      Descripcion: retos.tipoactividad,
      Categorias: [
        'Junior',
        'Sub-23',
        'Open',
        'Elite',
        'Master A',
        'Master B',
        'Master C',
      ],
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
}
