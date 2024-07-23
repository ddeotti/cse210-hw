/*
    In order to exceed the requirements, I did
    a function to convert seconds input to 
    an output as XX hours XX minutes XX seconds

*/

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public string DisplayVideoDetails()
    {
        TimeConversion video1Hours = new TimeConversion(_length);

        string details = $"Title: {_title}\nAuthor: {_author}\nLength: {video1Hours.Hours()} hours {video1Hours.Minutes()} minutes {video1Hours.Seconds()} seconds \nComments ({GetCommentCount()}):";

        foreach (var comment in _comments)
        {
            details += $"\n- {comment.DisplayCommentDetails()}";
        }
        return details + "\n";
    }
}
