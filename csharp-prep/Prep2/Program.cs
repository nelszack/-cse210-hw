using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage ");
        string percentage=Console.ReadLine();
        float grade=float.Parse(percentage);
        string letter= "";
        if (grade>=90){
            if (grade>90 && grade<94){
                letter="A-";
            }
            else{
                letter="A";
            }
        }
        else if (grade>=80){
            if (grade>80 && grade<84){
                letter="B-";
            }
            else if (grade>87 && grade<90){
                letter="B+";
            }
            else{
                letter="B";
            }
        }
        else if (grade>=70){
           if (grade>70 && grade<74){
                letter="C-";
            }
            else if (grade>77 && grade<80){
                letter="C+";
            }
            else{
                letter="C";
            }
        }
        else if (grade>=60){
            if (grade>60 && grade<64){
                letter="D-";
            }
            else if (grade>67 && grade<70){
                letter="D+";
            }
            else{
                letter="D";
            }
        }
        else if (grade<60){
            letter="F";
        }
        if (grade>=70){
            Console.Write($"your grade is a {letter} you passed!");
        }
        else if (grade<70){
            Console.Write($"your grade is a {letter} you did not pass try again");
        }
    }
}