using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionConvertidoraTemperatura
{
    internal class ConvertidorCelsiusAFarenheit
    {
        public void CelsiusAFarenheit(string user)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                 CELSIUS A FARENHEIT");
            Console.Write("\n \n \nDiga el grado de la temperatura: ");
            double celsius = double.Parse(Console.ReadLine());
            double farenheit = (celsius * 9/5) + 32 ;
            Console.WriteLine($"\n{user}, La temperatura en Farentheit es {farenheit}");
            Logger.Instance.Log(user, "Conversion de Celsius a Farenheit", $"({celsius} * 9/5) + 32", "F° " + farenheit.ToString());
            MenuRegresoTres menuRegresoTres = new MenuRegresoTres();
            menuRegresoTres.menuRegreso(user);
        } 
    }
}
