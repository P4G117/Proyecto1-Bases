import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-crear-reto',
  templateUrl: './crear-reto.component.html',
  styleUrls: ['./crear-reto.component.css']
})
export class CrearRetoComponent implements OnInit {

  creado:boolean;
  diaD:string;
  mesD:string;
  yearD:string;
  diaH:string;
  mesH:string;
  yearH:string;
  nombre:string;
  altfon:string;
  patrocinadores:string;
  tipo:string;
  privacidad:string;
  desde:string;
  hasta:string;
  boton:string;
  id:string;
  username:string;

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
      this.diaD = "2";
      this.mesD = "4";
      this.yearD = "2020";
      this.diaH = "30";
      this.mesH = "4";
      this.yearH = "2020";
      this.altfon = "Altura";
      this.patrocinadores = "Python";
      this.tipo = "Correr";
      this.privacidad = "Publico";
      this.desde = this.diaD + "-" + this.mesD + "-" + this.yearD;
      this.hasta = this.diaH + "-" + this.mesH + "-" + this.yearH;
      this.boton = "Guardar"
    }
    else{
      this.nombre = "Nombre del Reto";
      this.altfon = "";
      this.patrocinadores = "";
      this.tipo = "";
      this.privacidad = "";
      this.desde = "Desde";
      this.hasta = "Hasta";
      this.boton = "Crear";
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

  desdeSet(dob) {
    this.yearD = (dob[0] + dob[1] + dob[2] + dob[3]) ;
    this.mesD = (dob[5] + dob[6]);
    this.diaD = (dob[8] + dob[9]);
  }

  hastaSet(dob) {
    this.yearH = (dob[0] + dob[1] + dob[2] + dob[3]) ;
    this.mesH = (dob[5] + dob[6]);
    this.diaH = (dob[8] + dob[9]);
  }

  nombreSet(nombre){
    this.nombre = nombre;
  }

  altfSet(altf){
    this.altfon = altf;
  }

  tipoSet(tipo){
    this.tipo = tipo;
  }

  privSet(priv){
    this.privacidad = priv;
  }

  patroSet(patr){
    this.patrocinadores = patr;
  }





}
