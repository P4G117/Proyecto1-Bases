import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {RetosPorGrupo, RetosPublicos, Retos, Patrocinadores} from 'src/app/models/Retos';
import { GrupoBusqueda } from 'src/app/models/Grupos';

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

  getReto(IdReto:string):Observable<Retos[]>{
    return this.http.get<Retos[]>(this.url + '/' + IdReto);
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
  getRetosPublicos():Observable<RetosPublicos[]>{
    return this.http.get<RetosPublicos[]>('/api/GetRetosPublicos');
  }

  //Obtener los retos(privados) por grupos que puede ver un deportista
  getRetosPorGrupos(usuario:string):Observable<RetosPorGrupo[]>{
    return this.http.get<RetosPorGrupo[]>('/api/GetRetosPorGrupo' + '/' + usuario);
  }

  //Obtener los patrocinadores de un reto
  getPatrocinadores(IdReto:number):Observable<Patrocinadores[]>{
    return this.http.get<Patrocinadores[]>('/api/patrocinadoresRetos/' + IdReto);
  }

  //Retos en los que está inscrito un deportista
  getRetosInscritos(usuario:string):Observable<GrupoBusqueda[]>{
    return this.http.get<GrupoBusqueda[]>('/api/RetInscritosDep/' + usuario);

  }
}
