using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
