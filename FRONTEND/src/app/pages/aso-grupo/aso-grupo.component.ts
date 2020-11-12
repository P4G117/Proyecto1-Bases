import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router';

@Component({
  selector: 'app-aso-grupo',
  templateUrl: './aso-grupo.component.html',
  styleUrls: ['./aso-grupo.component.css']
})
export class AsoGrupoComponent implements OnInit {
  grupo : string;
  descripcion : string ;


  constructor(private router: Router) { }

  ngOnInit(): void {
    this.grupo = "Nombre del grupo",
    this.descripcion = "Información del grupo"
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
