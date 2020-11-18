import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Deportista } from 'src/app/models/Deportista';
import { Class } from 'src/app/models/Class';

@Injectable({
  providedIn: 'root'
})
export class DeportistaService {

  //url = "https://localhost:44317/api/Deportista";
  url:string = '/api/Deportista';

  constructor( private http:HttpClient) { }

  getAll():Observable<Deportista>{
    return this.http.get<Deportista>(this.url);
  }

  getDeportista(usuario:string):Observable<Deportista>{
    return this.http.get<Deportista>(this.url+'/'+usuario);
  }

  addDeportista(deportista:Deportista):Observable<Deportista>{
    return this.http.post<Deportista>(this.url, deportista);
  }

  getEM(){
    return this.http.get<Class>('/api/Deportista/sol');
  }

}
