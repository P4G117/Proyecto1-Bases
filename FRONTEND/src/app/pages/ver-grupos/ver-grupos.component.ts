import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-ver-grupos',
  templateUrl: './ver-grupos.component.html',
  styleUrls: ['./ver-grupos.component.css'],
})
export class VerGruposComponent {
  nombre: string;
  admi: string;
  info: string;
  participantes = [];

  creado:boolean;
  username:string;
  id:string;

  constructor(private router: Router, private _route: ActivatedRoute) {
    this.username = this._route.snapshot.paramMap.get('username');
    let crear = this._route.snapshot.paramMap.get('creado');
    if(crear == 'true'){
      this.creado = true;
      this.id = this._route.snapshot.paramMap.get('id');
    }
    else{
      this.creado = false;
    }

  }

  ngOnInit(){
    (this.nombre = 'Grupo'),
    (this.admi = 'Lucy'),
    (this.info = 'Se compite todas las semanas'),
    (this.participantes = [
      'Participante 1',
      'Participante 2',
      'Participante 3',
    ]);
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
    this.router.navigate(['vergrupo',this.username]);
  }
}
