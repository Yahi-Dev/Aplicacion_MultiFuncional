using PracticaUno.ImplementacionFUncionales;
using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionDivisas
{
    internal class EuroADop
    {
        public void EuroDop(string user)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            double tasaDeCambio = 68.50;
            Console.WriteLine("                   VAS A CONVERTIR DE EURO A PESO DOMINICANO ");
            Console.Write("\n \n \nIngrese la cantidad de monedas EUR: ");
            double euros = Convert.ToDouble(Console.ReadLine());

            double pesosDominicanos = euros * tasaDeCambio;

            Console.WriteLine($"{user}, la cantidad de {euros} euros a DOP, es DOP$:{pesosDominicanos}");
            Logger.Instance.Log(user, "Conversion de Euro a Peso Dominicano", $"{euros} * {tasaDeCambio} ", "DOP$ " + pesosDominicanos.ToString());
            MenuRegresoDos menuRegresoDos = new MenuRegresoDos();
            menuRegresoDos.menuRegreso(user);
            Console.ResetColor();
        }
    }
}
