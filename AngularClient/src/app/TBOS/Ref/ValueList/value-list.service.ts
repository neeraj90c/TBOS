import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CreateValueList, UpdateValueList, ValueListAll, ValueListDTO } from './valuelist.interface';
import { Observable } from 'rxjs';
import { createValueList, getAllValueList, updateValueList } from 'src/app/GlobalVariables';

@Injectable({
  providedIn: 'root'
})
export class ValueListService {

  constructor(private http: HttpClient) { }

  ReadAllValueList(): Observable<ValueListAll> {
    return this.http.get<ValueListAll>(getAllValueList)
  }

  CreateValueList(data: CreateValueList): Observable<ValueListDTO> {
    return this.http.post<ValueListDTO>(createValueList, data)
  }

  UpdateValueList(data: UpdateValueList): Observable<ValueListDTO> {
    return this.http.post<ValueListDTO>(updateValueList, data)
  }

}
