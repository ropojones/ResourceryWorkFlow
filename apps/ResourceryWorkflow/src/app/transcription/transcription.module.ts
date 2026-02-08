import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TranscriptionRoutingModule } from './transcription-routing.module';
import { TranscriptionComponent } from './transcription.component';


@NgModule({
  declarations: [
    TranscriptionComponent
  ],
  imports: [
    CommonModule,
    TranscriptionRoutingModule
  ]
})
export class TranscriptionModule { }
