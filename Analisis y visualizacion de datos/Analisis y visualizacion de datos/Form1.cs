using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Analisis_y_visualizacion_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DTG_tabla_datos.Columns.Add("columnaCategoria", "categorias");
            DTG_tabla_datos.Columns.Add("columnaCifra", "cantidad");
        }

        private void btn_añadir_datos_dtg_Click(object sender, EventArgs e)
        {
            string nombre_dato = txt_nombre_datos.Text;
            if (!string.IsNullOrEmpty(nombre_dato))
            {
                if (int.TryParse(txt_cifra_dato.Text,out int cantidad))
                {
                    // Asegúrate de que cantidad sea un índice válido dentro del rango de filas del DataGridView
                    if (cantidad >= 0 && cantidad < DTG_tabla_datos.Rows.Count)
                    {
                        // Si ya existe una fila en el índice especificado, puedes actualizar sus valores
                        DataGridViewRow fila = DTG_tabla_datos.Rows[cantidad];
                        int columnaCategoria = 0;
                        int columnaCifra = 1;
                        fila.Cells[columnaCategoria].Value = nombre_dato;
                        fila.Cells[columnaCifra].Value = cantidad;
                    }
                    else
                    {
                        // Si el índice está fuera del rango actual, agrega una nueva fila
                        int columnaCategoria = 0;
                        int columnaCifra = 1;
                        DTG_tabla_datos.Rows.Add(nombre_dato, cantidad);
                    }

                }
            }
        }

        private void btn_graficar_Click(object sender, EventArgs e)
        {

            chart_graficacion.Series.Clear();

            Series serieCifras = new Series("Cifras");

            serieCifras.ChartType = SeriesChartType.Column;

            foreach (DataGridViewRow fila in DTG_tabla_datos.Rows)
            {
                // Verificamos si la fila tiene celdas y si las celdas de categoría y cifra contienen datos válidos
                if (fila.Cells[0].Value != null && fila.Cells[1].Value != null)
                {
                    string categoria = fila.Cells[0].Value.ToString();
                    int cifra = Convert.ToInt32(fila.Cells[1].Value);

                    // Agregamos los datos a la serie del gráfico
                    serieCifras.Points.AddXY(categoria, cifra);
                }
            }
            serieCifras.ChartType = SeriesChartType.Pie;
            // Agregamos la serie al Chart
            chart_graficacion.Series.Add(serieCifras);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
