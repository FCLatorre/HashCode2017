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
            this.requestID = requestID;
            this.videoID = videoID;
            this.videoSize = videoSize;
            this.numRequest = numRequest;
            //Este calculo es clave para mejorar la puntuacion
            priority = numRequest - videoSize;
        }
        //atributes
        public int requestID;
        public int videoID;
        public int videoSize;
        public int numRequest;
        public int priority; //numRequest*videoSize
    }
}
