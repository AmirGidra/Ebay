import { TestBed } from '@angular/core/testing';

import { FilterServisService } from './filter-servis.service';

describe('FilterServisService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: FilterServisService = TestBed.get(FilterServisService);
    expect(service).toBeTruthy();
  });
});
