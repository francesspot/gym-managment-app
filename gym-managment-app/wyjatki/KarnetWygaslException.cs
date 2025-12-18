using System;
using System.Collections.Generic;

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
