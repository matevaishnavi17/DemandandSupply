import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import{JwtHelperService} from '@auth0/angular-jwt';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class AuthService {
  currentuser:BehaviorSubject<any>=new BehaviorSubject("null");
  baseServerUrl = "http://localhost:5285/api/"
  jwtHelperService=new JwtHelperService();
  constructor(private http: HttpClient) { }

  registerUser(user: Array<String>)
  {

      return this.http.post(
      this.baseServerUrl+"Login/Registration",
      {
       firstName: user[0],
       lastName:user[1],
       email:user[2],


       password:user[3],
       role:user[4]
      },
      {
        responseType: 'text',
      }
    );
  }

  loginUser(loginInfo: Array<string>){
    return this.http.post(this.baseServerUrl + 'Login/Login',
    {
    email : loginInfo[0],
    password :loginInfo[1],
    role:loginInfo[2]

    },
  {
    responseType: 'text',
  });
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
