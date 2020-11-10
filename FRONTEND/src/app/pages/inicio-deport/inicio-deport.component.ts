import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router';

@Component({
  selector: 'app-inicio-deport',
  templateUrl: './inicio-deport.component.html',
  styleUrls: ['./inicio-deport.component.css']
})
export class InicioDeportComponent implements OnInit {

  nombre: string
  apellido1: string
  Following: string
  Followers: string
  Actividades: string

  constructor(private router: Router) { }

  ngOnInit(): void {
    this.nombre = "Viviana"
    this.apellido1 = "Villalobos"
    this.Following = "12"
    this.Followers = "32"
    this.Actividades = "2"
  }

  iniciogo(){
    this.router.navigate(['inicio-deport']);
  }
  buscargo(){
    this.router.navigate(['buscar']);
  }

  retosGo(){
    this.router.navigate(['verRetos']);
  }

  competenciasGo(){
    this.router.navigate(['verCompetencias']);
  }


}
