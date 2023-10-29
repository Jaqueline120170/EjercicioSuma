using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSuma.Servicios
{
    internal class MenuImplementación : MenuInterfaz
    {
        public int pedirNumero()
        {
            Console.WriteLine("Indique el número que desee: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El número seleccionado es el: " + numero);

            return numero;
        }
    }
}
