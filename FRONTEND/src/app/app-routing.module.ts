import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InicioDeportComponent } from './pages/inicio-deport/inicio-deport.component';
import { LoginComponent } from './pages/login/login.component';
import { RegisterComponent } from './pages/register/register.component';
import { AsoGrupoComponent } from './pages/aso-grupo/aso-grupo.component';
import { InsCarreraComponent } from './pages/ins-carrera/ins-carrera.component';
import { InsRetoComponent } from './pages/ins-reto/ins-reto.component';
import { BuscarComponent } from './pages/buscar/buscar.component';
import { VerRetosComponent } from './pages/ver-retos/ver-retos.component';
import { VerCompetenciasComponent } from './pages/ver-competencias/ver-competencias.component';
import { VerRetoInfoComponent } from './pages/ver-reto-info/ver-reto-info.component';


const routes: Routes = [
  { path: "login", component: LoginComponent, pathMatch: "full" },
  { path: "register", component: RegisterComponent, pathMatch: "full" },
  { path: "inicio-deport", component: InicioDeportComponent, pathMatch: "full" },
  { path: "inscarrera", component: InsCarreraComponent, pathMatch: "full" },
  { path: "insreto", component: InsRetoComponent, pathMatch: "full" },
  { path: "asogrupo", component: AsoGrupoComponent, pathMatch: "full" },
  { path: "buscar", component: BuscarComponent, pathMatch: "full"},
  { path: "verRetos", component: VerRetosComponent, pathMatch: "full"},
  { path: "verCompetencias", component: VerCompetenciasComponent, pathMatch: "full"},
  { path: "verRetosInfo", component: VerRetoInfoComponent, pathMatch: "full"},


  { path: "", component: InicioDeportComponent, pathMatch: "full" },
  { path: "**", component: InicioDeportComponent, pathMatch: "full" },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
