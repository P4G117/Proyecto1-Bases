import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { InscripcionService } from '../../services/Inscripcion/inscripcion.service';
import { RetosService } from '../../services/Retos/retos.service';

import Swal from 'sweetalert2';
import { DeportistaReto } from 'src/app/models/Inscripcion';
import { RetosPublicos } from 'src/app/models/Retos';
@Component({
  selector: 'app-ins-reto',
  templateUrl: './ins-reto.component.html',
  styleUrls: ['./ins-reto.component.css'],
  providers: [InscripcionService, RetosService],
})
export class InsRetoComponent implements OnInit {
  reto: string;
  descripcion: string;
  patrocinadores = [];
  username: string;
  idReto: string;

  constructor(
    private router: Router,
    private _route: ActivatedRoute,
    private inscipcionSvc: InscripcionService,
    private retosSvc: RetosService
  ) {
    this.username = this._route.snapshot.paramMap.get('username');
    this.idReto = this._route.snapshot.paramMap.get('id');
  }

  ngOnInit(): void {
    this.retosSvc.getReto(this.idReto).subscribe((res) => {
      this.reto = res[0].Nombre;
      this.descripcion =
        'Periodo: ' +
        res[0].Periodo +
        ' Tipo de reto: ' +
        res[0].TipoReto +
        ' Tipo de actividad: ' +
        res[0].TipoActividad;
    });

    this.patrocinadores = [
      '../../../assets/images/image1.png',
      '../../../assets/images/image2.png',
    ];
  }

  inscribirse() {
    // Swal.fire({
    //   text: 'Gracias por inscribirse',
    //   icon: 'success',
    //   confirmButtonText: 'Aceptar',
    // });
    let inscripcion = new DeportistaReto();
    inscripcion.UsuarioDep = this.username;
    inscripcion.IdReto = Number(this.idReto);
    this.inscipcionSvc.postInscripcionReto(inscripcion).subscribe((res) => {
      console.log('Res ', res);
    });
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
