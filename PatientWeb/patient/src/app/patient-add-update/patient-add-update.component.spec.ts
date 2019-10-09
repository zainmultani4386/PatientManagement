import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PatientAddUpdateComponent } from './patient-add-update.component';

describe('PatientAddUpdateComponent', () => {
  let component: PatientAddUpdateComponent;
  let fixture: ComponentFixture<PatientAddUpdateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PatientAddUpdateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PatientAddUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
