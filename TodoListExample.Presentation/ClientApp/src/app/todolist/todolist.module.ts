import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TodolistRootComponent } from './todolist-root/todolist-root.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav'; 
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { SidebarSectionComponent } from '../sidebar-section/sidebar-section.component';
import { SidebarSectionItemComponent } from '../sidebar-section-item/sidebar-section-item.component';
import { MatExpansionModule } from '@angular/material/expansion'; 


@NgModule({
  declarations: [
    TodolistRootComponent,
    SidebarSectionComponent,
    SidebarSectionItemComponent,
  ],
  imports: [
    CommonModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatIconModule, 
    MatButtonModule,
    MatExpansionModule
  ],
  exports: [
    TodolistRootComponent
  ]
})
export class TodolistModule { }
