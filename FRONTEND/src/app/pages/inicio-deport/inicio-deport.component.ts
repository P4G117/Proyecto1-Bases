import { Component, OnInit } from '@angular/core';

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
  constructor() { }

  ngOnInit(): void {
    this.nombre = "Viviana"
    this.apellido1 = "Villalobos"
    this.Following = "12"
    this.Followers = "32"
    this.Actividades = "2"
  }

}
