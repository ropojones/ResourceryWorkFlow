import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LocalizationModule } from '@abp/ng.core';

import { InterpretationRoutingModule } from './interpretation-routing.module';
import { InterpretationComponent } from './interpretation.component';
import { InterpretationLayoutComponent } from './interpretation-layout.component';
import { InterpretationSidebarMenuComponent } from './interpretation-sidebar-menu.component';
import { ResourceryLayoutModule } from '../resourcery/layout/resourcery-layout.module';


@NgModule({
  declarations: [
    InterpretationComponent,
    InterpretationLayoutComponent,
    InterpretationSidebarMenuComponent
  ],
  imports: [
    CommonModule,
    LocalizationModule,
    InterpretationRoutingModule,
    ResourceryLayoutModule
  ]
})
export class InterpretationModule { }
