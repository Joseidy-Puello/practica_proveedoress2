using System.Data;
using System.Diagnostics.Eventing.Reader;
using Capa_Datos;
using Capa_Negocios;
using Microsoft.Data.SqlClient;

namespace Capa.Presentacion
{
    public partial class FormLISTATEMPORAL : Form
    {

        private List<PROVEEDOR> listaProveedoresTemporal = new List<PROVEEDOR>();
        private CNProveedor cnProveedor = new CNProveedor();

        public FormLISTATEMPORAL()
        {
            InitializeComponent();

            if (cmbTipoProveedor.Items.Count == 0)
            {
                cmbTipoProveedor.Items.Add("LOCAL");
                cmbTipoProveedor.Items.Add("INTERNACIONAL");
            }

            cmbTipoProveedor.SelectedIndex = 0; 
        }

        private void EnlazarDataGridView()
        {
            dgvLISTATEMPORAL.DataSource = null; // Desenlazar para refrescar
            dgvLISTATEMPORAL.DataSource = listaProveedoresTemporal; // Enlazar a la lista temporal
        }                                                          

        /* private void ObtenerRegistro()
         {
             conn.Open();
             DataTable dt = new DataTable();
             adapt = new SqlDataAdapter("SELECT * FROM PROVEEDOR", conn);
             adapt.Fill(dt);
             dgvLISTATEMPORAL.DataSource = dt;
             conn.Close();
         }*/

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
           /* string rnc = TxtRNC.Text.Trim();
            CNProveedor negocio = new CNProveedor();
            var proveedor = negocio.ObtenerProveedorPorRNC(rnc);

            //captura de error (solo 9 numeros para el RNC)
            if (TxtRNC.Text.Length != 9)
            {
                MessageBox.Show("El RNC debe tener 9 dígitos.");
                return;
            }


            if (proveedor != null)
            {
                MessageBox.Show("Proveedor encontrado: " + proveedor.NOMBRE);
                // muestrar los datos en controles
                TxtNOMBRE.Text = proveedor.NOMBRE;
                TxtRNC.Text = proveedor.RNC;
                TxtTELEFONO.Text = proveedor.TELEFONO;
                TxtTIPO.Text = proveedor.TIPO;
                TxtPRODUCTO.Text = proveedor.PRODUCTO;

            }
            else
            {
                MessageBox.Show("Proveedor no encontrado.");
            }*/


        }

        private void btnREGISTRAR_Click(object sender, EventArgs e)
        {
            PROVEEDOR nuevoProveedor;

            // Decidimos qué objeto crear basándonos en la selección del ComboBox.
            // Pasamos el texto del TextBox directamente al constructor.
            if (cmbTipoProveedor.SelectedItem.ToString() == "LOCAL")
            {
                nuevoProveedor = new ProveedorLocal(
                    TxtRNC.Text,
                    TxtNOMBRE.Text,
                    TxtTELEFONO.Text,
                    TxtPRODUCTO.Text
                );
            }
            else // Si es "INTERNACIONAL"
            {
                nuevoProveedor = new ProveedorInternacional(
                    TxtRNC.Text,
                    TxtNOMBRE.Text,
                    TxtTELEFONO.Text,
                    TxtPRODUCTO.Text
                );
            }

            // La lógica de validación sigue funcionando igual.
            if (!nuevoProveedor.EsValido())
            {
                MessageBox.Show("El identificador no es válido. Por favor, verifique los datos.", "Error de Validación");
                return;
            }

            // Para buscar duplicados, también usamos el texto del TextBox directamente.
            if (listaProveedoresTemporal.Any(p => p.ObtenerIdentificadorPrincipal() == TxtRNC.Text))
            {
                MessageBox.Show("Ya existe un proveedor con este identificador en la lista.", "Identificador Duplicado");
                return;
            }

            listaProveedoresTemporal.Add(nuevoProveedor);
            EnlazarDataGridView();
            MessageBox.Show("Proveedor agregado a la lista temporal.");


        }

        


        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }

                if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }

                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
        }

        private void dgvProveedores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtRNC.Text = dgvLISTATEMPORAL.CurrentRow.Cells[0].Value.ToString();
            TxtNOMBRE.Text = dgvLISTATEMPORAL.CurrentRow.Cells[1].Value.ToString();
            TxtTELEFONO.Text = dgvLISTATEMPORAL.CurrentRow.Cells[2].Value.ToString();
            cmbTipoProveedor.Text = dgvLISTATEMPORAL.CurrentRow.Cells[3].Value.ToString();
            TxtPRODUCTO.Text = dgvLISTATEMPORAL.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
          /*  conn.Open();
            string RNC = dgvLISTATEMPORAL.CurrentRow.Cells[0].Value.ToString();
            string connBD = "DELETE FROM PROVEEDOR WHERE RNC = '" + RNC + "'";
            SqlCommand cmd = new SqlCommand(connBD, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("El Registro se elimino correctamente");
            TxtRNC.Text = "";
            TxtNOMBRE.Text = "";
            TxtTELEFONO.Text = "";
            TxtTIPO.Text = "";
            TxtPRODUCTO.Text = "";
            conn.Close();*/
         
        
            if (dgvLISTATEMPORAL.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un proveedor para eliminar.");
                return;
            }

            string RNCaEliminar = dgvLISTATEMPORAL.CurrentRow.Cells[0].Value.ToString();

            // Buscar y eliminar de la lista temporal
            PROVEEDOR proveedorAEliminar = listaProveedoresTemporal.FirstOrDefault(p => p.RNC == RNCaEliminar);
            if (proveedorAEliminar != null)
            {
                listaProveedoresTemporal.Remove(proveedorAEliminar);
                MessageBox.Show("El Registro se eliminó correctamente de la lista temporal.");
            }
            else
            {
                MessageBox.Show("El proveedor no fue encontrado en la lista temporal.");
            }

            EnlazarDataGridView(); // Actualizar el DataGridView

            // Limpiar los cuadros de texto
            TxtRNC.Text = "";
            TxtNOMBRE.Text = "";
            TxtTELEFONO.Text = "";
            cmbTipoProveedor.Text = "";
            TxtPRODUCTO.Text = "";

        }
        

        private void FormPROVEEDORES_Load(object sender, EventArgs e)
        {

        }

        private void btnGUARDARENBD_Click(object sender, EventArgs e)
        {
            if (!listaProveedoresTemporal.Any())
            {
                MessageBox.Show("No hay proveedores en la lista para guardar.");
                return;
            }

            try
            {
                // Esta parte ya la tienes: guarda los proveedores en la BD.
                cnProveedor.GuardarListaProveedores(listaProveedoresTemporal);
                MessageBox.Show("Proveedores guardados en la Base de Datos exitosamente.");

                // --- INICIO DE LA MODIFICACIÓN ---

                // 1. Marcamos el resultado como "OK" para avisar que todo salió bien.
                this.DialogResult = DialogResult.OK;

                // 2. Cerramos el formulario de la lista temporal.
                this.Close();

                // --- FIN DE LA MODIFICACIÓN ---
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message);
                // Si hay un error, el formulario no se cierra y no se marca como OK.
            }
        }
    }
    
}
