import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { createContact, deleteContact, getAllContacts, getContactById, getContactByMasterCode, getContactByMasterCodeDefault, updateContact } from 'src/app/GlobalVariables';
import { ContactDetailDTO, ContactList, CreateContact, DeleteContact, UpdateContact } from './contact.interface';

@Injectable({
  providedIn: 'root'
})
export class ContactDetailService {

  constructor(private http: HttpClient) { }

  ReadAllContact():Observable<ContactList>{
    return this.http.get<ContactList>(getAllContacts)
  }

  ReadContactById(id:number):Observable<ContactDetailDTO>{
    return this.http.get<ContactDetailDTO>(getContactById+`/${id}`)
  }

  ReadContactByMasterCode(code:string):Observable<ContactList>{
    return this.http.get<ContactList>(getContactByMasterCode+`/${code}`)
  }
  ReadContactByMasterCodeDefault(code:string):Observable<ContactDetailDTO>{
    return this.http.get<ContactDetailDTO>(getContactByMasterCodeDefault+`/${code}`)
  }

  CreateContact(data:CreateContact):Observable<ContactDetailDTO>{
    return this.http.post<ContactDetailDTO>(createContact,data)
  }

  UpdateContact(data:UpdateContact):Observable<ContactDetailDTO>{
    return this.http.post<ContactDetailDTO>(updateContact,data)
  }

  DeleteContact(data:DeleteContact):Observable<void>{
    return this.http.post<void>(deleteContact,data)
  }
}
