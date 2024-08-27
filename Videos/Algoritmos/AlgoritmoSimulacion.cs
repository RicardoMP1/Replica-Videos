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
        public List<int> AlgoritmoCuadradoMedio(int n)
        {
            List<int> listaSalida = new List<int>();
            int pseudoaleatorio = n;
            while (!listaSalida.Contains(pseudoaleatorio))
            {
                listaSalida.Add(pseudoaleatorio);
                int cuadrado = pseudoaleatorio * pseudoaleatorio;
                string cadena = cuadrado.ToString();
                int longitud = cadena.Length;
                int mitad = longitud / 2;
                int inicio = mitad - 2;
                string subcadena = cadena.Substring(inicio, 4);
                pseudoaleatorio = Convert.ToInt32(subcadena);
            }
            return listaSalida;
        }
    }
}
