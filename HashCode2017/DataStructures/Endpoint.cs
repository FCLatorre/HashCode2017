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
        public Endpoint(int id, int l, int cch)
        {
            this.id = id;
            latency = l;

            cache = new List<Cache>();

            request = new List<Request>();
        }

        //atributes
        public int latency;
        public int id;
        public List<Cache> cache;
        public List<Request> request;

        public void orderCacheByLatency()
        {
            cache = cache.OrderBy(o => o.endpoints[id][0]).ToList();
        }

        public void orderRequestsByPriority()
        {
            request = request.OrderBy(o => o.priority).ToList();
        }

    }
}
