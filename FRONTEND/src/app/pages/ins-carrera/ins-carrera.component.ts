import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Carrera } from 'src/app/models/Carreras';
import { Inscripcion } from 'src/app/models/Inscripcion';
import Swal from 'sweetalert2';
import { CarrerasService } from '../../services/Carreras/carreras.service';
import { InscripcionService } from '../../services/Inscripcion/inscripcion.service';
import { DeportistaService } from '../../services/Deportista/deportista.service';


@Component({
  selector: 'app-ins-carrera',
  templateUrl: './ins-carrera.component.html',
  styleUrls: ['./ins-carrera.component.css'],
  providers: [CarrerasService, InscripcionService, DeportistaService],
})
export class InsCarreraComponent implements OnInit {
  carrera: string;
  descripcion: string;
  patrocinadores = [];
  fileToUpload: File = null;
  username: string;
  idCarrera: string;
  carr:Carrera = new Carrera();
  categoria:string;

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private carrerasSvc: CarrerasService,
    private inscripcionSvc:InscripcionService,
    private deportistaSvc: DeportistaService,
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.idCarrera = this._route.snapshot.paramMap.get('id');
    //Obtener informacion de la carrera

  }

  ngOnInit(): void {
    this.carrerasSvc.getCarrera(this.idCarrera).subscribe(res => {
      this.carr = res[0];
      this.carrera = this.carr.nombre;
      this.descripcion = 'Costo: '+ this.carr.costo.toString() + ' Fecha: ' + this.carr.fecha;
    })
    //this.carrera = 'Nombre de carrera';

    this.patrocinadores = [
      '../../../assets/images/image1.png',
      '../../../assets/images/image2.png',
    ];
  }

  handleFileInput(files: FileList) {
    this.fileToUpload = files.item(0);
  }

  inscribirse() {
    if (this.fileToUpload.size > 0) {
      // Swal.fire({
      //   text: 'Gracias por inscribirse',
      //   icon: 'success',
      //   confirmButtonText: 'Aceptar',
      // });
      let inscripcion = new Inscripcion();
      inscripcion.UsuarioDep = this.username;
      inscripcion.IdInscripcion = 10;
      inscripcion.IdCarrera = Number(this.carr.idcarrera);
      inscripcion.Comprobante = "URL 40";
      this.deportistaSvc.getEdadDeportista(this.username).subscribe(res => {
        let edad = res[0].follow;
        this.setCategoria(edad);
        inscripcion.Categoria = this.categoria;
        this.enviarInscripcion(inscripcion);
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

  setCategoria(edad:number){
    if(edad<15){
      this.categoria = 'Junior';
    }
    if(15<=edad && edad<23){
      this.categoria = 'Sub-23';
    }
    if(24<=edad && edad<30){
      this.categoria = 'Open';
    }
    if(30<=edad && edad<=40){
      this.categoria = 'Master A';
    }
    if(41<=edad && edad<50){
      this.categoria = 'Master B';
    }
    if(51<=edad){
      this.categoria = 'Master C';
    }
  }

  enviarInscripcion(inscripcion:Inscripcion){
    this.inscripcionSvc.postInscripcionCarrera(inscripcion).subscribe(res => {
      console.log('Res ', res);
    });
  }

}
