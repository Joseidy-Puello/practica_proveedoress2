﻿namespace Capa_Presentacion
{
    partial class FormPRINCIPAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPRINCIPAL));
            btnLISTATEMPORAL = new Button();
            btnREGISTROPROVEEDORES = new Button();
            btnREPORTEPROVEEDORES = new Button();
            panelPRINCIPAL = new Panel();
            pictureBox1 = new PictureBox();
            panelTITULO = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panelPRINCIPAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTITULO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLISTATEMPORAL
            // 
            btnLISTATEMPORAL.BackColor = SystemColors.ControlLightLight;
            btnLISTATEMPORAL.Image = (Image)resources.GetObject("btnLISTATEMPORAL.Image");
            btnLISTATEMPORAL.ImageAlign = ContentAlignment.MiddleLeft;
            btnLISTATEMPORAL.Location = new Point(0, 159);
            btnLISTATEMPORAL.Name = "btnLISTATEMPORAL";
            btnLISTATEMPORAL.Size = new Size(310, 48);
            btnLISTATEMPORAL.TabIndex = 0;
            btnLISTATEMPORAL.Text = "LISTA TEMPORAL";
            btnLISTATEMPORAL.UseVisualStyleBackColor = false;
            btnLISTATEMPORAL.Click += btnLISTATEMPORAL_Click;
            // 
            // btnREGISTROPROVEEDORES
            // 
            btnREGISTROPROVEEDORES.BackColor = SystemColors.ControlLightLight;
            btnREGISTROPROVEEDORES.ForeColor = SystemColors.ActiveCaptionText;
            btnREGISTROPROVEEDORES.Image = (Image)resources.GetObject("btnREGISTROPROVEEDORES.Image");
            btnREGISTROPROVEEDORES.ImageAlign = ContentAlignment.MiddleLeft;
            btnREGISTROPROVEEDORES.Location = new Point(0, 86);
            btnREGISTROPROVEEDORES.Name = "btnREGISTROPROVEEDORES";
            btnREGISTROPROVEEDORES.Size = new Size(310, 47);
            btnREGISTROPROVEEDORES.TabIndex = 1;
            btnREGISTROPROVEEDORES.Text = "REGISTRO PROVEEDORES";
            btnREGISTROPROVEEDORES.UseVisualStyleBackColor = false;
            btnREGISTROPROVEEDORES.Click += btnREGISTROPROVEEDORES_Click;
            // 
            // btnREPORTEPROVEEDORES
            // 
            btnREPORTEPROVEEDORES.BackColor = SystemColors.ControlLightLight;
            btnREPORTEPROVEEDORES.Image = (Image)resources.GetObject("btnREPORTEPROVEEDORES.Image");
            btnREPORTEPROVEEDORES.ImageAlign = ContentAlignment.MiddleLeft;
            btnREPORTEPROVEEDORES.Location = new Point(3, 237);
            btnREPORTEPROVEEDORES.Name = "btnREPORTEPROVEEDORES";
            btnREPORTEPROVEEDORES.Size = new Size(307, 51);
            btnREPORTEPROVEEDORES.TabIndex = 2;
            btnREPORTEPROVEEDORES.Text = "REPORTE PROVEEDORES";
            btnREPORTEPROVEEDORES.UseVisualStyleBackColor = false;
            btnREPORTEPROVEEDORES.Click += btnREPORTEPROVEEDORES_Click;
            // 
            // panelPRINCIPAL
            // 
            panelPRINCIPAL.BackColor = SystemColors.ControlLightLight;
            panelPRINCIPAL.Controls.Add(btnREGISTROPROVEEDORES);
            panelPRINCIPAL.Controls.Add(btnLISTATEMPORAL);
            panelPRINCIPAL.Controls.Add(btnREPORTEPROVEEDORES);
            panelPRINCIPAL.Dock = DockStyle.Left;
            panelPRINCIPAL.Location = new Point(0, 0);
            panelPRINCIPAL.Name = "panelPRINCIPAL";
            panelPRINCIPAL.Size = new Size(70, 574);
            panelPRINCIPAL.TabIndex = 4;
            panelPRINCIPAL.Paint += panelPRINCIPAL_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelTITULO
            // 
            panelTITULO.BackColor = SystemColors.ActiveCaption;
            panelTITULO.Controls.Add(pictureBox3);
            panelTITULO.Controls.Add(pictureBox1);
            panelTITULO.Dock = DockStyle.Top;
            panelTITULO.Location = new Point(70, 0);
            panelTITULO.Name = "panelTITULO";
            panelTITULO.Size = new Size(1122, 50);
            panelTITULO.TabIndex = 6;
            panelTITULO.Paint += panelTITULO_Paint;
            panelTITULO.MouseDown += panelTITULO_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1056, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(393, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(466, 443);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // FormPRINCIPAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1192, 574);
            Controls.Add(panelTITULO);
            Controls.Add(panelPRINCIPAL);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPRINCIPAL";
            Text = "FormPRINCIPAL";
            Load += FormPRINCIPAL_Load;
            panelPRINCIPAL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTITULO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLISTATEMPORAL;
        private Button btnREGISTROPROVEEDORES;
        private Button btnREPORTEPROVEEDORES;
        private Panel panelPRINCIPAL;
        private PictureBox pictureBox1;
        private Panel panelTITULO;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}