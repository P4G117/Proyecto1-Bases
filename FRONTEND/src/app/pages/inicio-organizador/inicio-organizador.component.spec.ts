import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InicioOrganizadorComponent } from './inicio-organizador.component';

describe('InicioOrganizadorComponent', () => {
  let component: InicioOrganizadorComponent;
  let fixture: ComponentFixture<InicioOrganizadorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InicioOrganizadorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InicioOrganizadorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
