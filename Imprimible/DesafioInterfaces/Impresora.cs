using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Impresora
    {
        List<Iimprimible> imprimibles = new List<Iimprimible>();


        public void ImprimirTodo()
        {
            foreach(Iimprimible i in imprimibles)
            {
                i.Imprimir();
            }
        }

        public void AgregarImprimible(Iimprimible unImprimible)
        {
            imprimibles.Add(unImprimible);
        }
    }
}
