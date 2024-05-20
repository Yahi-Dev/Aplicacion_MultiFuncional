using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionConvertidoraTemperatura
{
    internal class ConvertidorFarenheitCelsius
    {
        public void FarenheitCelsius(string user) 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                  FARENHEIT A CELSIUS");
            Console.Write("\n \n \nDiga el grado de la temperatura: ");
            double Farenheit = double.Parse(Console.ReadLine());
            double celsius = (Farenheit - 32) * 5/9;
            Console.WriteLine($"\n{user}, La temperatura en Celsius es {celsius}");
            Logger.Instance.Log(user, "Conversion de Farenheit a Celsius", $"({Farenheit} - 32) * 5/9", "C° " + celsius.ToString());
            MenuRegresoTres menuRegresoTres = new MenuRegresoTres();
            menuRegresoTres.menuRegreso(user);
        }
    }
}
