import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import Swal from 'sweetalert2';
import { CarrerasService } from '../../services/Carreras/carreras.service';

@Component({
  selector: 'app-ins-carrera',
  templateUrl: './ins-carrera.component.html',
  styleUrls: ['./ins-carrera.component.css'],
  providers: [CarrerasService],
})
export class InsCarreraComponent implements OnInit {
  carrera: string;
  descripcion: string;
  patrocinadores = [];
  fileToUpload: File = null;
  username: string;
  idCarrera: string;

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private carrerasSvc: CarrerasService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.idCarrera = this._route.snapshot.paramMap.get('id');
    //Obtener informacion de la carrera
    
  }

  ngOnInit(): void {
    this.carrera = 'Nombre de carrera';
    this.descripcion = 'Descripción de carrera';
    this.patrocinadores = [
      '../../../assets/Images/image 1.png',
      '../../../assets/Images/image 2.png',
    ];
  }

  handleFileInput(files: FileList) {
    this.fileToUpload = files.item(0);
  }

  inscribirse() {
    if (this.fileToUpload.size > 0) {
      Swal.fire({
        text: 'Gracias por inscribirse',
        icon: 'success',
        confirmButtonText: 'Aceptar',
      });
    } else {
      Swal.fire({
        text: 'Por favor agregar un comprobante',
        icon: 'error',
        confirmButtonText: 'Aceptar',
      });
    }
  }
  iniciogo() {
    this.router.navigate(['inicio-deport', this.username]);
  }
  buscargo() {
    this.router.navigate(['buscar', this.username]);
  }

  retosGo() {
    this.router.navigate(['verRetos', this.username]);
  }

  competenciasGo() {
    this.router.navigate(['verCompetencias', this.username]);
  }
}
