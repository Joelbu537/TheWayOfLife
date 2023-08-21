using System;
namespace TWOL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The Way Of Life";
            Console.Write("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WindowHeight = 61;
            Console.WindowWidth = 203;
            var rand = new Random();
            string[,] map = new string[60, 200];
            int mapl = map.GetLength(0);
            int mapw = map.GetLength(1);

            for(int i = 0; i < mapl; i++)
            {
                for(int j = 0; j < mapw; j++)
                {
                    map[i, j] = " ";
                }
            }
            // Map ist definiert
            int spawnl = rand.Next(25, 40);
            int spawnw = rand.Next(30, 120);
            map[spawnl, spawnw] = "#";
            bool gameover = false;
            while (gameover != true)
            {
                Thread.Sleep(100);
                Console.Clear();
                for (int i = 0; i < mapl; i++)
                {
                    for (int j = 0; j < mapw; j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < mapl; i++)
                {
                    for (int j = 0; j < mapw; j++)
                    {
                        if (map[i, j] == ";")
                        {
                            map[i, j] = " ";
                        }
                    }
                }
                for(int i = 0; i < mapl; i++ )
                {
                    for(int j = 0; j < mapw; j++)
                    {
                        if (map[i, j] == "#")
                        {
                            int expand = rand.Next(0, 6);
                            if (expand > 2)
                            {
                                if ((i < 59) && (i > 1))
                                {
                                    if ((j < 199) && (j > 1))
                                    {
                                        int cases = rand.Next(1, 5);
                                        switch (cases)
                                        {
                                            case 1:
                                                map[(i - 1), j] = "#";
                                                break;
                                            case 2:
                                                map[i, (j + 1)] = "#";
                                                break;
                                            case 3:
                                                map[(i - 1), j] = "#";
                                                break;
                                            case 4:
                                                map[i, (j - 1)] = "#";
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                for(int i = 0; i < mapl; i++ )
                {
                    for (int j = 0; j < mapw; j++)
                    {
                        if (map[i, j] == "#")
                        {
                            int die = rand.Next(0, 7);
                            if (die == 1)
                            {
                                map[i, j] = ";";
                            }
                        }
                    }
                }
            }
        }
    }
}
