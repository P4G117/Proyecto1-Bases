import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router} from '@angular/router';

import Swal from 'sweetalert2'; 
@Component({
  selector: 'app-sub-actividad',
  templateUrl: './sub-actividad.component.html',
  styleUrls: ['./sub-actividad.component.css']
})
export class SubActividadComponent  {
  actividadForm = new FormGroup({
    actividad: new FormControl(''),
    fecha: new FormControl(''),
    hora: new FormControl(''),
    duracion: new FormControl(''),
    tipo: new FormControl(''),
    kilometro: new FormControl(''),
    completitud: new FormControl(''),
    
  });
  fileToUpload: File = null;
  

  constructor(private router: Router) { }
  upLoad(){
    Swal.fire({
      text: 'Gracias por agregar una nueva actividad',
      icon: 'success',
      confirmButtonText: 'Aceptar'
    });
    this.router.navigate(['inicio-deport']);
    console.log(this.actividadForm.value);
    
  }
  onSubmit() {
    console.log(this.actividadForm.value);
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
    handleFileInput(files: FileList) {
      this.fileToUpload = files.item(0);
    }

 


}
