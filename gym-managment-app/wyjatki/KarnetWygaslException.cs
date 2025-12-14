using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_managment_app.wyjatki
{
    internal class KarnetWygaslException : Exception
    {
        public KarnetWygaslException()
            : base("Karnet klienta wygasł.")
        {
        }
    }
}
