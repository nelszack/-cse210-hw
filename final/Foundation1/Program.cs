using System;

class Program
{
    static void Main(string[] args)
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
        comment2.StoreComment("John", "this is a test");
        comment2.StoreComment("Steve", "this is a test2");
        comment2.StoreComment("Emma", "this is a test3");
        video2.SetComments(comment2);
        Comment comment3 = new();
        comment3.StoreComment("Joseph", "this is a test");
        comment3.StoreComment("Caleb", "this is a test2");
        comment3.StoreComment("Kyle", "this is a test3");
        video3.SetComments(comment3);
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach (var item in videos)
        {
            Console.WriteLine($"title: {item.GetTitle()} - chanal name: {item.GetAuthor()} time {item.GetTime()}");
            Dictionary<string, string> pairs = item.GetComments().GetDict();
            Console.WriteLine("Comments:");
            foreach (var item2 in pairs)
            {
                Console.WriteLine($"    {item2.Key} - {item2.Value}");
            }
        }
    }
}