import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TodolistRootComponent } from './todolist-root/todolist-root.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav'; 
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';


@NgModule({
  declarations: [
    TodolistRootComponent,
  ],
  imports: [
    CommonModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatIconModule, 
    MatButtonModule
  ],
  exports: [
    TodolistRootComponent
  ]
})
export class TodolistModule { }
