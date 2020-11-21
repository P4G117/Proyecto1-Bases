import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Deportista, Follow, NuevosAmigos } from 'src/app/models/Deportista';
import { Class } from 'src/app/models/Class';
import { Grupo, GrupoBusqueda } from 'src/app/models/Grupos';
import { ActividadesAmigos, PosiblesAmigos } from 'src/app/models/ActividadesAmigos';
@Injectable({
  providedIn: 'root'
})
export class DeportistaService {

  //url = "https://localhost:44317/api/Deportista";
  url:string = '/api/Deportista';

  constructor( private http:HttpClient) { }

  /* -------- CRUD DE DEPORTISTAS -------------- */
  getAll():Observable<Deportista>{
    return this.http.get<Deportista>(this.url);
  }

  getDeportista(usuario:string):Observable<Deportista[]>{
    return this.http.get<Deportista[]>(this.url+'/'+usuario);
  }

  addDeportista(deportista:Deportista):Observable<Deportista>{
    return this.http.post<Deportista>(this.url, deportista);
  }

  updateDeportista(usuario:string,deportista:Deportista):Observable<Deportista>{
    return this.http.put<Deportista>(this.url + '/' + usuario, deportista);
  }

  deleteDeportista(usuario:string):Observable<Deportista>{
    return this.http.delete<Deportista>(this.url + '/' + usuario);
  }

  /* ---------- FIN DEL CRUD DEPORTISTAS -----------*/

  //Cantidad de followers
  getFollower(usuario:string):Observable<Follow[]>{
    return this.http.get<Follow[]>('/api/GetFollowers/' + usuario);
  }

  //Cantidad de following
  getFollowing(usuario:string):Observable<Follow[]>{
    return this.http.get<Follow[]>('/api/GetFollowing/' + usuario);
  }

  //Cantidad de actividades
  getTotalActividades(usuario:string):Observable<Follow[]>{
    return this.http.get<Follow[]>('/api/GetTotalActividad/' + usuario);
  }

  //Edad del deportista
  getEdadDeportista(usuario:string):Observable<Follow[] >{
    return this.http.get<Follow[]>('/api/GetEdadDeportista/' + usuario);
  }

  // Ver las actividades de los que ya son amigos de un deportista
  getActividadAmigos(usuario:string):Observable<ActividadesAmigos>{
    return this.http.get<ActividadesAmigos>('/api/GetActiAmigos/'+usuario);
  }

  // Buscar grupos a los que un deportista NO pertenece
  //Buscar todos los grupos disponibles
  getGrupos(usuario:string):Observable<GrupoBusqueda>{
    return this.http.get<GrupoBusqueda>('/api/GetGruposDisponibles/'+ usuario);
  }

  //Buscar un grupo disponible por nombre
  getGruposPorNombre(usuario:string,grupo:string):Observable<GrupoBusqueda>{
    return this.http.get<GrupoBusqueda>('/api/BusquedaGruposDisponibles/'+ usuario + '/'+ grupo);
  }

  //Buscar grupos por nombre que SÍ pertenece un deportista
  getMisGrupos(usuario:string):Observable<Grupo>{
    return this.http.get<Grupo>('/api/MisGruposDep/'+usuario);
  }

  //Buscar nuevos deportistas amigos
  getNuevosAmigos(usuario:string):Observable<PosiblesAmigos>{
    return this.http.get<PosiblesAmigos>('/api/GetPosAmigos/' + usuario);
  }

  //Buscar nuevos deportistas amigos por nombre
  getNuevosAmigosNombre(usuario:string,amigo:string):Observable<NuevosAmigos>{
    return this.http.get<NuevosAmigos>('/api/GetBusquedaNombre/'+ usuario + '/' + amigo);
  }

  //Buscar nuevos deportistas amigos por nombre y apellido
  getNuevosAmigosApellido(usuario:string,nombre:string,apellido:string):Observable<NuevosAmigos>{
    return this.http.get<NuevosAmigos>('/api/GetBusquedaNombreApe/' + '/' + usuario + '/' + nombre + '/' + apellido);
  }

  //Buscar nuevos deportistas amigos por nombre y apellidos
  getNuevosAmigosNombreCompleto(usuario:string,nombre:string,apellido1:string,apellido2:string):Observable<NuevosAmigos>{
    return this.http.get<NuevosAmigos>('/api/GetBusquedaNombreApe/' + '/' + usuario + '/'
+ nombre + '/' + apellido1+'/'+apellido2);
  }

}
