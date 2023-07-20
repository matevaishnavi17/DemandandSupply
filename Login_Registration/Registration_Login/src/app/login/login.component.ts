import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  constructor(private loginAuth : AuthService){ }
  ngOnInit(): void {

  }

  loginForm = new FormGroup({
    email: new FormControl("",[Validators.required,Validators.email]),
    password: new FormControl("",[Validators.required,Validators.minLength(6),Validators.maxLength(15)]),
    role:new FormControl("",[Validators.required])
  });

  isUserValid: boolean =false;

  loginSubmit(){
    console.log(this.loginForm.value);

    this.loginAuth.loginUser([this.loginForm.value.email,this.loginForm.value.password,this.loginForm.value.role])
    .subscribe((res) =>
    {
       if (res =='Failure'){
        this.isUserValid=false;
        alert('Login Unsuccessfull');
      }
      else{
        this.isUserValid=true;
        alert('Login Successfull');

      }
    });
   }
    get Email():FormControl {
    return this.loginForm.get('email') as FormControl;
    }
    get PWD():FormControl {
      return this.loginForm.get('password') as FormControl;
    }
    get Role():FormControl {
      return this.loginForm.get('role') as FormControl;
      }
  }


