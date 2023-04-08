using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_OOVerden_Bestik
{
    internal class Kniv : Bestik
    {
        private bool GrillKniv { get; set; }

        public Kniv(int størrelse, string materiale, string håndtag, bool grillkniv) : base(størrelse, materiale, håndtag)
        {
            GrillKniv = grillkniv;
        }

        public void Skære(string mad)
        {
            Console.WriteLine("Så er " + mad + " skåret");
            TagetIBrug();
        }

        public override void Info()
        {
            Console.WriteLine("Kniv med størrelse " + Størrelse + "cm lavet af " + Materiale + " med et håndtag af " + Håndtag + ". " + (GrillKniv ? "Den er med grilltænder. " : "Den er uden grilltænder. ") + (Rent ? "Den er ren." : "Den er beskidt."));
        }
    }
}
