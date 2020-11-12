import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router';

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

  constructor(private router: Router) { }

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
