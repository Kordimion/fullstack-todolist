import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'sidebar-section',
  templateUrl: './sidebar-section.component.html',
  styleUrls: ['./sidebar-section.component.scss']
})
export class SidebarSectionComponent implements OnInit {

  constructor() { }

  @Input() name = '';

  ngOnInit(): void {
  }

}
