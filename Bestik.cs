using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_OOVerden_Bestik
{
    internal abstract class Bestik
    {
        protected int Størrelse { get; set; }
        protected string Materiale { get; set; }
        protected string Håndtag { get; set; }
        protected bool Rent { get; set; }

        public Bestik(int størrelse, string materiale, string håndtag)
        {
            Størrelse = størrelse;
            Materiale = materiale;
            Håndtag = håndtag;
            Rent = true; // Det er rent fra start
        }

        public void TagetIBrug()
        {
            Rent = false;
        }

        public void Vasket()
        {
            Console.WriteLine($"Så blev {GetType().Name.ToLower()} vasket.");
            Rent = true;
        }

        public abstract void Info();

    }
}
