using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment p1=new Assignment("bob smith", "math");
        MathAssignment p2 = new MathAssignment("Roberto Rodriguez","Fractions","Section 7.3","Problems 8-19");
        string sum=p2.GetSummery();
        string sum2=p2.GetHomworkList();
        Console.WriteLine(sum);
        Console.WriteLine(sum2);
        WritingAssignment p3= new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string sum3=p3.GetSummery();
        string sum4=p3.GetWritingInformation();
        Console.WriteLine(sum3);
        Console.WriteLine(sum4);

    }
}