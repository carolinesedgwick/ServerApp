using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp
{
    public class Lunch
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public int Duration { get; set; } = 1;
        public string Color { get; set; } = "#ebf9d1";
    }
}
