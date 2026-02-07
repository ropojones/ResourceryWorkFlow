import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ResourceryComponent } from './resourcery.component';
import { ResourceryDashboardComponent } from './dashboard/dashboard.component';
import { ResourceryTranscriptionComponent } from './transcription/transcription.component';

const routes: Routes = [
  {
    path: '',
    component: ResourceryComponent,
    children: [
      { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
      { path: 'dashboard', component: ResourceryDashboardComponent, data: { title: 'Dashboard' } },
      { path: 'transcription', component: ResourceryTranscriptionComponent, data: { title: 'Transcription' } }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ResourceryRoutingModule { }
