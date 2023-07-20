import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { AuthService } from './auth.service';
import { LoginComponent } from './login/login.component';

import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { NavbarComponent } from './navbar/navbar.component';
import { LoginServiceService } from './login-service.service';





@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,


ForgotPasswordComponent,
    NavbarComponent



  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
   ReactiveFormsModule,
   HttpClientModule
  ],
  providers: [
    AuthService,
    LoginServiceService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
