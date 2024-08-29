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
        public List<int> AlgoritmoCuadradoMedio(int semilla)
        {
            List<int> listaSalida = new List<int>();
            int mitadCadena = 0;
            int pseudoaleatorio = 0;
            int cuadrado = semilla * semilla;
            string cadena = cuadrado.ToString();
            if (cadena.Length <= 2) //Checamos si la longitud de la cadena tiene suficientes digitos
            {
                throw new ArgumentException("No se tienen suficientes digitos");
            }
            string cadenaModificada = cadena.Substring(1, cadena.Length - 2);
            mitadCadena = cadenaModificada.Length / 2;
            if (cadenaModificada.Length <= 3) // Nos aseguramos que cadena modificada tiene los suficientes digitos para hacer la operacion
            {
                pseudoaleatorio = Convert.ToInt32(cadenaModificada);
            }
            else
            {
                pseudoaleatorio = Convert.ToInt32(cadenaModificada.Substring(mitadCadena - 2, 3));
            }
            listaSalida.Add(pseudoaleatorio);
            while (true)
            {
                cuadrado = pseudoaleatorio * pseudoaleatorio;
                cadena = cuadrado.ToString();
                if (pseudoaleatorio == 0) //Si nuestro pseudoaleatorio es 0, finaliza el algoritmo
                {
                    return listaSalida;
                }
                cadenaModificada = cadena.Substring(1, cadena.Length - 2);
                mitadCadena = cadenaModificada.Length / 2;
                if (cadenaModificada.Length <= 3) // Nos aseguramos que cadena modificada tiene los suficientes digitos para hacer la operacion
                {
                    pseudoaleatorio = Convert.ToInt32(cadenaModificada);
                }
                else
                {
                    pseudoaleatorio = Convert.ToInt32(cadenaModificada.Substring(mitadCadena - 2, 3));
                }
                if (listaSalida.Contains(pseudoaleatorio))
                {
                    return listaSalida;
                }
                else
                {
                    listaSalida.Add(pseudoaleatorio);
                }
            }

        }
    }
}
