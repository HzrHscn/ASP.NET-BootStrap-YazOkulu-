﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;
using EntityLayerFramework;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        }

        public static int TalepEkleBLL(EntityBasvuruForm p)
        {
            if(p.Basogrid!=null && p.Basdersid != null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
