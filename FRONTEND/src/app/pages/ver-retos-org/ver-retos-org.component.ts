import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { GrupoBusqueda } from 'src/app/models/Grupos';
import { Retos } from 'src/app/models/Retos';
import { OrganizadorService } from '../../services/Organizador/organizador.service';

@Component({
  selector: 'app-ver-retos-org',
  templateUrl: './ver-retos-org.component.html',
  styleUrls: ['./ver-retos-org.component.css'],
  providers: [OrganizadorService],
})
export class VerRetosOrgComponent implements OnInit {
  informaciones = [
    {
      Nombre: 'Milla',
      Descripcion: 'Debe hacer una milla para completar el reto',
      tipo: 'reto',
      id: 0,
    },
    {
      Nombre: '4km de kayak',
      Descripcion: '4km de kayak para completar el reto',
      tipo: 'reto',
      id: 1,
    },
  ];

  informacionA = [];

  username: string;

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private organizadorSvc: OrganizadorService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    //Obtener informacion de los retos ya creados
  }

  ngOnInit(): void {
    this.organizadorSvc.getRetosOrganizador(this.username).subscribe((res) => {
      this.setRetos(res);
      console.log('res ', res)
    });
  }

  setRetos(retos: Retos[]) {
    retos.forEach((element) => {
      let info = {
        Nombre: element.nombre,
        Descripcion:
          'Periodo: ' +
          element.periodo +
          ' Tipo Actividad: ' +
          element.tipoActividad,
        tipo: 'reto',
        id: element.idretos,
      };
      this.informacionA.push(info);
    });
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
    this.router.navigate(['vergrupo', this.username]);
  }

  goRetoInfo(id: number) {
    this.router.navigate(['crearReto', this.username, 'true', id.toString()]);
  }

  goRetoInfoN() {
    this.router.navigate(['crearReto', this.username, 'false', '']);
  }
}
