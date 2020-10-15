using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Pato : Animales, Ivolador
    {
        int Energia;

        public Pato(int Energia)
        {
            this.Energia = Energia;
        }

        public void volador()
        {
            for(int i = 0; i <= Energia; i += 5)
            {
                Console.WriteLine("Estoy volando como un pato... ¡Cuak!");
                Energia -= 5;
                if(Energia == 0)
                {
                    Console.WriteLine("No tengo más energía... ¡Cuak!");
                }
            }
        }
    }
}
