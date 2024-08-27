using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videos.Algoritmos
{
    public class AlgoritmoSimulacion
    {
        public AlgoritmoSimulacion(){}

        public List<int> GenerarValores(int n)
        {
            List<int> listaSalida = new List<int>();
            for (int i = 0; i < n; i++) { 
                listaSalida.Add(5*(i+1));
            }
            return listaSalida;
        }

        public List<int> GeneradorCongruencial(int a, int c, int m, int x0){
            
            List<int> listaSalida = new List<int>();
            bool Entrar = true;
            int xi = x0;
            while (Entrar){

                xi = (a * xi + c) % m;
                if (!listaSalida.Contains(xi)){

                    listaSalida.Add((xi + 1) % m);
                }
                else{

                    Entrar = false;
                }
            }


            return listaSalida;
        }

        public List<int> GeneradorProductoMedio(int n, int n2)
        {

            List<int> listaSalida = new List<int>();
            bool Entrar = true;
            int xi = x0;
            while (Entrar)
            {

                xi = (a * xi + c) % m;
                if (!listaSalida.Contains(xi))
                {

                    listaSalida.Add((xi + 1) % m);
                }
                else
                {

                    Entrar = false;
                }
            }


            return listaSalida;
        }
    }
}
