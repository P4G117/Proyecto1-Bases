import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './pages/login/login.component';
import { RegisterComponent } from './pages/register/register.component';
import { InicioDeportComponent } from './pages/inicio-deport/inicio-deport.component';
import { InsCarreraComponent } from './pages/ins-carrera/ins-carrera.component';
import { AsoGrupoComponent } from './pages/aso-grupo/aso-grupo.component';
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


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    InicioDeportComponent,
    InsCarreraComponent,
    AsoGrupoComponent,
    InsRetoComponent,
    BuscarComponent,
    VerRetosComponent,
    VerCompetenciasComponent,
    HomeComponent,
    SubActividadComponent,
    GesGruposComponent,
    VerGruposComponent,
    CrearGrupoComponent,
    ParticipantesComponent,
    PosicionesComponent,
    JuniorComponent,
    SubComponent,
    OpenComponent,
    EliteComponent,
    MasteraComponent,
    MasterbComponent,
    MastercComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    ReactiveFormsModule,
    MatButtonModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
