using System;

public class Job{
   public string _companyzn;
   public string _jobTitlezn;
   public  int _startYearzn;
   public  int _endYearzn;

   public Job(){

   }
   public Job(string company, string jobtitle,int startyear,int endyear){
      _companyzn=company;
      _jobTitlezn=jobtitle;
      _startYearzn=startyear;
      _endYearzn=endyear;
   }
   public void Display(){
    Console.WriteLine($"{_jobTitlezn} ({_companyzn}) {_startYearzn}-{_endYearzn}");
   } 

   
}