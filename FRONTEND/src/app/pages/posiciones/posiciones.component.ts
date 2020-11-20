import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';
@Component({
  selector: 'app-posiciones',
  templateUrl: './posiciones.component.html',
  styleUrls: ['./posiciones.component.css']
})
export class PosicionesComponent implements OnInit {

  username:string;
  id:string;

  constructor(private router: Router,
    private _route: ActivatedRoute,) {
      this.username = this._route.snapshot.paramMap.get('username');
      this.id = this._route.snapshot.paramMap.get('id');
     }

  ngOnInit(): void {
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
