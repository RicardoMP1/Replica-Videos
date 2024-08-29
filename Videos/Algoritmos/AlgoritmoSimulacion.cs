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
            //bool Entrar = true;
            int rn = n;
            int rn1 = n2;
            
            while (!listaSalida.Contains(rn*rn1))
            {
                //listaSalida.Add(rn*rn1);
                int productoMedio = rn * rn1;
                string cadena = productoMedio.ToString();
                int longitud = cadena.Length;
                cadena = cadena.Substring(1, longitud-2);
                longitud = cadena.Length;
                string num1 = "0";
                string num2 = "0";
                if (cadena.Length >= 4)
                {
                    num1 = cadena.Substring(0, 3);
                    num2 = cadena.Substring(longitud - 3, longitud-1);
                }
                else
                {
                    num1 = cadena;
                    num2 = "0";
                }
               
                rn = rn1;
                if(num1 == "")
                {
                    rn1 = 0;
                }
                else
                {
                    rn1 = Convert.ToInt32(num1);
                }
                
                listaSalida.Add(rn1);



    
            }
            return listaSalida ;
        }
    }
}
