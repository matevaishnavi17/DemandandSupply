import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DemandDataComponent } from './demand-data.component';

describe('DemandDataComponent', () => {
  let component: DemandDataComponent;
  let fixture: ComponentFixture<DemandDataComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DemandDataComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DemandDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
