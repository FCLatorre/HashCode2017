using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2017.DataStructures
{
    class Request
    {
        //constructor
        public Request(int id, int idv, int vidw)
        {
            data[0] = id;
            data[1] = idv;
            data[2] = vidw;

        }
        //atributes
        public int[] data = new int[3];
    }
}
