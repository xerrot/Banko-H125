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
            SHA256 sha256 = SHA256.Create();

            void AddPlayer(string player_name) 
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(player_name));
                int seed = BitConverter.ToInt32(hashBytes, 0);
                Random random = new Random(seed);

                Player player = new Player {
                    Name = player_name,
                    row1 = new int[9],
                    row2 = new int[9],
                    row3 = new int[9]
                };

                for(int i = 0; i < 6; i++) 
                {
                    player.row1[i] = random.Next(1, 91);
                    player.row2[i] = random.Next(1, 91);
                    player.row3[i] = random.Next(1, 91);
                }
                Players.Add(player);
            }

            // FOR TESTING
            /*
            AddPlayer("Frida");
            AddPlayer("John");

            foreach (var player in Players)
            {
                Console.WriteLine($"Player name: {player.Name}");
                Console.WriteLine($"Row 1: {string.Join(", ", player.row1)}");
                Console.WriteLine($"Row 2: {string.Join(", ", player.row2)}");
                Console.WriteLine($"Row 3: {string.Join(", ", player.row3)}");
            }
            */
            
        }
        
        
    }
}
