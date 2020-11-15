import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-inicio-organizador',
  templateUrl: './inicio-organizador.component.html',
  styleUrls: ['./inicio-organizador.component.css']
})
export class InicioOrganizadorComponent implements OnInit {

  source: string = '';
  Nombre:string;
  Apellido: string;
  no_retos: string;
  no_competencias: string;
  no_grupos: string;
  constructor(
    private router: Router
  ) { }

  ngOnInit(): void {
    this.source = '../../../assets/images/image11.png';
    this.Nombre = "Viviana";
    this.Apellido = "Villalobos";
    this.no_competencias = "20";
    this.no_grupos = "10";
    this.no_retos = "23";
  }

  verRetos(){
    this.router.navigate(['verRetosOrg']);
  }

  goCompetencias(){
    this.router.navigate(['verCompeOrg']);
  }

}
