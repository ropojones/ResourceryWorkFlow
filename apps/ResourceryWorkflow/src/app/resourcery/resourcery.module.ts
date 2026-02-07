import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LocalizationModule } from '@abp/ng.core';

import { ResourceryRoutingModule } from './resourcery-routing.module';
import { ResourceryComponent } from './resourcery.component';
import { ResourcerySidebarComponent } from './layout/sidebar/sidebar.component';
import { ResourceryPageComponent } from './layout/page/page.component';
import { LogoComponent } from './layout/logo/logo.component';
import { ResourceryDashboardComponent } from './dashboard/dashboard.component';
import { ResourceryTranscriptionComponent } from './transcription/transcription.component';


@NgModule({
  declarations: [
    ResourceryComponent,
    ResourcerySidebarComponent,
    ResourceryPageComponent,
    ResourceryDashboardComponent,
    ResourceryTranscriptionComponent
  ],
  imports: [
    CommonModule,
    LocalizationModule,
    ResourceryRoutingModule,
    LogoComponent
  ]
})
export class ResourceryModule { }
