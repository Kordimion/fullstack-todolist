import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SidebarLabelsSectionComponent } from './sidebar-labels-section.component';

describe('SidebarLabelsSectionComponent', () => {
  let component: SidebarLabelsSectionComponent;
  let fixture: ComponentFixture<SidebarLabelsSectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SidebarLabelsSectionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SidebarLabelsSectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
