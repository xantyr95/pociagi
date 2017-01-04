using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Towarowy:Wagon
    {
        private string ladunek;
        public Towarowy(string model, int masa, string ladunek)
        {
            this.model = model;
            this.masa = masa;
            this.ladunek = ladunek;
        }
        public override string info()
        {
            return  "Model: " + model + ", masa: " + masa + ", ladunek: " + ladunek;
        }
    }
}
