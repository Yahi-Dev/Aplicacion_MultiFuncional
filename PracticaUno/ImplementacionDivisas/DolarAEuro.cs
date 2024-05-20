using PracticaUno.ImplementacionFUncionales;
using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionDivisas
{
    internal class DolarAEuro
    {
        public void USDAEUR(string user)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            double tasaDeCambio = 0.85;
            Console.WriteLine("                   VAS A CONVERTIR DE DOLAR A EURO ");
            Console.Write("\n \n \nIngrese la cantidad de moneda USD:");
            double dolares = Convert.ToDouble(Console.ReadLine());

            double euros = dolares * tasaDeCambio;

            Console.WriteLine($"{user}, la cantidad {dolares} dolares en euro es, EUR${euros}");
            Logger.Instance.Log(user, "Conversion de dolar a euro", $"{dolares} * {tasaDeCambio} ", "EUR$ " + euros.ToString());
            MenuRegresoDos menuRegresoDos = new MenuRegresoDos();
            menuRegresoDos.menuRegreso(user);
            Console.ResetColor();
        }
    }
}
