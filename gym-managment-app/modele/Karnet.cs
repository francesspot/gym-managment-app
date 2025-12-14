using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_managment_app.modele
{
    abstract class Karnet
    {
        public decimal Cena { get; protected set; }
        public bool Oplacony { get; private set; } = false;
        public DateTime DataWaznosci { get; protected set; }

        public void OplacKarnet(decimal kwota)
        {
            if (kwota < Cena)
                throw new Exception($"Kwota {kwota} jest za mała, cena karnetu to {Cena}.");

            Oplacony = true;
        }

        public bool CzyWazny()
        {
            return DateTime.Now <= DataWaznosci;
        }

        public int IleDniZostalo()
        {
            return (DataWaznosci - DateTime.Now).Days;
        }

    }
}
