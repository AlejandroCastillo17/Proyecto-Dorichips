namespace GDI_Dorichips
{
    partial class FormActualizarCantidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizarCantidades));
            label2 = new Label();
            panel1 = new Panel();
            lblCantidadActual = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnAgregar = new Button();
            txtCantidadNueva = new TextBox();
            cmbMT = new ComboBox();
            btnVD = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(212, 61);
            label2.Name = "label2";
            label2.Size = new Size(414, 51);
            label2.TabIndex = 12;
            label2.Text = "Actualizar Cantidades";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCantidadActual);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtCantidadNueva);
            panel1.Controls.Add(cmbMT);
            panel1.Location = new Point(65, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 262);
            panel1.TabIndex = 11;
            // 
            // lblCantidadActual
            // 
            lblCantidadActual.AutoSize = true;
            lblCantidadActual.BackColor = Color.Blue;
            lblCantidadActual.BorderStyle = BorderStyle.Fixed3D;
            lblCantidadActual.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadActual.ForeColor = SystemColors.MenuBar;
            lblCantidadActual.Location = new Point(273, 88);
            lblCantidadActual.Name = "lblCantidadActual";
            lblCantidadActual.Size = new Size(2, 37);
            lblCantidadActual.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 0);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuBar;
            label4.Location = new Point(451, 33);
            label4.Name = "label4";
            label4.Size = new Size(197, 37);
            label4.TabIndex = 23;
            label4.Text = "Nueva Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 0);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuBar;
            label3.Location = new Point(227, 33);
            label3.Name = "label3";
            label3.Size = new Size(200, 37);
            label3.TabIndex = 22;
            label3.Text = "Cantidad Actual";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(17, 33);
            label1.Name = "label1";
            label1.Size = new Size(181, 37);
            label1.TabIndex = 21;
            label1.Text = "Materia Prima";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(359, 167);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 55);
            btnClear.TabIndex = 20;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 128, 0);
            btnAgregar.Font = new Font("Comic Sans MS", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(147, 167);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 55);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Actualizar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCantidadNueva
            // 
            txtCantidadNueva.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidadNueva.Location = new Point(484, 87);
            txtCantidadNueva.Name = "txtCantidadNueva";
            txtCantidadNueva.PlaceholderText = "Kg";
            txtCantidadNueva.Size = new Size(124, 33);
            txtCantidadNueva.TabIndex = 6;
            txtCantidadNueva.KeyPress += txtCantidadNueva_KeyPress;
            // 
            // cmbMT
            // 
            cmbMT.BackColor = Color.Blue;
            cmbMT.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMT.ForeColor = Color.White;
            cmbMT.FormattingEnabled = true;
            cmbMT.Location = new Point(17, 87);
            cmbMT.Name = "cmbMT";
            cmbMT.Size = new Size(181, 38);
            cmbMT.TabIndex = 4;
            cmbMT.SelectedIndexChanged += cmbMT_SelectedIndexChanged;
            // 
            // btnVD
            // 
            btnVD.BackColor = Color.Transparent;
            btnVD.Image = (Image)resources.GetObject("btnVD.Image");
            btnVD.Location = new Point(12, 12);
            btnVD.Name = "btnVD";
            btnVD.Size = new Size(60, 50);
            btnVD.TabIndex = 13;
            btnVD.UseVisualStyleBackColor = false;
            btnVD.Click += btnVD_Click_1;
            // 
            // FormActualizarCantidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVD);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormActualizarCantidades";
            Text = "DORICHIPS";
            Load += DORICHIPS_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnClear;
        private Button btnAgregar;
        private TextBox txtCantidadNueva;
        private ComboBox cmbMT;
        private Button btnVD;
        private Label lblCantidadActual;
    }
}