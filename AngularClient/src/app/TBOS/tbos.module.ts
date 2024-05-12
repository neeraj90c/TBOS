import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerMasterComponent } from './Master/Customer/customer-master/customer-master.component';
import { HomeComponent } from './Home/home.component';
import { TbosRoutingModule } from '../TBOS/tbos-routing.module';
import { WorklistComponent } from './worklist/worklist.component';
import { CustomerDetailComponent } from './Master/Customer/customer-detail/customer-detail.component';
import { HttpClientModule } from '@angular/common/http'


@NgModule({
  declarations: [
    HomeComponent,
    CustomerMasterComponent,
    WorklistComponent,
    CustomerDetailComponent
  ],
  imports: [
    CommonModule,
    TbosRoutingModule,
    HttpClientModule 
  ]
})
export class TbosModule { }
