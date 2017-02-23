using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2017.DataStructures
{
    class Video
    {
        public Video(int id, int size)
        {
            this.id = id;
            this.size = size;
        }

        //atributes
        public int size;         //in megabytes
        public int[][] requests;
        public int id;
    }
}
