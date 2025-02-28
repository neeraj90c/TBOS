import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { createValueListItem, getAllByVLName, getAllByVLNameMulti, getAllByValueListId, updateValueListItem } from 'src/app/GlobalVariables';
import { CreateValueListItem, UpdateValueListItem, ValueListItemAll, ValueListItemDTO, VlDictionaryList } from './valuelistitem.interface';

@Injectable({
  providedIn: 'root'
})
export class ValueListItemService {

  constructor(private http: HttpClient) { }

  ReadAllByVLId(id: number): Observable<ValueListItemAll> {
    return this.http.get<ValueListItemAll>(getAllByValueListId + `/${id}`)
  }

  ReadAllByVLName(vlName: string): Observable<ValueListItemAll> {
    return this.http.get<ValueListItemAll>(getAllByVLName + `/${vlName}`)
  }

  CreateValueList(data: CreateValueListItem): Observable<ValueListItemDTO> {
    return this.http.post<ValueListItemDTO>(createValueListItem, data)
  }

  UpdateValueList(data: UpdateValueListItem): Observable<ValueListItemDTO> {
    return this.http.post<ValueListItemDTO>(updateValueListItem, data)
  }
  ReadAllByVLNameMulti(data:{multiVLName: string}): Observable<VlDictionaryList> {
    return this.http.post<VlDictionaryList>(getAllByVLNameMulti,data)
  }
}
