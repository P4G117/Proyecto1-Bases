import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerGrupoOrgComponent } from './ver-grupo-org.component';

describe('VerGrupoOrgComponent', () => {
  let component: VerGrupoOrgComponent;
  let fixture: ComponentFixture<VerGrupoOrgComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VerGrupoOrgComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VerGrupoOrgComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
