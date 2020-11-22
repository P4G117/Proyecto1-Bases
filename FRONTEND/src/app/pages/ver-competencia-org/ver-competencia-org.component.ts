import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Carrera } from 'src/app/models/Carreras';
import { CarrerasService} from '../../services/Carreras/carreras.service';
import { OrganizadorService } from '../../services/Organizador/organizador.service';


@Component({
  selector: 'app-ver-competencia-org',
  templateUrl: './ver-competencia-org.component.html',
  styleUrls: ['./ver-competencia-org.component.css'],
  providers: [CarrerasService,OrganizadorService]
})
export class VerCompetenciaOrgComponent implements OnInit {

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

  informacionA= [
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
  competencias:Carrera = new Carrera();
  username: string;


  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private carreraSvc: CarrerasService,
    private organizadorSvc: OrganizadorService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.organizadorSvc.getCarrerasOrganizador(this.username).subscribe((res) => {
      this.setRetos(res);
      console.log('res ', res)
    });
   }

  ngOnInit(): void {
  }

  setRetos(retos: Carrera[]) {
    this.informacionA = [];
    retos.forEach((element) => {
      let info = {
        Nombre: element.nombre,
        Descripcion: element.tipoactividad,
        tipo: 'competencia',
        id: element.idcarrera,
      };
      this.informacionA.push(info);
    });
  }

  goInicio(){
    this.router.navigate(['inicio-organizador',this.username]);
  }

  goRetos(){
    this.router.navigate(['verRetosOrg',this.username]);
  }

  goCompetencias(){
    this.router.navigate(['verCompeOrg',this.username]);
  }

  goGrupo(){
    this.router.navigate(['verGrupoOrg',this.username]);
  }

  goCompetenciaInfo(id:number){
    this.router.navigate(['crearComp',this.username,'true',id.toString()]);
  }

  goCompetenciaInfoN(){
    this.router.navigate(['crearComp',this.username,'false','']);
  }


}
