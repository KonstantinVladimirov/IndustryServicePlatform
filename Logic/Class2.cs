using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Class2
    {
        private string x, y;

        public Class2(string x, string y)
        {
            this.x = x;
            this.y = y;
        }

        public string getSumStr()
        {
            return x + " " +y;
        }
    }
}
