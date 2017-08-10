using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice9
{
    class Point
    {
        int Info { get; set; }
        Point Next { get; set; }
        public Point(int info)
        {
            Info = info;
            Next = null;
        }
        public static implicit operator bool(Point point)
        {
            if (point.Info >= 0)
                return true;
            else
                return false;
        }
    }
}
