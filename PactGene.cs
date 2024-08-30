using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using UnityEngine;
using Verse;

namespace DanteRewind
{
    public class Gene_DantehPact : Gene

    {

        public List<Pawn> sinner = new List<Pawn>();



       // public sinnerAmountGizmo bandwidthGizmo;

        public int SinnerCapacity = 12;


        public bool CanPactWithNewPawn
        {
            get
            {
                if (SinnerCapacity >= 12)
                {
                    return false;
                }
                return true;

            }
        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Collections.Look(ref sinner, "sinner", LookMode.Reference);
            Scribe_Values.Look(ref SinnerCapacity, "sinnerCapacity", 12);
        }
        //public override IEnumerable<Gizmo> GetGizmos()
        //{
           // if (pawn.IsColonistPlayerControlled)
            //{
               // if (bandwidthGizmo == null)
                //{
                    //bandwidthGizmo = new sinnerAmountGizmo(this);
               // }
              //  yield return bandwidthGizmo;
           // }
        //}
    }
}
        