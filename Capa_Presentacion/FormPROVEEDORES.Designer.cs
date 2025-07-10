namespace Capa_Presentacion
{
    partial class FormPROVEEDORES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPROVEEDORES));
            btnELIMINAR2 = new Button();
            dgvProveedores = new DataGridView();
            labelPROVEEDORESTEMP = new Label();
            btnBUSCAR2 = new Button();
            txtNOMBRE2 = new TextBox();
            lblRNC2 = new Label();
            lBLNOMBRE2 = new Label();
            mkdtxtRNC = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnELIMINAR2
            // 
            btnELIMINAR2.Location = new Point(178, 384);
            btnELIMINAR2.Name = "btnELIMINAR2";
            btnELIMINAR2.Size = new Size(145, 29);
            btnELIMINAR2.TabIndex = 1;
            btnELIMINAR2.Text = "Eliminar";
            btnELIMINAR2.UseVisualStyleBackColor = true;
            btnELIMINAR2.Click += btnELIMINAR2_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.BackgroundColor = SystemColors.ControlLightLight;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(387, 135);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(715, 298);
            dgvProveedores.TabIndex = 3;
            // 
            // labelPROVEEDORESTEMP
            // 
            labelPROVEEDORESTEMP.AutoSize = true;
            labelPROVEEDORESTEMP.BackColor = SystemColors.ActiveCaption;
            labelPROVEEDORESTEMP.Font = new Font("Modern No. 20", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPROVEEDORESTEMP.Location = new Point(411, 50);
            labelPROVEEDORESTEMP.Name = "labelPROVEEDORESTEMP";
            labelPROVEEDORESTEMP.Size = new Size(234, 31);
            labelPROVEEDORESTEMP.TabIndex = 4;
            labelPROVEEDORESTEMP.Text = "PROVEEDORES";
            // 
            // btnBUSCAR2
            // 
            btnBUSCAR2.Location = new Point(178, 321);
            btnBUSCAR2.Name = "btnBUSCAR2";
            btnBUSCAR2.Size = new Size(145, 29);
            btnBUSCAR2.TabIndex = 6;
            btnBUSCAR2.Text = "Buscar";
            btnBUSCAR2.UseVisualStyleBackColor = true;
            btnBUSCAR2.Click += btnBUSCAR2_Click;
            // 
            // txtNOMBRE2
            // 
            txtNOMBRE2.Location = new Point(158, 240);
            txtNOMBRE2.Name = "txtNOMBRE2";
            txtNOMBRE2.Size = new Size(184, 27);
            txtNOMBRE2.TabIndex = 9;
            // 
            // lblRNC2
            // 
            lblRNC2.AutoSize = true;
            lblRNC2.Location = new Point(114, 173);
            lblRNC2.Name = "lblRNC2";
            lblRNC2.Size = new Size(38, 20);
            lblRNC2.TabIndex = 11;
            lblRNC2.Text = "RNC";
            // 
            // lBLNOMBRE2
            // 
            lBLNOMBRE2.AutoSize = true;
            lBLNOMBRE2.Location = new Point(88, 247);
            lBLNOMBRE2.Name = "lBLNOMBRE2";
            lBLNOMBRE2.Size = new Size(64, 20);
            lBLNOMBRE2.TabIndex = 12;
            lBLNOMBRE2.Text = "Nombre";
            // 
            // mkdtxtRNC
            // 
            mkdtxtRNC.Location = new Point(158, 166);
            mkdtxtRNC.Mask = "999999999";
            mkdtxtRNC.Name = "mkdtxtRNC";
            mkdtxtRNC.Size = new Size(184, 27);
            mkdtxtRNC.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormPROVEEDORES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1215, 545);
            Controls.Add(pictureBox1);
            Controls.Add(mkdtxtRNC);
            Controls.Add(lBLNOMBRE2);
            Controls.Add(lblRNC2);
            Controls.Add(txtNOMBRE2);
            Controls.Add(btnBUSCAR2);
            Controls.Add(labelPROVEEDORESTEMP);
            Controls.Add(dgvProveedores);
            Controls.Add(btnELIMINAR2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPROVEEDORES";
            Text = "FormPROVEEDORES";
            Load += FormPROVEEDORES_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnELIMINAR2;
        private DataGridView dgvProveedores;
        private Label labelPROVEEDORESTEMP;
        private Button btnBUSCAR2;
        private Label label1;
        private Label label2;
        private TextBox txtNOMBRE2;
        private Label lblRNC2;
        private Label lBLNOMBRE2;
        private MaskedTextBox mkdtxtRNC;
        private PictureBox pictureBox1;
    }
}