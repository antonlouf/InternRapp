import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddLanguagePopupComponent } from './add-language-popup.component';

describe('AddLanguagePopupComponent', () => {
  let component: AddLanguagePopupComponent;
  let fixture: ComponentFixture<AddLanguagePopupComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddLanguagePopupComponent],
    }).compileComponents();

    fixture = TestBed.createComponent(AddLanguagePopupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
