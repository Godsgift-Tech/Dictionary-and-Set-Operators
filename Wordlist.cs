using Dictionary_SetOperators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_SetOperators
{
    public class Wordlist(string wordText, string meaning)
    {
        // declaring a property for the object in Wordlist
        public string Word { get; set; } = wordText;
        public string Meaning { get; set; } = meaning;
    }

}



