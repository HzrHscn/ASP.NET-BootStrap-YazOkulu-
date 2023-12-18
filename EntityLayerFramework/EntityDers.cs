using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerFramework
{
    public class EntityDers
    {
        private string dersad;
        public string Dersad { get => dersad; set => dersad = value; }
        
        private int min;
        public int Min { get => min; set => min = value; }
        
        private int max;
        public int Max { get => max; set => max = value; }

        private int dersid;
        public int DersId { get => dersid; set => dersid = value; }
        
    }
}
