import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Home/home.component';
import { CustomerMasterComponent } from './Master/Customer/customer-master/customer-master.component';
import { CustomerDetailComponent } from './Master/Customer/customer-detail/customer-detail.component';


const routes: Routes = [
  {
    path: '', component: HomeComponent, children: [
      { path: 'customer', component: CustomerMasterComponent, title: 'CustomerMaster' },
      { path: 'customer/:id', component: CustomerDetailComponent, title: 'Customer Details' },
    ]
  }
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TbosRoutingModule { }
