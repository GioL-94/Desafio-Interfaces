using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class SuperMan : SuperHeroes, Ivolador
    {
        int Experiencia;

        public SuperMan(int Experiencia)
        {
            this.Experiencia = Experiencia;
        }

        public void volador()
        {
            for(int i = 0; i < Experiencia; i += 3)
            {
                Console.WriteLine("Estoy volando como un campeón");
            }

        }
    }
}
