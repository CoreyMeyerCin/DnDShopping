import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NpcharacterEditComponent } from './npcharacter-edit.component';

describe('NpcharacterEditComponent', () => {
  let component: NpcharacterEditComponent;
  let fixture: ComponentFixture<NpcharacterEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NpcharacterEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NpcharacterEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
