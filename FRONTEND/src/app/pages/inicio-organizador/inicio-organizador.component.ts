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
      this.organizador = res;
      console.log('Organizador ', this.organizador);
      this.Nombre = this.organizador.primernombre;
      this.Apellido = this.organizador.apellido1;
    });
  }

  ngOnInit(): void {
    this.source = '../../../assets/images/image11.png';
    //this.Nombre = "Viviana";
    //this.Apellido = "Villalobos";
    this.no_competencias = "20";
    this.no_grupos = "10";
    this.no_retos = "23";
  }

  goRetos(){
    this.router.navigate(['verRetosOrg',this.username]);
  }

  goCompetencias(){
    this.router.navigate(['verCompeOrg',this.username]);
  }

  goGrupo(){
    this.router.navigate(['vergrupo',this.username]);
  }

}
