import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GesGruposComponent } from './ges-grupos.component';

describe('GesGruposComponent', () => {
  let component: GesGruposComponent;
  let fixture: ComponentFixture<GesGruposComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GesGruposComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GesGruposComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
