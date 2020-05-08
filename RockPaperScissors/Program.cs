using System;
using System.Threading.Tasks.Sources;

namespace RockPaperScissors {
    class Program {
        static void Main(string[] args) {

            string inputPlayer;
            string inputCPU;
            int randomInt;

            int scoreCPU = 0; int scorePlayer = 0;
            Boolean play = true;

            while(play) {
                Console.WriteLine("Rock Paper Scissors!");
                Console.WriteLine("Which do you choose? ");
                inputPlayer = Console.ReadLine();
                //Console.WriteLine(inputPlayer);

                Random rnd = new Random();

                randomInt = rnd.Next(1, 3);
                //Console.WriteLine(randomInt);
                switch(randomInt) {
                    case 1:
                        inputCPU = "ROCK";
                        Console.WriteLine("CPU choose rock");
                        if(inputPlayer == "scissors") {
                            Console.WriteLine("CPU wins!");
                            scoreCPU++;
                        }
                        if (inputPlayer=="rock") {
                            Console.WriteLine("TIE!");
                        }
                        else {
                            Console.WriteLine("YOU win!");
                            scorePlayer++;
                        }

                        break;
                    case 2:
                        inputCPU = "PAPER";
                        Console.WriteLine("CPU choose paper");
                        if(inputPlayer == "rock") {
                            Console.WriteLine("CPU wins!");
                            scoreCPU++;
                        }
                        if(inputPlayer == "paper") {
                            Console.WriteLine("TIE!");
                        }
                        else {
                            Console.WriteLine("YOU win!");
                            scorePlayer++;
                        }
                        break;
                    case 3:
                        inputCPU = "SCISSORS";
                        Console.WriteLine("CPU choose scissors");
                        if(inputPlayer == "paper") {
                            Console.WriteLine("CPU wins!");
                            scoreCPU++;
                        }
                        if(inputPlayer == "scissors") {
                            Console.WriteLine("TIE!");
                        }
                        else {
                            Console.WriteLine("YOU win!");
                            scorePlayer++;
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid entry!");
                        break;

                }

                Console.WriteLine("Play again (y or n)?");
                inputPlayer = Console.ReadLine();
                if(inputPlayer == "n") {
                    Console.WriteLine("You won " + scorePlayer);
                    Console.WriteLine("CPU won " + scoreCPU);
                    Console.WriteLine("Thanks for playing!");
                    break;

                }
            }





        }
    }
}
