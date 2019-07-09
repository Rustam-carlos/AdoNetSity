using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sity
{
    public class Numbers
    {
        public int Id { get; set; }
        public Cityes city { get; set; }
        public string CityName { get; set; }
        public string Number { get; set; }
        public string Coment { get; set; }

        public override string ToString()
        {
            return Number;
        }
    }
}
