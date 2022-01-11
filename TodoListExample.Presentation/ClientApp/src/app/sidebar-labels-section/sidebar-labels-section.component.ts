import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sidebar-labels-section',
  templateUrl: './sidebar-labels-section.component.html',
  styleUrls: ['./sidebar-labels-section.component.scss']
})
export class SidebarLabelsSectionComponent implements OnInit {

  constructor() { }

  stopPropagation(event: Event) {
    event.stopPropagation();
  }

  ngOnInit(): void {
  }

}
