import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Class } from 'src/app/models/Class';
import { Deportista } from 'src/app/models/Deportista';
import { DeportistaService } from '../../services/Deportista/deportista.service';

@Component({
  selector: 'app-inicio-deport',
  templateUrl: './inicio-deport.component.html',
  styleUrls: ['./inicio-deport.component.css'],
  providers: [DeportistaService],
})
export class InicioDeportComponent implements OnInit {
  nombre: string;
  apellido1: string;
  Following: string;
  Followers: string;
  Actividades: string;
  username: string;
  classes: Class;

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private deportistaSvc: DeportistaService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.deportistaSvc.getEM().subscribe((res:Class) => {
      this.classes = res;
      console.log(this.classes);
      console.log(this.classes.primernombre);
    })
  }

  ngOnInit(): void {

    //this.nombre = 'Viviana';
    //this.apellido1 = 'Villalobos';
    this.Following = '12';
    this.Followers = '32';
    this.Actividades = '2';
  }

  iniciogo() {
    console.log(this.classes.primernombre);
    console.log(this.classes.apellido2);
    this.nombre = this.classes.primernombre;
    this.apellido1 = this.classes.apellido1;
    //this.router.navigate(['inicio-deport']);
  }
  buscargo() {
    this.router.navigate(['buscar']);
  }

  retosGo() {
    this.router.navigate(['verRetos']);
  }

  competenciasGo() {
    this.router.navigate(['verCompetencias']);
  }
}
