import { Component } from '@angular/core';
import { Router} from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent{

  username: string;
  password: string;
  rol: string;

  constructor(private router: Router) { }

  rolSet(rol){
    this.rol = rol
  }

  login(){
    const user = {username: this.username, password: this.password, rol: this.rol};
    //Manda la informacion al servidor a ver si concuerda

    console.log(this.username);
    console.log(this.password);
    console.log(this.rol);

    this.router.navigate(['inicio-deport']);
  }


}
