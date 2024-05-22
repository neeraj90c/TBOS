import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TransportMasterComponent } from './transport-master.component';

describe('TransportMasterComponent', () => {
  let component: TransportMasterComponent;
  let fixture: ComponentFixture<TransportMasterComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TransportMasterComponent]
    });
    fixture = TestBed.createComponent(TransportMasterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
