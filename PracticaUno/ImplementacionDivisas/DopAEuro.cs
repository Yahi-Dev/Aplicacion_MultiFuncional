using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionDivisas
{
    internal class DopAEuro
    {
        public void DopAEur(string user)
        {
            double tasaDeCambio = 0.0146;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                   VAS A CONVERTIR DE PESO DOMINICANO A EURO");
            Console.Write(" \n \n \nIngrese la cantidad de moneda DOP:");
            double Dop = Convert.ToDouble(Console.ReadLine());

            double euros = Dop * tasaDeCambio;

            Console.WriteLine($"{user}, la cantidad {Dop} de pesos dominicanos en euro es, EUR${euros}");
            Logger.Instance.Log(user, "Conversion de Peso Dominicano a Euro", $"{Dop} * {tasaDeCambio} ", "EUR$ " + euros.ToString());
            MenuRegresoDos menuRegresoDos = new MenuRegresoDos();
            menuRegresoDos.menuRegreso(user);
            Console.ResetColor();
        }
    }
}
