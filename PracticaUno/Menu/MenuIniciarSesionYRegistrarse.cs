using PracticaUno.Implementacion_menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Menu
{
    internal class MenuIniciarSesionYRegistrarse
    {
        public void IniciarSesionORegistrarse()
        {
            InicioYRegistro InicioApp = new InicioYRegistro();
            int opcion;
            do
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"     ___      .______   .______   
    /   \     |   _  \  |   _  \  
   /  ^  \    |  |_)  | |  |_)  | 
  /  /_\  \   |   ___/  |   ___/  
 /  _____  \  |  |      |  |      
/__/     \__\ | _|      | _|  ");

                Console.WriteLine("\n \n \n1- Iniciar Sesion\n");
                Console.WriteLine("2- Registrarse");

                Console.Write("\n Elija su opcion: ");

                Console.ResetColor();
                try{
                
                
                
                
                opcion = int.Parse(Console.ReadLine()!);
                }catch(Exception ex)
                {
                    opcion = 4;
                }
                InicioApp.InicioRegistro(opcion);
            }while (opcion >= 3 || opcion <= 0);
        }
    }
}
