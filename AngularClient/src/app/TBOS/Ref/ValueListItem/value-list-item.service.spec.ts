import { TestBed } from '@angular/core/testing';

import { ValueListItemService } from './value-list-item.service';

describe('ValueListItemService', () => {
  let service: ValueListItemService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ValueListItemService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
