import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';

import Swal from 'sweetalert2';
@Component({
  selector: 'app-ins-reto',
  templateUrl: './ins-reto.component.html',
  styleUrls: ['./ins-reto.component.css']
})
export class InsRetoComponent implements OnInit {
  reto : string;
  descripcion : string ;
  patrocinadores = [];
  username: string;
  idReto: string;

  constructor(private router: Router, private _route: ActivatedRoute) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.idReto = this._route.snapshot.paramMap.get('id');
   }

  ngOnInit(): void {
    this.reto="Nombre del reto"
    this.descripcion = "Descripción del reto";
    this.patrocinadores = ['../../../assets/Images/image 1.png',
    '../../../assets/Images/image 2.png'];
  }

  inscribirse(){
    Swal.fire({
      text: 'Gracias por inscribirse',
      icon: 'success',
      confirmButtonText: 'Aceptar'
    });
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
}
