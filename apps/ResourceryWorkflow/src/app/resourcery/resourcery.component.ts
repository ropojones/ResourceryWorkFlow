import { Component } from '@angular/core';

@Component({
  selector: 'app-resourcery',
  templateUrl: './resourcery.component.html',
  styleUrl: './resourcery.component.scss'
})
export class ResourceryComponent {
  isSidebarCollapsed = true;

  toggleSidebar(): void {
    this.isSidebarCollapsed = !this.isSidebarCollapsed;
  }
}
