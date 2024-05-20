using PracticaUno.Implementacion_menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Menu
{
    internal class MenuPrincipal
    {
        public void Menu(string user)
        {
            int opcion;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("!!!INICIO DE SESION EXITOSO!!!");
            Thread.Sleep(3000);
            Console.Clear();
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                   MENU \n \n \n \n1- Sumadora \n2- Convertidor de Divisas \n3- Convertidora de Temperatura \n4- Historial de la App \n5- Salir ");
                Console.Write("\n \nElija su opcion aqui: ");
                opcion = int.Parse(Console.ReadLine()!);
                FuncionMenuPrincipal funcionMenuPrincipal = new FuncionMenuPrincipal();
                funcionMenuPrincipal.menuPrincipal(user, opcion);
            } while (opcion <= 0 || opcion >= 6);
        
        }
    }
}
