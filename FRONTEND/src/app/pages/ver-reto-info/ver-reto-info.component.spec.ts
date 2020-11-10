import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerRetoInfoComponent } from './ver-reto-info.component';

describe('VerRetoInfoComponent', () => {
  let component: VerRetoInfoComponent;
  let fixture: ComponentFixture<VerRetoInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VerRetoInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VerRetoInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
