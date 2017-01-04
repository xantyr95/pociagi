using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Aplikacja : Pociag
    {
        public Aplikacja()
        {
            Informacje();
            Operacje();
        }
        public void Informacje()
        {
            Console.WriteLine("Aplikacja do skladania pociagow");
            Console.WriteLine("Wybierz co chcesz zrobic?");
            Console.WriteLine("D - Wcisnij by dodac lokomotywe");
            Console.WriteLine("W - Wcisnij by dodac wagon");
            Console.WriteLine("Z - Wcisnij by wypisac dodana zawartosc");
            Console.WriteLine("S - Wcisnij by sprawdzic czy sklad moze jechac");
            Console.WriteLine("E - wyjscie");
        }
        public void wybierzWagon()
        {
            int masa;
            string model;
            string ladunek;
            string rodzaj;
            Console.WriteLine("Wybierz rodzaj wagonu");
            Console.WriteLine("T - Wagon Towarowy");
            Console.WriteLine("O - Wagon Osobowy");
            Console.WriteLine("P - Wcisnij by wrocic do menu glownego");
            char znak = Convert.ToChar(Console.ReadLine());
            try
            {
                if (znak == 'T' || znak == 't')
                {
                    Console.WriteLine("Podaj mase");
                    masa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj model");
                    model = Console.ReadLine();
                    Console.WriteLine("Podaj ladunek");
                    ladunek =(Console.ReadLine());
                    DodajTowarowy(model, masa, ladunek);
                    Console.WriteLine("Pomyslnie dodano wagon");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();

                }
                else if (znak == 'O' || znak == 'o')
                {
                    Console.WriteLine("Podaj model");
                    model = Console.ReadLine();
                    Console.WriteLine("Podaj mase");
                    masa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj ladunek");
                    rodzaj =(Console.ReadLine());
                    DodajOsobowy(model, masa, rodzaj);
                    Console.WriteLine("Pomyslnie dodano wagon");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                }
                else if (znak == 'P' || znak == 'p')
                {
                    Informacje();
                    Operacje();
                }
                else
                {
                    Console.WriteLine("Wpisano zly znak");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Informacje();
            Operacje();

        }
        public void Operacje()
        {
            string model;
            int masa;
            char Znak;
            Znak = Convert.ToChar(Console.ReadLine());
            try
            {
                switch (Znak)
                {
                    case 'D':
                        Console.WriteLine("Podaj model");
                        model = Console.ReadLine();
                        Console.WriteLine("Podaj mase");
                        masa = Convert.ToInt32(Console.ReadLine());
                        DodajLokomotywe(model, masa);
                        Console.WriteLine("Pomyslnie dodano lokomotywe");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Informacje();
                        Operacje();
                        break;
                    case 'W':
                        wybierzWagon();
                        break;
                    case 'Z':
                        Informacje();
                        Console.ReadKey();
                        Informacje();
                        Operacje();
                        break;
                    case 'S':
                        MozeJechac();
                        break;
                    case 'E':
                        Console.WriteLine("Wyjscie");
                        break;
                    default:
                        Console.WriteLine("Wprowadzono bledny klawisz");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
            }
        }

    }
}
