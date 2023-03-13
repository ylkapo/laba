using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace практика
{
    internal class monitor
    {
        public string firm { get; set; }
        public string type { get; set; }
        public float diagonal { get; set; }
        public void Print(string firm, string type, float diagonal)
        {
            firm = "Samsung";
            type = "жидкокристаллический";
            diagonal = 32;
        }
    }

}
