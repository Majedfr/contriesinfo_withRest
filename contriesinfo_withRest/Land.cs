using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contriesinfo_withRest
{
    internal class Land
    {
        public Land()
        {

            Nachbar = new List<string>();
            Capital = new List<string>();
        }

        public string Oficial_name { get; set; }
        public string Region { get; set; }
        public List<string> Capital { get; set; }
        public List<string> Nachbar { get; set; }
        public double Grose { get; set; }
        public string flags { get; set; }
        public int population { get; set; }
        public string CoatArms { get; set; }
    }
}
   
