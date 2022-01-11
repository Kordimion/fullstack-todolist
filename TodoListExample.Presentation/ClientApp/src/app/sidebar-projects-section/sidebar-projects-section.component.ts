import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sidebar-projects-section',
  templateUrl: './sidebar-projects-section.component.html',
  styleUrls: ['./sidebar-projects-section.component.scss']
})
export class SidebarProjectsSectionComponent implements OnInit {

  constructor() { }

  stopPropagation(event: Event) {
    event.stopPropagation();
  }

  ngOnInit(): void {
  }

}
