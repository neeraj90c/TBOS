import { TestBed } from '@angular/core/testing';

import { ValueListService } from './value-list.service';

describe('ValueListService', () => {
  let service: ValueListService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ValueListService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
