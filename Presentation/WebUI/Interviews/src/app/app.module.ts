import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule }   from '@angular/forms';

import { Router } from '@angular/router';

import { AppComponent } from './app.component';
import { AppRoutingModule } from "app/app-routing.module";

import { PageNotFoundComponent } from "app/not-found.component";

import { JobModule } from "app/jobs/job.module";
import { InterviewModule } from "app/interviews/interview.module";

@NgModule({
   imports: [
    BrowserModule,
    FormsModule,    
    JobModule,
    InterviewModule,      
    AppRoutingModule
  ],
  declarations: [
    AppComponent,
    PageNotFoundComponent,
  ],
 
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
