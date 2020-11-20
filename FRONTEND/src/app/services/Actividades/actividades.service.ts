import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Actividad } from 'src/app/models/Actividad';
@Injectable({
  providedIn: 'root'
})
export class ActividadesService {

  url:string = '/api/Actividad';

  constructor(private http:HttpClient) { }

  getActividad(usuario:string):Observable<Actividad>{
    return this.http.get<Actividad>(this.url+'/'+ usuario);
  }

  postActividad(actividad:Actividad):Observable<Actividad>{
    return this.http.post<Actividad>(this.url, actividad);
  }

  updateActividad(idActividad:number,actividad:Actividad):Observable<Actividad>{
    return this.http.put<Actividad>(this.url + '/' + idActividad, actividad);
  }

  deleteActividad(idActividad:number):Observable<Actividad>{
    return this.http.delete<Actividad>(this.url + '/' + idActividad);
  }
  
}
