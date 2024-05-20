using Microsoft.VisualBasic;
using PracticaUno.Archivo_Json;
using PracticaUno.Menu;
using PracticaUno.Minoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno.Implementacion_menu
{
    internal class InicioYRegistro
    {
        private List<UsuarioInformacion> usuariosRegistrados = new List<UsuarioInformacion>();
        public void InicioRegistro(int opcion) 
        {

                switch (opcion)
                {
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("                    ESTOS CAMPOS REQUERIRAN DE LA INFORMACION PUESTA AL REGISTRARSE \n \n");
                        Console.Write("                        DIGITE LA INFORMACION CORRESPONDIENTES A LOS CAMPOS REQUERIDOS \n \n");
                        Console.Write("USERNAME: ");
                        string user = Console.ReadLine()!;
                        Console.Write("\nPassword: ");
                        string password = Console.ReadLine()!;
                    Console.ResetColor();
                        usuariosRegistrados = GuardarDatos.DeserializeJsonFile();
                        InicioDeSesion iniciarSesion = new InicioDeSesion();
                        
                        if (iniciarSesion.inicio(user, password))
                        {
                          MenuPrincipal menu = new MenuPrincipal();
                          menu.Menu(user);
                        }

                    break;

                    case 2:
                       Console.Clear();

                        UsuarioInformacion info = new UsuarioInformacion();

                        Console.Write("REGISTRO\n \n");

                        Console.Write("Name: ");
                        info.Name = Console.ReadLine()!;

                        Console.Write("\n  last Name: ");
                        info.LastName = Console.ReadLine()!;

                        Console.Write("\n       User Name: ");
                        info.UserName = Console.ReadLine()!;

                        Console.Write("\n            EmailAddress: ");
                        info.MailAddress = Console.ReadLine()!;

                        Console.Write("\n                  Password: ");
                        info.Password = Console.ReadLine()!;

                       Console.Write("\n                        NumberPhone: ");
                       info.PhoneNumber = Console.ReadLine()!;

                        Console.Write("\n                               Date of Birth: ");
                        ValidacionFechaNacimiento validacion = new ValidacionFechaNacimiento();
                        validacion.ValidarNacimiento();

                        usuariosRegistrados = GuardarDatos.DeserializeJsonFile();
                        usuariosRegistrados.Add(info);

                        Console.Clear() ;
                    Console.WriteLine("Registro exitoso!!!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MenuIniciarSesionYRegistrarse menuInicioYRegistro = new MenuIniciarSesionYRegistrarse();

                    //GuardarDatos.GetUsuarioInformacions(info.Name, info.LastName, info.UserName, info.MailAddress, info.Password, info.DateOfBirth, nameYPhone.NamePhone, nameYPhone.PhoneNumber);
                    GuardarDatos.SerializeJsonFile(usuariosRegistrados);
                    menuInicioYRegistro.IniciarSesionORegistrarse();
                        break;

                    default:
                    Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("!! Elija una opcion entre 1 y 2. XXXX ");
                        Console.ResetColor();
                        break;

                }
        }
    }
}
