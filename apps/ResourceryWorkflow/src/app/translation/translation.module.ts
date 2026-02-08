import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LocalizationModule } from '@abp/ng.core';

import { TranslationRoutingModule } from './translation-routing.module';
import { TranslationComponent } from './translation.component';
import { TranslationLayoutComponent } from './translation-layout.component';
import { TranslationSidebarMenuComponent } from './translation-sidebar-menu.component';
import { ResourceryLayoutModule } from '../resourcery/layout/resourcery-layout.module';


@NgModule({
  declarations: [
    TranslationComponent,
    TranslationLayoutComponent,
    TranslationSidebarMenuComponent
  ],
  imports: [
    CommonModule,
    LocalizationModule,
    TranslationRoutingModule,
    ResourceryLayoutModule
  ]
})
export class TranslationModule { }
