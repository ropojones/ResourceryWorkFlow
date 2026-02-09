import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LocalizationModule } from '@abp/ng.core';

import { DirectorateRoutingModule } from './directorate-routing.module';
import { DirectorateComponent } from './directorate.component';
import { DirectorateLayoutComponent } from './directorate-layout.component';
import { DirectorateSidebarMenuComponent } from './directorate-sidebar-menu.component';
import { InternalMemorandaComponent } from './internal-memoranda/internal-memoranda.component';
import { ResourceryLayoutModule } from '../resourcery/layout/resourcery-layout.module';


@NgModule({
  declarations: [
    DirectorateComponent,
    DirectorateLayoutComponent,
    DirectorateSidebarMenuComponent,
    InternalMemorandaComponent
  ],
  imports: [
    CommonModule,
    DirectorateRoutingModule,
    LocalizationModule,
    ResourceryLayoutModule
  ]
})
export class DirectorateModule { }
