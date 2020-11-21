import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CarrerasPorGrupo, CarrerasPublicas, Carrera } from 'src/app/models/Carreras';
import { Patrocinadores } from 'src/app/models/Retos';

@Injectable({
  providedIn: 'root'
})
export class CarrerasService {

  url:string = '/api/Carrera';
  constructor(private http:HttpClient) { }

  /* ---------------- CRUD de CARRERA --------------*/
  getAllCarrera():Observable<Carrera>{
    return this.http.get<Carrera>(this.url);
  }

  getCarrera(IdCarrera:string):Observable<Carrera[]>{
    return this.http.get<Carrera[]>(this.url + '/' + IdCarrera);
  }

  postCarrera(carrera:Carrera):Observable<Carrera>{
    return this.http.post<Carrera>(this.url,carrera);
  }

  updateCarrera(IdCarrera:number,carrera:Carrera):Observable<Carrera>{
    return this.http.put<Carrera>(this.url + '/' + IdCarrera,carrera);
  }

  deleteCarrera(IdCarrera:number):Observable<Carrera>{
    return this.http.delete<Carrera>(this.url + '/' + IdCarrera);
  }
  /* ---------------- Fin de CRUD de CARRERA --------------*/

    // Mostrar todas las carreras públicas que se encuentran disponibles
    getCarrerasPublicas():Observable<CarrerasPublicas>{
      return this.http.get<CarrerasPublicas>('/GetCarrerasPublicas');
    }

    // Mostras las carreras privadas segun el grupo donde se encuentra el deportista
    getCarrerasPorGrupo(usuario:string):Observable<CarrerasPorGrupo>{
      return this.http.get<CarrerasPorGrupo>('/GetCarrerasSegunGrupo/' + usuario);
    }

    //Obtener los patrocinadores de una carrera
    getPatrocinadores(IdCarrera:number):Observable<Patrocinadores>{
      return this.http.get<Patrocinadores>('/api/patrocinadoresCarreras/' + IdCarrera);
    }
}
