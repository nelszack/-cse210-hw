using System;
// Zack Nelson 4/25/24 ,
class Program
{
    static void Main(string[] args)
    {   int numbzn;
        List<int> numbListzn= new List<int>();
        do
        {
            Console.Write("enter a numeber ");
            string numbstrzn=Console.ReadLine();
            numbzn=int.Parse(numbstrzn);
            if (numbzn!=0){
                numbListzn.Add(numbzn);
            }
        } while (numbzn!=0);
        int lennumblistzn=numbListzn.Count();
        Console.WriteLine(lennumblistzn);
        float totalzn=0;
        int highestzn=0;
        int smallPositivezn=100000000;
        numbListzn.Sort();
        foreach (int i in numbListzn){
            totalzn+=i;
            if (i>highestzn){
                highestzn=i;
            }
            if (i<smallPositivezn&&i>0)
            {
                smallPositivezn=i;
            }
        }
        Console.WriteLine($"the sum of the list is {totalzn}");
        Console.WriteLine($"the avg of the list is {totalzn/(lennumblistzn)}");
        Console.WriteLine($"the largest number in the list is {highestzn}");
        Console.WriteLine($"the smallest positive number in the list is {smallPositivezn}");
        Console.WriteLine("Sorted list");
        foreach (int numb in numbListzn){
            Console.WriteLine(numb);
        }

        }
        
    }