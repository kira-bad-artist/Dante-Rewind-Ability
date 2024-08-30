using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuntimeAudioClipLoader;
using Verse;

namespace DanteRewind
{
    public class Hediff_SinnerPact : HediffWithTarget
    {
        public Pawn master;


        public override bool ShouldRemove => master.DestroyedOrNull() || master.Dead;

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_References.Look(ref master, "master");
        }

    }
}
