using PracticaUno.ImplementacionFUncionales;
using PracticaUno.Log;
using PracticaUno.Menu;
using PracticaUno.ProgramaEnEjecucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Implementacion_menu
{
    internal class FuncionMenuPrincipal
    {
        public void menuPrincipal(string user, int opcion)
        {
            Console.Clear();

            switch (opcion) 
            {
                case 1:
                    MenuSumadora menu = new MenuSumadora();
                    menu.menuSumadora(user);
                    break;

                case 2:
                    MenuConvertidorDeDivisas convertidorDeDivisas = new MenuConvertidorDeDivisas();
                    convertidorDeDivisas.menuConvertidorDivisas(user);
                    break;

                case 3:
                    MenuConvertidoraTemperatura menuConvertidoraTemperatura = new MenuConvertidoraTemperatura();
                    menuConvertidoraTemperatura.MenuTemperatura(user);
                    break;

                    case 4:
                    VerLog verLog = new VerLog(Program.TxtLog);
                    verLog.DesplegarLog();
                    break;

                    case 5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Adios {user}:)");
                    Console.ResetColor();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR!!! - xxxx ELIJA UNA OPCION DENTRO DEL RANGO DE 1 HASTA 4 xxxx ");
                    Console.ResetColor();

                    break;
            }
        }
    }
}
