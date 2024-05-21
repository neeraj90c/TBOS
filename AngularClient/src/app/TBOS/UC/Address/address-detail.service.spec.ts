import { TestBed } from '@angular/core/testing';

import { AddressDetailService } from './address-detail.service';

describe('AddressDetailService', () => {
  let service: AddressDetailService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AddressDetailService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
