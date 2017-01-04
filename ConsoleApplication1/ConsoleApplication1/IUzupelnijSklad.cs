using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IUzupelnijSklad
    {
        void DodajOsobowy(string model, int masa, string rodzaj);
        void DodajTowarowy(string model, int masa, string ladunek);
        void DodajLokomotywe(string model, int masa);
    }
}
