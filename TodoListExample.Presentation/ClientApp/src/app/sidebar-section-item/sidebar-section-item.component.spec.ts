import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SidebarSectionItemComponent } from './sidebar-section-item.component';

describe('SidebarSectionItemComponent', () => {
  let component: SidebarSectionItemComponent;
  let fixture: ComponentFixture<SidebarSectionItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SidebarSectionItemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SidebarSectionItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
