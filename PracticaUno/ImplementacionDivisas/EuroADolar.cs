using PracticaUno.ImplementacionFUncionales;
using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionDivisas
{
    internal class EuroADolar
    {

        public void ConvertidorEURaUSD(string user)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            double tasaCambio = 1.18;
            Console.WriteLine("                   VAS A CONVERTIR DE EURO A DOLAR ");
            Console.Write("\n \n \nDigite la cantidad de moneda EUR: ");
            int moneda = int.Parse(Console.ReadLine());
            double dolares = tasaCambio * moneda;
            Console.WriteLine($" \n{user}, la cantidad de {moneda} euro en dolar es, USD$:{dolares}");
            Logger.Instance.Log(user, "Conversion de Euro a Dolar", $"{moneda} * {tasaCambio} ", "USD$ " + dolares.ToString());
            MenuRegresoDos menuRegresoDos = new MenuRegresoDos();
            menuRegresoDos.menuRegreso(user);
            Console.ResetColor();
        }
    }
}
