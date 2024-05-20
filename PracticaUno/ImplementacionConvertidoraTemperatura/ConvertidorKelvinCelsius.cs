using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionConvertidoraTemperatura
{
    internal class ConvertidorKelvinCelsius
    {
        public void KelvinCelsius(string user)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("                                 KELVIN A CELSIUS");
            Console.Write("\n \n \nDiga el grado de la temperatura: ");
            double kelvin = double.Parse(Console.ReadLine());
            double celcius = kelvin - 273.15;
            Console.WriteLine($"\n{user}, La temperatura en Celsius es {celcius}");
            Logger.Instance.Log(user, "Conversion de Kelvin a Celsius", $"{kelvin} - 273.15", "C° " + celcius.ToString());
            MenuRegresoTres menuRegresoTres = new MenuRegresoTres();
            menuRegresoTres.menuRegreso(user);
        }
    }
}
