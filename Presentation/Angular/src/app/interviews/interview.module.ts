import { NgModule }       from '@angular/core';
import { CommonModule }   from '@angular/common';
import { FormsModule }    from '@angular/forms';

import { InterviewComponent }    from './interview.component';

import { InterviewRoutingModule } from './interview-routing.module'
@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    InterviewRoutingModule
  ],
  declarations: [
    InterviewComponent
  ],
  providers: []
})
export class InterviewModule {}