using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace DanteRewind
{
    [DefOf]
    public static class Danteh_DefOf
    {
        public static GeneDef DantehPact;
        public static HediffDef SinnerPact;
        static Danteh_DefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(Danteh_DefOf));
        }
    }

   
}
