import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class LoginServiceService {

  constructor(private httpClient: HttpClient) {}
  baseApiUrl="https://localhost:5001/";

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
}
