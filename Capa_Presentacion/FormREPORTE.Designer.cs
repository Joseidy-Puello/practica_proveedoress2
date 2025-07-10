namespace Capa_Presentacion
{
    partial class FormREPORTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormREPORTE));
            lblREPORTEPROVEEDORES = new Label();
            lblLOCALES = new Label();
            lblINTERNACIONALES = new Label();
            lblTOTALPRODUCTOS = new Label();
            lblTotalProveedores = new Label();
            btnACTUALIZAR = new Button();
            FormsPlot1 = new ScottPlot.WinForms.FormsPlot();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblREPORTEPROVEEDORES
            // 
            lblREPORTEPROVEEDORES.AutoSize = true;
            lblREPORTEPROVEEDORES.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblREPORTEPROVEEDORES.Location = new Point(425, 20);
            lblREPORTEPROVEEDORES.Name = "lblREPORTEPROVEEDORES";
            lblREPORTEPROVEEDORES.Size = new Size(419, 34);
            lblREPORTEPROVEEDORES.TabIndex = 0;
            lblREPORTEPROVEEDORES.Text = "REPORTE PROVEEDORES";
            // 
            // lblLOCALES
            // 
            lblLOCALES.AutoSize = true;
            lblLOCALES.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLOCALES.Location = new Point(276, 88);
            lblLOCALES.Name = "lblLOCALES";
            lblLOCALES.Size = new Size(219, 23);
            lblLOCALES.TabIndex = 2;
            lblLOCALES.Text = "Total Proveedores Locales:";
            // 
            // lblINTERNACIONALES
            // 
            lblINTERNACIONALES.AutoSize = true;
            lblINTERNACIONALES.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblINTERNACIONALES.Location = new Point(624, 88);
            lblINTERNACIONALES.Name = "lblINTERNACIONALES";
            lblINTERNACIONALES.Size = new Size(282, 23);
            lblINTERNACIONALES.TabIndex = 3;
            lblINTERNACIONALES.Text = "Total Proveedores Internacionales:";
            // 
            // lblTOTALPRODUCTOS
            // 
            lblTOTALPRODUCTOS.AutoSize = true;
            lblTOTALPRODUCTOS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTOTALPRODUCTOS.Location = new Point(1027, 88);
            lblTOTALPRODUCTOS.Name = "lblTOTALPRODUCTOS";
            lblTOTALPRODUCTOS.Size = new Size(139, 23);
            lblTOTALPRODUCTOS.TabIndex = 4;
            lblTOTALPRODUCTOS.Text = "Total Productos:";
            // 
            // lblTotalProveedores
            // 
            lblTotalProveedores.AutoSize = true;
            lblTotalProveedores.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProveedores.Location = new Point(23, 88);
            lblTotalProveedores.Name = "lblTotalProveedores";
            lblTotalProveedores.Size = new Size(148, 23);
            lblTotalProveedores.TabIndex = 1;
            lblTotalProveedores.Text = "Total Provedores:";
            // 
            // btnACTUALIZAR
            // 
            btnACTUALIZAR.Location = new Point(547, 507);
            btnACTUALIZAR.Name = "btnACTUALIZAR";
            btnACTUALIZAR.Size = new Size(115, 42);
            btnACTUALIZAR.TabIndex = 5;
            btnACTUALIZAR.Text = "Actualizar";
            btnACTUALIZAR.UseVisualStyleBackColor = true;
            btnACTUALIZAR.Click += btnACTUALIZAR_Click;
            // 
            // FormsPlot1
            // 
            FormsPlot1.BackColor = SystemColors.ControlLightLight;
            FormsPlot1.DisplayScale = 1.25F;
            FormsPlot1.Location = new Point(49, 126);
            FormsPlot1.Name = "FormsPlot1";
            FormsPlot1.Size = new Size(1088, 365);
            FormsPlot1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormREPORTE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1224, 561);
            Controls.Add(pictureBox1);
            Controls.Add(FormsPlot1);
            Controls.Add(btnACTUALIZAR);
            Controls.Add(lblTOTALPRODUCTOS);
            Controls.Add(lblINTERNACIONALES);
            Controls.Add(lblLOCALES);
            Controls.Add(lblTotalProveedores);
            Controls.Add(lblREPORTEPROVEEDORES);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormREPORTE";
            Text = "FormREPORTE";
            Load += FormREPORTE_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblREPORTEPROVEEDORES;
        private Label lblLOCALES;
        private Label lblINTERNACIONALES;
        private Label lblTOTALPRODUCTOS;
        private Label lblTotalProveedores;
        private Button btnACTUALIZAR;
        private ScottPlot.WinForms.FormsPlot FormsPlot1;
        private PictureBox pictureBox1;
    }
}