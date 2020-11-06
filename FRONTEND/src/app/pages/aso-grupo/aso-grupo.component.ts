import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-aso-grupo',
  templateUrl: './aso-grupo.component.html',
  styleUrls: ['./aso-grupo.component.css']
})
export class AsoGrupoComponent implements OnInit {
  grupo : string;
  descripcion : string ;


  constructor() { }

  ngOnInit(): void {
    this.grupo = "Nombre del grupo",
    this.descripcion = "Información del grupo"
  }

}
