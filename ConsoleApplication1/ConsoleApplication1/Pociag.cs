using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pociag : IPoprawnyPociag, IUzupelnijSklad
    {
        private List<Wagon> Wagony;
        private List<Lokomotywa> Lokomotywy;


        public Pociag()
        {
            Wagony = new List<Wagon>();
            Lokomotywy = new List<Lokomotywa>();
        }

        public void DodajOsobowy(string model, int masa, string rodzaj)
        {
            Wagony.Add(new Osobowy(model, masa, rodzaj));
        }

        public void DodajTowarowy(string model, int masa, string ladunek)
        {
            Wagony.Add(new Towarowy(model, masa, ladunek));
        }

        public void DodajLokomotywe(string model, int masa)
        {
            Lokomotywy.Add(new Lokomotywa(model, masa));
        }

        public bool MozeJechac()
        {
            int mLokomotyw = 0;
            int mWagonow = 0;

            foreach (var element in Lokomotywy)
            {
                mLokomotyw = mLokomotyw + element.zmasa();
            }

            foreach (var element in Wagony)
            {
                mWagonow = mWagonow + element.zmasa();
            }

            if (mLokomotyw >= mWagonow)
            {
                Console.WriteLine("Skład może jechać!");
                return true;
            }
            else if (mLokomotyw == 0 && mWagonow == 0)
            {
                Console.WriteLine("Skład nie może jechać!");
                return false;
            }
            else
            {
                Console.WriteLine("Skład nie może jechać!");
                return false;
            }
        }

        public string Informacja()
        {
            Console.WriteLine("Skład pociągu: \n");
            foreach (var element in Lokomotywy)
            {
                Console.WriteLine("Lokomotywa: {0}", element.info());
            }
            foreach (var element in Wagony)
            {
                Console.WriteLine("Wagon: {0}", element.info());
            }

            if (Lokomotywy.Count == 0 && Wagony.Count == 0)
            {
                Console.WriteLine("Nie ma lokomotywy i nie ma wagonu \n");
            }

            else if (Lokomotywy.Count == 0)
            {
                Console.WriteLine("Skład nie posiada lokomotywy \n");
            }

            else if (Wagony.Count == 0)
            {
                Console.WriteLine("Skład nie posiada wagonu \n");
            }

            return "";
        }
    }
}
