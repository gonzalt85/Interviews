import { Component, OnInit } from '@angular/core';
import { Job } from './job';
import { Router } from '@angular/router';
import { JobService } from './job.service';

@Component({
  selector: 'JobListComponent',
  templateUrl: './job-list.component.html',
  styleUrls: ['../app.component.css']
})
export class JobListComponent {
  constructor(
    private router:Router,
    private jobService:JobService
  ){}

  ListAll():Job[]
  {
    return this.jobService.ListAll();
  }

  OnSelect(job:Job)
  {
    this.router.navigate(['job', job.Id]);
  }
}