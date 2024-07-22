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
        Video video1 = new("Exploring the Cosmos: A Journey Through Space and Time", "CosmicExplorer", 100);
        Video video2 = new("Culinary Delights: Discovering World Cuisines", "CulinaryVoyager", 200);
        Video video3 = new("The Art of Mindfulness: A Guide to Inner Peace", "MindfulMeditator", 300);
        Comment comment1 = new();
        comment1.StoreComment("Bob", "This video is out of this world! Really enjoyed the journey through the cosmos.");
        comment1.StoreComment("Joe", "The graphics and explanations are stellar! I’ve learned so much about our universe.");
        comment1.StoreComment("Sue", "Amazing content! It’s like a mini-course in astronomy. Can’t wait for more videos like this.");
        video1.SetComments(comment1);
        Comment comment2 = new();
        comment2.StoreComment("John", "Your video made me hungry! The dishes look so delicious and the recipes seem easy to follow. ");
        comment2.StoreComment("Steve", "I love how you’ve brought the flavors of the world to our kitchens. Can’t wait to try these recipes!");
        comment2.StoreComment("Emma", "Great video! The cooking tips are really helpful. Looking forward to more culinary adventures.");
        video2.SetComments(comment2);
        Comment comment3 = new();
        comment3.StoreComment("Joseph", "This video is a breath of fresh air! The mindfulness techniques are really helpful.");
        comment3.StoreComment("Caleb", "I feel more peaceful just by watching this. The guide to inner peace is truly enlightening.");
        comment3.StoreComment("Kyle", "Thank you for sharing this. It’s a great reminder to slow down and be present in the moment.");
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
        Address address1 = new("525 Templeveiw Dr.", "Rexburg", "Idaho", "USA");
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
        Address address2 = new("100 Street Dr.", "Paris", "France", "France", false);
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
        Lectures lecture = new("Demystifying Machine Learning", "Dive into the world of Machine Learning with this interactive workshop", "sept 30 2030", "12:30 pm", "teton event center", "john smith", 200);
        lecture.DisplayShort();
        Console.WriteLine();
        lecture.DisplayStandard();
        Console.WriteLine();
        lecture.DisplayFull();
        Console.WriteLine();
        Receptions reception = new("Demystifying Machine Learning", "Dive into the world of Machine Learning with this interactive workshop", "sept 30 2030", "12:30 pm", "teton event center", "rsvp@event.com");
        reception.DisplayShort();
        Console.WriteLine();
        reception.DisplayStandard();
        Console.WriteLine();
        reception.DisplayFull();
        Console.WriteLine();
        Outdoor outdoor = new("Demystifying Machine Learning", "Dive into the world of Machine Learning with this interactive workshop", "sept 30 2030", "12:30 pm", "teton event center", "cloudy with a chance of meatballs");
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
                    Console.Clear();
                    Foundation1();
                    break;
                case "2":
                    Console.Clear();
                    Foundation2();
                    break;
                case "3":
                    Console.Clear();
                    Foundation3();
                    break;
                case "4":
                    Console.Clear();
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