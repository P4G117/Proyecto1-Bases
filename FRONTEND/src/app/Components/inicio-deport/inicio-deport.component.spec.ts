import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InicioDeportComponent } from './inicio-deport.component';

describe('InicioDeportComponent', () => {
  let component: InicioDeportComponent;
  let fixture: ComponentFixture<InicioDeportComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InicioDeportComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InicioDeportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
