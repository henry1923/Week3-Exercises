using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks:
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab, kas kasutaja 
            //saab arstiks õppida
            Console.WriteLine("Mitu punkti said sa matemaatikas?");
            int Mate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mitu punkti said sa keemias?");
            int Keemia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mitu punkti said sa bioloogias?");
            int Bioloogia = Convert.ToInt32(Console.ReadLine());

            if (Mate >= 95 || Keemia >= 90 || Bioloogia >= 95) 
            {
                Console.WriteLine("Võid õppida arstiks");
            }
            else

            {
                Console.WriteLine("Oled liiga loll, et arstiks saada.");         
            }
                
            





        }
    }
}
