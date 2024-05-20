using PracticaUno.ImplementacionDivisas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Menu
{
    internal class MenuConvertidorDeDivisas
    {
        public void menuConvertidorDivisas(string user)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("                            CONVERTIDOR DE DIVISAS \n \n \n");
                Console.WriteLine("1- EUR/USD \n2- USD/EUR \n3- EUR/DOP \n4- DOP/EUR \n5- USD/DOP \n6- DOP/USD");

                Console.Write("\n \nElija su opcion: ");
                opcion = int.Parse(Console.ReadLine());
                ImplementacionMenuDivisas menuDivisas = new ImplementacionMenuDivisas();
                menuDivisas.MenuDivisas(user, opcion);
            } while (opcion <= 0 || opcion >= 7);
        }
    }
}
