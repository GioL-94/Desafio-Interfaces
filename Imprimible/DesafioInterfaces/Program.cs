using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato c = new Contrato();
            Foto f = new Foto();
            Documento doc = new Documento();

            Impresora print = new Impresora();

            print.AgregarImprimible(doc);
            print.AgregarImprimible(f);
            print.AgregarImprimible(c);

            print.ImprimirTodo();

        }
    }
}
