import { Component, EventEmitter, Output } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Archivo } from 'src/app/models/Archivo';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent {
  myForm: FormGroup;
  nombre: string;
  apellido1: string;
  username: string;
  password: string;
  year: number;
  month: number;
  day: number;
  apellido2: string;
  rolA: string;
  nacionalidad: string;

  constructor(public fb: FormBuilder) {
    this.myForm = this.fb.group({
      usuario: [
        '',
        [
          Validators.required,
          Validators.minLength(10),
          Validators.maxLength(10),
        ],
      ],
      pass: [
        '',
        [
          Validators.required,
          Validators.minLength(10),
          Validators.maxLength(10),
        ],
      ],
      nombre: ['', [Validators.required]],
      apellido1: ['', [Validators.required]],
      apellido2: ['', [Validators.required]],
      nacionalidad: ['', [Validators.required]],
      dob: ['', [Validators.required]],
      rol: ['', [Validators.required]],
    });
  }

  user(usernames: string) {
    this.username = usernames;
  }

  passwordSet(password: string) {
    this.password = password;
  }

  nombreSet(nombre: string) {
    this.nombre = nombre;
  }

  apellido1Set(apellido1: string) {
    this.apellido1 = apellido1;
  }

  apellido2Set(apellido2: string) {
    this.apellido2 = apellido2;
  }

  nacionalidadSet(apellido2: string) {
    this.apellido2 = apellido2;
  }

  dobSet(dob) {
    this.year = (dob[0] + dob[1] + dob[2] + dob[3]) * 1;
    this.month = (dob[5] + dob[6]) * 1;
    this.day = (dob[8] + dob[9]) * 1;
    console.log(this.day);
  }

  rolSet(rol){
    this.rolA = rol;
  }

  saveData1(){
    console.log(this.nombre);
    console.log(this.apellido1);
    console.log(this.username);
    console.log(this.password);
    console.log(this.year);
    console.log(this.month);
    console.log(this.day);
    console.log(this.apellido2);
    console.log(this.rolA);
    console.log(this.nacionalidad);
    
  }

}
