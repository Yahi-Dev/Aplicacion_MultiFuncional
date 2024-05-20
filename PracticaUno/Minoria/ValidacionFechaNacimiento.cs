using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PracticaUno.Minoria
{
    public class ValidacionFechaNacimiento
    {
        public void ValidarNacimiento()
        {
            DateTime fe;
            bool fechaValida = false;
            UsuarioInformacion date = new UsuarioInformacion();
            fe = date.DateOfBirth;
            while (!fechaValida)
            {
                Console.WriteLine("Diga la fecha de su nacimiento (dd/mm/yyyy): ");
                string fecha = Console.ReadLine();
                if (DateTime.TryParse(fecha, out fe))
                {
                    fechaValida = true;
                }
                else
                {
                    Console.WriteLine("Digite la fecha en el formato (dd/mm/yyyy) ");
                }
            }
            date.DateOfBirth = fe;
        }
    }
}
