import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MasteraComponent } from './mastera.component';

describe('MasteraComponent', () => {
  let component: MasteraComponent;
  let fixture: ComponentFixture<MasteraComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MasteraComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MasteraComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
