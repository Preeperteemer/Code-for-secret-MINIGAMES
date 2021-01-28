using System;

namespace Secret_minigames
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string startall;
            
            
            Console.WriteLine("Write (Start jeoperdy, topic coding) for a jeoperdy game with the topic about code");
            Console.WriteLine("Write (Start jeoperdy, topic food) for a jeoperdy game with the topic about food");
            Console.WriteLine("Write (Start jeoperdy, topic automobiles) for a jeoperdy game with the topic about cars and other auto mobiles");
            Console.WriteLine("Write (Start jeoperdy, topic furniture) for a jeoperdy game with the topic about furniture");
            Console.WriteLine("Write (Start kahoot, topic = Random) for a kahoot quiz with the topic about Random stuff");
            Console.WriteLine("Write (Start kahoot, topic = Sports) for a kahoot quiz with the topic about Bizzare Sports");
            Console.WriteLine("Write (Start kahoot, topic = WeirdStuff) for a kahoot quiz with the topic about WeirdStuff");
            Console.WriteLine("Write (FeedBack_Submit) in order to submit feedback about this program to the Owner");
            startall = Console.ReadLine();
            if (startall == "Start jeoperdy, topic coding")
            {
                Console.WriteLine("Starting Minigame...");
                Console.WriteLine("Here's the Link: https://jeopardylabs.com/play/codeing-2");
                Console.WriteLine("Restart for more");
            }
            else if (startall == "Start jeoperdy, topic food")
            {
                Console.WriteLine("Starting Minigame...");
                Console.WriteLine("Here's the Link: https://jeopardylabs.com/play/food-food-food-181 ");
                Console.WriteLine("Restart for more");

            }
            else if (startall == "Start jeoperdy, topic automobiles")
            {
                Console.WriteLine("Starting Minigame...");
                Console.WriteLine("Here's the Link: https://jeopardylabs.com/play/automobiles22");
                Console.WriteLine("Restart for more");
            }


            else if (startall == "Start jeoperdy, topic furniture")
            {
                Console.WriteLine("Starting Minigame...");
                Console.WriteLine("Here's the Link: https://jeopardylabs.com/play/furniture-21");
                Console.WriteLine("Restart for more");
            }
            else if (startall == "Start kahoot, topic = Random")
            {
                Console.WriteLine("Starting Minigame...");
                Console.WriteLine("Here's the Link: https://play.kahoot.it/v2/?quizId=2e96f392-9d13-4a79-8eaa-3be1831ab1b8");
                Console.WriteLine("Restart for more");
            }
            else if (startall == "Start kahoot, topic = Sports")
            {
                Console.WriteLine("Starting Minigame...");
                Console.WriteLine("Here's the Link: https://play.kahoot.it/v2/?quizId=58272415-cc50-40f1-8483-25f89ea1d832");
                Console.WriteLine("Restart for more");
            }
            else if (startall == "Start kahoot, topic = WeirdStuff")
            {
                Console.WriteLine("Starting Minigame...");
                Console.WriteLine("Here's the Link: https://play.kahoot.it/v2/?quizId=8cc2e7f5-462f-4361-aaa3-6d0a0c119010");
                Console.WriteLine("Restart for more");
            }
            else if (startall == "Dev_Only")
            {
                Console.WriteLine("Wellcome Back Timur");
                Console.WriteLine("Here's the Link to access code FILE: https://www.dropbox.com/t/jlsC6f3SHODYMzXr");
                Console.WriteLine("Attention if u r not timur then pls do not touch the file as u can break it and the code will be not working anymore");
                Console.WriteLine("If u want to view the file then pls contact the owner at https://mail.google.com/mail/u/0/?view=cm&fs=1&tf=1&source=mailto&to=16timurradjabov@gmail.com");
            }
            else if (startall == "FeedBack_Submit")
            {
                Console.WriteLine("In order to submit feedback");
                Console.WriteLine("send it to the email below");
                Console.WriteLine("https://mail.google.com/mail/u/0/?view=cm&fs=1&tf=1&source=mailto&to=feedbackforcode@gmail.com");
            }
            else if (startall == "")
            {
                Console.WriteLine("Pls enter a command to start a minigame");
                Console.WriteLine("But now u have to restart the program to continue though");
            }
            else if (startall == " ")
            {
                Console.WriteLine("Pls enter a command to start a minigame");
                Console.WriteLine("But now u have to restart the program to continue though");
            }
            else if (startall == "  ")
            {
                Console.WriteLine("Pls enter a command to start a minigame");
                Console.WriteLine("But now u have to restart the program to continue though");
            }
            else if (startall == "   ")
            {
                Console.WriteLine("Pls enter a command to start a minigame");
                Console.WriteLine("But now u have to restart the program to continue though");
            } 
            else if (startall == "SourceCode")
            {
                Console.WriteLine("Click the link bellow to go to the github repositry");
                Console.WriteLine("Pls enter a command to start a minigame");
            }




        }
    }
}