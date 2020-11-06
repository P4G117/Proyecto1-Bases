import { Component, OnInit } from '@angular/core';

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

  constructor() { }

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
}
