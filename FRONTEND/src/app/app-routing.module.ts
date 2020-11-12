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
import { HomeComponent } from './pages/home/home.component';
import { SubActividadComponent } from './pages/sub-actividad/sub-actividad.component';
import { GesGruposComponent } from './pages/ges-grupos/ges-grupos.component';
import { VerGruposComponent } from './pages/ver-grupos/ver-grupos.component';
import { CrearGrupoComponent } from './pages/crear-grupo/crear-grupo.component';
import { ParticipantesComponent } from './pages/participantes/participantes.component';
import { PosicionesComponent } from './pages/posiciones/posiciones.component';
import { JuniorComponent } from './pages/junior/junior.component';
import { SubComponent } from './pages/sub/sub.component';
import { OpenComponent } from './pages/open/open.component';
import { EliteComponent } from './pages/elite/elite.component';
import { MasteraComponent } from './pages/mastera/mastera.component';
import { MasterbComponent } from './pages/masterb/masterb.component';
import { MastercComponent } from './pages/masterc/masterc.component';


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
  { path: "home", component: HomeComponent, pathMatch: "full" },
  { path: "actividad", component: SubActividadComponent, pathMatch: "full" },
  { path: "gesgrupos", component: GesGruposComponent, pathMatch: "full" },
  { path: "vergrupo", component: VerGruposComponent, pathMatch: "full" },
  { path: "creargrupo", component: CrearGrupoComponent, pathMatch: "full" },
  { path: "participantes", component: ParticipantesComponent, pathMatch: "full" },
  { path: "posiciones", component: PosicionesComponent, pathMatch: "full" },
  { path: "junior", component: JuniorComponent, pathMatch: "full" },
  { path: "sub", component: SubComponent, pathMatch: "full" },
  { path: "open", component: OpenComponent, pathMatch: "full" },
  { path: "elite", component: EliteComponent, pathMatch: "full" },
  { path: "mastera", component: MasteraComponent, pathMatch: "full" },
  { path: "masterb", component: MasterbComponent, pathMatch: "full" },
  { path: "masterc", component: MastercComponent, pathMatch: "full" },

  { path: "", component: HomeComponent, pathMatch: "full" },
  { path: "**", component: HomeComponent, pathMatch: "full" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
