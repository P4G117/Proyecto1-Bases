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
    idcarrera:number;
    idorganizador:string;
    nombre:string;
    fecha: string;
    recorrido:string;
    cuenta:number;
    costo: number;
    privacidad: boolean;
    tipoactividad:string
}

export class Patrocinadores{
    nombrepatrocinador:string;
}