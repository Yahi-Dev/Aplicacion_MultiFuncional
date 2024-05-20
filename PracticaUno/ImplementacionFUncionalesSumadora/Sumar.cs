using PracticaUno.Implementacion_menu;
using PracticaUno.Log;
using PracticaUno.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionFUncionales
{
    internal class Sumar
    {
        public void suma(string user, int a, int b)
        {
            int opcion;
            int resultado = a + b;
            
                Console.WriteLine($"{user}, el resultado de su suma ({a} + {b}) es {resultado}");
            Logger.Instance.Log(user, "Suma", $"{a} + {b} ", resultado.ToString());
                MenuRegreso menu = new MenuRegreso();
            menu.menuRegreso(user);
        }
    }
}
