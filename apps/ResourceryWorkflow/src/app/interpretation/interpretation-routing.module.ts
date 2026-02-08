import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InterpretationComponent } from './interpretation.component';

const routes: Routes = [{ path: '', component: InterpretationComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InterpretationRoutingModule { }
