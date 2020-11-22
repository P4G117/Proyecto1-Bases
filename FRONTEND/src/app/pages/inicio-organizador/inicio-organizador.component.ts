import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Organizador } from 'src/app/models/Organizador';
import { OrganizadorService } from '../../services/Organizador/organizador.service';

@Component({
  selector: 'app-inicio-organizador',
  templateUrl: './inicio-organizador.component.html',
  styleUrls: ['./inicio-organizador.component.css'],
  providers: [OrganizadorService]
})
export class InicioOrganizadorComponent implements OnInit {

  source: string = '';
  Nombre:string;
  Apellido: string;
  no_retos: string;
  no_competencias: string;
  no_grupos: string;
  username: string;
  organizador: Organizador = new Organizador();

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private organizadorSvc: OrganizadorService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.organizadorSvc.getOrganizador(this.username).subscribe(res => {
      console.log('Res ', res);
      this.organizador = res[0];
      console.log('Organizador ', this.organizador);
      this.Nombre = this.organizador.primernombre;
      this.Apellido = this.organizador.apellido1;
      this.obtenerCompetencias(this.username);
      this.obtenerGrupos(this.username);
      this.obtenerRetos(this.username);
    });
  }

  ngOnInit(): void {
    this.source = '../../../assets/images/image11.png';
    //this.Nombre = "Viviana";
    //this.Apellido = "Villalobos";
    // this.no_competencias = "20";
    // this.no_grupos = "10";
    // this.no_retos = "23";
  }


  obtenerCompetencias(useName){
    this.organizadorSvc.getCantCarrerasOrganizador(useName).subscribe(res => {
      this.no_competencias = res[0].follow.toString();
    })
  };

  obtenerGrupos(useName){
    this.organizadorSvc.getCantGruposOrganizador(useName).subscribe(res => {
      this.no_grupos = res[0].follow.toString();
    })
  };

  obtenerRetos(useName){
    this.organizadorSvc.getCantRetosOrganizador(useName).subscribe(res => {
      this.no_retos = res[0].follow.toString();
    })
  };

  goRetos(){
    this.router.navigate(['verRetosOrg',this.username]);
  }

  goCompetencias(){
    this.router.navigate(['verCompeOrg',this.username]);
  }

  goGrupo(){
    this.router.navigate(['verGrupoOrg',this.username]);
  }

}
