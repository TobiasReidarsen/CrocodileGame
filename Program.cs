namespace KrokodilleSpill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Crocodile game!\nPlay game? Y/N?");

            string playGame = Console.ReadLine().ToLower();
            if(playGame == "y")
            {
                Console.Clear();
                Console.WriteLine("Which number is bigger?\nUse <, > or =");
                DrawGame.DrawBoard();
                Game.StartGame();

            }
            else if(playGame == "n")
            {
                Console.WriteLine("Ok bye!");
                Environment.Exit(0);
            }
            else if (playGame == "snu")
            {
                string snuDette = "Tobias";
                string tempString = "";
                for (int i = snuDette.Length - 1; i >= 0; i = i - 1)
                {
                    tempString +=  snuDette[i]; 

                    Console.WriteLine("Forandrer ikke snuDette "+ snuDette[i]);
                }
                snuDette = tempString;
                Console.WriteLine(tempString);
                Console.WriteLine(snuDette);

            }
            else if (playGame == "tell")
            {
                string tellA = "aaahfhegryaaadjkeaa"; // 8 a
                int antallA = 0;

                for (int i = 0; i < tellA.Length; i++)
                {
                    Console.WriteLine(tellA[i]);
                    if (tellA[i] == 'a') // må sammenligne char når du sammenligner bokstav for bokstav
                    {
                        antallA++;
                    }

                }
                Console.WriteLine(antallA); // skal være 8
            }
        }
    }
}