import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { PaginatedDTO } from 'src/app/TBOS/common.interface';
import { CustomerMasterDTOPaginated } from '../customer.interface';
import { CustomerService } from '../customer.service';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-customer-master',
  templateUrl: './customer-master.component.html',
  styleUrls: ['./customer-master.component.css']
})
export class CustomerMasterComponent implements OnInit {


  constructor(
    private customerService: CustomerService,
    private modalService: NgbModal
  ) { }

  customerList: CustomerMasterDTOPaginated[] = []
  customerModal!: NgbModalRef
  customerForm = new FormGroup({
    
  })

  @ViewChild('customerModalTemplate') customerModalContent!: ElementRef

  ngOnInit(): void {
    let body: PaginatedDTO = {
      pageSize: 10,
      pageNo: 1
    }
    this.customerService.ReadAllCustomerPaginated(body).subscribe(res => {
      this.customerList = res.items
    })
  }

  openCustomerModal() {
    this.customerModal = this.modalService.open(this.customerModalContent, { size: 'xl' })
  }

}
