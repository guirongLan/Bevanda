using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevanda
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int Bevanda;
            double soldi, costo;
            while (true)
            {
                Console.WriteLine("scegli la bevanda");
                Console.WriteLine("1,2,3");
                Bevanda = Convert.ToInt32(Console.ReadLine());
                switch (Bevanda)//包含更多的可能性
                {
                    case 1:
                        {
                            costo = 1;
                        }
                         break;
                    case 2:
                        {
                            costo = 3;
                        }
                        break;
                    case 3:
                        {
                            costo = 2.5;
                        }
                        break;
                }
                Console.WriteLine("inseglisci soldi");
                soldi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Eroga");
                Console.WriteLine("il resto =" + soldi);
                Console.ReadKey()*/
            int Numero;
            double Soldi;
            double Prezzo1 = 0, Prezzo;
            double Resto;
            double Altro;
            while (true)
            {
                Console.WriteLine("Inserire un numero maggiore di 0 e minore o uguale a 10");
                Numero = Convert.ToInt32(Console.ReadLine());
                switch (Numero)
                {
                    case 1:
                        {
                            Console.WriteLine("Acqua");
                            Prezzo1 = 0.50;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Caffè");
                            Prezzo1 = 1.50;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Caffè all'Alpina");
                            Prezzo1 = 2.00;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Caffè per vegani");
                            Prezzo1 = 5.00;
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Caffè di Venezia");
                            Prezzo1 = 7.50;
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Cioccolata calda con il latte e panna");
                            Prezzo1 = 9.50;
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Tè caldo della estathè");
                            Prezzo1 = 12.00;
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Acqua con mela della Apple");
                            Prezzo1 = 20.00;
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Acqua calda");
                            Prezzo1 = 23.50;
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Acqua Benedetta");
                            Prezzo1 = 0.25;
                            break;
                        }
                    case 22:
                        {
                            Console.WriteLine("Gesù in polvere");
                            Prezzo1 = 22.22;
                            break;
                        }
                    default:
                        Console.WriteLine("Allora sei tardo se metti un numero o uguale a zero o maggiore di 10!");
                        Console.WriteLine("Ora mi tengo tutti i soldi MONA");
                        break;
                }
                Prezzo = Prezzo1;
                Console.WriteLine("Inserire " + Prezzo + " euro");
                Soldi = Convert.ToDouble(Console.ReadLine());
                Resto = Soldi - Prezzo;
                if (Resto == 0)
                {
                    Console.WriteLine("Non hai resto");
                }
                else if (Resto > 0)
                {
                    Resto = Soldi - Prezzo;
                    Console.WriteLine("Ecco il tuo resto " + Resto);
                }
                else
                {
                    Altro = Prezzo - Soldi;
                    while (Altro != 0)
                    {
                        Console.WriteLine("Devi mettere altri " + Altro + " euro");
                        Soldi = Convert.ToDouble(Console.ReadLine());
                        if (Altro == Soldi)
                        {
                            Console.WriteLine("Non hai resto");
                            Altro = 0;
                        }
                        else if (Altro > Soldi)
                        {
                            Altro = Altro - Soldi;
                            Console.WriteLine("Mancano ancora " + Altro + " euro");
                        }
                        else
                        {
                            Resto = Soldi - Altro;
                            Altro = 0;
                            Console.WriteLine("Il tuo resto è " + Resto + " euro");
                        }
                    }
                }
                Console.WriteLine("Erogazione della bevanda");
            }
        }

    }

}


