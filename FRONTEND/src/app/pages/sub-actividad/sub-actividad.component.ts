import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Actividad } from 'src/app/models/Actividad';
import { ActividadesService } from '../../services/Actividades/actividades.service';

import Swal from 'sweetalert2';
@Component({
  selector: 'app-sub-actividad',
  templateUrl: './sub-actividad.component.html',
  styleUrls: ['./sub-actividad.component.css'],
  providers: [ActividadesService],
})
export class SubActividadComponent {
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
  username: string;
  nombre: string;
  fecha: string;
  hora: string;
  duracion: string;
  tipo: string;
  kilometraje: string;
  completitud: string;

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private actividadSvc: ActividadesService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
  }
  upLoad() {
    // Swal.fire({
    //   text: 'Gracias por agregar una nueva actividad',
    //   icon: 'success',
    //   confirmButtonText: 'Aceptar',
    // });
    this.generarActividad();

  }
  onSubmit() {
    console.log(this.actividadForm.value);
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
  handleFileInput(files: FileList) {
    this.fileToUpload = files.item(0);
  }

  setNombre(nombre) {
    this.nombre = nombre;
  }

  setFecha(fecha) {
    this.fecha = fecha;
  }

  setHora(hora) {
    this.hora = hora;
  }

  setDuracion(duracion) {
    this.duracion = duracion;
  }

  setTipo(tipo) {
    this.tipo = tipo;
  }

  setKilo(kilome) {
    this.kilometraje = kilome;
  }

  setComple(comple) {
    this.completitud = comple;
  }

  generarActividad() {
    let actividad = new Actividad();
    actividad.Nombreactividad = this.nombre;
    actividad.Fecha = this.fecha;
    actividad.Hora = this.hora;
    actividad.Mapa = 'URL 20';
    actividad.Kilometros = Number(this.kilometraje);
    actividad.Duracion = this.duracion;
    actividad.Completitud = this.completitud;
    actividad.TipoActividad = this.tipo;
    actividad.IdDeportista = this.username;
    this.actividadSvc.postActividad(actividad).subscribe((res) => {
      console.log('Res ', res);
      console.log(this.actividadForm.value);
    });
  }
}
