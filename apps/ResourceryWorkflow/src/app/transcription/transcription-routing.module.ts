import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TranscriptionComponent } from './transcription.component';

const routes: Routes = [{ path: '', component: TranscriptionComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TranscriptionRoutingModule { }
