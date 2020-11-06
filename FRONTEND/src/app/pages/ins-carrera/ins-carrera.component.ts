import { Component, OnInit } from '@angular/core';

import Swal from 'sweetalert2';

@Component({
  selector: 'app-ins-carrera',
  templateUrl: './ins-carrera.component.html',
  styleUrls: ['./ins-carrera.component.css']
})
export class InsCarreraComponent implements OnInit {
  carrera : string;
  descripcion : string ;
  patrocinadores = [];
  fileToUpload: File = null;

  constructor() { }

  ngOnInit(): void {
    this.carrera="Nombre de carrera"
    this.descripcion = "Descripción de carrera";
    this.patrocinadores = ['../../../assets/Images/image 1.png',
    '../../../assets/Images/image 2.png'];
    
  }

  handleFileInput(files: FileList) {
    this.fileToUpload = files.item(0);
  }

  inscribirse(){
    if(this.fileToUpload.size>0){
      Swal.fire({
        text: 'Gracias por inscribirse',
        icon: 'success',
        confirmButtonText: 'Aceptar'
      });
    }else{
    Swal.fire({
      text: 'Por favor agregar un comprobante',
      icon: 'error',
      confirmButtonText: 'Aceptar'
    });
  }
}

  /*emailSignIn(user, password) {
    if (
      this.name.hasError('required') ||
      this.name.hasError('email') ||
      this.pass.hasError('required')
    ) {
      Swal.fire({
        text: 'Su correo electrónico o contraseña no es válido',
        icon: 'error',
        confirmButtonText: 'Cerrar'
      });
    } else {
      this.authService.SignIn(user.value, password.value);
    }
  }*/
    
}
