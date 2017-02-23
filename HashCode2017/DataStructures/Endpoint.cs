using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2017.DataStructures
{
    class Endpoint
    {
        //constructor
        public Endpoint(int l, int cch)
        {
            latency = l;

            cache = new int[cch][];
        }

        //atributes
        public int latency;
        public int[][] cache; //2colums
    }
}
