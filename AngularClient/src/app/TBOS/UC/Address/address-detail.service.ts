import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { createAddress, deleteAddress, getAddressById, getAddressByMasterCode, getAddressByMasterCodeDefault, getAllAddresss, updateAddress } from 'src/app/GlobalVariables';
import { AddressDetailDTO, AddressList, CreateAddress, DeleteAddress, UpdateAddress } from './address.interface';

@Injectable({
  providedIn: 'root'
})
export class AddressDetailService {

  constructor(private http: HttpClient) { }

  ReadAllAddress():Observable<AddressList>{
    return this.http.get<AddressList>(getAllAddresss)
  }

  ReadAddressById(id:number):Observable<AddressDetailDTO>{
    return this.http.get<AddressDetailDTO>(getAddressById+`/${id}`)
  }

  ReadAddressByMasterCode(code:string):Observable<AddressList>{
    return this.http.get<AddressList>(getAddressByMasterCode+`/${code}`)
  }
  ReadAddressByMasterCodeDefault(code:string):Observable<AddressDetailDTO>{
    return this.http.get<AddressDetailDTO>(getAddressByMasterCodeDefault+`/${code}`)
  }

  CreateAddress(data:CreateAddress):Observable<AddressDetailDTO>{
    return this.http.post<AddressDetailDTO>(createAddress,data)
  }

  UpdateAddress(data:UpdateAddress):Observable<AddressDetailDTO>{
    return this.http.post<AddressDetailDTO>(updateAddress,data)
  }

  DeleteAddress(data:DeleteAddress):Observable<void>{
    return this.http.post<void>(deleteAddress,data)
  }
}
