import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { createTransport, deleteTransport, getAllTransport, getTransportById, updateTransport } from 'src/app/GlobalVariables';
import { CreateTransport, DeleteTransport, TransportList, TransportMaster, UpdateTransport } from './transport.interface';

@Injectable({
  providedIn: 'root'
})
export class TransportMasterService {

  constructor(private http: HttpClient) { }

  ReadAllTransports(): Observable<TransportList> {
    return this.http.get<TransportList>(getAllTransport)
  }

  CreateTransport(data:CreateTransport): Observable<TransportMaster> {
    return this.http.post<TransportMaster>(createTransport,data)
  }

  UpdateTransport(data:UpdateTransport): Observable<TransportMaster> {
    return this.http.post<TransportMaster>(updateTransport,data)
  }

  ReadTransportById(TransportId:number): Observable<TransportMaster> {
    return this.http.get<TransportMaster>(getTransportById+`/${TransportId}`)
  }

  DeleteTransport(data:DeleteTransport): Observable<void> {
    return this.http.post<void>(deleteTransport,data)
  }
}
