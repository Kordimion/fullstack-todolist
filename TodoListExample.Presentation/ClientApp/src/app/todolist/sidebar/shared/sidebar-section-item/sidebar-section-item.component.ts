import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'sidebar-section-item',
  templateUrl: './sidebar-section-item.component.html',
  styleUrls: ['./sidebar-section-item.component.scss']
})
export class SidebarSectionItemComponent implements OnInit {
  constructor() { }

  @Input() icon = "";

  @Input() iconColor = "";

  @Input() text = "";

  ngOnInit(): void {
  }

}
