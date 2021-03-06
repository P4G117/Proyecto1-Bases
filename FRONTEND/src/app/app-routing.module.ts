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
import { VerRetoInfoComponent } from './pages/ver-reto-info/ver-reto-info.component';
import { VerCompetenciaInfoComponent } from './pages/ver-competencia-info/ver-competencia-info.component';
import { InicioOrganizadorComponent } from './pages/inicio-organizador/inicio-organizador.component';
import { VerRetosOrgComponent } from './pages/ver-retos-org/ver-retos-org.component';
import { CrearRetoComponent } from './pages/crear-reto/crear-reto.component';
import { VerCompetenciaOrgComponent } from './pages/ver-competencia-org/ver-competencia-org.component';
import { CrearCompComponent } from './pages/crear-comp/crear-comp.component';
import { AtletaComponent } from './pages/atleta/atleta.component';
import { VerGrupoOrgComponent } from './pages/ver-grupo-org/ver-grupo-org.component';


const routes: Routes = [
  { path: "login", component: LoginComponent, pathMatch: "full" },
  { path: "register", component: RegisterComponent, pathMatch: "full" },
  { path: "inicio-deport/:username", component: InicioDeportComponent, pathMatch: "full" },
  { path: "inscarrera/:username/:id", component: InsCarreraComponent, pathMatch: "full" },
  { path: "insreto/:username/:id", component: InsRetoComponent, pathMatch: "full" },
  { path: "asogrupo/:username/:id", component: AsoGrupoComponent, pathMatch: "full" },
  { path: "buscar/:username", component: BuscarComponent, pathMatch: "full"},
  { path: "verRetos/:username", component: VerRetosComponent, pathMatch: "full"},
  { path: "verCompetencias/:username", component: VerCompetenciasComponent, pathMatch: "full"},
  { path: "verRetosInfo/:username/:id", component: VerRetoInfoComponent, pathMatch: "full" },
  { path: "VerCompetenciaInfo/:username/:id", component: VerCompetenciaInfoComponent, pathMatch: "full"},
  { path: "home", component: HomeComponent, pathMatch: "full" },
  { path: "actividad/:username", component: SubActividadComponent, pathMatch: "full" },
  { path: "gesgrupos/:username", component: GesGruposComponent, pathMatch: "full" },
  { path: "vergrupo/:username/:creado/:id", component: VerGruposComponent, pathMatch: "full" },
  { path: "creargrupo/:username/:creado/:id", component: CrearGrupoComponent, pathMatch: "full" },
  { path: "participantes/:username/:id", component: ParticipantesComponent, pathMatch: "full" },
  { path: "posiciones/:username/:id", component: PosicionesComponent, pathMatch: "full" },
  { path: "junior/:username/:id", component: JuniorComponent, pathMatch: "full" },
  { path: "sub/:username/:id", component: SubComponent, pathMatch: "full" },
  { path: "open/:username/:id", component: OpenComponent, pathMatch: "full" },
  { path: "elite/:username/:id", component: EliteComponent, pathMatch: "full" },
  { path: "mastera/:username/:id", component: MasteraComponent, pathMatch: "full" },
  { path: "masterb/:username/:id", component: MasterbComponent, pathMatch: "full" },
  { path: "masterc/:username/:id", component: MastercComponent, pathMatch: "full" },
  { path: "inicio-organizador/:username", component: InicioOrganizadorComponent, pathMatch: "full"},
  { path: "verRetosOrg/:username", component: VerRetosOrgComponent, pathMatch: "full"},
  { path: "crearReto/:username/:creado/:id", component: CrearRetoComponent, pathMatch: "full"},
  { path: "verCompeOrg/:username", component:VerCompetenciaOrgComponent, pathMatch:"full"},
  { path: "crearComp/:username/:creado/:id", component:CrearCompComponent, pathMatch:"full"},
  { path: "atleta/:username/:username_friend/:amigo", component:AtletaComponent, pathMatch:"full"},
  { path: "verGrupoOrg/:username", component:VerGrupoOrgComponent, pathMatch:"full"},



  { path: "", component: HomeComponent, pathMatch: "full" },
  { path: "**", component: HomeComponent, pathMatch: "full" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
