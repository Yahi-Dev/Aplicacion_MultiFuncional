using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionConvertidoraTemperatura
{
    internal class ConvertidorCelsiusKelvin
    {
        public void CelciusKelvin(string user)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                 CELSIUS A KELVIN");
            Console.Write("\n \n \nDiga el grado de la temperatura: ");
            double celcius = double.Parse(Console.ReadLine());
             double kelvin = celcius + 273.15;
            Console.WriteLine($"\n{user}, La temperatura en Kelvin es {kelvin}");
            Logger.Instance.Log(user, "Conversion de Celsius a Kelvin", $"{celcius} + 273.15", "K° " + kelvin.ToString());
            MenuRegresoTres menuRegresoTres = new MenuRegresoTres();
            menuRegresoTres.menuRegreso(user);
        }
    }
}
