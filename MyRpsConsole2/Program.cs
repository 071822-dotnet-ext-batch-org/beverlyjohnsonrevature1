using System;
using System.Collections.Generic;
using System.Linq;

namespace MyRpsConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
         //create an instance of a Player 
         /*
                    Player p1 = new Player();
                    p1.fName = "Mark";
                    p1.lName = "Moore;
                    p1.DoB = new DateTime(1989, 5, 2);

                    Console.WriteLine($"The players name is {p1.fName} {p1.lName} and his age is {p1.DoB.ToShortDateString()}.");
                    p1.SetAge(109);
                    Console.WriteLine($"The players age is {p1.GetAge()}");
                    p1.Wins = 10;
                    int wins = p1.Wins;

                    Console.WriteLine($"{p1.FName} has {p1.Wins} wins");
        */
        // Random rand = new Random();// the Random class gets us a pseudorandom decimal between 0 and 1.

            // // These List<>'s are analogous to saving the data permanently in a Db. (We aren't doing that... YET.)
            // //create a List<Game> to hold all the games
            // List<Game> games = new List<Game>();
            // // create a List<Player> to hold allthe players.
            // List<Player> players = new List<Player>();
            // // create a List<Round> to hold all the Rounds
            // List<Round> rounds = new List<Round>();

            GamePlay gameplay = new GamePlay();

            // maybe I want to add the ability to check out my stats without playing a game?

            //Welcome message..
            Console.WriteLine("Welcome to your favorite game!\n\tThis is Rock-Paper-Scissors!"); 

            //Instructions to play...
            Console.WriteLine("\tPress the number corresponding to Rock, Paper, or Scissors to make your choice. \n\tThe game will continue until you have won at least 2 rounds. \n\tTo continue, press ENTER");

            //This loop is the beginning of each game.
            while (true) 
            {
                //this creates a new game within the GamePlay Class instance. 
                gameplay.NewGame();

                //get the users name 
                Console.WriteLine("What is your first and last name?");
                bool playerAlreadyInList = gameplay.P1Name(Console.ReadLine().Split(" ")); //[my,name,is,Beverly,Johnson] 
        
                if (playerAlreadyInList)
                {
                   Console.WriteLine($"Hey, {gameplay.GetP1().Fname} {gameplay.GetP1().Lname}, it looks like you are a returning player. Welcome back.");
                }
                else
                {
                    Console.WriteLine($"Hey, {gameplay.GetP1().Fname} {gameplay.GetP1().Lname}, it looks like you are a new player. Welcome! When you complete a game you will be added permanently to our records.");
                }

                //a while loop to play rounds until one player has won 2 rounds 
                while(!gameplay.IsThereAWinner())//the Game object will have a method that will calculate if there is a winner.
                {
                    //call PlayGame to create a round and add the current game players to it.
                    gameplay.PlayRound();
                    //keep prompting until he user puts in the correct option range
                    do
                    {
                        Console.WriteLine("Please enter \n\t1 for ROCK.\n\t2 for PAPER.\n\t3 for SCISSORS.")
                
                        Console.WriteLine("Please enter...\n\t1 for Rock.\n\t2 for Paper.\n\t3 for Scissors.");

                            // validate the users choice and assign the 
                            bool successfulConversion = gameplay.ValidateUserChoice(Console.ReadLine());
                            if (successfulConversion) break;
                            else Console.WriteLine($"Please enter a correct number. Either 1, 2, or 3.");

                    } while (true);// this is an infinite loop.

                    //evaluate the round.
                    int roundWinner = gameplay.EvaluatePlayersChoices();

                    //tell them it was a tie and loop back up to the top to reprompt
                    if (roundWinner == 0) Console.WriteLine($"This round was a tie! ...Let's try again.);
                    //if the user won
                    else if (roundWinner == 1) Console.WriteLine($"Congrats, {gameplay.GetP1().Fname}, you won this round.");
                    //if the computer won
                    else Console.WriteLine($"I'm sorry, {gameplay.GetP2().Fname} {gameplay.GetP2().Lname} won this round.");

                    Console.WriteLine($"\n\tYou chose {gameplay.GetLastRoundPlayed().P1Choice}.\n\t{gameplay.GetP2().Fname} {gameplay.GetP2().Lname} chose {gameplay.GetLastRoundPlayed().P2Choice}.\n");
                    Console.WriteLine($"\tIn this game:\nYou have won {gameplay.GetPlayer1RoundWins()} rounds,\nThe computer has won {gameplay.GetComputerRoundWins()} rounds, and\nThere have been {gameplay.GetNumberOfTies()} ties.\n\n");
                }//end of 1 game
                
                //call a method to finalize the game. 
                Game g = gameplay.FinalizeGame();

                //tell the user the rounds played status.
                Console.WriteLine($"So far, your record is {g.P1.Wins}/{g.P1.Losses} and the computer's record is {g.P2.Wins}/{g.P2.Losses}.");

                //ask if they want to play again. Each game needs to be stored.
                Console.WriteLine($"Hey {g.P1.Fname}, would you like to play another game??\n\tEnter 'Y' to play again anything else to quit the program.");
                string playAgain = Console.ReadLine();
                if (String.Equals("Y", playAgain, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Awesome! Let's play again!");
                    //call a method to reset the necessary variables to start a new game.
                    gameplay.ResetForNewGame();
                }
                else
                {
                    //continue;// will end the current loop and immediately start the next iteration of the same loop.
                    Console.WriteLine($"I'm sorry to see you go... se la vi.");
                    break;
                }
            }//exit gameplay
                
        
        //int computerChoice = 0;
        //Random Rand = new Random(); //the Random class gets us a pseudorandom decimal between 0 and 1. 
        //int player1Choice = 0;
        //int player1Wins = 0;//how many rounds player1 wins
        //int computerWins = 0;//how many rounds computer wins
        //int numberOfTies = 0;//how many time player and computer ties
       
        
        //string player1Name = "";
        //string computerName = "MacPro";
        //string player1ChoiceStr = "";
        //string playAgain = "";

        //bool successfulConversion = false;
        //bool isTie = true; //Not used for challenge

        //start game by pressing enter
        //Console.Read();

        //get the users name 
        //Console.WriteLine("What is your name?");
        //player1Name = Console.ReadLine ();

        
        //const int MaxLength = 15;


        //if (player1Name.Length > MaxLength)
        //{
            //Console.WriteLine("Please enter a name that is less than 15 characters");
            //player1Name = Console.ReadLine ();
        //}
           
        //Console.WriteLine($"Welcome to R-P-S Game, {player1Name}");
    
    
    

    
  

    //This loop is for winner of 2 rounds either player or computer
    /*while (player1Wins < 2 && computerWins < 2)
    {

        //get users choice 
        Console.WriteLine("Please enter ...\n\t1 for Rock.\n\t2 for Paper\n\t3 for Scissors.");
        player1ChoiceStr = Console.ReadLine();
        

        successfulConversion = Int32.TryParse(player1ChoiceStr, out player1Choice);
        //Console.WriteLine($"the number you inputted was {successfulConversion}, {player1Choice}");
        
        //get the computers random choice
        computerChoice = Rand.Next(3) + 1;
        Console.WriteLine(computerChoice);

        //evaluate the choices to determine the winner of the round
        
        if (player1Choice == computerChoice)
        {//if it was a tie
                //tell them it was a tie and loop back uop to the top to reprompt
                Console.WriteLine($"This round was a tie!,...Let's try again.");
                numberOfTies++;
                //isTie = true;

        }//if the user won
        else if((player1Choice == 1 && computerChoice == 3) || 
                    (player1Choice == 2 && computerChoice == 1) ||
                        (player1Choice == 3 && computerChoice == 2))
        {
            Console.WriteLine($"Congrats, {player1Name}, you won this round");
            player1Wins++;
            isTie = false;
            Console.WriteLine($"\r\n{player1Name}: {player1Wins}");
            Console.WriteLine($"\r\nComputer: {computerWins}");
        }
        else
        {//if the computer won
            Console.WriteLine($"I'm Sorry, {computerName} won this round!");
            computerWins++;
            isTie = false;
        Console.WriteLine($"\r\n{player1Name}: {player1Wins}");
        Console.WriteLine($"\r\nComputer: {computerWins}");
        }
    }
        //ask if they want tot play again
        Console.WriteLine ($"Hey {player1Name}, would you like to play again? \n\tEnter 'Y' for yes or 'N' for no");
        playAgain = Console.ReadLine();
        if (String.Equals("Y", playAgain, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Awesome! Let's play again...");
            isTie = true;
        }
        else
        {
            //continue; will end the current loop and immediately starts the iteration the next loop
            Console.WriteLine($"I'm sorry to see you go!");
            //DrawGameBoard -display the score tally
            Console.WriteLine("Thank you for playing Rock, Paper, Scissors.");
            Console.WriteLine("\r\n\r\nThe final score was:");
            Console.WriteLine($"\r\n{player1Name}: {player1Wins}");
            Console.WriteLine($"\r\nComputer: {computerWins}");
            break;
        }
            
        
        if (player1Wins == 2)
        { 
            Console.WriteLine("Congrats! You won!");
        }
        else
        {
            Console.WriteLine($"Sorry, the computer won...");
        }
    }  

            






        }
    }
    }

        //REMEMBER TO VALIDATE USER INPUT
        /*try
        {
            int player1Choice = Int32.Parse();
        }
        catch (OverflowException ex)
        {
            Console.WriteLine ($"The parse method failed because {player1Choice}, {ex.Message}, {player1Name}");
        }
        catch (FormatException ex);
        */
        /*int requiredWidth = 0;
            requiredWidth = "requiredWidth".Length +
                               player1Name.Length +
                               1 +
                               1 +
                               4 +
                               4 +
                               "Computer".Length +
                               1 +
                               1 +
                               4 +
                               1;

            int right = Console.WindowWidth - requiredWidth;
            int top = 1;
            if (right < "ROCK, PAPER, SCISSORS...".Length)
                top++;

            int scoreX = right;
            int scoreY = top;*/