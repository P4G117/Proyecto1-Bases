import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Follow, Organizador } from 'src/app/models/Organizador';
import { Retos } from 'src/app/models/Retos';
import { Carrera } from 'src/app/models/Carreras';
import { Grupo } from 'src/app/models/Grupos';

@Injectable({
  providedIn: 'root'
})
export class OrganizadorService {

  url:string = '/api/Organizador';

  constructor( private http:HttpClient) { }

  /* --------------------- CRUD de ORGANIZADOR -------------------*/
  getAll():Observable<Organizador>{
    return this.http.get<Organizador>(this.url);
  }

  getOrganizador(usuario:string):Observable<Organizador[]>{
    return this.http.get<Organizador[]>(this.url+'/'+usuario);
  }

  addOrganizador(organizador:Organizador):Observable<Organizador>{
    return this.http.post<Organizador>(this.url, organizador);
  }

  updateOrganizador(usuario:string,organizador:Organizador):Observable<Organizador>{
    return this.http.put<Organizador>(this.url + '/' + usuario, organizador);
  }

  deleteOrganizador(usuario:string):Observable<Organizador>{
    return this.http.delete<Organizador>(this.url + '/' + usuario);
  }

  /* --------------------- Fin de CRUD de ORGANIZADOR -------------------*/


  // Estos retornan los grupos, carreras o retos con los atributos de cada uno que tiene un organizador
  getRetosOrganizador(usuario:string):Observable<Retos[]>{
    return this.http.get<Retos[]>('/api/TodosRetosOrg/'+ usuario);
  }

  getCarrerasOrganizador(usuario:string):Observable<Carrera[]>{
    return this.http.get<Carrera[]>('/api/TodasCarrerasOrg/' + usuario);
  }

  getGruposOrganizador(usuario:string):Observable<Grupo[]>{
    return this.http.get<Grupo[]>('/api/TodasCarrerasOrg/' + usuario);
  }

  // Estos métodos retornan la cantidad de carreras, grupos o retos que tiene un Organizador
  getCantCarrerasOrganizador(usuario:string):Observable<Follow[]>{
    return this.http.get<Follow[]>('/api/GetTotalCarrerasOrg/'+ usuario);
  }

  getCantRetosOrganizador(usuario:string):Observable<Follow[]>{
    return this.http.get<Follow[]>('/api/GetTotalRetosOrg/'+ usuario);
  }

  getCantGruposOrganizador(usuario:string):Observable<Follow[]>{
    return this.http.get<Follow[]>('/api/GetTotalGruposDeOrg/'+ usuario);
  }

}
