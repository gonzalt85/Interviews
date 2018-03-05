import { NgModule }             from '@angular/core';
import { RouterModule, Routes, Router, ActivatedRoute } from '@angular/router';

import { JobListComponent }    from './job-list.component';
import { JobDetailComponent }  from './job-detail.component';
import { JobService } from "app/jobs/job.service";

const jobRoutes: Routes = [
  { path: 'job/:id', component: JobDetailComponent },
  { path: 'jobs', component:JobListComponent }
];

@NgModule({
  imports: [
    RouterModule.forChild(jobRoutes)
  ],
  exports: [RouterModule]
})
export class JobRoutingModule{}