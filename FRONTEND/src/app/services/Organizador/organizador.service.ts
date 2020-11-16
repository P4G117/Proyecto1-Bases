import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Organizador } from 'src/app/models/Organizador';

@Injectable({
  providedIn: 'root'
})
export class OrganizadorService {

  url:string = '/api/Organizador';

  constructor( private http:HttpClient) { }

  getAll():Observable<Organizador>{
    return this.http.get<Organizador>(this.url);
  }

  getOrganizador(usuario:string):Observable<Organizador>{
    return this.http.get<Organizador>(this.url+'/'+usuario);
  }

  addOrganizador(organizador:Organizador):Observable<Organizador>{
    return this.http.post<Organizador>(this.url, organizador);
  }
}
