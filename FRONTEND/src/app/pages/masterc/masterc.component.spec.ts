import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MastercComponent } from './masterc.component';

describe('MastercComponent', () => {
  let component: MastercComponent;
  let fixture: ComponentFixture<MastercComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MastercComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MastercComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
