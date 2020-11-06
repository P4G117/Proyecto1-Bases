import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AsoGrupoComponent } from './aso-grupo.component';

describe('AsoGrupoComponent', () => {
  let component: AsoGrupoComponent;
  let fixture: ComponentFixture<AsoGrupoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AsoGrupoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AsoGrupoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
