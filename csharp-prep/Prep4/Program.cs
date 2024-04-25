using System;
// Zack Nelson 4/25/24 ,
class Program
{
    static void Main(string[] args)
    {   int numbzn;
        List<int> numbListzn= new List<int>();
        do
        {
            Console.Write("enter a numeber");
            string numbstrzn=Console.ReadLine();
            numbzn=int.Parse(numbstrzn);
            if (numbzn!=0){
                numbListzn.Add(numbzn);
            }
        } while (numbzn!=0);
        int lennumblistzn=numbListzn.Count();
        Console.WriteLine(lennumblistzn);
        for (int i=0;i<lennumblistzn;i++){
            Console.Write(i);
            
        }

        }
        
    }
}