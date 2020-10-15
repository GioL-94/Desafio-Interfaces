using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Boing747 : Aviones, Ivolador
    {
        int HorasV;

        public Boing747(int HorasV)
        {
            this.HorasV = HorasV;

        }

        public void volador()
        {
            for(int i = 0; i < HorasV; i+= 13) // HorasV es el máximo de horas de vuelo (para no tener un bucle infinito)
            {
                Console.WriteLine("Estoy volando como un avion...");
            }
        }
    }
}
