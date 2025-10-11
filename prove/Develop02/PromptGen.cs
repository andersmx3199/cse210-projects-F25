using System.Security.Cryptography.X509Certificates;

class PromptGen
{
    public string _promptOne = "Who was the most interesting person I interacted with today?";
    public string _promptTwo = "What was the best part of my day?";
    public string _promptThree = "How did I see the hand of the Lord in my life today?";
    public string _promptFour = "What was the strongest emotion I felt today?";
    public string _promptFive = "If I had one thing I could do over today, what would it be?";

    public Entry PickandDisplayPrompt()
    {
        Random rand = new Random();
        int number = rand.Next(1, 6); // 1 is inclusive, 6 is exclusive
        
        if (number == 1){
            Console.WriteLine(_promptOne);
            string response = Console.ReadLine();
            return new Entry(_promptOne, response);
        }
        else if (number == 2){
            Console.WriteLine(_promptTwo);
            string response = Console.ReadLine();
            return new Entry(_promptTwo, response);
        }
        else if (number == 3){
            Console.WriteLine(_promptThree);
            string response = Console.ReadLine();
            return new Entry(_promptThree, response);
        }
        else if (number == 4){
            Console.WriteLine(_promptFour);
            string response = Console.ReadLine();
            return new Entry(_promptFour, response);
        }
        else{
            Console.WriteLine(_promptFive);
            string response = Console.ReadLine();
            return new Entry(_promptFive, response);
            
        }
    }

}