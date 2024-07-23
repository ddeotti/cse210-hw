public class SampleComments
{
    private List<Video> videos;

    public SampleComments()
    {
        List<Comment> comments1 = new List<Comment>
        {
            new Comment("Maria", "Great video!"),
            new Comment("Paula", "Very informative."),
            new Comment("Fernanda", "Loved the content!")
        };

        List<Comment> comments2 = new List<Comment>
        {
            new Comment("Marcos", "Nice tutorial."),
            new Comment("Pedro", "Helped me a lot, thanks!"),
            new Comment("Francisco", "Well explained.")
        };

        List<Comment> comments3 = new List<Comment>
        {
            new Comment("Maria", "Awesome video."),
            new Comment("Joao", "Good job!"),
            new Comment("Ivan", "This is amazing.")
        };


        Video video1 = new Video("Strogonoff Recipe", "Easy cooking videos", 7202, comments1);
        Video video2 = new Video("DIY Wood Chair", "Woodworking king", 1200, comments2);
        Video video3 = new Video("C# Tips and Tricks", "C# channel", 600, comments3);

        videos = new List<Video> { video1, video2, video3 };
    }

    public void DisplayComments()
    {
        foreach (var video in videos)
        {
            Console.WriteLine(video.DisplayVideoDetails());
        }
    }
}
