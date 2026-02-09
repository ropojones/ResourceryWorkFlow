import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProtocolComponent } from './protocol.component';
import { ProtocolLayoutComponent } from './protocol-layout.component';

const routes: Routes = [
  {
    path: '',
    component: ProtocolLayoutComponent,
    children: [{ path: '', component: ProtocolComponent, data: { title: 'Protocol' } }]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProtocolRoutingModule { }
