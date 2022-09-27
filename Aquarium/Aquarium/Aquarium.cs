using System;
using System.Collections;
using System.Collections.Generic;

namespace Aquarium
{
    internal class Aquarium
    {
        public int Glaskasten { get; set; }
        public int Fish { get; set; }

        public Aquarium(int glaskasten, int fish)
        {
            Glaskasten = glaskasten;
            Fish = fish;
        }

        public static void Behaeltererstellen()
        {
            //Fragt Aquariumgröße ab
            Console.WriteLine($"Wie hoch soll das Aquarium sein ?");
            int höhe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Wie breit soll dein Aquarium werden ?");
            int breite = Convert.ToInt32(Console.ReadLine());

            //string[,] erstellt ein zweidimensionales Array
            string[,] glaskasten = new string[breite, höhe];
            Console.Clear();
            Console.WriteLine();
            for (int j = 0; j < höhe; j++)
            {
                for (int i = 0; i < breite; i++)
                {
                    if (i == 0 || i == breite - 1)
                    {
                        glaskasten[i, j] = "|";
                    }
                    else
                    {
                        glaskasten[i, j] = " ";
                    }
                    if (j == höhe - 1)
                    {
                        if (i == 0 || i == breite - 1)
                        {
                            glaskasten[i, j] = "+";
                        }
                        else
                        {
                            glaskasten[i, j] = "-";
                        }
                    }
                }
            }
            //druckt das Array aus
            for (int j = 0; j < höhe; j++)
            {
                for (int i = 0; i < breite; i++)
                {
                    Console.Write(glaskasten[i, j]);
                }
                Console.Write("\n");
            }
            //fügt zufallskoordinaten für den carp hinzu
            Random random = new Random();
            int carp_höhe = random.Next(4, höhe - 4);
            int carp_breite = random.Next(4, breite - 4);

            //erstellt carp
            List<string> carp = new List<string> { "<", ">", "<" };

            int counter = 0;



            do
            {
                if (carp[0] == "<" & glaskasten[carp_breite, carp_höhe] != "|")
                {
                    glaskasten[carp_breite, carp_höhe] = carp[0];
                    glaskasten[carp_breite + 1, carp_höhe] = carp[1];
                    glaskasten[carp_breite + 2, carp_höhe] = carp[2];
                    if (glaskasten[carp_breite + 3, carp_höhe] != "|")
                    {
                        glaskasten[carp_breite + 3, carp_höhe] = " ";
                    }
                    carp_breite--;
                }
                else if (carp[0]== "<" & glaskasten[carp_breite, carp_höhe] == "|")
                {
                    glaskasten[carp_breite + 1, carp_höhe] = carp[0] = ">";
                    glaskasten[carp_breite + 2, carp_höhe] = carp[1] = "<";
                    glaskasten[carp_breite + 3, carp_höhe] = carp[2] = ">";
                    carp_breite++;
                }

                if (carp[0] == ">" & glaskasten[carp_breite+4, carp_höhe] != "|")
                {
                    glaskasten[carp_breite+3, carp_höhe] = carp[0];
                    glaskasten[carp_breite +2, carp_höhe] = carp[1];
                    glaskasten[carp_breite +1, carp_höhe] = carp[2];
                    if (glaskasten[carp_breite, carp_höhe] != "|")
                    {
                        glaskasten[carp_breite, carp_höhe] = " ";
                    }
                    carp_breite++;
                }
                else if (carp[0] == ">" & glaskasten[carp_breite+4, carp_höhe] == "|")
                {
                    glaskasten[carp_breite +3, carp_höhe] = carp[0] = "<";
                    glaskasten[carp_breite + 2, carp_höhe] = carp[1] = ">";
                    glaskasten[carp_breite + 1, carp_höhe] = carp[2] = "<";
                }

                for (int j = 0; j < höhe; j++)
                {
                    for (int i = 0; i < breite; i++)
                    {
                        Console.Write(glaskasten[i, j]);
                    }
                    Console.Write("\n");
                }

                counter++;
            } while (counter < 15);




            //do
            //{
            //    Console.ReadKey();
            //    if (carp[0] == "<")
            //    {
            //        if (glaskasten[carp_breite, carp_höhe] == "|")
            //        {
            //            glaskasten[carp_breite + 1, carp_höhe] = carp[0] = ">";
            //            glaskasten[carp_breite + 2, carp_höhe] = carp[1] = "<";
            //            glaskasten[carp_breite + 3, carp_höhe] = carp[2] = ">";
            //        }
            //        else if (glaskasten[carp_breite, carp_höhe] != "|")
            //        {
            //            glaskasten[carp_breite , carp_höhe] = carp[0];
            //            glaskasten[carp_breite +1, carp_höhe] = carp[1];
            //            glaskasten[carp_breite + 2, carp_höhe] = carp[2];
            //            if (glaskasten[carp_breite, carp_höhe] != "|")
            //            {
            //                glaskasten[carp_breite+3, carp_höhe] = " ";
            //            }
            //            carp_breite--;
            //        }
            //        for (int j = 0; j < höhe; j++)
            //        {
            //            for (int i = 0; i < breite; i++)
            //            {
            //                Console.Write(glaskasten[i, j]);
            //            }
            //            Console.Write("\n");
            //        }
            //    }
            //    if (carp[0] == ">")
            //    {
            //        if (glaskasten[carp_breite+1, carp_höhe] == "|")
            //        {
            //            glaskasten[carp_breite - 1, carp_höhe] = carp[0] = "<";
            //            glaskasten[carp_breite - 2, carp_höhe] = carp[1] = ">";
            //            glaskasten[carp_breite - 3, carp_höhe] = carp[2] = "<";
            //        }
            //        else if (glaskasten[carp_breite+1, carp_höhe] != "|")
            //        {
            //            glaskasten[carp_breite+3, carp_höhe] = carp[0];
            //            glaskasten[carp_breite+2, carp_höhe] = carp[1];
            //            glaskasten[carp_breite+1, carp_höhe] = carp[2];
            //            if (glaskasten[carp_breite, carp_höhe] != "|")
            //            {
            //                glaskasten[carp_breite, carp_höhe] = " ";
            //            }
            //            carp_breite++;
            //        }
            //        for (int j = 0; j < höhe; j++)
            //        {
            //            for (int i = 0; i < breite; i++)
            //            {
            //                Console.Write(glaskasten[i, j]);
            //            }
            //            Console.Write("\n");
            //        }
            //    }
            //    counter++;
            //} while (counter < 30);








            //else if (carp[0] == ">")
            //{
            //    if (glaskasten[carp_breite, carp_höhe] != "|")
            //    {
            //        glaskasten[carp_breite, carp_höhe] = carp[0];
            //        glaskasten[carp_breite - 1, carp_höhe] = carp[1];
            //        glaskasten[carp_breite - 2, carp_höhe] = carp[2];
            //        //glaskasten[carp_breite - 3, carp_höhe] = " ";
            //        carp_breite = carp_breite + 1;
            //    }
            //    else if (glaskasten[carp_breite, carp_höhe] == "|")
            //    {
            //        carp[0] = "<";
            //        carp[1] = ">";
            //        carp[2] = "<";
            //    }
            //}

            //if ((carp[0] == "<") & (glaskasten[carp_breite, carp_höhe] == glaskasten[breite - breite, carp_höhe]))
            //{
            //    carp[0] = ">";
            //    carp[1] = "<";
            //    carp[2] = ">";
            //}
            //if ((carp[0] == "<") & (glaskasten[carp_breite, carp_höhe] != glaskasten[breite - breite, carp_höhe]))
            //{
            //    glaskasten[carp_breite, carp_höhe] = carp[0];
            //    glaskasten[carp_breite + 1, carp_höhe] = carp[1];
            //    glaskasten[carp_breite + 2, carp_höhe] = carp[2];
            //    glaskasten[carp_breite + 3, carp_höhe] = " ";
            //    carp_breite = carp_breite - 1;
            //}


            //if (carp[0] == "<")
            //{
            //    if (glaskasten[carp_breite, carp_höhe] != glaskasten[breite - breite, carp_höhe])

            //    {
            //        glaskasten[carp_breite, carp_höhe] = carp[0];
            //        glaskasten[carp_breite + 1, carp_höhe] = carp[1];
            //        glaskasten[carp_breite + 2, carp_höhe] = carp[2];
            //        glaskasten[carp_breite + 3, carp_höhe] = " ";
            //        carp_breite--;
            //    }
            //    else
            //    {
            //        carp[0] = ">";
            //        carp[1] = "<";
            //        carp[2] = ">";
            //    }
            //}
            //if (carp[0] == ">")
            //{
            //    if (glaskasten[carp_breite, carp_höhe] != glaskasten[breite-1, carp_höhe])
            //    {

            //        glaskasten[carp_breite, carp_höhe] = carp[0];
            //        glaskasten[carp_breite + 1, carp_höhe] = carp[1];
            //        glaskasten[carp_breite + 2, carp_höhe] = carp[2];
            //        glaskasten[carp_breite + 3, carp_höhe] = " ";
            //    }
            //    else
            //    {
            //        carp[0] = "<";
            //        carp[1] = ">";
            //        carp[2] = "<";
            //    }
            //}


            //counter++;
            //if (carp[0] == "<")
            //{
            //    carp_breite = carp_breite - 1;
            //    glaskasten[carp_breite + 1, carp_höhe] = carp[0];
            //    glaskasten[carp_breite + 2, carp_höhe] = carp[1];
            //    glaskasten[carp_breite + 3, carp_höhe] = carp[2];
            //    glaskasten[carp_breite + 4, carp_höhe] = " ";

            //    if (glaskasten[carp_breite, carp_höhe] == glaskasten[breite - breite, carp_höhe])
            //    {
            //        carp[0] = ">";
            //        carp[1] = "<";
            //        carp[2] = ">";
            //    }
            //}

            //if (carp[0] == ">" && glaskasten[carp_breite, carp_höhe] != glaskasten[breite, carp_höhe])
            //{
            //    carp_breite = carp_breite + 1;
            //    glaskasten[carp_breite, carp_höhe] = carp[0];
            //    glaskasten[carp_breite + 1, carp_höhe] = carp[1];
            //    glaskasten[carp_breite + 2, carp_höhe] = carp[2];
            //    glaskasten[carp_breite + 3, carp_höhe] = " ";
            //    if (glaskasten[carp_breite, carp_höhe] == glaskasten[breite, carp_höhe])
            //    {
            //        carp[0] = ">";
            //        carp[1] = "<";
            //        carp[2] = ">";
            //    }
            //}


            //else if (glaskasten[carp_breite, carp_höhe] == glaskasten[breite, carp_höhe])
            //{
            //    carp[0] = "<";
            //    carp[1] = ">";
            //    carp[2] = "<";
            //    carp_breite = carp_breite - 1;
            //    glaskasten[carp_breite, carp_höhe] = carp[0];
            //    glaskasten[carp_breite - 1, carp_höhe] = carp[1];
            //    glaskasten[carp_breite - 2, carp_höhe] = carp[2];
            //    glaskasten[carp_breite - 3, carp_höhe] = " ";
            //}
            //else
            //{
            //    carp_breite = carp_breite + 1;
            //    glaskasten[carp_breite - 1, carp_höhe] = carp[0];
            //    glaskasten[carp_breite - 2, carp_höhe] = carp[1];
            //    glaskasten[carp_breite - 3, carp_höhe] = carp[2];
            //    glaskasten[carp_breite - 4, carp_höhe] = " ";
            //}





            //int fischlaenge = carp.Length;
            //Console.WriteLine(fischlaenge);

            Console.ReadKey();
        }
    }
}
