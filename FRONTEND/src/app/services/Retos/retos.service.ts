import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {RetosPorGrupo, RetosPublicos,Retos } from 'src/app/models/Retos';

@Injectable({
  providedIn: 'root'
})
export class RetosService {

  url:string = '/api/Reto';
  constructor(private http:HttpClient) { }


  //CRUD para los retos
  getAllRetos():Observable<Retos>{
    return this.http.get<Retos>(this.url);
  }

  getReto(IdReto:number):Observable<Retos>{
    return this.http.get<Retos>(this.url + '/' + IdReto);
  }

  postReto(reto:Retos):Observable<Retos>{
    return this.http.post<Retos>(this.url,reto);
  }

  updateReto(IdReto:number,reto:Retos):Observable<Retos>{
    return this.http.put<Retos>(this.url + '/' + IdReto,reto);
  }

  deleteReto(IdReto:number):Observable<Retos>{
    return this.http.delete<Retos>(this.url + '/' + IdReto);
  }

  //Obtener los retos publicos que puede ver un deportista
  getRetosPublicos():Observable<RetosPublicos>{
    return this.http.get<RetosPublicos>('/GetRetosPublicos');
  }

  //Obtener los retos(privados) por grupos que puede ver un deportista
  getRetosPorGrupos(usuario:string):Observable<RetosPorGrupo>{
    return this.http.get<RetosPorGrupo>('/GetRetosPorGrupo' + '/' + usuario);
  }
}
