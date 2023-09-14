using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList
{
    public static class AskUser
    {
        public static string GetInfoFromConsole(string message)
        {
            string? userAnswer = "";

            do
            {
                Console.WriteLine(message);
                userAnswer = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userAnswer))
                {
                    if (userAnswer == null)
                    {
                        throw new ArgumentNullException(userAnswer, "Answer is null.");
                    }
                    else
                    {
                        Console.WriteLine("You didn't write an answer.");
                        userAnswer = "";
                    }
                }
            } while (userAnswer == "");

            return userAnswer;
        }

        public static bool AreThereMoreBooks(bool areMoreBooks)

        {
            areMoreBooks = true;
            bool validAnswer = false;
            do
            {
                string areMoreBooksText = AskUser.GetInfoFromConsole("Are there any more books you want to add? (yes/no):");
                if (areMoreBooksText.ToLower().Trim() == "yes")
                {
                    areMoreBooks = true;
                    validAnswer = true;
                }
                else if (areMoreBooksText.ToLower().Trim() == "no")
                {
                    areMoreBooks = false;
                    validAnswer = true;
                }
                else
                {
                    Console.WriteLine("Write yes or no to continue.");
                }
            } while (validAnswer == false);

            return areMoreBooks;
        }
    }
}
