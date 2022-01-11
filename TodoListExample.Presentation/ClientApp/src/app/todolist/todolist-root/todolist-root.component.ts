import { Component } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';

@Component({
  selector: 'todolist-root',
  templateUrl: './todolist-root.component.html',
  styleUrls: ['./todolist-root.component.css']
})
export class TodolistRootComponent {

  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches),
      shareReplay()
    );

  stopPropagation(event: Event) {
    event.stopPropagation();
  }

  constructor(private breakpointObserver: BreakpointObserver) {}

}
