import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CreateCustomer, CustomerList, CustomerListPaginated, CustomerMasterDTO } from './customer.interface';
import { createCustomer, getAllCustomers, getAllCustomersPaginated } from '../../../GlobalVariables';
import { PaginatedDTO } from '../../common.interface';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http: HttpClient) { }

  ReadAllCustomer(): Observable<CustomerList> {
    return this.http.get<CustomerList>(getAllCustomers)
  }

  ReadAllCustomerPaginated(data: PaginatedDTO): Observable<CustomerListPaginated> {
    return this.http.post<CustomerListPaginated>(getAllCustomersPaginated, data)
  }

  CreateCustomer(data: CreateCustomer): Observable<CustomerMasterDTO> {
    return this.http.post<CustomerMasterDTO>(createCustomer, data)
  }

}
