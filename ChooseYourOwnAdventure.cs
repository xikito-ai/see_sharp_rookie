using System;

class ChooseYourOwnAdventure
{
    /*
    A story telling, that changes depending on the choices the user makes.
    */
    
    static void Main(string[] args)
  {
    /* THE MYSTERIOUS NOISE */

    // Start by asking for the user's name:
    Console.Write("What is your name?: ");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello, {name}! Welcome to our story.");

    //beginning of story
    Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

    //first choice
    Console.Write("Type YES or NO: ");
    string noiseChoice = Console.ReadLine().ToUpper();
    //reactions to first choice
    if (noiseChoice == "NO")
    {
      Console.WriteLine("Not much of an adventure if we don't leave our room!");
      Console.WriteLine("THE END.");
    }
    else if (noiseChoice == "YES")
    {
      Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?");

      //second choice
      Console.Write("Type OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine().ToUpper();

      //reactions to second choice
      if (doorChoice == "KNOCK")
      {
        //riddle
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \" \n \"Poor people have it. Rich people need it. If you eat it you die. \nWhat is it?\"");
        //answer to riddle
        Console.Write("Type your answer: ");
        string riddleAnswer = Console.ReadLine().ToUpper();
        //reactions to riddle
        if (riddleAnswer == "NOTHING")
        {
          Console.WriteLine("The door opens and NOTHING is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.");
        }
        else
        {
          Console.WriteLine("You answered incorrectly. The door doesn't open.\nTHE END.");
        }//end riddle
      }
      //continue reaction to second choice
      else if (doorChoice == "OPEN")
      {
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");

        //third choice
        Console.Write("Enter a number (1-3): ");
        string keyChoice = Console.ReadLine().ToUpper();

        //reactions to third choice
        switch (keyChoice)
        {
          case "1":
            Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there. Strange...\nTHE END.");
            break;
          case "2":
            Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END.");
            break;
          case "3":
            Console.WriteLine("You choose the third key. The door doesn't open.\nTHE END.");
            break;
          default:
            break;
        }//end reactions (switch)
      }//end reaction to second choice (else if)
    }//end reaction to first choice (else if)

  }//end main
}




