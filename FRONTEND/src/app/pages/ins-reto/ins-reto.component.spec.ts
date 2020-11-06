import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsRetoComponent } from './ins-reto.component';

describe('InsRetoComponent', () => {
  let component: InsRetoComponent;
  let fixture: ComponentFixture<InsRetoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InsRetoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InsRetoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
