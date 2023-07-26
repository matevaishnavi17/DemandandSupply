import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DemandDataComponent } from './demand-data/demand-data.component';
import { fileuploadComponent } from './file-upload/file-upload.component';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { LoginComponent } from './login/login.component';
import { NavigatorComponent } from './navigator/navigator.component';

import { RegisterComponent } from './register/register.component';
import { AuthserviceGuard } from './Services/authservice.guard';
import { LoginPermissionGuard } from './Services/login-permission.guard';
import { PermissionGuard } from './Services/permission.guard';


const routes: Routes = [
  {
    path:'app-login',
    component:LoginComponent,
    canActivate:[LoginPermissionGuard]
  },
  {
    path:'',
    component:RegisterComponent,
    canActivate:[AuthserviceGuard, PermissionGuard]
  },
  {
    path:'app-navigator',
    component:NavigatorComponent
  },
  {
    path:'app-file-upload',
    component:fileuploadComponent
  },
  {
    path:'app-forgot-password',
    component:ForgotPasswordComponent
  },
  {
    path:'app-demand-data',
    component:DemandDataComponent
  },
 
  
  
  // {
  //   path:'',
  //   redirectTo : 'login',
  //   pathMatch: 'full'
  // },
  



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
