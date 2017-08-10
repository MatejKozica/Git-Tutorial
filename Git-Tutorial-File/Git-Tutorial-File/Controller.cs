using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Tutorial_File
{
    class Controller
    {
        public static void LogIn(Person person, string ime, string lozinka)
        {
            if (!person.IsLoggedIn)
            {
                if (person.Name == ime && person.Password == lozinka)
                    person.IsLoggedIn = true;
            }
        }
    }
}
