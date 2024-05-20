using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PracticaUno.ProgramaEnEjecucion;

namespace PracticaUno.Archivo_Json
{
    public class GuardarDatos
    {
        //public static string JsonPath = @"Descargas\Informacion.json";
        public static void SerializeJsonFile(List<UsuarioInformacion> informacion)
        {
            string informacionJson = JsonConvert.SerializeObject(informacion.ToArray(), Formatting.Indented);
            File.WriteAllText(Program.JsonPath , informacionJson);
        }
        public static List<UsuarioInformacion> GetUsuarioInformacions(string Nombre, string Apellido,string UsuarioNombre, string Correo, string Contraseña, DateTime FechaDeNacimiento,string NumeroTelefono)
        {
            List<UsuarioInformacion> informacion = new List<UsuarioInformacion> { 

                new UsuarioInformacion
                {
                    Name = Nombre,
                    LastName = Apellido,
                    UserName = UsuarioNombre,
                    MailAddress = Correo,
                    Password = Contraseña, 
                    DateOfBirth = FechaDeNacimiento,
                    PhoneNumber = NumeroTelefono,
                }
            };

            return informacion;
        }

        public static string GetInformacionRegistro()
        {
            string Informacionregistro;
            using(var reader = new StreamReader(Program.JsonPath))
            {
                Informacionregistro = reader.ReadToEnd();
            }
            return Informacionregistro;
        }

        public static List<UsuarioInformacion> DeserializeJsonFile()
        {
            try
            {
                string jsonText = File.ReadAllText(Program.JsonPath);
                List<UsuarioInformacion> usuarios = JsonConvert.DeserializeObject<List<UsuarioInformacion>>(jsonText);
                return usuarios;
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error al cargar los usuarios registrados: " + ex.Message);
                return new List<UsuarioInformacion>();
            }
        }
    }
}