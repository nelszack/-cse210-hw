using System;

class Program
{
    static string Menu()
    {
        Console.Write("1. Foundation1\n2. Foundation2\n3. Foundation3\n4. Foundation4\n5 Quit\nWhat do you choose: ");
        string choice = Console.ReadLine();
        return choice;
    }
    static void Foundation1()
    {
        List<Video> videos = new();
        Video video1 = new("Watch this", "The best", 100);
        Video video2 = new("Watch this2", "The worst", 200);
        Video video3 = new("Watch this3", "The average", 300);
        Comment comment1 = new();
        comment1.StoreComment("Bob", "The best");
        comment1.StoreComment("Joe", "This is not the best");
        comment1.StoreComment("Sue", "Don't watch this");
        video1.SetComments(comment1);
        Comment comment2 = new();
        comment2.StoreComment("John", "good video");
        comment2.StoreComment("Steve", "this video is ok");
        comment2.StoreComment("Emma", "cool");
        video2.SetComments(comment2);
        Comment comment3 = new();
        comment3.StoreComment("Joseph", "i didn't watch");
        comment3.StoreComment("Caleb", "cool");
        comment3.StoreComment("Kyle", "this is fun");
        video3.SetComments(comment3);
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach (var item in videos)
        {
            item.DisplayInfo();
        }
    }

    static void Foundation2()

    {
        Order order1 = new();
        Address address1 = new("525 templeveiw dr", "rexburg", "Idaho", "USA");
        Customer customer1 = new();
        Product product1 = new("Apple", "A101", 1.05, 5);
        Product product2 = new("Couch", "C101", 99.99, 2);
        Product product3 = new("Bed", "B101", 70.86, 2);
        customer1.SetName("Bob Smith");
        customer1.SetAddress(address1);
        order1.AddList(product1);
        order1.AddList(product2);
        order1.AddList(product3);
        order1.SetCostomer(customer1);

        Order order2 = new();
        Address address2 = new("100 street dr", "city city", "state2", "country50", false);
        Customer customer2 = new();
        Product product4 = new("fruit boundle", "F101", 5.05, 5);
        Product product5 = new("Couch", "C101", 199.99, 2);
        customer2.SetName("John Smith");
        customer2.SetAddress(address2);
        order2.AddList(product4);
        order2.AddList(product5);
        order2.SetCostomer(customer2);

        order1.CreateLable();
        Console.WriteLine();
        order2.CreateLable();
    }
    static void Foundation3()
    {
        Lectures lecture = new("Become better", "learn how to become better", "sept 30 2030", "12:30 pm", "teton event center", "john smith", 200);
        lecture.DisplayShort();
        Console.WriteLine();
        lecture.DisplayStandard();
        Console.WriteLine();
        lecture.DisplayFull();
        Console.WriteLine();
        Receptions reception = new("Become better2", "learn how to become better", "sept 30 2030", "12:30 pm", "teton event center", "rsvp@event.com");
        reception.DisplayShort();
        Console.WriteLine();
        reception.DisplayStandard();
        Console.WriteLine();
        reception.DisplayFull();
        Console.WriteLine();
        Outdoor outdoor = new("Become better3", "learn how to become better", "sept 30 2030", "12:30 pm", "teton event center", "cloudy with a chance of meatballs");
        outdoor.DisplayShort();
        Console.WriteLine();
        outdoor.DisplayStandard();
        Console.WriteLine();
        outdoor.DisplayFull();
        Console.WriteLine();
    }

    static void Foundation4()
    {
        Activity activity = new();
        Running running1 = new(DateTime.Now.ToString("dd MMM yyyy"), 30, 3.0);
        Biking biking1 = new(DateTime.Now.ToString("dd MMM yyyy"), 30, 6.0);
        Swimming swimming1 = new(DateTime.Now.ToString("dd MMM yyyy"), 30, 3000.0 / 31);
        activity.AddList(running1);
        activity.AddList(biking1);
        activity.AddList(swimming1);
        activity.GetSummary();
    }
    static void Main(string[] args)
    {
        string Choise;
        do
        {
            Choise = Menu();

            switch (Choise)
            {
                case "1":
                    Foundation1();
                    break;
                case "2":
                    Foundation2();
                    break;
                case "3":
                    Foundation3();
                    break;
                case "4":
                    Foundation4();
                    break;

                case "5":
                    break;

                default:
                    Console.WriteLine("not an option ");
                    break;
            }
        } while (Choise != "5");

    }
}