import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SidebarProjectsSectionComponent } from './sidebar-projects-section.component';

describe('SidebarProjectsSectionComponent', () => {
  let component: SidebarProjectsSectionComponent;
  let fixture: ComponentFixture<SidebarProjectsSectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SidebarProjectsSectionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SidebarProjectsSectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
