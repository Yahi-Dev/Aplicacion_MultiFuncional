using PracticaUno.Implementacion_menu;
using PracticaUno.ImplementacionFUncionalesSumadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.ImplementacionFUncionales
{
    internal class ResolverSumadora
    {
        public void calculadora(string user, int opcion)
        {
            switch (opcion) 
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                                   SUMADORA");
                    Console.Write("\n \n\nDigite el primer numero: ");
                    int primerDigitoSuma = int .Parse(Console.ReadLine());
                    Console.Write("Digite el segundo digito: ");
                    int segundoDigitoSuma = int.Parse(Console.ReadLine());
                    Sumar suma = new Sumar(); ;
                    suma.suma(user, primerDigitoSuma,segundoDigitoSuma);
                    Console.ResetColor();
                    break;

                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                                        RESTA");
                    Console.Write("\n \n\nDigite el primer numero: ");
                    int primerDigitoResta = int.Parse(Console.ReadLine());
                    Console.Write("Digite el segundo digito: ");
                    int segundoDigitoResta = int.Parse(Console.ReadLine());
                    Resta restar = new Resta();
                    restar.resta(user, primerDigitoResta, segundoDigitoResta);
                    Console.ResetColor();
                    break;

                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                                        MULTIPLICACION");
                    Console.Write("\n \n\nDigite el primer numero: ");
                    int primerDigitoMul= int.Parse(Console.ReadLine());
                    Console.Write("Digite el segundo digito: ");
                    int segundoDigitoMul = int.Parse(Console.ReadLine());
                    Multiplicacion multiplicacion = new Multiplicacion();
                    multiplicacion.Multiplicar(user, primerDigitoMul, segundoDigitoMul);
                    break;

                    case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                                      DIVISION");
                    Console.Write("\n \nDigite el primer numero:");
                    int primerDigitoDiv = int.Parse(Console.ReadLine());
                    Console.Write("\n \nDigite el segundo numero:");
                    int segundoDigitoDiv = int.Parse(Console.ReadLine());
                    Division division = new Division();
                    division.dividir(user, primerDigitoDiv, segundoDigitoDiv);
                    break;

                    default :
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR!!! - xxxx ELIJA UNA OPCION DENTRO DEL RANGO DE 1 HASTA 4 xxxx ");
                    Console.ResetColor(); Console.WriteLine("");
                        break;
            }
            
        }
    }
}
