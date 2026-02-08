import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LocalizationModule } from '@abp/ng.core';

import { ConferenceRoutingModule } from './conference-routing.module';
import { ConferenceComponent } from './conference.component';
import { ConferenceLayoutComponent } from './conference-layout.component';
import { ConferenceSidebarMenuComponent } from './conference-sidebar-menu.component';
import { ResourceryLayoutModule } from '../resourcery/layout/resourcery-layout.module';


@NgModule({
  declarations: [
    ConferenceComponent,
    ConferenceLayoutComponent,
    ConferenceSidebarMenuComponent
  ],
  imports: [
    CommonModule,
    LocalizationModule,
    ConferenceRoutingModule,
    ResourceryLayoutModule
  ]
})
export class ConferenceModule { }
