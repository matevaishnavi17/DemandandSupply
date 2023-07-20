import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class AuthService {

  constructor(private http: HttpClient) { }

  baseServerUrl = "https://localhost:5001/api/"

  registerUser(user: Array<String>)
  {

      return this.http.post(
      this.baseServerUrl+"Login",
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
  })
 }
}
