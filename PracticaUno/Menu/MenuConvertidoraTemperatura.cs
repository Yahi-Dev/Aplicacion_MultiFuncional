using PracticaUno.ImplementacionConvertidoraTemperatura;
using PracticaUno.ImplementacionDivisas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Menu
{
    internal class MenuConvertidoraTemperatura
    {
        public void MenuTemperatura(string user)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("                            CONVERTIDOR DE TEMPERATURA\n \n \n");
                Console.WriteLine("1- Celsisus a Farenheit \n2- Farenheit a Celsius \n3- Celsisus a Kelvin \n4- Kelvin a Celsius \n5- Farenheit a Kelvin \n6- Kelvin a Farenheit");
                Console.Write("\n \nElija su opcion: ");
                opcion = int.Parse(Console.ReadLine());
                ImplementacionMenuTemperaturacs implementacionMenu = new ImplementacionMenuTemperaturacs();
                implementacionMenu.menuTemperaturas(user, opcion);
            } while (opcion <= 0 || opcion >= 7);
        }
    }
}
