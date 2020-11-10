import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerRetosComponent } from './ver-retos.component';

describe('VerRetosComponent', () => {
  let component: VerRetosComponent;
  let fixture: ComponentFixture<VerRetosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VerRetosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VerRetosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
