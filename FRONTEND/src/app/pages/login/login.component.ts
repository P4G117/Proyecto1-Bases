import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DeportistaService } from '../../services/Deportista/deportista.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  providers: [DeportistaService],
})
export class LoginComponent {
  username: string;
  password: string;
  rol: string;

  constructor(
    private router: Router,
    private deportistaSvc: DeportistaService
  ) {}

  ngOnInit(){
    this.deportistaSvc.getAll().subscribe(res => {
      console.log('Res ', res);
    })
  }

  rolSet(rol) {
    this.rol = rol;
  }

  setUser(user){
    this.username = user;
  }

  setPassword(password){
    this.password = password;
  }

  login() {
    console.log(this.rol);
    if (this.rol == "deportista"){
      this.router.navigate(['inicio-deport',this.username]);
    }
    if (this.rol== "productor"){
      this.router.navigate(['inicio-organizador']);
    }


  }
}
