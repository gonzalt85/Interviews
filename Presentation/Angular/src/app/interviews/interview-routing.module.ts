import { NgModule }             from '@angular/core';
import { RouterModule, Routes, Router, ActivatedRoute } from '@angular/router';
import {InterviewComponent} from './interview.component'
const interviewRoutes: Routes = [
  { path: 'interviews/:id', component: InterviewComponent }
];

@NgModule({
  imports: [
    RouterModule.forChild(interviewRoutes)
  ],
  exports:[RouterModule]
})
export class InterviewRoutingModule{}