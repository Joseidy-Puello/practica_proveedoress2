﻿using System;
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

        
        private void btnIRALISTATEMPORAL_Click(object sender, EventArgs e)
        {
            FormLISTATEMPORAL formTemporal = new FormLISTATEMPORAL();
            formTemporal.ShowDialog();
        }

        private void btnBUSCAR2_Click(object sender, EventArgs e)
        {

            string rnc = mkdtxtRNC.Text.Trim();

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

        private void btnIRALISTATEMPORAL_Click_1(object sender, EventArgs e)
        {
            FormLISTATEMPORAL formTemporal = new FormLISTATEMPORAL();
            formTemporal.ShowDialog();
        }

        private void mkdtxtRNC_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPRINCIPAL form = new FormPRINCIPAL();
            form.Show();
            this.Dispose();
        }

        private void btnLIMPIAR2_Click(object sender, EventArgs e)
        {
            // Limpiar campos
            foreach (Control control in this.Controls)
            {
                if (control is TextBox txt) txt.Clear();
                if (control is MaskedTextBox msk) msk.Clear();
                if (control is ComboBox cmb) cmb.SelectedIndex = -1;
            }

            // Limpiar selección de dgvBASEDEDATOS y recargar datos desde la base
            if (dgvProveedores != null)
            {
                dgvProveedores.ClearSelection();
                dgvProveedores.CurrentCell = null;

                // Recargar datos desde SQL Server
                using (SqlConnection conn = new SqlConnection("Server=.;DataBase=PROVEEDORES;Integrated Security=true;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = "SELECT RNC, NOMBRE, TELEFONO, PRODUCTO, TIPO FROM PROVEEDOR";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProveedores.DataSource = dt;
                }
            }
        }
    }
}
