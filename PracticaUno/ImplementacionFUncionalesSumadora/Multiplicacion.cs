using PracticaUno.Log;
using PracticaUno.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionFUncionales
{
    internal class Multiplicacion
    {
        public void Multiplicar(string user, int a, int b)
        {
            int opcion;
            int resultado = a * b;

            Console.WriteLine($"{user}, el resultado de su multiplicacion ({a} * {b}) es {resultado}");
            Logger.Instance.Log(user, "Multiplicacion", $"{a} * {b} ", resultado.ToString());
            MenuRegreso menu = new MenuRegreso();
            menu.menuRegreso(user);




        }
    }
}
