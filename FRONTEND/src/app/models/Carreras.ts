import { DecimalPipe } from '@angular/common';

export class CarrerasPublicas{
    nombre:string;
    fecha:string;
    cuenta:number;
    costo:number;
    tipoActividad:string;
}

export class CarrerasPorGrupo{
    nombregrupo:string;
    nombrecarrera:string;
    fecha:string;
    recorrido:string;
    cuenta:number;
    costo:number;
    tipoActividad:string;
}

export class Carrera{
    IdCarrera:number;
    IdOrganizador:string;
    Nombre:string;
    Fecha: string;
    Recorrido:string;
    Cuenta:number;
    Costo: number;
    Privacidad: boolean;
    TipoActividad:string
}