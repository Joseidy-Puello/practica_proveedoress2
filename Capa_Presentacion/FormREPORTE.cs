using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ScottPlot;


namespace Capa_Presentacion
{
    public partial class FormREPORTE : Form
    {
        public FormREPORTE()
        {
            InitializeComponent();
        }

        private void FormREPORTE_Load(object sender, EventArgs e)
        {

        }


        private void btnACTUALIZAR_Click(object sender, EventArgs e)
        {
            int totalLocales = 0;
            int totalInternacionales = 0;
            HashSet<string> productosUnicos = new HashSet<string>();

            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=PROVEEDORES;Integrated Security=true" + "; TrustServerCertificate=True;"))
            {
                conn.Open();
                string query = "SELECT TIPO, PRODUCTO FROM PROVEEDOR";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tipo = reader["TIPO"].ToString();
                        string producto = reader["PRODUCTO"].ToString();

                        if (tipo == "LOCAL") totalLocales++;
                        else if (tipo == "INTERNACIONAL") totalInternacionales++;

                        if (!string.IsNullOrWhiteSpace(producto))
                            productosUnicos.Add(producto.Trim().ToUpper());
                    }
                }
            }

            int totalProveedores = totalLocales + totalInternacionales;
            int totalProductosUnicos = productosUnicos.Count;

            lblTotalProveedores.Text = "Total Proveedores: " + totalProveedores.ToString();
            lblLOCALES.Text = "Total Proveedores Locales: " + totalLocales.ToString();
            lblINTERNACIONALES.Text = "Total Proveedores Internacionales: " + totalInternacionales.ToString();
            lblTOTALPRODUCTOS.Text = "Total Productos: " + totalProductosUnicos.ToString();

            if (totalLocales == 0 && totalInternacionales == 0 && totalProductosUnicos == 0)
            {
                MessageBox.Show("No se encontraron datos para mostrar el reporte.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🖼️ Graficar con ScottPlot 5.x
            FormsPlot1.Plot.Clear();

            double[] alturas = { totalLocales, totalInternacionales, totalProveedores, totalProductosUnicos };
            string[] etiquetas = { $"Locales ({totalLocales})", $"Internacionales ({totalInternacionales})", $"Total Proveedores ({totalProveedores})", $"Productos ({totalProductosUnicos})" };
            double[] posiciones = { 0, 1, 2, 3 };

            // Limpiar y preparar el gráfico
            FormsPlot1.Plot.Clear();

            // Crear gráfico de barras
            var barras = FormsPlot1.Plot.Add.Bars(values: alturas);

            barras.ValueLabelStyle.IsVisible = false;

            // Estilizar las barra
            barras.ValueLabelStyle.PointFilled = true; // Set to true if you want points to be filled
            barras.ValueLabelStyle.ForeColor = new ScottPlot.Color(30, 144, 255, 150); // Color del texto de las etiquetas de valor
            barras.ValueLabelStyle.BorderColor = new ScottPlot.Color(0, 0, 0); // Bordes negros


            // Posicionar etiquetas del eje X
            FormsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(posiciones, etiquetas);


            // Agregar títulos
            FormsPlot1.Plot.Title("Reporte de Proveedores y Productos");
            FormsPlot1.Plot.YLabel("Cantidad");
            FormsPlot1.Plot.XLabel("Categorías");


            // Mostrar el gráfico
            FormsPlot1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPRINCIPAL form = new FormPRINCIPAL();
            form.Show();
            this.Dispose();
        }
    }
}
