import { Component, OnInit, Input } from '@angular/core';
import { Job } from './job';
import { Router, ActivatedRoute } from '@angular/router';
import { JobService } from './job.service';

@Component({
  selector: 'JobComponent',
  templateUrl: './job.component.html',
  styleUrls: ['../app.component.css']
})
export class JobComponent{
  job = new Job(0,'', '', '', '', 0, '', '', 0);
  constructor(    
    private jobService:JobService,
    private route:ActivatedRoute,
    private router:Router
  ){}

  add():void
  {         
    this.jobService.Create(new Job(this.job.Id, this.job.Name,this.job.Description, this.job.DateEntered, this.job.Duration, this.job.JobStatusId,this. job.Requirements,this. job.Notes, this.job.LocationId));
  }
}