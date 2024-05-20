using PracticaUno.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionConvertidoraTemperatura
{
    internal class MenuRegresoTres
    {
        public void menuRegreso(string user)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n \n \n¿Desea volver al Menu principal o al Convertidor de temperatura?");
                Console.WriteLine("1- Menu Principal");
                Console.WriteLine("2- Menu Convertidor de temperaturas");
                Console.Write("\nElija: su opcion 1 0 2: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Menu(user);
                }
                if (opcion == 2)
                {
                    MenuConvertidoraTemperatura menuConvertidoraTemperatura = new MenuConvertidoraTemperatura();
                    menuConvertidoraTemperatura.MenuTemperatura(user);
                }
            } while (opcion <= 0 || opcion >= 3);

        }
    }
}
