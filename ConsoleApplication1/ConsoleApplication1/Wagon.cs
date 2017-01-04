using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Wagon
    {
        protected string model;
        protected int masa;
        public abstract string info();
        public int zmasa()
        {
            return masa;
        }
    }
}
