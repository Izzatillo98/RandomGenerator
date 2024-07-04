
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tynamix.ObjectFiller;

namespace RandomGenerator.Service
{
    internal class GenerateRandom

    {
        public void GenerateFullNames(int count)
        {
            RealNames realNameGenerator = new RealNames();
            Console.WriteLine("There are some full names: ");

            for (int i = 0; i < count; i++)
            {
                string fullNameRandom = realNameGenerator.GetValue();
                Console.WriteLine(fullNameRandom);
            }
        }
        public void GenerateEmailAdress(int caunt)
        {
            EmailAddresses emailAddresses = new EmailAddresses();
            Console.WriteLine("There are some Emails: ");
            for (int i = 0; i < caunt; i++)
            {
                string randomEmail = emailAddresses.GetValue();
                Console.WriteLine(randomEmail);
            }

        }
        public void GenerateIntRange(int caunt)
        {
            IntRange intRange = new IntRange();
            Console.WriteLine("There are some random numbers: ");
            for (int i = 0; i < caunt; i++)
            {
                int randomNumber = intRange.GetValue();
                Console.WriteLine(randomNumber);
            }
        }
        public void GenerateLoremIpsum(int caunt, int numberofWords)
        {
            Lipsum loremIpsum = new Lipsum();
            Console.WriteLine("There are some random texts:");
            for (int i = 0; i < caunt; i++)
            {
                string randomText = loremIpsum.GetValue();
                Console.WriteLine(randomText);
            }
        }

    }
}

