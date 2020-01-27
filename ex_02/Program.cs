using System;
using System.Collections.Generic;

namespace rappel_ex08
{
    class Program
    {
        static void ShowInfo(Media m)
        {
            Console.WriteLine(m);
        }

        static void Main(string[] args)
        {
            List<Media> medias = new List<Media>();

            int nbVehicles = 20;

            for (int i = 0; i < nbVehicles; i++)
            {
                Random rnd = new Random();
                switch ((int)Math.Floor((double)rnd.Next(1, 4)))
                {
                    case 1:
                        medias.Add(new Book());
                        break;
                    case 2:
                        medias.Add(new Movie());
                        break;
                    case 3:
                        medias.Add(new Magazine());
                        break;
                    default:
                        break;
                }

            }

            foreach (Media m in medias)
            {
                ShowInfo(m);
            }

        }
    }
}
