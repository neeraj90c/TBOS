import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CustomerList, CustomerListPaginated } from './customer.interface';
import { getAllCustomers, getAllCustomersPaginated } from '../../../GlobalVariables';
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

}
