import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerRetosOrgComponent } from './ver-retos-org.component';

describe('VerRetosOrgComponent', () => {
  let component: VerRetosOrgComponent;
  let fixture: ComponentFixture<VerRetosOrgComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VerRetosOrgComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VerRetosOrgComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
