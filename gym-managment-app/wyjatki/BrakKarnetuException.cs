using System;
using System.Collections.Generic;

namespace gym_managment_app.wyjatki
{
    internal class BrakKarnetuException : Exception
    {
        public BrakKarnetuException() 
            : base("Klient nie posiada karnetu.")
        {
        }
    }
}
