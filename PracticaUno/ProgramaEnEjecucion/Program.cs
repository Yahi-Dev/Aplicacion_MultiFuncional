using PracticaUno.Implementacion_menu;
using PracticaUno.Menu;
using PracticaUno.Minoria;

namespace PracticaUno.ProgramaEnEjecucion
{
    internal static class Program
    {
        public static string JsonPath = @"Descargas\Informacion.json";
        public static string TxtLog = @"Descargas\Info.txt";
        static void Main(string[] args)
        {
            if (!Directory.Exists("Descargas"))
            {
                Directory.CreateDirectory("Descargas");
            }

            if (!File.Exists(JsonPath))
                File.CreateText(JsonPath);

            if (!File.Exists(TxtLog))
                File.CreateText(TxtLog);


            MenuIniciarSesionYRegistrarse InicioApp = new MenuIniciarSesionYRegistrarse();
            InicioApp.IniciarSesionORegistrarse();

        }
    }
}