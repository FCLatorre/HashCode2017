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

            string[] endpointData = inputV[2].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < numEndpoints; i++)
            {
                string[] endpointAttributes= inputV[3].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                for(int j=0; j< Int32.Parse(endpointAttributes[1]))
                {

                }
            }
            int totalRequests = Int32.Parse(auxiliar[2]);
            int totalCaches = Int32.Parse(auxiliar[3]);
            int cacheSize = Int32.Parse(auxiliar[4]);

            /*
            //Recorrer los endpoints y asignar videos a caches
            for (int i=0; i < endpoints.length; i++)
            {
                //Ordenar los request del usuario por campo prioridad

                //Ordenar las caches del usuario

                //para cada endpoint resolvemos los videos con las caches
                for (int j=0; j < endpoint.request; j++)
                {
                    for(int z=0; z<endpoint.caches; z++)
                    {
                        if (cache.espaciodisponiblwe > espacioVideo)
                        {

                        }
                    }
                }
                
            }
            */


            //Final: Escribir al fichero
            /*
            System.IO.File.WriteAllText(@"..\..\Output\me_at_the_zoo.out", slices.Count().ToString() + Environment.NewLine);
            for (int i = 0; i < slices.Count(); i++)
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
