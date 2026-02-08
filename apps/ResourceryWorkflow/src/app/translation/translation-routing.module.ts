import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TranslationComponent } from './translation.component';
import { TranslationLayoutComponent } from './translation-layout.component';

const routes: Routes = [
  {
    path: '',
    component: TranslationLayoutComponent,
    children: [{ path: '', component: TranslationComponent }]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TranslationRoutingModule { }
