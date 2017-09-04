import {Injectable} from '@angular/core';
import {Job} from './job';
import {Headers, Http} from '@angular/http';
import 'rxjs/add/operator/toPromise';

@Injectable()
export class JobService{
    jobList:Job[] = [              
                 { Id: 1,  Name: '.NET Developer' , Description:'.NET Developer in Manhattan', DateEntered:'07/25/2017', Duration:'', JobStatusId:0, LocationId:0,Notes:'',Requirements:'' },
                 { Id: 2, Name: '.NET Developer', Description:'Senior .NET Developer in Columbus', DateEntered:'07/25/2017', Duration:'', JobStatusId:0, LocationId:0,Notes:'',Requirements:'' }
                ];
    
    private jobsUrl = 'api/jobs';
    private headers = new Headers({'Content-Type': 'application/json'});
    constructor(private http: Http){}
    Create(job:Job):void
    {
        this.jobList.push(job);
    }

    ListAll():Job[]
    {
       return this.jobList;
    }

    Get(id:number):Job
    {
        return this.jobList[id];
    }
}