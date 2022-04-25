import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NpcharacterDetailComponent } from './npcharacter-detail.component';

describe('NpcharacterDetailComponent', () => {
  let component: NpcharacterDetailComponent;
  let fixture: ComponentFixture<NpcharacterDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NpcharacterDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NpcharacterDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
