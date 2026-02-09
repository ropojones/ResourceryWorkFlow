import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DirectorateComponent } from './directorate.component';
import { DirectorateLayoutComponent } from './directorate-layout.component';
import { InternalMemorandaComponent } from './internal-memoranda/internal-memoranda.component';

const routes: Routes = [
  {
    path: '',
    component: DirectorateLayoutComponent,
    children: [
      { path: '', component: DirectorateComponent },
      { path: 'internal-memoranda', component: InternalMemorandaComponent, data: { title: 'Internal Memoranda' } }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DirectorateRoutingModule { }
