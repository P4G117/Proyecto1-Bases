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

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    InicioDeportComponent,
    InsCarreraComponent,
    AsoGrupoComponent,
    InsRetoComponent,
    BuscarComponent
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
