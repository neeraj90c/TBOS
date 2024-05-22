import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { catchError, of, switchMap } from 'rxjs';
import { AuthenticationService } from 'src/app/Common/Authentication/authentication.service';
import { MenuDataItem, ParentMenu } from 'src/app/Common/Menu/ManageMenuDTO';
import { MenuService } from 'src/app/Common/Menu/menu.service';
import { LoaderService } from 'src/app/Shared/loader/loader.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  User = this.authService.User();
  parentMenu: ParentMenu[] = [];

  constructor(
    private router: Router,
    private authService: AuthenticationService,
    private loaderService: LoaderService,
    private menuService: MenuService
  ) { }

  ngOnInit(): void {
    if (this.authService.isAuthenticated()) {
      this.authService.validateToken().pipe(
        switchMap(() => this.fetchUserMenu()),
        catchError(err => {
          this.Logout();
          return of(null);
        })
      ).subscribe();
    }else{
      //this.Logout();
    }
  }

  private fetchUserMenu() {
    const body: ParentMenu = {
      userId: this.User.userId,
      roleId: 0,
      menuId: 0,
      parentMenuId: 0,
      subRoleId: 0,
      subRoleName: '',
      subRoleCode: '',
      subRoleDesc: '',
      displayOrder: 0,
      defaultChildMenuId: 0,
      menuIconUrl: '',
      templatePath: '',
      isParent: 0,
      childrenCount: 0,
      childIsParent: 0
    };

    return this.menuService.getMenuForUser(body).pipe(
      switchMap((userMenu: MenuDataItem) => {
        this.authService.authorizedPages = userMenu.items.map(res => res.subRoleCode);

        this.parentMenu = userMenu.items.filter(res => res.isParent === 1 || res.childIsParent === 1)
          .map(res => {
            res.childMenuList = userMenu.items.filter(usermenu => usermenu.parentMenuId === res.menuId);
            return res;
          });
          console.log(this.parentMenu);
          

        return of(null);
      })
    );
  }

  Logout(): void {
    this.authService.SignOutUser();
  }

}
