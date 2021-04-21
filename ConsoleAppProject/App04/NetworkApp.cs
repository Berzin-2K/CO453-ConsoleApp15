using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        private int PostCount = 0;
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading(" Berzin's news Feed");
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToLongTimeString());

            string[] choices = new string[]
                {
                    "post Message", "Post image", "" +
                    "Display All Posts", "Delete Message", "Quit"
                };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: DeleteMessage(); break;
                    case 5: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            Console.WriteLine("Enter file name: ");
            string filename = Console.ReadLine();
            Console.WriteLine("Enter Caption: ");
            string caption = Console.ReadLine();
            PhotoPost post = new PhotoPost(news.getAuthor(), filename, caption, PostCount);
            news.AddPhotoPost(post);

        }

        private void PostMessage()
        {
            Console.WriteLine("Enter Your message");
            PostCount++;
            string message = Console.ReadLine();
            MessagePost post = new MessagePost(news.getAuthor(), message, PostCount);
            news.AddMessagePost(post);

        }

        private void DeleteMessage()
        {
            Console.WriteLine("Enter the ID of the post you want to delete ");
            int id = Convert.ToInt32(Console.ReadLine());
            news.RemovePost(id); 
        }
    }
}
