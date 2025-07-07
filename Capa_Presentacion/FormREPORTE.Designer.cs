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
            lblPRODUCTOS = new Label();
            lblTOTAL = new Label();
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
            lblLOCALES.Location = new Point(446, 230);
            lblLOCALES.Name = "lblLOCALES";
            lblLOCALES.Size = new Size(61, 20);
            lblLOCALES.TabIndex = 2;
            lblLOCALES.Text = "Locales:";
            // 
            // lblINTERNACIONALES
            // 
            lblINTERNACIONALES.AutoSize = true;
            lblINTERNACIONALES.Location = new Point(446, 328);
            lblINTERNACIONALES.Name = "lblINTERNACIONALES";
            lblINTERNACIONALES.Size = new Size(112, 20);
            lblINTERNACIONALES.TabIndex = 3;
            lblINTERNACIONALES.Text = "Internacionales:";
            // 
            // lblPRODUCTOS
            // 
            lblPRODUCTOS.AutoSize = true;
            lblPRODUCTOS.Location = new Point(446, 419);
            lblPRODUCTOS.Name = "lblPRODUCTOS";
            lblPRODUCTOS.Size = new Size(78, 20);
            lblPRODUCTOS.TabIndex = 4;
            lblPRODUCTOS.Text = "Productos:";
            // 
            // lblTOTAL
            // 
            lblTOTAL.AutoSize = true;
            lblTOTAL.Location = new Point(446, 129);
            lblTOTAL.Name = "lblTOTAL";
            lblTOTAL.Size = new Size(45, 20);
            lblTOTAL.TabIndex = 1;
            lblTOTAL.Text = "Total:";
            // 
            // FormREPORTE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1307, 561);
            Controls.Add(lblPRODUCTOS);
            Controls.Add(lblINTERNACIONALES);
            Controls.Add(lblLOCALES);
            Controls.Add(lblTOTAL);
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
        private Label lblPRODUCTOS;
        private Label lblTOTAL;
    }
}