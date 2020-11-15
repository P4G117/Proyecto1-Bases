import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearCompComponent } from './crear-comp.component';

describe('CrearCompComponent', () => {
  let component: CrearCompComponent;
  let fixture: ComponentFixture<CrearCompComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CrearCompComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearCompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
