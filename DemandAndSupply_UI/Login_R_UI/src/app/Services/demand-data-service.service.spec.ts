import { TestBed } from '@angular/core/testing';

import { DemandDataServiceService } from './demand-data-service.service';

describe('DemandDataServiceService', () => {
  let service: DemandDataServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DemandDataServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
