using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndOO
{

    public class Model
    {
        public Personer personer { get; set; }
        public Trekning[] trekninger { get; set; }
    }

    public class Personer
    {
        public bool velgAlle { get; set; }
        public int trekkAntall { get; set; }
        public Person[] liste { get; set; }
    }

    public class Person
    {
        public int id { get; set; }
        public string navn { get; set; }
        public bool erValgt { get; set; }
    }

    public class Trekning
    {
        public string[] vinnere { get; set; }
        public string tid { get; set; }
        public string[] deltakere { get; set; }
    }

}
