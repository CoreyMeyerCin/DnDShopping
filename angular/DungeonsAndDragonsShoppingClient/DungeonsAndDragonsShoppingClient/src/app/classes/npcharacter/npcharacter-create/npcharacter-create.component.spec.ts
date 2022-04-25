import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NpcharacterCreateComponent } from './npcharacter-create.component';

describe('NpcharacterCreateComponent', () => {
  let component: NpcharacterCreateComponent;
  let fixture: ComponentFixture<NpcharacterCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NpcharacterCreateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NpcharacterCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
