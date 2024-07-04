using RandomGenerator.Service;

namespace RandomGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateRandom random = new GenerateRandom();

            string isContinue;
            do
            {
                Console.WriteLine("Which service do you want?");
                Console.WriteLine("1 Random full name");
                Console.WriteLine("2 Random Email Adress");
                Console.WriteLine("3 Random Numbers");
                Console.WriteLine("4 Random text");
                Console.Write("Choose");

                string userChoise = Console.ReadLine();
                int ConvertUserChoise = Convert.ToInt32(userChoise);

                Console.WriteLine("How many do you want randoms?");
                Console.Write("Enter the number");

                string userInput = Console.ReadLine();
                int userInputValue = Convert.ToInt32(userInput);

                switch (ConvertUserChoise)
                {
                    case 1:

                        random.GenerateFullNames(userInputValue);
                        break;

                    case 2:

                        random.GenerateEmailAdress(userInputValue);
                        break;

                    case 3:

                        random.GenerateIntRange(userInputValue);
                        break;

                    case 4:
                        Console.Write("Enter the number of words: ");
                        Console.WriteLine("How many words do you want? ");
                        string userInputText = Console.ReadLine();
                        int userTextValue = Convert.ToInt32(userInputText);
                        random.GenerateLoremIpsum(caunt: userInputValue, numberofWords: userTextValue);
                        break;
                }

                Console.WriteLine("Do you want to continue? (+)");
                isContinue = Console.ReadLine();

            } while (isContinue == "+");
            
        }
    }
}
