import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActividadesAmigos, PosiblesAmigos } from 'src/app/models/ActividadesAmigos';

@Injectable({
  providedIn: 'root'
})
export class ActividadesAmigosService {

  //url:string = '/GetActiAmigos/';
  constructor(private http:HttpClient) { }

  //Servicio para traerse todas las actividades de los amigos
  getActividadesAmigos(usuario:string):Observable<ActividadesAmigos>{
    return this.http.get<ActividadesAmigos>('/api/GetActiAmigos/' + usuario);
  }

  //Servicio para traerse lista de posibles amigos
  getNuevosAmigos(usuario:string):Observable<PosiblesAmigos[]>{
    return this.http.get<PosiblesAmigos[]>('/api/GetPosAmigos/' + usuario);
  }

}
