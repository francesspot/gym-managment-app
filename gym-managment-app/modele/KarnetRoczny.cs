using System;
using System.Collections.Generic;

namespace gym_managment_app.modele
{
    internal class KarnetRoczny : Karnet
    {
        public KarnetRoczny()
        {
            this.Cena = 1000m;
            this.DataWaznosci = DateTime.Now.AddYears(1);
        }
    }
}
