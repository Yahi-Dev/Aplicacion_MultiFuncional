using PracticaUno.Log;
using PracticaUno.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionConvertidoraTemperatura
{
    internal class ConvertidorKelvinFarenheit
    {
        public void KelvinFarenheit(string user)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                 KELVIN A FARENHEIT");
            Console.Write("\n \n \nDiga el grado de la temperatura: ");
            double kelvin = double.Parse(Console.ReadLine());
            double celsius = kelvin - 2713.15;
            double farenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"\n{user}, La temperatura en Farenheit es {farenheit}");
            Logger.Instance.Log(user, "Conversion de Kelvin a Farenheit", $"{kelvin} - 273.15 * 9/5 + 32", "K° " + farenheit.ToString());
            MenuRegresoTres menuRegresoTres = new MenuRegresoTres();
            menuRegresoTres.menuRegreso(user);
        }
    }
}
