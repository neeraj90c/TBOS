import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { User, UserLoginDTO, UserResponseDTO } from './auth.interface';
import { Auth, ValidateToken } from 'src/app/GlobalVariables';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient, private router: Router) { }

  isAuthenticated() {
    if (localStorage.getItem('access_token') != null || localStorage.getItem('access_token') != undefined) {
      return true;
    } else {
      return false
    }
  }

  SignOutUser() {
    this.router.navigate(['/login'])
    localStorage.clear()
  }


  userlogin(data: UserLoginDTO): Observable<UserResponseDTO> {
    return this.http.post<UserResponseDTO>(Auth, data);
  }

  validateToken(): Observable<User>  {
    return this.http.get<User>(ValidateToken);
  }


  UserData = {}

  // private userObject = new BehaviorSubject<any>({});

  // setData(value: any) {
  //   this.userObject.next(value);
  // }

  saveUserData(data:User){
    localStorage.setItem('userObject',encodeURIComponent(JSON.stringify(data)))
  }

  User():User{
    let userObject:any = localStorage.getItem('userObject')
    this.UserData=JSON.parse(decodeURIComponent(userObject))
    return JSON.parse(decodeURIComponent(userObject))
  }

  authorizedPages: string[] = []

  isUserAdminOrSupervisor():boolean{
    let roles = this.User().roleId.split(",").map(function(item) {
      return item.trim();
  })
    if(roles.includes('2') || roles.includes('3')){
      return true
    }else{
      return false
    }
  }


  isAdmin():boolean{
    let roles = this.User().roleId.split(",").map(function(item) {
      return item.trim();
  })
    if(roles.includes('3')){
      return true
    }else{
      return false
    }
  }

}
