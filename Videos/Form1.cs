using System.Windows.Forms;
using Videos.Algoritmos;

namespace Videos{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Paso 0: Condición de vacío
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS");
                return;
            }

            // Paso 1: Inicialización de Parámetros
            int n = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);


            // Paso 1.2: Condiciones
            /*
            if (a <= 0 || c <= 0 || x0 <= 0){
                MessageBox.Show("Los valores de a, c y x0 tienen que ser mayores a CERO");
                return;
            }

            if (m <= x0 || m <= c || m <= a){
                MessageBox.Show("El valor de m tiene que ser mayor a los valores de a, c, y x0");
                return;
            }
            */

            // Paso 2: Declarar clase algortimo genético
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();

            // Paso 3: Llamar método principal
            List<int> listaEnteros = algoritmo.GeneradorProductoMedio(n, n2);

            // Paso 4: Llenar el Grid
            llenarGrid(listaEnteros);
        }

        public void llenarGrid(List<int> lista)
        {

            // Paso 0: Indicar el número de columnas
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            

            // Paso 1: Determina la cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");
           

            // Paso 2: Recorres el grid para cada fila llenas los valores aleatorios
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }

        }

        public void DescargaExcel(DataGridView data)
        {
            //Paso 0: Instalar complemento de Excel
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;

            //Paso 1: Construyes columnas y los nombres de las 'cabeceras'
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }

            //Paso 2: Construyes filas y llenas valores
            int indiceFilas = 0;
            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }

            //Paso 3: Visibilidad
            exportarExcel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
