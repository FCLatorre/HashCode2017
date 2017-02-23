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
            id = id;
            size = size;
        }

        //atributes
        public double size;         //in megabytes
        public int[][] requests;
        public int id;
    }
}
