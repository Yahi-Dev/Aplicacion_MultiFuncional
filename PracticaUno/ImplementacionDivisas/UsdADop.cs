using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionDivisas
{
    internal class UsdADop
    {
        public void UsdADOp(string user)
        {
            double tasaDeCambio = 56.50;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                   VAS A CONVERTIR DE DOLAR A PESO DOMINICANO");
            Console.Write("\n \n \nIngrese la cantidad de moneda USD:");
            double dolares = Convert.ToDouble(Console.ReadLine());

            double Dop = dolares * tasaDeCambio;

            Console.WriteLine($"{user}, la cantidad {dolares} dolares en peso dominicanos es, DOP${Dop}");
            Logger.Instance.Log(user, "Conversion de Dolar a Peso Dominicano", $"{dolares} * {tasaDeCambio} ", "DOP$ " + Dop.ToString());
            MenuRegresoDos menuRegresoDos = new MenuRegresoDos();
            menuRegresoDos.menuRegreso(user);
            Console.ResetColor();
        }
    }
}
