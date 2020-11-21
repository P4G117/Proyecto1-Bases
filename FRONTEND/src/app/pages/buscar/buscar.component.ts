import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CarrerasPorGrupo, CarrerasPublicas } from 'src/app/models/Carreras';
import { Deportista } from 'src/app/models/Deportista';
import { GrupoBusqueda } from 'src/app/models/Grupos';
import { RetosPorGrupo, RetosPublicos } from 'src/app/models/Retos';
import { DeportistaService } from '../../services/Deportista/deportista.service';
import { ActividadesAmigosService } from '../../services/Amigos/actividades-amigos.service';
import { PosiblesAmigos } from 'src/app/models/ActividadesAmigos';
import { CarrerasService } from '../../services/Carreras/carreras.service';
import { RetosService } from '../../services/Retos/retos.service';
import { GruposService } from '../../services/Grupos/grupos.service';


@Component({
  selector: 'app-buscar',
  templateUrl: './buscar.component.html',
  styleUrls: ['./buscar.component.css'],
  providers: [
    DeportistaService,
    ActividadesAmigosService,
    CarrerasService,
    RetosService,
    GruposService
  ],
})
export class BuscarComponent implements OnInit {
  filtro: string;
  busqueda: string;
  username: string;

  informaciones = [
    {
      Nombre: 'Viviana',
      Descripcion: 'Cartago, Cartago, Costa Rica',
      tipo: 'atleta',
      id: '0',
    },
    {
      Nombre: 'Sebastian',
      Descripcion: 'La Garriga, CT, Spain',
      tipo: 'atleta',
      id: '1',
    },
    { Nombre: 'Fernanda', Descripcion: 'Itanhaem, SP', tipo: 'atleta', id: 2 },
    {
      Nombre: 'Manuel',
      Descripcion: 'Cartago, Cartago, Costa Rica',
      tipo: 'atleta',
      id: '3',
    },
    {
      Nombre: 'Ana',
      Descripcion: 'San Jose, San Jose, Costa Rica',
      tipo: 'atleta',
      id: '4',
    },
    {
      Nombre: 'Ciclitas',
      Descripcion: 'Somos ciclistas muy cools',
      tipo: 'grupo',
      id: '5',
    },
    {
      Nombre: 'Corredores',
      Descripcion: 'Corredores que nos gusta hablar del deporte',
      tipo: 'grupo',
      id: '6',
    },
    {
      Nombre: 'Kayak Costa Rica',
      Descripcion: 'Deportistas de Costa Rica aficionados al Kayak',
      tipo: 'grupo',
      id: '7',
    },
    {
      Nombre: 'Nadadores profesionales',
      Descripcion: 'Nadadores profesionales de la maraton',
      tipo: 'grupo',
      id: '8',
    },
    {
      Nombre: 'Maraton',
      Descripcion: 'Maraton mas importante de Costa Rica',
      tipo: 'competencia',
      id: '9',
    },
    {
      Nombre: '4 piscinas',
      Descripcion: '4 piscinas olimpicas',
      tipo: 'competencia',
      id: '10',
    },
    {
      Nombre: 'Milla',
      Descripcion: 'Debe hacer una milla para completar el reto',
      tipo: 'reto',
      id: '11',
    },
    {
      Nombre: '4km de kayak',
      Descripcion: '4km de kayak para completar el reto',
      tipo: 'reto',
      id: '12',
    },
  ];

  informacionA = [];

  deportistas: Deportista[];

  filtros = [];

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private amigosSvc: ActividadesAmigosService,
    private carreraSvc: CarrerasService,
    private retosSvc: RetosService,
    private gruposSvc: GruposService,
    private deportistaSvc: DeportistaService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.amigosSvc.getNuevosAmigos(this.username).subscribe((res) => {
      this.setAtletas(res);
    });
    this.carreraSvc.getCarrerasPublicas().subscribe((res) => {
      this.setCompePublicas(res);
    });
    this.carreraSvc.getCarrerasPorGrupo(this.username).subscribe((res) => {
      this.setCompePrivadas(res);
    });
    this.retosSvc.getRetosPublicos().subscribe((res) => {
      this.setRetosPublicos(res);
    });
    this.retosSvc.getRetosPorGrupos(this.username).subscribe((res) => {
      this.setRetosPrivados(res);
    });
    this.deportistaSvc.getGrupos(this.username).subscribe((res) => {
      this.setGruposPublicos(res);
    });

  }

  ngOnInit(): void {


    this.filtros = this.informacionA;
    this.filtro = '';
  }

  rolSet(rol) {
    this.busqueda = rol;
  }

  buscar() {
    console.log(this.busqueda);
    this.filtros = [];
    this.informacionA.forEach((element) => {
      if (element.tipo == this.busqueda) {
        if (this.filtro != '') {
          if (element.Nombre == this.filtro) {
            this.filtros.push(element);
          }
        } else {
          this.filtros.push(element);
        }
      }
    });
  }
  go(informacion) {
    console.log(informacion.Nombre);
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

  verInfo(tipo, id) {
    if (tipo == 'reto') {
      this.router.navigate(['verRetosInfo', this.username, id]);
    }
    if (tipo == 'grupo') {
      this.router.navigate(['asogrupo', this.username, id]);
    }
    if (tipo == 'competencia') {
      this.router.navigate(['inscarrera', this.username, id]);
    }
    if (tipo == 'atleta') {
      this.router.navigate(['atleta', this.username, id, 'false']);
    }
  }

  setAtletas(posAmigos: PosiblesAmigos[]) {
    console.log('pos ' ,posAmigos);
    console.log('pos ' ,posAmigos[0].primer_nombre);
    posAmigos.forEach((element) => {
      let info = {

        Nombre: element.primer_nombre,
        Descripcion: element.apellido1 + ' ' + element.apellido2,
        tipo: 'atleta',
        id: element.usuariodep,
      };
      this.informacionA.push(info);
    });
  }

  setRetosPublicos(retos: RetosPublicos[]) {
    retos.forEach((element) => {
      let info = {
        Nombre: element.nombre,
        Descripcion: element.tipo_actividad + ', ' + element.tipo_reto,
        tipo: 'reto',
        id: element.idreto.toString(),
      };
      this.informacionA.push(info);
    });
  }

  setRetosPrivados(retos: RetosPorGrupo[]) {
    retos.forEach((element) => {
      let info = {
        Nombre: element.nombrereto,
        Descripcion: element.tipoactividad + ', ' + element.tiporeto,
        tipo: 'reto',
        id: element.idreto.toString(),
      };
      this.informacionA.push(info);
    });
  }

  setCompePublicas(compe: CarrerasPublicas[]) {
    compe.forEach((element) => {
      let info = {
        Nombre: element.nombre,
        Descripcion: element.tipoActividad,
        tipo: 'competencia',
        id: element.idcarrera.toString(),
      };
      this.informacionA.push(info);
    });
  }

  setCompePrivadas(compe: CarrerasPorGrupo[]) {
    compe.forEach((element) => {
      let info = {
        Nombre: element.nombrecarrera,
        Descripcion: element.tipoActividad,
        tipo: 'competencia',
        id: element.idcarrera.toString(),
      };
      this.informacionA.push(info);
    });
  }

  setGruposPublicos(grupos: GrupoBusqueda[]) {
    console.log('grupos ', grupos);
    grupos.forEach((element) => {
      let info = {
        Nombre: element.nombre,
        Descripcion: 'Es un grupo',
        tipo: 'grupo',
        id: element.idgrupo.toString(),
      };
      this.informacionA.push(info);
    });
  }
}
