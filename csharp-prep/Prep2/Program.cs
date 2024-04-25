using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage ");
        string percentagezn=Console.ReadLine();
        float gradezn=float.Parse(percentagezn);
        string letterzn= "";
        if (gradezn>=90){
            if (gradezn>90 && gradezn<94){
                letterzn="A-";
            }
            else{
                letterzn="A";
            }
        }
        else if (gradezn>=80){
            if (gradezn>80 && gradezn<84){
                letterzn="B-";
            }
            else if (gradezn>87 && gradezn<90){
                letterzn="B+";
            }
            else{
                letterzn="B";
            }
        }
        else if (gradezn>=70){
           if (gradezn>70 && gradezn<74){
                letterzn="C-";
            }
            else if (gradezn>77 && gradezn<80){
                letterzn="C+";
            }
            else{
                letterzn="C";
            }
        }
        else if (gradezn>=60){
            if (gradezn>60 && gradezn<64){
                letterzn="D-";
            }
            else if (gradezn>67 && gradezn<70){
                letterzn="D+";
            }
            else{
                letterzn="D";
            }
        }
        else if (gradezn<60){
            letterzn="F";
        }
        Console.Write($"Your grade is a {letterzn}");
        if (gradezn>=70){
            Console.Write($" you passed!");
        }
        else if (gradezn<70){
            Console.Write($" you did not pass try again");
        }
    }
}