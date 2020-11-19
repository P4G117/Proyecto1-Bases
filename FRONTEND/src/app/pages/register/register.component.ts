import { Component, EventEmitter, Output } from '@angular/core';
import { Router } from '@angular/router';
import { Organizador } from 'src/app/models/Organizador';
import { Deportista } from '../../models/Deportista';
import { DeportistaService } from '../../services/Deportista/deportista.service';
import { OrganizadorService } from '../../services/Organizador/organizador.service'


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
  providers: [DeportistaService, OrganizadorService],
})
export class RegisterComponent {
  username: string;
  password: string;
  name: string;
  apellido1: string;
  apellido2: string;
  nacionalidad: string;
  dia: string;
  mes: string;
  year: string;
  fechNaci: string;
  rol: string;


  @Output() onChange: EventEmitter<File> = new EventEmitter<File>();
  constructor(
    private router: Router,
    private deportistaSvc: DeportistaService,
    private organizadorSvc: OrganizadorService
  ) {}

  ngOnInit(){
  }

  updateSource($event: Event) {
    // We access he file with $event.target['files'][0]
    this.projectImage($event.target['files'][0]);
  }

  // Uses FileReader to read the file from the input
  source: string = '';
  projectImage(file: File) {
    let reader = new FileReader();
    // TODO: Define type of 'e'
    reader.onload = (e: any) => {
      // Simply set e.target.result as our <img> src in the layout
      this.source = e.target.result;
      this.onChange.emit(file);
    };
    // This will process our file and get it's attributes/data
    reader.readAsDataURL(file);
  }

  fool(){
    console.log(this.username);
  }

  setUsername(username: string){
    this.username = username;
  }

  setPassword(password: string){
    this.password = password;
  }

  setName(name: string){
    this.name = name;
  }

  setApellido1(apellido1: string){
    this.apellido1 = apellido1;
  }

  setApellido2(apellido2: string){
    this.apellido2 = apellido2;
  }

  setNacionalidad(nacionalidad: string){
    this.nacionalidad = nacionalidad;
  }

  setDob(dob) {
    this.year = (dob[0] + dob[1] + dob[2] + dob[3]);
    this.mes = (dob[5] + dob[6]);
    this.dia = (dob[8] + dob[9]) ;
    this.fechNaci = this.year+'-'+this.mes+'-'+this.dia+'T17:16:40';
  }

  setRol(rol){
    this.rol = rol;
  }



  signup() {
    console.log(this.rol);
    if (this.rol == "deportista"){
      this.generateDeportista();
    }
    if (this.rol== "productor"){
      this.generateOrganizador();
    }

  }



  generateDeportista(){
    let deportista = new Deportista();
    deportista.usuariodep = this.username;
    deportista.primernombre = this.name;
    deportista.apellido1 = this.apellido1;
    deportista.apellido2 = this.apellido2;
    deportista.fecnac = this.fechNaci;
    deportista.nacionalidad = this.nacionalidad;
    deportista.foto = "URL 90";
    deportista.clave = this.password;
    this.deportistaSvc.addDeportista(deportista).subscribe(res => {
      console.log('Res ', res);
      this.router.navigate(['home']);
    });
  }

  generateOrganizador(){
    let organizador = new Organizador();
    organizador.usuarioorg = this.username;
    organizador.primernombre = this.name;
    organizador.apellido1 = this.apellido1;
    organizador.apellido2 = this.apellido2;
    organizador.fecnac = this.fechNaci;
    organizador.nacionalidad = this.nacionalidad;
    organizador.foto = "URL 90";
    organizador.clave = this.password;
    this.organizadorSvc.addOrganizador(organizador).subscribe(res => {
      console.log('Res ', res);
      this.router.navigate(['home']);
    })
  }

}
