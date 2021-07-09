using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace rock_paper_scissors
{
 class Program
 {
  static void Main(string[] args)
  {
   string inputPlayer, inputCPU;
   int randomInt;

   bool playAgain = true;

   while (playAgain)
   {
    int scorePlayer = 0;
    int scoreCPU = 0;

    while (scorePlayer < 3 && scoreCPU < 3)
    {

     Console.Write("Choose between Rock,Paper,Scissors:   ");
     inputPlayer = Console.ReadLine();



     Random rnd = new Random();
     randomInt = rnd.Next(1, 4);


     switch (randomInt)
     {
      case 1:
       inputCPU = "Rock";
       Console.WriteLine("Computer chose rock");
       if (inputPlayer == "Rock")
       {
        Console.WriteLine("Draw!!\n\n");
       }
       else if (inputPlayer == "Paper")
       {
        Console.WriteLine("Player wins");
        scorePlayer++;
       }
       else if (inputPlayer == "Scissors")
       {
        Console.WriteLine("Cpu wins!!\n\n");
        scoreCPU++;

       }
       break;
      case 2:
       inputCPU = "Paper";
       Console.WriteLine("Computer chose paper");
       if (inputPlayer == "Paper")
       {
        Console.WriteLine("Draw!!\n\n");
       }
       else if (inputPlayer == "Rock")
       {
        Console.WriteLine("CPU wins!!\n\n");
        scoreCPU++;
       }
       else if (inputPlayer == "Scissors")
       {
        Console.WriteLine("Player wins");
        scorePlayer++;
       }
       break;
      case 3:
       inputCPU = "Scissors";
       Console.WriteLine("Computer chose scissors");
       if (inputPlayer == "Scissors")
       {
        Console.WriteLine("Draw!!\n\n");
       }
       else if (inputPlayer == "Rock")
       {
        Console.WriteLine("Player wins");
        scorePlayer++;
       }
       else if (inputPlayer == "Paper")
       {
        Console.WriteLine("Cpu wins!!\n\n");
        scoreCPU++;
       }
       break;

      default:
       Console.WriteLine("Invalid Entry");
       break;
     }

     Console.WriteLine("\n\nScores:\tPlayer:\t{0}\tCpu:\t{1}", scorePlayer, scoreCPU);

     if (scorePlayer == 3)
     {
      Console.WriteLine("Player won!!");
     }
     else if (scoreCPU == 3)
     {
      Console.WriteLine("CPU won!!");
     }
     else
     {

     }

    }
    Console.WriteLine("Do you want to play again? (Y/N)");
    string loop = Console.ReadLine();
    if (loop == "Y")
    {
     playAgain = true;
     Console.Clear();
    }
    else if (loop == "N")
    {
     playAgain = false;
    }
    else
    {

    }


   }
  }
 }
}

