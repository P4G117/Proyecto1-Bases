import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-crear-grupo',
  templateUrl: './crear-grupo.component.html',
  styleUrls: ['./crear-grupo.component.css']
})
export class CrearGrupoComponent implements OnInit {
  grupoForm = new FormGroup({
    nombre: new FormControl(''),
    admi: new FormControl(''),
    info: new FormControl(''),
    participantes: new FormControl('')

  });

  paricipantes = [
    {Nombre : 'Viviana'},
    {Nombre : 'Luis'},
    {Nombre : 'Fabian'},
    {Nombre : 'Samuel'},
    {Nombre : 'Lucia'},
    {Nombre : 'Natalia'},
    {Nombre : 'Enrique'},
    {Nombre : 'Pamela'},
    {Nombre : 'Estrella'},,
    {Nombre : 'Nickolas'},
  ];

  username:string;
  id:string;
  creado:boolean;
  boton:string;
  nombre:string;
  descripcion:string;

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
  ) {
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

  ngOnInit(): void {
    if(this.creado){
      this.boton = "Guardar"
      this.descripcion = "Descripcion del grupo ya creado"
      this.nombre = "Corredores";
    }
    else{
      this.nombre = "Nombre del Grupo";
      this.boton = "Crear";
      this.descripcion = "Descripcion del grupo a crear"

    }
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

  descripcionSet(descrip){
    this.descripcion = descrip;
  }

  crear(){
    //Actualizar o crear grupo
  }

  nombreSet(nombre){
    this.nombre = nombre;
  }

}
