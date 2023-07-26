import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { JwtHelperService } from '@auth0/angular-jwt';



@Injectable({
  providedIn: 'root'
})
export class LoginServiceService {
  jwtHelperService=new JwtHelperService();
  currentuser:BehaviorSubject<any>=new BehaviorSubject("null");

  constructor(private httpClient: HttpClient) {}
  baseApiUrl="http://localhost:5285/";

  registerUser(user: any) {
    return this.httpClient.post(
      this.baseApiUrl + 'api/Login',
      {
        firstName:user[0],
        lastName:user[1],
        email: user[2],
        password: user[3],
        role: user[4]
      },
      {
        responseType: 'text',
      }
    );
  }
  login(model: any) {
    return this.httpClient.post(this.baseApiUrl + "api/Login/Login" , model);
  }
  setToken(token: string) {
    localStorage.setItem("access_token",token);
    this.loadCurrentUser();
  }

  loadCurrentUser(){
    const Token=localStorage.getItem("Access_token");
    const userInfo=Token!=null?this.jwtHelperService.decodeToken(Token):null;
    console.log(userInfo);
    }
}
