using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;

namespace game {
    class Program {
        static void Main (string[] args) {
            Random random = new Random ();
            int countPlay = 1;
            bool theGuesses = false;
            // result and reentry message

            Console.WriteLine ("This is the Ultimate Guessing Game");
            Console.WriteLine ("Enter a username");
            string username = Console.ReadLine ();
            Console.WriteLine ("Welcome @" + username);

            // Allow User to pick a level
            Console.WriteLine ("Pick a level to begin");
            Console.WriteLine ("For Easy Press 1");
            Console.WriteLine ("For Medium Press 2");
            Console.WriteLine ("For Hard Press 3");
            Console.Write ("1, 2 or 3? ");
            int level = Convert.ToInt16 (Console.ReadLine ());

            // Dispay Level to User
            while (level < 1 || level > 3) {
                Console.WriteLine ("Please enter a valid level");
                level = Convert.ToInt16 (Console.ReadLine ());
            }
            Console.WriteLine ("Wonderful!!! You're in Level " + level);

            // Create 3 levels with it properties
            //LEVEL 1 -------------------------------------------------------------------------

            while (level == 1) {
                // Locally known variables for Level 1
                int guessLimit = 6;
                int mynumber = random.Next(1,11);

                // Introduce user to level 1
                Console.WriteLine ("Welcome to level 1 @" + username);
                Console.WriteLine ("Please guess a Number from 1 - 10");
                Console.WriteLine ("...and if it is the number my program choose then you've Won");
                Console.WriteLine ("Good Luck ! ! !");
                Console.WriteLine ("You have 6 guesses");
                // Accept user guesses
                int guessed = Convert.ToInt16 (Console.ReadLine ());

                //alert the user if they enter a number with 1 - 10 range if they did't initially
                while (guessed < 1 || guessed > 10) {
                    Console.WriteLine ("Invalid number. Please enter a number between 1 - 10");
                    guessed = Convert.ToInt16 (Console.ReadLine ());
                }
                // if user is wrong run this loop 6 times for level 1
                while (guessed != mynumber && !theGuesses) { // afer each loop inform user numbers of guesses left
                    if (countPlay < guessLimit) {
                        Console.WriteLine ("You have " + (guessLimit - countPlay) + " left");
                        Console.WriteLine ("Wrong guess. Try again");
                        guessed = Convert.ToInt16 (Console.ReadLine ());
                        countPlay++;
                    }
                    // if user guesses right got to exit the loop and check the below if and else to confirm
                    else {
                        theGuesses = true;
                    }
                }
                // If after 6 loops user is wrong display lost message
                if (theGuesses) {
                    Console.WriteLine ("You have used up all your guesses");
                    Console.WriteLine ("You Lose!");
                    break;
                }
                // display win message if user guess correct
                else {
                    Console.WriteLine ("Yes! You guessed right");
                    break;
                }

            }
            
            //LEVEL 2 ------------------------------------------------------------------------------------

            while (level == 2) {
                // Locally known variables for Level 1
                int guessLimit = 4;
                int mynumber = random.Next(1,21);

                // Introduce user to level 1
                Console.WriteLine ("Welcome to level 2 @" + username);
                Console.WriteLine ("Please guess a Number from 1 - 20");
                Console.WriteLine ("...and if it is the number my program choose then you've Won");
                Console.WriteLine ("Good Luck ! ! !");
                Console.WriteLine ("You have 4 guesses");
                // Accept user guesses
                int guessed = Convert.ToInt16 (Console.ReadLine ());

                //alert the user if they enter a number with 1 - 10 range if they did't initially
                while (guessed < 1 || guessed > 20) {
                    Console.WriteLine ("Invalid number. Please enter a number between 1 - 10");
                    guessed = Convert.ToInt16 (Console.ReadLine ());
                }
                // if user is wrong run this loop 6 times for level 1
                while (guessed != mynumber && !theGuesses) { // afer each loop inform user numbers of guesses left
                    if (countPlay < guessLimit) {
                        Console.WriteLine ("You have " + (guessLimit - countPlay) + " left");
                        Console.WriteLine ("Wrong guess. Try again");
                        guessed = Convert.ToInt16 (Console.ReadLine ());
                        countPlay++;
                    }
                    // if user guesses right got to exit the loop and check the below if and else to confirm
                    else {
                        theGuesses = true;
                    }
                }

                // If after 6 loops user is wrong display lost message
                if (theGuesses) {
                    Console.WriteLine ("You have used up all 4 guesses");
                    Console.WriteLine ("You Lose!");
                    break;
                }
                // display win message if user guess correct
                else {
                    Console.WriteLine ("Yes! You guessed right");
                    break;
                }

            }
            //LEVEL 3

            while (level == 3) {
                // Locally known variables for Level 1
                int guessLimit = 6;
                int mynumber = random.Next(1,51);

                // Introduce user to level 1
                Console.WriteLine ("Welcome to level 3 @" + username);
                Console.WriteLine ("Please guess a Number from 1 - 50");
                Console.WriteLine ("...and if it is the number my program choose then you've Won");
                Console.WriteLine ("Good Luck ! ! !");
                Console.WriteLine ("You have 3 guesses");
                // Accept user guesses
                int guessed = Convert.ToInt16 (Console.ReadLine ());

                //alert the user if they enter a number with 1 - 10 range if they did't initially
                while (guessed < 1 || guessed > 50) {
                    Console.WriteLine ("Invalid number. Please enter a number between 1 - 50");
                    guessed = Convert.ToInt16 (Console.ReadLine ());
                }
                // if user is wrong run this loop 6 times for level 1
                while (guessed != mynumber && !theGuesses) { // afer each loop inform user numbers of guesses left
                    if (countPlay < guessLimit) {
                        Console.WriteLine ("You have " + (guessLimit - countPlay) + " left");
                        Console.WriteLine ("Wrong guess. Try again");
                        guessed = Convert.ToInt16 (Console.ReadLine ());
                        countPlay++;
                    }
                    // if user guesses right got to exit the loop and check the below if and else to confirm
                    else {
                        theGuesses = true;
                    }
                }

                // If after 6 loops user is wrong display lost message
                if (theGuesses) {
                    Console.WriteLine ("You have used up all your guesses");
                    Console.WriteLine ("You Lose!");
                    break;
                }
                // display win message if user guess correct
                else {
                    Console.WriteLine ("Yes! You guessed right");
                    break;
                }
            }
        }
    }
}