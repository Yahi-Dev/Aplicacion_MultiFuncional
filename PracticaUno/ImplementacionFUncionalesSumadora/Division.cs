using PracticaUno.ImplementacionFUncionales;
using PracticaUno.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionFUncionalesSumadora
{
    internal class Division
    {
        public void dividir(string user, int a, int b)
        {
            int opcion;
            int resultado = a / b;

            Console.WriteLine($"{user}, el resultado de su division ({a}/{b}) es {resultado}");
            Logger.Instance.Log(user, "Division", $"{a}/{b} ", resultado.ToString());
            MenuRegreso menu = new MenuRegreso();
            menu.menuRegreso(user);
        }
    }
}
