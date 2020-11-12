import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router';

@Component({
  selector: 'app-ges-grupos',
  templateUrl: './ges-grupos.component.html',
  styleUrls: ['./ges-grupos.component.css']
})
export class GesGruposComponent implements OnInit {
  grupos=["Grupo 1",
  "Grupo 2",
  "Grupo 3"]

  constructor(private router: Router) { }

  ngOnInit(): void {
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
