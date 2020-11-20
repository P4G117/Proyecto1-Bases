import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';
@Component({
  selector: 'app-sub',
  templateUrl: './sub.component.html',
  styleUrls: ['./sub.component.css']
})
export class SubComponent implements OnInit {
  carrera:string;
  participantes=[];

  username:string;
  id:string;

  constructor(private router: Router,
    private _route: ActivatedRoute,) {
      this.username = this._route.snapshot.paramMap.get('username');
      this.id = this._route.snapshot.paramMap.get('id');
     }

  ngOnInit(): void {
    this.carrera="Running",
    this.participantes=[{nombre:"Nombre", edad:10,tiempo:"XX:XX:XX:xx"},
    {nombre:"Nombre", edad:10,tiempo:"XX:XX:XX:xx"},
    {nombre:"Nombre", edad:10,tiempo:"XX:XX:XX:xx"},
    {nombre:"Nombre", edad:10,tiempo:"XX:XX:XX:xx"}]
  }
  goInicio(){
    this.router.navigate(['inicio-organizador',this.username]);
  }

  goRetos(){
    this.router.navigate(['verRetosOrg',this.username]);
  }

  goCompetencias(){
    this.router.navigate(['verCompeOrg',this.username]);
  }

  goGrupo(){
    this.router.navigate(['verGrupoOrg',this.username]);
  }

}
