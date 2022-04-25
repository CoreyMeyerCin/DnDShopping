import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NpcharacterListComponent } from './npcharacter-list.component';

describe('NpcharacterListComponent', () => {
  let component: NpcharacterListComponent;
  let fixture: ComponentFixture<NpcharacterListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NpcharacterListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NpcharacterListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
