using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int imenilac;
            bool imenilacOK =true;

            do
            {
                Console.Write("Unesite imenilac: ");
                imenilacOK = Int32.TryParse(Console.ReadLine(), out imenilac);
            }
            while (!imenilacOK || imenilac==0);
            Console.Write("Imenilac: {0}", imenilac);
            Console.WriteLine();
            //-------------------------------------------------------------------------
            //-------------------------------------------------------------------------

            int brojilac;
            bool brojilacOK = true;

            do
            {
                Console.Write("Unesite brojilac: ");
                brojilacOK = Int32.TryParse(Console.ReadLine(), out brojilac);
            }
            while (!brojilacOK);
            Console.Write("Brojilac: {0}", brojilac);
            Console.WriteLine();
            //-------------------------------------------------------------------------
            //-------------------------------------------------------------------------

            Console.Write("Rezultat deljenja je: {0}", (float)brojilac / imenilac);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
