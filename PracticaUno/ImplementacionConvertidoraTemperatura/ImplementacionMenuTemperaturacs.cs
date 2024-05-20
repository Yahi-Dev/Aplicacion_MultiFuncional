using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionConvertidoraTemperatura
{
    internal class ImplementacionMenuTemperaturacs
    {
        public void menuTemperaturas(string user, int opcion)
        {
            switch (opcion) 
            {
                case 1:
                    ConvertidorCelsiusAFarenheit convertidorCelsiusAFarenheit = new ConvertidorCelsiusAFarenheit();
                    convertidorCelsiusAFarenheit.CelsiusAFarenheit(user);
                    break;
                case 2:
                    ConvertidorFarenheitCelsius convertidorFarenheitCelsius = new ConvertidorFarenheitCelsius();
                    convertidorFarenheitCelsius.FarenheitCelsius(user);
                    break;
                case 3:
                    ConvertidorCelsiusKelvin convertidorCelsiusKelvin = new ConvertidorCelsiusKelvin();
                    convertidorCelsiusKelvin.CelciusKelvin(user);
                    break;
                case 4:
                    ConvertidorKelvinCelsius convertidorKelvinCelsius = new ConvertidorKelvinCelsius();
                    convertidorKelvinCelsius.KelvinCelsius(user);
                    break;
                case 5:
                    ConvertidorFarenheitKelvin convertidor = new ConvertidorFarenheitKelvin();
                    convertidor.FarenheitKelvin(user);
                    break;
                case 6:
                    ConvertidorKelvinFarenheit convertidor1 = new ConvertidorKelvinFarenheit();
                    convertidor1.KelvinFarenheit(user);
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR!!! - xxxx ELIJA UNA OPCION DENTRO DEL RANGO DE 1 HASTA 6 xxxx ");
                    Console.ResetColor(); Console.WriteLine("");
                    break;
            }
        }
    }
}
