import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthenticationService } from '../Common/Authentication/authentication.service';
import { UserLoginDTO } from '../Common/Authentication/auth.interface';
import { Router } from '@angular/router';
import { LoaderService } from '../Shared/loader/loader.service';
import { catchError, of, switchMap } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginError: string | null = null;
  isLoading: boolean = false;

  constructor(
    private authService: AuthenticationService,
    private router: Router,
    private loaderService: LoaderService
  ) { }

  ngOnInit(): void {
    if (this.authService.isAuthenticated()) {
      this.router.navigate(['/']);
    }
  }

  LoginForm = new FormGroup({
    userName: new FormControl('', [Validators.required]),
    password: new FormControl('', [Validators.required]),
    companyCode: new FormControl('string')
  });

  loginUser(): void {

    if (this.LoginForm.valid) {
      this.loaderService.show()
      let userdata: UserLoginDTO = { ...this.LoginForm.value } as UserLoginDTO
      this.authService.userlogin(userdata).pipe(
        switchMap((res) => {
          if (res.data.token.trim() !== "") {
            localStorage.setItem('access_token', res.data.token.trim());
            return this.authService.validateToken();
          } else {
            this.loginError = res.data.designation;
            return of(null);
          }
        }),
        catchError((err) => {
          this.authService.SignOutUser();
          return of(null);
        })
      ).subscribe({
        next: (res) => {
          if (res) {
            this.authService.saveUserData(res);
            this.loaderService.dismiss()
            this.router.navigate(['/']);
          }
        }
      });
    }
  }

}
