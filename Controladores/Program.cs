using EjercicioSuma.Servicios;

namespace EjercicioSuma.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementación();
            SumaInterfaz si = new SumaImplementacion();

            int numero = mi.pedirNumero();

            int suma = si.hacerSuma(numero);

            Console.WriteLine("El resultado de la suma es: " + suma);
        }
    }
}