import { NgModule } from '@angular/core';

import { PagesRoutingModule } from './pages-routing.module';
import { PagesComponent } from './pages.component';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [PagesComponent, LoginComponent],
  imports: [PagesRoutingModule]
})
export class PagesModule {}