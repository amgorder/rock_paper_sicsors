using System;
using System.Collections.Generic;
namespace rock_paper_sicsors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int userScore = 0;
            int aiScore = 0;
            bool running = true;
            while (running)
            {
                System.Console.WriteLine(@"
 _______  _______  _______  _                                           
(  ____ )(  ___  )(  ____ \| \    /\                                    
| (    )|| (   ) || (    \/|  \  / /                                    
| (____)|| |   | || |      |  (_/ /                                     
|     __)| |   | || |      |   _ (                                      
| (\ (   | |   | || |      |  ( \ \                                     
| ) \ \__| (___) || (____/\|  /  \ \                                    
|/   \__/(_______)(_______/|_/    \/                                    
                                                                        
 _______  _______  _______  _______  _______                            
(  ____ )(  ___  )(  ____ )(  ____ \(  ____ )                           
| (    )|| (   ) || (    )|| (    \/| (    )|                           
| (____)|| (___) || (____)|| (__    | (____)|                           
|  _____)|  ___  ||  _____)|  __)   |     __)                           
| (      | (   ) || (      | (      | (\ (                              
| )      | )   ( || )      | (____/\| ) \ \__                           
|/       |/     \||/       (_______/|/   \__/                           
                                                                        
 _______  _______ _________ _______  _______  _______  _______  _______ 
(  ____ \(  ____ \\__   __/(  ____ \(  ____ \(  ___  )(  ____ )(  ____ \
| (    \/| (    \/   ) (   | (    \/| (    \/| (   ) || (    )|| (    \/
| (_____ | |         | |   | (_____ | (_____ | |   | || (____)|| (_____ 
(_____  )| |         | |   (_____  )(_____  )| |   | ||     __)(_____  )
      ) || |         | |         ) |      ) || |   | || (\ (         ) |
/\____) || (____/\___) (___/\____) |/\____) || (___) || ) \ \__/\____) |
\_______)(_______/\_______/\_______)\_______)(_______)|/   \__/\_______)
                                                                        

Select you weapon: 
(R)ock
(P)aper
(S)cissor");
                List<string> weapons = new List<string>(){
    "Rock",
    "Paper",
    "Scissor"
};
                int ai = rand.Next(weapons.Count);
                string aiSelect = weapons[ai];
                ConsoleKeyInfo userInput = System.Console.ReadKey();
                if (userInput.Key != ConsoleKey.R || userInput.Key != ConsoleKey.P || userInput.Key != ConsoleKey.S)
                {
                    Console.Clear();
                    System.Console.WriteLine(@"Invalid Input
                    Try Again");
                }
                if (userInput.Key == ConsoleKey.R && aiSelect == "Rock")
                {
                    Console.Clear();
                    System.Console.WriteLine("Draw");
                }
                if (userInput.Key == ConsoleKey.R && aiSelect == "Paper")
                {
                    Console.Clear();
                    aiScore += 1;
                    System.Console.WriteLine("AI Wins" + " " + aiScore);
                }
                if (userInput.Key == ConsoleKey.R && aiSelect == "Scissor")
                {
                    Console.Clear();
                    userScore += 1;
                    System.Console.WriteLine("You Win" + " " + userScore);
                }
                if (userInput.Key == ConsoleKey.P && aiSelect == "Rock")
                {
                    Console.Clear();
                    userScore += 1;
                    System.Console.WriteLine("You Win" + " " + userScore);
                }
                if (userInput.Key == ConsoleKey.P && aiSelect == "Paper")
                {
                    Console.Clear();
                    System.Console.WriteLine("Draw");
                }
                if (userInput.Key == ConsoleKey.P && aiSelect == "Scissor")
                {
                    Console.Clear();
                    aiScore += 1;
                    System.Console.WriteLine("AI Wins" + " " + aiScore);
                }
                if (userInput.Key == ConsoleKey.S && aiSelect == "Rock")
                {
                    Console.Clear();
                    aiScore += 1;
                    System.Console.WriteLine("AI Wins" + " " + aiScore);
                }
                if (userInput.Key == ConsoleKey.S && aiSelect == "Paper")
                {
                    Console.Clear();
                    userScore += 1;
                    System.Console.WriteLine("You Win" + " " + userScore);
                }
                if (userInput.Key == ConsoleKey.S && aiSelect == "Scissor")
                {
                    Console.Clear();
                    System.Console.WriteLine("Draw");
                }
                if (userScore >= 10)
                {
                    running = false;
                    System.Console.WriteLine(@"
         _________ _        _        _______  _______ 
|\     /|\__   __/( (    /|( (    /|(  ____ \(  ____ )
| )   ( |   ) (   |  \  ( ||  \  ( || (    \/| (    )|
| | _ | |   | |   |   \ | ||   \ | || (__    | (____)|
| |( )| |   | |   | (\ \) || (\ \) ||  __)   |     __)
| || || |   | |   | | \   || | \   || (      | (\ (   
| () () |___) (___| )  \  || )  \  || (____/\| ) \ \__
(_______)\_______/|/    )_)|/    )_)(_______/|/   \__/
                                                      
");
                }
                if (aiScore >= 10)
                {
                    running = false;
                    System.Console.WriteLine(@"
 _        _______  _______  _______  _______ 
( \      (  ___  )(  ____ \(  ____ \(  ____ )
| (      | (   ) || (    \/| (    \/| (    )|
| |      | |   | || (_____ | (__    | (____)|
| |      | |   | |(_____  )|  __)   |     __)
| |      | |   | |      ) || (      | (\ (   
| (____/\| (___) |/\____) || (____/\| ) \ \__
(_______/(_______)\_______)(_______/|/   \__/
                                             
");
                }
            }
        }
    }
}

