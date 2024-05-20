using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionConvertidoraTemperatura
{
    internal class ConvertidorFarenheitKelvin
    {
        public void FarenheitKelvin(string user)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                  FARENHEIT A KELVIN");
            Console.Write("\n \n \nDiga el grado de la temperatura: ");
            double Farenheit = double.Parse(Console.ReadLine());
            double celsius = (Farenheit - 32) * 5 / 9;
            double kelvin = celsius + 273.15;
            Console.WriteLine($"\n{user}La temperatura en Kelvin es {kelvin}");
            Logger.Instance.Log(user, "Conversion de Farenheit a Kelvin", $"({Farenheit} - 32) * 5 /9 + 273.15", "K° " + kelvin.ToString());
            MenuRegresoTres menuRegresoTres = new MenuRegresoTres();
            menuRegresoTres.menuRegreso(user);
        }
    }
}
