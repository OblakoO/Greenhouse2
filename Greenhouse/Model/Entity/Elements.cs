using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class ElementsEntityBase
    {

        public Location Location { get; set; }
        public Size Size { get; set; }

    }
    public class Location
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Size
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
