public class Post : UserHandler
{
// ---------------------------------------variables-------------------------------------------
public int _likes;
protected List<string> _commentList = new List<string>();
public string _comment;
public string _quote;
public DateTime currentDateTime = DateTime.Now;
protected int postNumber;
public FileHandler fileHandler = new FileHandler();
 protected List<string> postStringList = new List<string>();
protected string _stringPost;

public string postinputString;
public int postinputNumber;
 

// -------------------------------paths--------------------------------

 protected string _postPath = "post.txt";

// ----------------------------------------constructor-------------------------------------------
     public Post(string quote = "", int likes = 0)
{
    _quote = quote;
    _likes = likes;
}

    // -----------------------------------------methods----------------------------------------------



    public override string ToString()
    {
        return $"Quote: {_quote} || {_likes} Likes";
    }

    

public void AddComment()
{
    Console.WriteLine("Comment: ");
    _comment = Console.ReadLine();
    _commentList.Add(_comment);

}

  
     public void CreatePost()
{
    Console.WriteLine("Post: ");
    _quote = Console.ReadLine();
    Post post = new Post(_quote);
    // _postList.Add(post);
    // _stringPost = post.ToString();
    // postStringList.Add(_stringPost);
    // fileHandler.SaveFile(postStringList,_postPath);


        string csv = $"{post._quote},{post._likes}";

        string filePath = "post.txt";

        File.WriteAllText(filePath, csv);
      

   

   
    

}

public void DisplayPost(List<Post> _postList)
{
    postStringList = fileHandler.LoadFile(_postPath);

    foreach (string post in postStringList)
    {
        int postNumber = postStringList.IndexOf(post) + 1;
        Console.WriteLine($"{postNumber}. {post.ToString()} || {currentDateTime}");

    }
    // Console.WriteLine($"[L]ike");
    // postinputString = Console.ReadLine();
    // if (postinputString == "l" || postinputString == "L")
    // {
    //     Console.WriteLine("Which Post[#]: ");
    //     postinputString = Console.ReadLine();
    //     postinputNumber = int.Parse(postinputString);
    //     LikePost(_postList[postinputNumber]);
    // }
    // else
    // {
    // }

}


public void LikePost(Post post)
{
_likes = _likes + 1;
}




}