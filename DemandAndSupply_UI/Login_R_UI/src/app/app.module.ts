import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { AuthService } from './Services/auth.service';
import { LoginComponent } from './login/login.component';
import{JwtHelperService, JwtModule} from '@auth0/angular-jwt';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { NavbarComponent } from './navbar/navbar.component';
import { LoginServiceService } from './Services/login-service.service';
import { FileUploadService } from './Services/file-upload.service';
import { fileuploadComponent } from './file-upload/file-upload.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatPaginatorModule } from '@angular/material/paginator';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { NgFor } from '@angular/common';
//import { NgModule } from '@angular/core';
import {MatCheckboxModule} from '@angular/material/checkbox';

import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { DemandDataComponent } from './demand-data/demand-data.component';
import { NavigatorComponent } from './navigator/navigator.component';
import { MatToolbar, MatToolbarModule } from '@angular/material/toolbar';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatAutocompleteSelectedEvent, MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatChipInputEvent, MatChipsModule } from '@angular/material/chips';
import { MatDialogModule } from '@angular/material/dialog';
import {MatInputModule} from '@angular/material/input';







@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,
    ForgotPasswordComponent,
    NavbarComponent,
    fileuploadComponent,
    DemandDataComponent,
    NavigatorComponent,


],
  imports: [
    BrowserModule,
    AppRoutingModule,
   ReactiveFormsModule,
   HttpClientModule,
   MatCardModule,

   MatButtonModule,
   MatPaginatorModule,
   MatTableModule,
   MatIconModule,
   HttpClientModule,
   MatToolbarModule,
   MatExpansionModule,
   BrowserAnimationsModule,
   MatSidenavModule,
   MatChipsModule,
   MatAutocompleteModule,
   MatDialogModule,
   MatInputModule,


   MatFormFieldModule,
   MatSelectModule,
   FormsModule,
   NgFor,
   MatCheckboxModule,
   ReactiveFormsModule,
   BrowserAnimationsModule,
//    JwtModule.forRoot({
//     config: {
//       tokenGetter: tokenGetter,
//       allowedDomains: ["localhost:5205"],
//       disallowedRoutes: []
//     }
//   })
 ],
  schemas:[CUSTOM_ELEMENTS_SCHEMA],

  providers: [
    AuthService,
    LoginServiceService,
    FileUploadService,

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
