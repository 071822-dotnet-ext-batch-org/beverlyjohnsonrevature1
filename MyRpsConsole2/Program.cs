using System;

namespace RpsConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
         //Welcome message..
         Console.WriteLine("Welcome to your favorite game!\n\tThis is Rock-Paper-Scissors!"); 
          
        //Instructions to play...
        Console.WriteLine("\tPress the number corresponding to Rock, Paper, or Scissors to make your choice. \n\tThe game will continue until you have won at least 2 rounds. \n\tTo continue, press ENTER");
   
    //This loop is for if they want to play again.

        //(unseen to the user) create some variables to store which choice the user made,
    while (true) 
    { 
        int computerChoice = 0;
        Random Rand = new Random(); //the Random class gets us a pseudorandom decimal between 0 and 1. 
        int player1Choice = 0;
        int player1Wins = 0;//how many rounds player1 wins
        int computerWins = 0;//how many rounds computer wins
        int numberOfTies = 0;//how many time player and computer ties
       
        
        string player1Name = "";
        string computerName = "MacPro";
        string player1ChoiceStr = "";
        string playAgain = "";

        bool successfulConversion = false;
        bool isTie = true; //Not used for challenge

        //start game by pressing enter
        Console.Read();

        //get the users name 
        Console.WriteLine("What is your name?");
        player1Name = Console.ReadLine ();

        
        const int MaxLength = 15;


        if (player1Name.Length > MaxLength)
        {
            Console.WriteLine("Please enter a name that is less than 15 characters");
            player1Name = Console.ReadLine ();
        }
           
        Console.WriteLine($"Welcome to R-P-S Game, {player1Name}");
    
    
    

    
  

    //This loop is for winner of 2 rounds either player or computer
    while (player1Wins < 2 && computerWins < 2)
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