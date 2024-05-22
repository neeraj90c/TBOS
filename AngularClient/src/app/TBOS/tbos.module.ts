import { NgModule } from '@angular/core';
import { SharedModule } from '../Shared/shared.module';
import { TbosRoutingModule } from '../TBOS/tbos-routing.module';
import { HomeComponent } from './Home/home.component';
import { AgentMasterComponent } from './Master/Agent/agent-master/agent-master.component';
import { CustomerDetailComponent } from './Master/Customer/customer-detail/customer-detail.component';
import { CustomerMasterComponent } from './Master/Customer/customer-master/customer-master.component';
import { TransportMasterComponent } from './Master/Transport/transport-master/transport-master.component';
import { WorklistComponent } from './worklist/worklist.component';


@NgModule({
  declarations: [
    HomeComponent,
    CustomerMasterComponent,
    WorklistComponent,
    CustomerDetailComponent,
    TransportMasterComponent,
    AgentMasterComponent
  ],
  imports: [
    SharedModule,
    TbosRoutingModule
     
  ]
})
export class TbosModule { }
