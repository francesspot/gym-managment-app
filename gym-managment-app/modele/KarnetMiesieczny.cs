using System;
using System.Collections.Generic;

namespace gym_managment_app.modele
{
    internal class KarnetMiesieczny : Karnet
    {
        public KarnetMiesieczny()
        {
            this.Cena = 120m; 
            this.DataWaznosci = DateTime.Now.AddMonths(1);
        }
    }
}
