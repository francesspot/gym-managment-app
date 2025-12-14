using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
