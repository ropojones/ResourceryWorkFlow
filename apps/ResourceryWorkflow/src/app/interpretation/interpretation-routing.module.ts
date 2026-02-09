import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InterpretationComponent } from './interpretation.component';
import { InterpretationLayoutComponent } from './interpretation-layout.component';

const routes: Routes = [
  {
    path: '',
    component: InterpretationLayoutComponent,
    children: [{ path: '', component: InterpretationComponent, data: { title: 'Interpretation' } }]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InterpretationRoutingModule { }
