using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3102022Arrays
{
    internal class Mount:IComparable<Mount>
    {
        public String name;
        public int hight;

        public int CompareTo(Mount? other)
        {
            return this.hight.CompareTo(other);
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\n" +
                "Height: {1}", name, hight);
        }
    }


}
