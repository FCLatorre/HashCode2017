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
        public Request(int requestID, int videoID, int videoSize, int numRequest)
        {
            requestID = requestID;
            videoID = videoID;
            videoSize = videoSize;
            numRequest = numRequest;
        }
        //atributes
        public int requestID;
        public int videoID;
        public int videoSize;
        public int numRequest;
        public int priority; //numRequest*videoSize
    }
}
