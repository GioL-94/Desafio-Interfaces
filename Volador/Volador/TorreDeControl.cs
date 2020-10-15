using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class TorreDeControl
    {
        List<Ivolador> voladores = new List<Ivolador>();
        public void VuelenTodos()
        {
            foreach(Ivolador iv in voladores)
            {
                iv.volador();
            }
        }

        public void AgregarVolador(Ivolador unVolador)
        {
            voladores.Add(unVolador);
        }
    }
}
