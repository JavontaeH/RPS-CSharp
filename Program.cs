using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerScore = 0;
            var cpuScore = 0;
            string rock = $@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)

";

            string paper = $@"
     _______
---'    ____)___
           ______)
          _______)
         _______)
---.__________)
                ";

            string scissors = $@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
            ";


            void GameLoop()
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"| Player:{playerScore} | Computer:{cpuScore} |");
                Console.WriteLine("What would you like to throw?");
                Console.WriteLine("1) Rock");
                Console.WriteLine("2) Paper");
                Console.WriteLine("3) Scissors");
                var answer = Console.ReadLine();
                string playerAnswer = "";
                if (answer == "1")
                {
                    Console.WriteLine(rock);
                    playerAnswer = rock;
                }
                if (answer == "2")
                {
                    Console.WriteLine(paper);
                    playerAnswer = paper;
                }
                if (answer == "3")
                {
                    Console.WriteLine(scissors);
                    playerAnswer = scissors;
                }
                Console.WriteLine("VS");
                Random r = new Random();
                int cpuGen = r.Next(0, 3);
                string cpuAnswer = "";
                if (cpuGen == 0) { cpuAnswer = rock; }
                if (cpuGen == 1) { cpuAnswer = paper; }
                if (cpuGen == 2) { cpuAnswer = scissors; }
                Console.WriteLine(cpuAnswer);
                void CalculateScore()
                {
                    if (cpuAnswer == playerAnswer) { };
                    if (cpuAnswer == rock && playerAnswer == scissors) { cpuScore += 1; };
                    if (cpuAnswer == paper && playerAnswer == rock) { cpuScore += 1; }
                    if (playerAnswer == scissors && playerAnswer == paper) { playerScore += 1; }
                    if (playerAnswer == rock && cpuAnswer == scissors) { playerScore += 1; };
                    if (playerAnswer == paper && cpuAnswer == rock) { playerScore += 1; }
                    if (playerAnswer == scissors && cpuAnswer == paper) { playerScore += 1; }
                }
                CalculateScore();
            }
            while (playerScore < 3 && cpuScore < 3)
            {
                GameLoop();
            }
            if (playerScore == 3)
            {
                Console.WriteLine("You Won!");
            }
            else if (cpuScore == 3)
            {
                Console.WriteLine("You Lost!");
            }

        }
    }
}
