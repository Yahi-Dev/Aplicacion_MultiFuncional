using PracticaUno.Archivo_Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Implementacion_menu
{
    internal class InicioDeSesion
    {
        private List<UsuarioInformacion> usuariosRegistrados = new List<UsuarioInformacion>();
        public bool inicio(string UserName, string password)
        {

            usuariosRegistrados = GuardarDatos.DeserializeJsonFile();

            foreach (var usuario in usuariosRegistrados)
            {
                if (usuario.UserName == UserName && usuario.Password == password)
                {

                    Console.WriteLine("entro");
                    return true;
                }
            }

            return false;
        }
    }
}

