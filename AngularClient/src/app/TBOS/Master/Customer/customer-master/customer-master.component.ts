import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { PaginatedDTO } from 'src/app/TBOS/common.interface';
import { AgentMasterService } from '../../Agent/agent-master.service';
import { AgentMaster } from '../../Agent/agent.interface';
import { CreateCustomer, CustomerMasterDTO, CustomerMasterDTOPaginated, UpdateCustomer } from '../customer.interface';
import { CustomerService } from '../customer.service';
import { TransportMasterService } from '../../Transport/transport-master.service';
import { TransportMaster } from '../../Transport/transport.interface';
import { AddressDetailService } from 'src/app/TBOS/UC/Address/address-detail.service';
import { AuthenticationService } from 'src/app/Common/Authentication/authentication.service';
import { User } from 'src/app/Common/Authentication/auth.interface';
import { updateContact, updateCustomer } from 'src/app/GlobalVariables';
import { ContactDetailService } from 'src/app/TBOS/UC/Contact/contact-detail.service';
import { forkJoin, switchMap } from 'rxjs';
import { CreateAddress } from 'src/app/TBOS/UC/Address/address.interface';
import { CreateContact } from 'src/app/TBOS/UC/Contact/contact.interface';

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
    private addressService: AddressDetailService,
    private contactService: ContactDetailService,
    private authService: AuthenticationService,
    private modalService: NgbModal
  ) { }

  User: User = this.authService.User();
  customerList: CustomerMasterDTOPaginated[] = [];
  agentList: AgentMaster[] = [];
  transportList: TransportMaster[] = [];
  customerModal!: NgbModalRef;

  customerForm = new FormGroup({
    customerId: new FormControl(0),
    customerName: new FormControl('', Validators.required),
    transportId: new FormControl(0),
    agentId: new FormControl(0),
    paymentTerm: new FormControl(0),
    branchId: new FormControl(0),
    customerBranch: new FormControl(''),
    status: new FormControl(0),
    taxForm: new FormControl('', Validators.required),
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
    cGST: new FormControl('N'),
    sGST: new FormControl('N'),
    iGST: new FormControl('N'),
    uTGST: new FormControl('N'),
    gSTIN_No: new FormControl(''),
    gSTReverseCharge: new FormControl(''),
    exportGST: new FormControl('N'),
    actionUser: new FormControl(this.User.userId)
  });

  get taxFormCTRL(): FormControl {
    return this.customerForm.controls.taxForm
  }

  get customerNameCTRL(): FormControl {
    return this.customerForm.controls.customerName
  }

  addressForm = new FormGroup({
    detailId: new FormControl(0),
    masterCode: new FormControl(''),
    addressType: new FormControl(''),
    add_line1: new FormControl('', Validators.required),
    add_line2: new FormControl(''),
    add_line3: new FormControl(''),
    add_line4: new FormControl(''),
    city: new FormControl(''),
    state: new FormControl(''),
    country: new FormControl(''),
    pincode: new FormControl(''),
    status: new FormControl(2),
    actionUser: new FormControl(this.User.userId)
  })

  conactForm = new FormGroup({
    contactId: new FormControl(0),
    masterCode: new FormControl(''),
    personName: new FormControl('', Validators.required),
    designation: new FormControl(''),
    phoneNumber: new FormControl('', Validators.required),
    mobileNumber: new FormControl(''),
    emailId: new FormControl(''),
    contactStatus: new FormControl(2),
    actionUser: new FormControl(this.User.userId)
  })

  mainForm = new FormGroup({
    customerDetail: this.customerForm,
    addressDetail: this.addressForm,
    contactDetail: this.conactForm
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
    this.agentMasterService.ReadAllAgents().subscribe(res => {
      this.agentList = res.items
    })
    this.transportMasterService.ReadAllTransports().subscribe(res => {
      this.transportList = res.items
    })
    this.addressService.ReadAllAddress().subscribe(res => {
      console.log(res);

    })
  }

  openCustomerModal() {
    this.customerModal = this.modalService.open(this.customerModalContent, { size: 'xl' })
  }
  createCustomer() {
    this.mainForm.markAllAsTouched()

    let newCustomer = {}

    if (this.mainForm.touched && this.mainForm.valid) {

      let contactForm = { ...this.customerForm.value }
      let createCustomer: CreateCustomer = {
        customerName: contactForm.customerName as string,
        transportId: contactForm.transportId as number,
        paymentTerm: contactForm.paymentTerm as number,
        branchId: contactForm.branchId as number,
        customerBranch: contactForm.customerBranch as string,
        status: contactForm.status as number,
        taxForm: contactForm.taxForm as string,
        tin_No: contactForm.tin_No as string,
        agentCommission: contactForm.agentCommission as number,
        paymentDay: contactForm.paymentDay as string,
        creditDaysLock: contactForm.creditDaysLock as number,
        cstTinNo: contactForm.cstTinNo as string,
        customerType: contactForm.customerType as string,
        defaultPrice: contactForm.defaultPrice as string,
        defaultInvoice: contactForm.defaultInvoice as string,
        creditAmountLock: contactForm.creditAmountLock as number,
        panNo: contactForm.panNo as string,
        priority: contactForm.priority as string,
        customerRemarks: contactForm.customerRemarks as string,
        cGST: contactForm.cGST as string,
        sGST: contactForm.sGST as string,
        iGST: contactForm.iGST as string,
        uTGST: contactForm.uTGST as string,
        gSTIN_No: contactForm.gSTIN_No as string,
        gSTReverseCharge: contactForm.gSTReverseCharge as string,
        exportGST: contactForm.exportGST as string,
        actionUser: this.User.userId.toString()
      }
      this.customerService.CreateCustomer(createCustomer).pipe(switchMap(customerResponse => {
        customerResponse
        let addressForm = { ...this.addressForm.value }
        let createAddress: CreateAddress = {
          masterCode: customerResponse.customerCode,
          addressType: addressForm.addressType as string,
          add_line1: addressForm.add_line1 as string,
          add_line2: addressForm.add_line2 as string,
          add_line3: addressForm.add_line3 as string,
          add_line4: addressForm.add_line4 as string,
          city: addressForm.city as string,
          state: addressForm.state as string,
          country: addressForm.country as string,
          pincode: addressForm.pincode as string,
          status: addressForm.status as number,
          actionUser: this.User.userId.toString()
        }
        let contactForm = { ...this.conactForm.value }
        let createContact: CreateContact = {
          masterCode: customerResponse.customerCode,
          personName: contactForm.personName as string,
          designation: contactForm.designation as string,
          phoneNumber: contactForm.phoneNumber as string,
          mobileNumber: contactForm.mobileNumber as string,
          emailId: contactForm.emailId as string,
          contactStatus: contactForm.contactStatus as number,
          actionUser: this.User.userId.toString()
        }
        const createAddress$ = this.addressService.CreateAddress(createAddress)
        const createContact$ = this.contactService.CreateContact(createContact)
        return forkJoin([createAddress$, createContact$]);
      })).subscribe(
        ([addressResponse, contactResponse]) => {
          console.log('Address created:', addressResponse);
          console.log('Contact created:', contactResponse);
          this.mainForm.reset();
          this.customerModal.close()
        },
        error => {
          console.error('Error occurred:', error);
        }
      )

    }

  }


  onGstChange(gstType: string) {
    switch (gstType) {
      case 'cGST':
        this.customerForm.patchValue({ cGST: this.customerForm.value.cGST === 'Y' ? 'N' : 'Y' });
        this.customerForm.patchValue({ sGST: this.customerForm.value.cGST });
        this.customerForm.patchValue({ iGST: 'N' });
        this.customerForm.patchValue({ uTGST: 'N' });
        break;
      case 'sGST':
        this.customerForm.patchValue({ sGST: this.customerForm.value.sGST === 'Y' ? 'N' : 'Y' });
        this.customerForm.patchValue({ cGST: this.customerForm.value.sGST });
        this.customerForm.patchValue({ iGST: 'N' });
        this.customerForm.patchValue({ uTGST: 'N' });
        break;
      case 'iGST':
        this.customerForm.patchValue({ cGST: 'N' });
        this.customerForm.patchValue({ sGST: 'N' });
        this.customerForm.patchValue({ iGST: 'Y' });
        this.customerForm.patchValue({ uTGST: 'N' });
        break;
      case 'uTGST':
        this.customerForm.patchValue({ cGST: 'N' });
        this.customerForm.patchValue({ sGST: 'N' });
        this.customerForm.patchValue({ iGST: 'N' });
        this.customerForm.patchValue({ uTGST: 'Y' });
        break;
      case 'exportGST':
        this.customerForm.patchValue({ exportGST: this.customerForm.value.exportGST === 'Y' ? 'N' : 'Y' });
        break;
      default:
        break;
    }
  }
  setAgentCommission(e: AgentMaster) {
    console.log(e);
    this.customerForm.patchValue({
      agentCommission : e.agentCommission
    })
  }
  handlePageSizeChange(e: { currentPage: number, pageSize: number }) {
    let body: PaginatedDTO = {
      pageSize: e.pageSize,
      pageNo: e.currentPage
    }
    this.customerService.ReadAllCustomerPaginated(body).subscribe(res => {
      this.customerList = res.items
    })
  }

}
