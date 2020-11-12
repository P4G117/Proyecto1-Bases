import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MasterbComponent } from './masterb.component';

describe('MasterbComponent', () => {
  let component: MasterbComponent;
  let fixture: ComponentFixture<MasterbComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MasterbComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MasterbComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
