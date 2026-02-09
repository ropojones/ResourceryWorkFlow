import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TranscriptionComponent } from './transcription.component';
import { TranscriptionLayoutComponent } from './transcription-layout.component';

const routes: Routes = [
  {
    path: '',
    component: TranscriptionLayoutComponent,
    children: [{ path: '', component: TranscriptionComponent, data: { title: 'Transcription' } }]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TranscriptionRoutingModule { }
