using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_OOVerden_Bestik
{
    internal class Gaffel : Bestik
    {
        private int AntalTænder { get; set; }

        public Gaffel(int størrelse, string materiale, string håndtag, int antaltænder) : base(størrelse, materiale, håndtag)
        {
            AntalTænder = antaltænder;
        }

        public void Stikke(string mad)
        {
            Console.WriteLine("Så er " + mad + " på gaflen.");
            TagetIBrug();
        }
        
        public override void Info()
        {
            Console.WriteLine("Gaffel med størrelse " + Størrelse + "cm lavet af " + Materiale + " med et håndtag af " + Håndtag + " og med " + AntalTænder + " antal tænder. " + (Rent ? "Den er ren." : "Den er beskidt"));
        }
    }
}
