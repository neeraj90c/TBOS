import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgentMasterComponent } from './agent-master.component';

describe('AgentMasterComponent', () => {
  let component: AgentMasterComponent;
  let fixture: ComponentFixture<AgentMasterComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AgentMasterComponent]
    });
    fixture = TestBed.createComponent(AgentMasterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
