import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerCompetenciaOrgComponent } from './ver-competencia-org.component';

describe('VerCompetenciaOrgComponent', () => {
  let component: VerCompetenciaOrgComponent;
  let fixture: ComponentFixture<VerCompetenciaOrgComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VerCompetenciaOrgComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VerCompetenciaOrgComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
