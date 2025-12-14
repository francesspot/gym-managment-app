using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
