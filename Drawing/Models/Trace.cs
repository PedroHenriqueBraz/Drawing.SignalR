using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drawing.Models
{
    public class Trace
    {
    public Point initial { get; set; }
    public Point final { get; set; }
    public string color { get; set; }
    }

    public class Point
    {
        public int positionX { get; set; }
        public int positionY { get; set; }
    }
}