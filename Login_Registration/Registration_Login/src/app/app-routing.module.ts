import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { LoginComponent } from './login/login.component';

import { RegisterComponent } from './register/register.component';

const routes: Routes = [
  {
    path:'app-login',
    component:LoginComponent
  },
  {
    path:'app-register',
    component:RegisterComponent
  },
  {
    path:'app-forgot-password',
    component:ForgotPasswordComponent
  },
  {
    path:'',
    redirectTo : 'login',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
