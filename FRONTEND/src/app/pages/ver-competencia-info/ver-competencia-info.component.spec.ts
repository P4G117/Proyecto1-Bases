import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerCompetenciaInfoComponent } from './ver-competencia-info.component';

describe('VerCompetenciaInfoComponent', () => {
  let component: VerCompetenciaInfoComponent;
  let fixture: ComponentFixture<VerCompetenciaInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VerCompetenciaInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VerCompetenciaInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
