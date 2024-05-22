import { TestBed } from '@angular/core/testing';

import { TransportMasterService } from './transport-master.service';

describe('TransportMasterService', () => {
  let service: TransportMasterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TransportMasterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
