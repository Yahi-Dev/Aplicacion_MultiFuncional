using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionDivisas
{
    internal class ImplementacionMenuDivisas
    {
        public void MenuDivisas(string user, int opcion)
        {

            switch (opcion) 
            {
                    case 1:
                    EuroADolar euroADolar = new EuroADolar();
                    euroADolar.ConvertidorEURaUSD(user);
                    break;

                    case 2:
                    DolarAEuro dolarAEuro = new DolarAEuro();
                    dolarAEuro.USDAEUR(user);
                    break;

                    case 3:
                    EuroADop euroADop = new EuroADop();
                    euroADop.EuroDop(user);
                    break;

                    case 4:
                    DopAEuro dopAEuro = new DopAEuro();
                    dopAEuro.DopAEur(user);
                    break;

                    case 5:
                    UsdADop usdADop = new UsdADop();
                    usdADop.UsdADOp(user);
                    break;

                    case 6:
                    DopAUsd dopAUsd = new DopAUsd();
                    dopAUsd.ConvertidorDopAUsd(user);
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
