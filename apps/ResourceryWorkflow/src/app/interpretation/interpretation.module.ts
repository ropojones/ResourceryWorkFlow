import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { InterpretationRoutingModule } from './interpretation-routing.module';
import { InterpretationComponent } from './interpretation.component';


@NgModule({
  declarations: [
    InterpretationComponent
  ],
  imports: [
    CommonModule,
    InterpretationRoutingModule
  ]
})
export class InterpretationModule { }
