using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace DanteRewind
{
    public static class Core
    {
        public static bool IsSinner(this Pawn pawn)
        {
            Pawn master;
            return pawn.IsSinner(out master);
        }
        public static bool IsSinner(this Pawn pawn, out Pawn master)
        {
            if (pawn?.health?.hediffSet?.GetFirstHediffOfDef(Danteh_DefOf.SinnerPact) is Hediff_SinnerPact hediff_SinnerPact)
            {
                master = hediff_SinnerPact.master;
                return true;
            }
            master = null;
            return false;
        }
    }
}
