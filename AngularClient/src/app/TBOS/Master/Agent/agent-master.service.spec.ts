import { TestBed } from '@angular/core/testing';

import { AgentMasterService } from './agent-master.service';

describe('AgentMasterService', () => {
  let service: AgentMasterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AgentMasterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
