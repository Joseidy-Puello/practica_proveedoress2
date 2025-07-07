using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa.Presentacion;
using Capa_Datos;
using Capa_Negocios;
using Microsoft.Data.SqlClient;

namespace Capa_Presentacion
{
    public partial class FormPROVEEDORES : Form
    {

        private CNProveedor cnProveedor = new CNProveedor();

        public FormPROVEEDORES()
        {
            InitializeComponent();
        }

        private void FormPROVEEDORES_Load(object sender, EventArgs e)
        {
            CargarTodosLosProveedores();
        }

        private void CargarTodosLosProveedores()
        {
            try
            {
                dgvProveedores.DataSource = cnProveedor.ObtenerTodosLosProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
            }
        }

        // --- MÉTODO RENOMBRADO ---
        // Este es el evento para tu nuevo botón "btnIRALISTATEMPORAL"
        private void btnIRALISTATEMPORAL_Click(object sender, EventArgs e)
        {
            FormLISTATEMPORAL formTemporal = new FormLISTATEMPORAL();
            formTemporal.ShowDialog();
        }

        private void btnBUSCAR2_Click(object sender, EventArgs e)
        {

            string rnc = txtRNC2.Text.Trim();

            if (string.IsNullOrWhiteSpace(rnc))
            {
                MessageBox.Show("Por favor ingresa un RNC para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CNProveedor proveedorNegocio = new CNProveedor();
                DataTable resultados = proveedorNegocio.BuscarProveedores(rnc);

                dgvProveedores.DataSource = resultados;

                if (resultados.Rows.Count > 0)
                {
                    // Selecciona la primera fila
                    dgvProveedores.ClearSelection();
                    dgvProveedores.Rows[0].Selected = true;

                    // ✅ Aquí actualizas el campo txtNombre
                    txtNOMBRE2.Text = resultados.Rows[0]["NOMBRE"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún proveedor con ese RNC.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNOMBRE2.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       private void btnELIMINAR2_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un proveedor para eliminar.");
                return;
            }

            string RNC = dgvProveedores.CurrentRow.Cells["RNC"].Value.ToString();
            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar al proveedor con RNC/ID '{RNC}' de la base de datos?",
                                     "Confirmar Eliminación",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    cnProveedor.EliminarProveedor(RNC);
                    MessageBox.Show("Proveedor eliminado exitosamente.");
                    CargarTodosLosProveedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
       }


    }
}
