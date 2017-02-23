using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2017.DataStructures
{
    class Cache
    {
        //constructor
        public Cache(int id, int cap)
        {
            remainSpace = cap;
            cacheID = id;
        }

        //atributes
        public int capacity;
        public int remainSpace;
        public int cacheID;
        public List<Endpoint> endp;
        public List<Video> videos;
        public int[][] endpoints;

    }
}
