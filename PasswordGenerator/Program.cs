using FormationCS;
using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int AMOUNT_OF_PASSWORD = 10;

            int lengthPass = Outils.AskPositiveNumberNonZero("Longueur du mot de passe");

            int choice = Outils.AskNumberBetweenRange("Choose your specification: \n" +
                "\t1- Only uppercase characters\n" +
                "\t2- Only lowercase and uppercase characters\n" +
                "\t3- Only characters and numbers\n" +
                "\t4- Characters, numbers andd specials characters\n" +
                "Votre choix", 1, 4);

            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string upperCase = lowerCase.ToUpper();
            string digits = "0123456789";
            string specialCharacters = "@#$+-";
            string alphabet;
            string password = "";
            Random random = new Random();

            if (choice == 1)
                alphabet = upperCase;
            else if (choice == 2)
                alphabet = lowerCase + upperCase;
            else if (choice == 3)
                alphabet = lowerCase + lowerCase + digits;
            else
                alphabet = upperCase + lowerCase + digits + specialCharacters;

            int lengthAlphabet = alphabet.Length;

            for (int i = 0; i < AMOUNT_OF_PASSWORD; i++)
            {
                password = "";

                while (password.Length < lengthPass)
                {
                    int index = random.Next(0, lengthAlphabet);
                    password += alphabet[index];
                }

                Console.WriteLine($"Password generated: {password}");
            }
        }
    }
}
