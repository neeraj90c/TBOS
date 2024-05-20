import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { PaginatedDTO } from 'src/app/TBOS/common.interface';
import { AgentMasterService } from '../../Agent/agent-master.service';
import { AgentMaster } from '../../Agent/agent.interface';
import { CustomerMasterDTOPaginated } from '../customer.interface';
import { CustomerService } from '../customer.service';
import { TransportMasterService } from '../../Transport/transport-master.service';
import { TransportMaster } from '../../Transport/transport.interface';

@Component({
  selector: 'app-customer-master',
  templateUrl: './customer-master.component.html',
  styleUrls: ['./customer-master.component.css']
})
export class CustomerMasterComponent implements OnInit {


  constructor(
    private customerService: CustomerService,
    private agentMasterService: AgentMasterService,
    private transportMasterService: TransportMasterService,
    private modalService: NgbModal
  ) { }

  customerList: CustomerMasterDTOPaginated[] = []
  agentList: AgentMaster[] = []
  transportList: TransportMaster[] = [];
  customerModal!: NgbModalRef

  customerForm = new FormGroup({
    customerId: new FormControl(0),
    customerName: new FormControl('', Validators.required),
    transportId: new FormControl(0),
    agentId: new FormControl(0),
    paymentTerm: new FormControl(0),
    branchId: new FormControl(0),
    customerBranch: new FormControl(''),
    status: new FormControl(0),
    taxForm: new FormControl(''),
    tin_No: new FormControl(''),
    agentCommission: new FormControl(0),
    paymentDay: new FormControl(''),
    creditDaysLock: new FormControl(0),
    cstTinNo: new FormControl(''),
    customerType: new FormControl(''),
    defaultPrice: new FormControl(''),
    defaultInvoice: new FormControl(''),
    creditAmountLock: new FormControl(0),
    panNo: new FormControl(''),
    priority: new FormControl(''),
    customerRemarks: new FormControl(''),
    cGST: new FormControl(''),
    sGST: new FormControl(''),
    iGST: new FormControl(''),
    uTGST: new FormControl(''),
    gSTIN_No: new FormControl(''),
    gSTReverseCharge: new FormControl(''),
    exportGST: new FormControl(''),
    actionUser: new FormControl(0)
  });

  @ViewChild('customerModalTemplate') customerModalContent!: ElementRef

  ngOnInit(): void {
    let body: PaginatedDTO = {
      pageSize: 10,
      pageNo: 1
    }
    this.customerService.ReadAllCustomerPaginated(body).subscribe(res => {
      this.customerList = res.items
    })
    this.agentMasterService.ReadAllAgents().subscribe(res=>{
      this.agentList = res.items
    })
    this.transportMasterService.ReadAllTransports().subscribe(res=>{
      this.transportList = res.items
    })
  }

  openCustomerModal() {
    this.customerModal = this.modalService.open(this.customerModalContent, { size: 'xl' })
  }

}
