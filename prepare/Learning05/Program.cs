using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes= new List<Shape>();
        Circle c1=new Circle("red",3);
        shapes.Add(c1);
        Square s1=new Square("blue",6);
        shapes.Add(s1);
        Rectangle r1=new Rectangle("green",3,4);
        shapes.Add(r1);
        for(int i=0;i<3;i++){
            string color=shapes[i].getColor();
            double area=shapes[i].GetArea();
            Console.WriteLine($"color: {color} area: {area}");
            {
                
            }
        }
    }
}