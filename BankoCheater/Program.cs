using System;
using System.Security.Cryptography;
using System.Text;


namespace BankoCheater
{
    class Player
    {
        public string Name {get; set;}
        public int[] row1 {get; set;}
        public int[] row2 {get; set;}
        public int[] row3 {get; set;}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> Players = new List<Player>();
            int userInput;
            List<int> numbers = new List<int>();

            Players.Add(new Player { Name = "Roman", row1 = [3,20,40,70,84], row2 = [25,33,41,61,71], row3 = [7,14,27,58,67] });
            Players.Add(new Player { Name = "Roman1", row1 = [2,40,62,75,86], row2 = [17,25,32,53,89], row3 = [7,18,38,46,79] });
            Players.Add(new Player { Name = "Roman2", row1 = [10,22,31,40,72], row2 = [27,32,42,61,85], row3 = [9,33,58,64,86] });
            Players.Add(new Player { Name = "Roman3", row1 = [30,42,53,70,85], row2 = [6,17,23,63,86], row3 = [9,18,24,46,59] });
            Players.Add(new Player { Name = "Roman4", row1 = [1,23,33,42,72], row2 = [15,24,47,63,74], row3 = [18,48,59,65,89] });
            Players.Add(new Player { Name = "Roman5", row1 = [30,41,60,73,80], row2 = [14,21,61,75,82], row3 = [9,24,35,59,76] });
            Players.Add(new Player { Name = "Roman6", row1 = [10,33,42,50,72], row2 = [6,13,21,44,54], row3 = [27,37,58,65,90] });
            Players.Add(new Player { Name = "Roman7", row1 = [10,40,55,61,80], row2 = [15,36,41,58,65], row3 = [9,28,44,59,78] });
            Players.Add(new Player { Name = "Roman8", row1 = [3,21,47,73,80], row2 = [13,27,32,53,76], row3 = [8,18,29,69,79] });
            Players.Add(new Player { Name = "Roman9", row1 = [2,11,20,44,85], row2 = [12,22,46,55,72], row3 = [37,58,69,79,90] });
            Players.Add(new Player { Name = "Roman10", row1 = [2,42,61,70,80], row2 = [3,35,45,76,85], row3 = [19,28,37,49,56] });

            void playGame()
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                if (!numbers.Contains(userInput))
                    numbers.Add(userInput);

                foreach (var player in Players)
                {
                    if (player.row1.All(n => numbers.Contains(n)))
                    {
                        Console.WriteLine($"Banko! Player {player.Name} completed row 1.");
                    }
                    if (player.row2.All(n => numbers.Contains(n)))
                    {
                        Console.WriteLine($"Banko! Player {player.Name} completed row 2.");
                    }
                    if (player.row3.All(n => numbers.Contains(n)))
                    {
                        Console.WriteLine($"Banko! Player {player.Name} completed row 3.");
                    }
                }
            }


            while(true)
            {
                playGame();
            }

        }


    }
}
 