import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { createAgent, deleteAgent, getAgentById, getAllAgents, updateAgent } from 'src/app/GlobalVariables';
import { AgentList, AgentMaster, CreateAgent, DeleteAgent, UpdateAgent } from './agent.interface';

@Injectable({
  providedIn: 'root'
})
export class AgentMasterService {

  constructor(private http: HttpClient) { }

  ReadAllAgents(): Observable<AgentList> {
    return this.http.get<AgentList>(getAllAgents)
  }

  CreateAgent(data:CreateAgent): Observable<AgentMaster> {
    return this.http.post<AgentMaster>(createAgent,data)
  }

  UpdateAgent(data:UpdateAgent): Observable<AgentMaster> {
    return this.http.post<AgentMaster>(updateAgent,data)
  }

  ReadAgentById(agentId:number): Observable<AgentMaster> {
    return this.http.get<AgentMaster>(getAgentById+`/${agentId}`)
  }

  DeleteAgent(data:DeleteAgent): Observable<void> {
    return this.http.post<void>(deleteAgent,data)
  }

}
