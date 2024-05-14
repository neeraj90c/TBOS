import { Injectable } from '@angular/core';
import { MenuDataItem, ParentMenu } from './ManageMenuDTO';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { getMenuForUser } from 'src/app/GlobalVariables';

@Injectable({
  providedIn: 'root'
})
export class MenuService {

  constructor(private http: HttpClient, private router: Router) { }


  getMenuForUser(data: ParentMenu): Observable<MenuDataItem> {
    return this.http.post<MenuDataItem>(getMenuForUser, data);
  }

}
