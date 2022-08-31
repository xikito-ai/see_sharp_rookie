using System;

class PasswordChecker
{

  /* Have an user input a password and check its strength by a couple of standards. The strength of a password is measured by the score (whose starting value is 0). For each standard met the score is incremented by one. Therefore, the higher the score the stronger the password.
  */

  public static void Main(string[] args)
  {

    //defining password standards
    int minLength = 8;
    string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string lowercase = uppercase.ToLower();
    string digits = "0123456789";
    string specialChars = "#?!";

    //ask user for password input
    Console.WriteLine("Please enter a password.");
    string user_password = Console.ReadLine();

    //scoring password
    int score = 0;

    //check minLength
    if (user_password.Length >= minLength)
    {
      score++;
    }
    //check uppercase
    if (Tools.Contains(user_password, uppercase))
    {
      score++;
    }
    //check lowercase
    if (Tools.Contains(user_password, lowercase))
    {
      score++;
    }
    //check digits
    if (Tools.Contains(user_password, digits))
    {
      score++;
    }
    //check special characters
    if (Tools.Contains(user_password, specialChars))
    {
      score++;
    }
    //check for easy passwords
    if (user_password == "password" || user_password == "1234")
    {
      score = 0;
    }

    Console.WriteLine($"Your score is: {score}");

    //give feedback to the user about their password
    switch(score)
    {
      case 5:
        Console.WriteLine("Your password is extremely strong.");
        break;
      case 4:
        Console.WriteLine("Your password is extremely strong.");
        break;
      case 3:
        Console.WriteLine("Your password is strong.");
        break;
      case 2:
        Console.WriteLine("Your password is medium.");
        break;
      case 1:
        Console.WriteLine("Your password is weak.");
        break;
      default:
        Console.WriteLine("Your password does not meet any of the standards.");
        break;
    }

  }
}
