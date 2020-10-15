using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Program
    {
        static void Main(string[] args)
        {

            Pato p = new Pato(10);
            Boing747 bng = new Boing747(26);
            SuperMan sm = new SuperMan(9);
            TorreDeControl tdc = new TorreDeControl();
            tdc.AgregarVolador(p);
            tdc.AgregarVolador(bng);
            tdc.AgregarVolador(sm);

            tdc.VuelenTodos();

        }
    }
}
