import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {RetosPorGrupo, RetosPublicos,Retos } from 'src/app/models/Retos';
import { DeportistaGrupo, Grupo} from 'src/app/models/Grupos';

@Injectable({
  providedIn: 'root'
})
export class GruposService {

  url:string = '/api/Grupo';
  constructor(private http:HttpClient) { }

  //Para asociar un deportista a un grupo
  postGrupoDeportista(grupo:DeportistaGrupo):Observable<DeportistaGrupo>{
    return this.http.post<DeportistaGrupo>('/api/DeportistaGrupo', grupo);
  }

  //CRUD de los grupos, lo gestiona el Organizador.
  getAllGrupos():Observable<Grupo>{
    return this.http.get<Grupo>(this.url);
  }

  getGrupo(IdGrupo:number):Observable<Grupo>{
    return this.http.get<Grupo>(this.url + '/' + IdGrupo);
  }

  postGrupo(grupo:Grupo):Observable<Grupo>{
    return this.http.post<Grupo>(this.url,grupo);
  }

  updateGrupo(IdGrupo:number,grupo:Grupo):Observable<Grupo>{
    return this.http.put<Grupo>(this.url + '/' + IdGrupo,grupo);
  }

  deleteGrupo(IdGrupo:number):Observable<Grupo>{
    return this.http.delete<Grupo>(this.url + '/' + IdGrupo);
  }

}
