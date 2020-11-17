import { TestBed } from '@angular/core/testing';

import { ActividadesAmigosService } from './actividades-amigos.service';

describe('ActividadesAmigosService', () => {
  let service: ActividadesAmigosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ActividadesAmigosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
