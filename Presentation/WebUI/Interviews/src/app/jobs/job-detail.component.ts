import { Component, OnInit, Input } from '@angular/core';
import { Job } from './job';
import { Router } from '@angular/router';
import { JobService } from './job.service';

@Component({
  //selector: 'JobDetailComponent',
  templateUrl: './job-detail.component.html',
  styleUrls: ['../app.component.css']
})
export class JobDetailComponent {
  job = new Job(0,'', '', '', '', 0, '', '', 0);
  constructor(
    private router:Router,
    private jobService:JobService
  ){}

  Get(id:number):Job
  {         
     return this.jobService.Get(id);
  }
}