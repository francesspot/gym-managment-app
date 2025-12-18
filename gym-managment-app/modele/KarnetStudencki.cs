using System;
using System.Collections.Generic;

namespace gym_managment_app.modele
{
    internal class KarnetStudencki : Karnet
    {
        public KarnetStudencki()
        {
            this.Cena = 80m; 
            this.DataWaznosci = DateTime.Now.AddMonths(1);
        }
    }
}
