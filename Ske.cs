using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_OOVerden_Bestik
{
    internal class Ske : Bestik
    {

        public Ske(int størrelse, string materiale, string håndtag) : base(størrelse, materiale, håndtag) 
        { 
        
        }

        public void Øse(string mad)
        {
            Console.WriteLine("Så er " + mad + " på skeen.");
            TagetIBrug();
        }

        public override void Info()
        {
            Console.WriteLine("Ske med størrelse " + Størrelse + "cm lavet af " + Materiale + " med et håndtag af " + Håndtag + ". " + (Rent ? "Den er ren." : "Den er beskidt."));
        }
    }
}
