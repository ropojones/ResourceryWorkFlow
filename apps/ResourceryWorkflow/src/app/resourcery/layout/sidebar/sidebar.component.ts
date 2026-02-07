import { Component, Input } from '@angular/core';
import { AuthService } from '@abp/ng.core';


@Component({
  selector: 'app-resourcery-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.scss',
})
export class ResourcerySidebarComponent {
  @Input() collapsed = false;
}
