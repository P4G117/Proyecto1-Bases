import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Inscripcion, DeportistaReto } from 'src/app/models/Inscripcion';
import { DeportistaGrupo } from 'src/app/models/Grupos';

@Injectable({
  providedIn: 'root'
})
export class InscripcionService {

  constructor(private http:HttpClient) { }

  //Para inscribirse en una carrera
  postInscripcionCarrera(inscripcion:Inscripcion):Observable<Inscripcion>{
    return this.http.post<Inscripcion>('api/Inscripcion',inscripcion);
  }

  //Para inscribirse en un reto
  postInscripcionReto(inscripcion:DeportistaReto):Observable<DeportistaReto>{
    return this.http.post<DeportistaReto>('api/DeportistaReto',inscripcion);
  }

  postInscripcionGrupo(inscripcion:DeportistaGrupo):Observable<DeportistaGrupo>{
    return this.http.post<DeportistaGrupo>('api/DeportistaGrupo',inscripcion);
  }
}
