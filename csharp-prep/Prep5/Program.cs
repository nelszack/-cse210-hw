using System;
// Zack Nelson 4/25/24 ,get name and umber from user then print out their name and number^2
class Program
{
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName(){
            Console.Write("What is your name? ");
            string UserNamezn=Console.ReadLine();
            return UserNamezn;
        }

        static int PromptUserNumber(){
            Console.Write("what is your fav numb? ");
            string favNumbznstr=Console.ReadLine();
            int favNumbzn=int.Parse(favNumbznstr);
            return favNumbzn;
        }

        static int SquareNumber(int numbzn){
            return numbzn*numbzn;
        }

        static void DisplayResult(string namezn, int numbzn){
            Console.WriteLine($"{namezn}, your fav numb squared is {numbzn}");
        }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string namezn=PromptUserName();
        int favNumbzn=PromptUserNumber();
        int numbSqaredzn=SquareNumber(favnumbzn);
        DisplayResult(namezn,numbsqaredzn);
        


    }
}