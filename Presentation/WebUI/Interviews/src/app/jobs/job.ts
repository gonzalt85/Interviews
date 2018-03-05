export class Job {
  constructor(
   public Id: number,
   public Name: string,
   public Description:string,
   public DateEntered:any,
   public Duration:string,
   public JobStatusId:number,
   public Requirements:string,
   public Notes:string,
   public LocationId:number,
  ){}
}