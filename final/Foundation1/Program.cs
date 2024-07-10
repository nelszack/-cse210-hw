using System;

class Program
{
    static void Main(string[] args)
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
}