using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Lokomotywa
    {
        private string model;
        private int masa;
        public Lokomotywa(string model, int masa)
        {
            this.model = model;
            this.masa = masa;
        }
        public int zmasa()
        {
            return masa;
        }
        public string info()
        {
            return "Model: " + model + ", masa: " + masa;
        }
    }
}

