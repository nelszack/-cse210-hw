using System;

public class Job{
   public string _companyzn;
   public string _jobTitlezn;
   public  int _startYearzn;
   public  int _endYearzn;

   public Job(){

   }
   public void Display(){
    Console.WriteLine($"{_jobTitlezn} ({_companyzn}) {_startYearzn}-{_endYearzn}");
   } 

   
}