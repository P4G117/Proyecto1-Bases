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
  deportista: Deportista = new Deportista();

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private deportistaSvc: DeportistaService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.deportistaSvc.getDeportista(this.username).subscribe(res => {
      console.log('Res ', res);
      this.deportista = res[0];
      console.log('Deporttista ', this.deportista);
      this.nombre = this.deportista.primernombre;
      this.apellido1 = this.deportista.apellido1;
      console.log('Deporttista ', this.apellido1);
      this.obtenerFollowers(this.username);
      this.obtenerActividades(this.username);
      this.obtenerFollowing(this.username);

    });
  }

  obtenerFollowers(useName){
    this.deportistaSvc.getFollower(useName).subscribe(res => {
      this.Followers = res[0].follow.toString();
      console.log('Followers ', this.Followers);
    })
  };

  obtenerFollowing(useName){
    this.deportistaSvc.getFollowing(useName).subscribe(res => {
      this.Following = res[0].follow.toString();
      console.log('Followings ', this.Following);
    })
  };

  obtenerActividades(useName){
    this.deportistaSvc.getTotalActividades(useName).subscribe(res => {
      console.log('res ', res);
      console.log('res0 ', res[0]);
      this.Actividades = res[0].follow.toString();
      console.log('Actividades ', this.Actividades);
    })
  };

  ngOnInit(): void {
  }

  iniciogo() {
    this.router.navigate(['inicio-deport',this.username]);
  }
  buscargo() {
    this.router.navigate(['buscar',this.username]);
  }

  retosGo() {
    this.router.navigate(['verRetos',this.username]);
  }

  competenciasGo() {
    this.router.navigate(['verCompetencias',this.username]);
  }

  actividadGo(){
    this.router.navigate(['actividad',this.username]);
  }
}
