using System;

public class Program
{
    /*
        You are making a social network application and want to add post creation functionality.
        As a user creates a post, the text "New post" should be automatically outputted so that then the user can add the text he/she wants to share.
        The program you are given declares a Post class with a text private field, and the ShowPost() method which outputs the content.
        
        Sample Input - Hello!

        Sample Output - New post
                        Hello!
    */
    class Post
    {
        private string text;
        
        //write a constructor here
        public Post()
        {
            Console.WriteLine("New post");
        }
        

        public void ShowPost()
        {
            Console.WriteLine(text);
        }
        
        //write a property for member text
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        
    }

    static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }
}

