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
            lblREPORTEPROVEEDORES = new Label();
            lblLOCALES = new Label();
            lblINTERNACIONALES = new Label();
            lblTOTALPRODUCTOS = new Label();
            lblTotalProveedores = new Label();
            btnACTUALIZAR = new Button();
            FormsPlot1 = new ScottPlot.WinForms.FormsPlot();
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
            lblLOCALES.Location = new Point(337, 88);
            lblLOCALES.Name = "lblLOCALES";
            lblLOCALES.Size = new Size(184, 20);
            lblLOCALES.TabIndex = 2;
            lblLOCALES.Text = "Total Proveedores Locales:";
            // 
            // lblINTERNACIONALES
            // 
            lblINTERNACIONALES.AutoSize = true;
            lblINTERNACIONALES.Location = new Point(693, 88);
            lblINTERNACIONALES.Name = "lblINTERNACIONALES";
            lblINTERNACIONALES.Size = new Size(235, 20);
            lblINTERNACIONALES.TabIndex = 3;
            lblINTERNACIONALES.Text = "Total Proveedores Internacionales:";
            // 
            // lblTOTALPRODUCTOS
            // 
            lblTOTALPRODUCTOS.AutoSize = true;
            lblTOTALPRODUCTOS.Location = new Point(1098, 88);
            lblTOTALPRODUCTOS.Name = "lblTOTALPRODUCTOS";
            lblTOTALPRODUCTOS.Size = new Size(115, 20);
            lblTOTALPRODUCTOS.TabIndex = 4;
            lblTOTALPRODUCTOS.Text = "Total Productos:";
            // 
            // lblTotalProveedores
            // 
            lblTotalProveedores.AutoSize = true;
            lblTotalProveedores.Location = new Point(54, 88);
            lblTotalProveedores.Name = "lblTotalProveedores";
            lblTotalProveedores.Size = new Size(123, 20);
            lblTotalProveedores.TabIndex = 1;
            lblTotalProveedores.Text = "Total Provedores:";
            // 
            // btnACTUALIZAR
            // 
            btnACTUALIZAR.Location = new Point(599, 520);
            btnACTUALIZAR.Name = "btnACTUALIZAR";
            btnACTUALIZAR.Size = new Size(94, 29);
            btnACTUALIZAR.TabIndex = 5;
            btnACTUALIZAR.Text = "Actualizar";
            btnACTUALIZAR.UseVisualStyleBackColor = true;
            btnACTUALIZAR.Click += btnACTUALIZAR_Click;
            // 
            // FormsPlot1
            // 
            FormsPlot1.DisplayScale = 1.25F;
            FormsPlot1.Location = new Point(12, 127);
            FormsPlot1.Name = "FormsPlot1";
            FormsPlot1.Size = new Size(1239, 365);
            FormsPlot1.TabIndex = 6;
            // 
            // FormREPORTE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1307, 561);
            Controls.Add(FormsPlot1);
            Controls.Add(btnACTUALIZAR);
            Controls.Add(lblTOTALPRODUCTOS);
            Controls.Add(lblINTERNACIONALES);
            Controls.Add(lblLOCALES);
            Controls.Add(lblTotalProveedores);
            Controls.Add(lblREPORTEPROVEEDORES);
            Name = "FormREPORTE";
            Text = "FormREPORTE";
            Load += FormREPORTE_Load;
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
    }
}