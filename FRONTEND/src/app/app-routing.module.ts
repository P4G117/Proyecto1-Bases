import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InicioDeportComponent } from './Components/inicio-deport/inicio-deport.component';
import { LoginComponent } from './Components/login/login.component';
import { RegisterComponent } from './Components/register/register.component';
import { AsoGrupoComponent } from './pages/aso-grupo/aso-grupo.component';
import { InsCarreraComponent } from './pages/ins-carrera/ins-carrera.component';
import { InsRetoComponent } from './pages/ins-reto/ins-reto.component';


const routes: Routes = [
  { path: "login", component: LoginComponent, pathMatch: "full" },
  { path: "register", component: RegisterComponent, pathMatch: "full" },
  { path: "inicio-deport", component: InicioDeportComponent, pathMatch: "full" },
  { path: "inscarrera", component: InsCarreraComponent, pathMatch: "full" },
  { path: "insreto", component: InsRetoComponent, pathMatch: "full" },
  { path: "asogrupo", component: AsoGrupoComponent, pathMatch: "full" },
  { path: "", component: InicioDeportComponent, pathMatch: "full" },
  { path: "**", component: InicioDeportComponent, pathMatch: "full" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
