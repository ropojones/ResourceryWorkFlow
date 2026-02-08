import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConferenceComponent } from './conference.component';
import { ConferenceLayoutComponent } from './conference-layout.component';

const routes: Routes = [
  {
    path: '',
    component: ConferenceLayoutComponent,
    children: [{ path: '', component: ConferenceComponent }]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ConferenceRoutingModule { }
