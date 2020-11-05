import { Component } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent{

  username: string;
  password: string;
  rol: string;

  constructor() { }

  rolSet(rol){
    this.rol = rol
  }

  login(){
    console.log(this.username);
    console.log(this.password);
    console.log(this.rol);
  }


}
