import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsCarreraComponent } from './ins-carrera.component';

describe('InsCarreraComponent', () => {
  let component: InsCarreraComponent;
  let fixture: ComponentFixture<InsCarreraComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InsCarreraComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InsCarreraComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
