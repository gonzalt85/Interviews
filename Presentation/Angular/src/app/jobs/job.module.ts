import { NgModule }       from '@angular/core';
import { CommonModule }   from '@angular/common';
import { FormsModule }    from '@angular/forms';

import { JobComponent } from "./job.component";
import { JobListComponent }    from './job-list.component';
import { JobDetailComponent }    from './job-detail.component';

import { JobService } from './job.service';

import { JobRoutingModule } from "./job-routing.module";
import { HttpModule } from '@angular/http';

@NgModule({
  imports: [    
    CommonModule,
    FormsModule,
    JobRoutingModule,  
    HttpModule
  ],
  declarations: [
    JobListComponent,
    JobDetailComponent,
    JobComponent
  ],
  providers: [ JobService ]
})
export class JobModule {}