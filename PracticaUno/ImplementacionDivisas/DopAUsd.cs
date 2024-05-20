using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionDivisas
{
    internal class DopAUsd
    {
        public void ConvertidorDopAUsd(string user)
        {
            double tasaCambio = 0.0177;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                   VAS A CONVERTIR DE PESO DOMINICANO A DOLAR ");
            Console.Write("\n \n \nDigite la cantidad de moneda DOP: ");
            int monedaDop = int.Parse(Console.ReadLine());
            double dolares = monedaDop * tasaCambio;
            Console.WriteLine($" \n{user}, la cantidad de {monedaDop} DOP en dolar es, USD$:{dolares}");
            Logger.Instance.Log(user, "Conversion de Peso Dominicano a Dolar", $"{monedaDop} * {tasaCambio} ", "USD$"  + dolares.ToString());
            MenuRegresoDos menuRegresoDos = new MenuRegresoDos();
            menuRegresoDos.menuRegreso(user);
            Console.ResetColor();
        }
    }
}
