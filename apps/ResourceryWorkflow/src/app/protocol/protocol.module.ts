import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LocalizationModule } from '@abp/ng.core';

import { ProtocolRoutingModule } from './protocol-routing.module';
import { ProtocolComponent } from './protocol.component';
import { ProtocolLayoutComponent } from './protocol-layout.component';
import { ProtocolSidebarMenuComponent } from './protocol-sidebar-menu.component';
import { ResourceryLayoutModule } from '../resourcery/layout/resourcery-layout.module';


@NgModule({
  declarations: [
    ProtocolComponent,
    ProtocolLayoutComponent,
    ProtocolSidebarMenuComponent
  ],
  imports: [
    CommonModule,
    LocalizationModule,
    ProtocolRoutingModule,
    ResourceryLayoutModule
  ]
})
export class ProtocolModule { }
