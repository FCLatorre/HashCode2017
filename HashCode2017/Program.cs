using System;
using HashCode2017.DataStructures;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio: Leer del fichero
            List <Video> videos= new List<Video>();
            string input = System.IO.File.ReadAllText(@"..\..\Input\me_at_the_zoo.in");

            string[] inputV = input.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            //Leer del fichero y crear las estructuras
            string[] auxiliar = inputV[0].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            int numVideos = Int32.Parse(auxiliar[0]);

            string[] capacidadVideos = inputV[1].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            for (int i=0; i < numVideos; i++)
            {
                videos.Add(new Video(i, Int32.Parse(capacidadVideos[i])));
            }

            int numEndpoints = Int32.Parse(auxiliar[1]);
            List<Endpoint> endpoints = new List<Endpoint>();

            int contador = 2;
            for (int i = 0; i < numEndpoints; i++)
            {
                string[] endpointData = inputV[contador].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                contador++;
                string[] endpointAttributes= inputV[contador].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                Endpoint client = new Endpoint(i, Int32.Parse(endpointData[0]));
                int numCaches = Int32.Parse(endpointData[1]);
                for (int j=0; j< numCaches; j++)
                {
                    string[] cacheData = inputV[contador+j+1].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    client.cache.Add(new Cache(Int32.Parse(cacheData[0]), Int32.Parse(cacheData[1])));
                }
                endpoints.Add(client);
                contador = contador + numCaches;
            }
            int totalRequests = Int32.Parse(auxiliar[2]);
            contador++; ///!!!!!
            for(int i=0; i < totalRequests; i++)
            {
                string[] request = inputV[contador+i].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            }
            int totalCaches = Int32.Parse(auxiliar[3]);
            int cacheSize = Int32.Parse(auxiliar[4]);

            //Recorrer los endpoints y asignar videos a caches
            for (int i=0; i < endpoints.Count(); i++)
            {
                //Ordenar los request del usuario por campo prioridad

                //Ordenar las caches del usuario

                //para cada endpoint resolvemos los videos con las caches
                for (int j=0; j < endpoints.ElementAt(i).request.Count(); j++)
                {
                    Request r = endpoints.ElementAt(i).request.ElementAt(j);

                    for (int z=0; z< endpoints.ElementAt(i).cache.Count(); z++)
                    {
                        if (endpoints.ElementAt(i).cache.ElementAt(z).remainSpace > r.videoSize)
                        {
                            endpoints.ElementAt(i).cache.ElementAt(z).videos.Add(videos.Find(x => x.id == r.videoID));
                            endpoints.ElementAt(i).cache.ElementAt(z).remainSpace = endpoints.ElementAt(i).cache.ElementAt(z).remainSpace - r.videoSize;
                        }
                    }
                }
            }

            for (int i = 0; i < endpoints.Count(); i++)
            {

            }

                //Final: Escribir al fichero

                //System.IO.File.WriteAllText(@"..\..\Output\me_at_the_zoo.out", slices.Count().ToString() + Environment.NewLine);
            /*for (int i = 0; i < slices.Count(); i++)
            {
                string aux = slices.ElementAt(i).cornerUp.coordX.ToString() + " " +
                             slices.ElementAt(i).cornerUp.coordY.ToString() + " " +
                             slices.ElementAt(i).cornerDown.coordX.ToString() + " " +
                             slices.ElementAt(i).cornerDown.coordY.ToString();
                System.IO.File.AppendAllText(@"..\..\Output\small.out", aux + Environment.NewLine);
            }
            */



            Console.ReadKey();
        }
    }
}
