﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa.Presentacion;

namespace Capa_Presentacion
{
    public partial class FormPRINCIPAL : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FormPRINCIPAL()
        {
            InitializeComponent();
        }

        private void btnREGISTROPROVEEDORES_Click(object sender, EventArgs e)
        {
            FormPROVEEDORES frm = new FormPROVEEDORES();
            frm.Show();
            this.Hide();
        }

        private void btnLISTATEMPORAL_Click(object sender, EventArgs e)
        {

            FormLISTATEMPORAL frm = new FormLISTATEMPORAL();
            frm.Show();
            this.Hide();
        }

        private void btnREPORTEPROVEEDORES_Click(object sender, EventArgs e)
        {
            FormREPORTE frm = new FormREPORTE();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panelPRINCIPAL.Width == 70)
            {
                panelPRINCIPAL.Width = 310;
            }
            else
            {
                panelPRINCIPAL.Width = 70;
            }
        }

        private void FormPRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelPRINCIPAL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTITULO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTITULO_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
