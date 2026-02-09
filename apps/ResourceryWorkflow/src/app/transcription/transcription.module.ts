import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LocalizationModule } from '@abp/ng.core';

import { TranscriptionRoutingModule } from './transcription-routing.module';
import { TranscriptionComponent } from './transcription.component';
import { TranscriptionLayoutComponent } from './transcription-layout.component';
import { TranscriptionSidebarMenuComponent } from './transcription-sidebar-menu.component';
import { ResourceryLayoutModule } from '../resourcery/layout/resourcery-layout.module';


@NgModule({
  declarations: [
    TranscriptionComponent,
    TranscriptionLayoutComponent,
    TranscriptionSidebarMenuComponent
  ],
  imports: [
    CommonModule,
    LocalizationModule,
    TranscriptionRoutingModule,
    ResourceryLayoutModule
  ]
})
export class TranscriptionModule { }
