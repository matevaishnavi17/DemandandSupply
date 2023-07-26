import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../Services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  repeatPass: string ='none';
  displayMsg: string='';
  isAccountCreated: boolean=false;

  constructor(private authservice: AuthService) { }
  ngOnInit(): void {

  }

     selectedTeam = '';
     onSelected(value:string): void {
       this.selectedTeam = value;
      }

    registerForm = new FormGroup({
    firstname: new FormControl("",[Validators.required,Validators.minLength(2),Validators.pattern("[a-zA-z].*")]),
    lastname: new FormControl('',[Validators.required, Validators.minLength(2),Validators.pattern("[a-zA-Z].*")]),
    email: new FormControl('',[Validators.required, Validators.email]),
    password:new FormControl("",[Validators.required,Validators.minLength(6),Validators.maxLength(12)]),
    role:new FormControl("",[Validators.required])
  });

  registerSubmited(){if(this.Password.value != null)
    {
      console.log(this.registerForm);
      this.repeatPass='none'
      this.authservice.registerUser(
      [
        this.registerForm.value.firstname,
        this.registerForm.value.lastname,
        this.registerForm.value.email,

        this.registerForm.value.password,
        this.registerForm.value.role
      ]
      ).subscribe(res =>{
        if(res=='Registered'){
          alert('Account Created Successfully');
          this.isAccountCreated=true;
        }else if(res=='Already Exist'){
          alert("User Already Exist.")
          this.isAccountCreated=false;
        }else {
          alert('Something Went Wrong');
          this.isAccountCreated=false;
        }
  });
}
else{this.repeatPass='inline'}
}
get FirstName():FormControl{
  return this.registerForm.get("firstname") as FormControl;
}
get LastName():FormControl{
  return this.registerForm.get("lastname") as FormControl;
}
get Email():FormControl{
  return this.registerForm.get("email") as FormControl;
}

get Password():FormControl{
                return this.registerForm.get("password") as FormControl;
              }

get Role():FormControl{
                return this.registerForm.get("role") as FormControl;
              }

}
