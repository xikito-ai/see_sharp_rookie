using System;

class GuessNumber
{

    /*Have an user guess a random number between 1-10 and let them know if they got it correct, are too low, or are too high.
    */
    
  static void Main(string[] args)
  {

    //start with user input
    Console.WriteLine("Choose a number between 1-10.");
    int user_answer = Convert.ToInt32(Console.ReadLine());

    //generate random number between 1-10 to be the right number
    Random rnd = new Random();
    int right_answer = rnd.Next(1,11);
    
    //check if user chose the right number
    if (user_answer == right_answer)
    {
      Console.WriteLine("Congratulation! You got the right number!");
    }
    else if (user_answer < right_answer)
    {
      Console.WriteLine($"Bummer! You guessed wrong. You are too low! \nThe right answer was {right_answer}!");
    }
    else
    {
      Console.WriteLine($"Bummer! You guessed wrong. You are too high! \nThe right answer was {right_answer}!");
    }

  }
}
