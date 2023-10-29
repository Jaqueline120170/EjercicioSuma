using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSuma.Servicios
{
    internal class SumaImplementacion : SumaInterfaz
    {
        public int hacerSuma(int numero)
        {
            int suma = 0;

            for(int i = 1; i <= numero; i++)
            {
                suma += i;
            }

            return suma;
        }
    }
}
