import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router';
@Component({
  selector: 'app-junior',
  templateUrl: './junior.component.html',
  styleUrls: ['./junior.component.css']
})
export class JuniorComponent implements OnInit {
  carrera:string;
  participantes=[];

  constructor(private router: Router) { }

  ngOnInit(): void {
    this.carrera="Running",
    this.participantes=[{nombre:"Nombre", edad:10,tiempo:"XX:XX:XX:xx"},
    {nombre:"Nombre", edad:10,tiempo:"XX:XX:XX:xx"},
    {nombre:"Nombre", edad:10,tiempo:"XX:XX:XX:xx"},
    {nombre:"Nombre", edad:10,tiempo:"XX:XX:XX:xx"}]
  }
  retosGo(){
    this.router.navigate(['verRetos']);
  }

  competenciasGo(){
    this.router.navigate(['verCompetencias']);
  }
  gruposGo(){
    this.router.navigate(['gesgrupos']);
  }

}
