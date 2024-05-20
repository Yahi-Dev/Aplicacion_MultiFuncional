using PracticaUno.ImplementacionFUncionales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Menu
{
    internal class MenuSumadora
    {
        public void menuSumadora(string user)
        {
            int opcionCal;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("                              CALCULADORA \n \n \n1- Sumar \n2- Restar \n3- Multiplicar \n4- Dividir");
                Console.Write("\n \nElija una opcion: ");
                 opcionCal = int.Parse(Console.ReadLine());
                ResolverSumadora cal = new ResolverSumadora();
                cal.calculadora(user, opcionCal);
                Console.ResetColor();
            } while (opcionCal <= 0 || opcionCal >= 5);
        }
    }
}
