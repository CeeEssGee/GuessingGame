using System;

// Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
Random random = new Random();

int secretNumber = random.Next(1, 100);
int rounds = 6;

Console.WriteLine("Choose Your Difficulty by Entering the Associated Number (Default is Medium)");
Console.WriteLine("Cheater - 1");
Console.WriteLine("Easy - 2");
Console.WriteLine("Medium - 3");
Console.WriteLine("Hard - 4");

string difficulty = Console.ReadLine();
int difficultyNumber = int.Parse(difficulty);

if (difficultyNumber == 4)
{
    rounds = 4;
};

if
(difficultyNumber == 3)
{
    rounds = 6;
};

if
(difficultyNumber == 2)
{
    rounds = 8;
};

if
(difficultyNumber == 1)
{
    rounds = 999;
};

// Display a message to the user asking them to guess the secret number.
Console.WriteLine("Guess the secret number.");


for (int i = 1; i < (1 + rounds); i++)
{
    // Display a prompt for the user's guess.
    // Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
    Console.WriteLine($"Enter guess #{i}.");

    // Take the user's guess as input and save it as a variable.
    string input = Console.ReadLine();

    // Compare the user's guess with the secret number. Inform the user if their guess was too high or too low, when they guess incorrectly. Display a success message if the guess is correct, otherwise display a failure message.
    if (int.Parse(input) == secretNumber)
    {
        Console.WriteLine("You guessed the Secret Number!");
        // end the loop early if the user guesses the correct number
        break;
    }
    else if (int.Parse(input) != secretNumber && (rounds - i) == 0)
    {
        Console.WriteLine($"You lose! The Secret Number was {secretNumber}!");
    }
    else if (int.Parse(input) > secretNumber)
    {
        Console.WriteLine($"The Secret Number is lower than {input}. Guesses left: {rounds - i}");
    }
    else if (int.Parse(input) < secretNumber)
    {
        Console.WriteLine($"The Secret Number is higher than {input}. Guesses left: {rounds - i}");
    }
}