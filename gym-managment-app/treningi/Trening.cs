using gym_managment_app.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_managment_app.treningi
{
    internal class Trening
    {
        public Klient Klient { get; }
        public DateTime DataTreningu { get; }
        public RodzajTreningu RodzajTreningu { get; }
        public int CzasTrwaniaWMinutach { get; }
        public Trener TrenerProwadzacy { get; }

        public Trening(Klient klient, DateTime dataTreningu, RodzajTreningu rodzajTreningu, int czasTrwaniawMinutach, Trener trenerProwadzacy)
        {
            Klient = klient;
            DataTreningu = dataTreningu;
            RodzajTreningu = rodzajTreningu;
            CzasTrwaniaWMinutach = czasTrwaniawMinutach;
            TrenerProwadzacy = trenerProwadzacy;
        }

        public string GetInfo()
        {
            return $"Trening: {RodzajTreningu}, Data: {DataTreningu:yyyy-MM-dd HH:mm}, Czas trwania: {CzasTrwaniaWMinutach} minut, Trener: {TrenerProwadzacy.Imie} {TrenerProwadzacy.Nazwisko}";
        }

    }
}
