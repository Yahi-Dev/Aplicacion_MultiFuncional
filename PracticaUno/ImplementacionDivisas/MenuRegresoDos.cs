using PracticaUno.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionDivisas
{
    internal class MenuRegresoDos
    {
        public void menuRegreso(string user)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n \n \n¿Desea volver al Menu principal o Convertidor Divisa");
                Console.WriteLine("1- Menu Principal");
                Console.WriteLine("2- Menu Divisa");
                Console.Write("\nElija: su opcion 1 0 2: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Menu(user);
                }
                if (opcion == 2)
                {
                    MenuConvertidorDeDivisas convertidorDeDivisas = new MenuConvertidorDeDivisas();
                    convertidorDeDivisas.menuConvertidorDivisas(user);
                }
            } while (opcion <= 0 || opcion >= 3);

        }
    }
}
