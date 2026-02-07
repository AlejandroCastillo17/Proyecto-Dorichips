namespace GDI_Dorichips.Interfaz
{
    partial class FormAgregarMateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarMateriaPrima));
            btnClear = new Button();
            label2 = new Label();
            btnAgregar = new Button();
            panel1 = new Panel();
            txtCantMP = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtNomMP = new TextBox();
            txtCostoMP = new TextBox();
            btnVD = new Button();
            btnAC = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 0, 192);
            btnClear.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(547, 282);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 55);
            btnClear.TabIndex = 23;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(121, 81);
            label2.Name = "label2";
            label2.Size = new Size(563, 51);
            label2.TabIndex = 21;
            label2.Text = "Agregar Nueva Materia Prima";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 0, 192);
            btnAgregar.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(547, 167);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 55);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtCantMP);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNomMP);
            panel1.Controls.Add(txtCostoMP);
            panel1.Location = new Point(121, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 185);
            panel1.TabIndex = 20;
            // 
            // txtCantMP
            // 
            txtCantMP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantMP.Location = new Point(162, 72);
            txtCantMP.MaxLength = 50;
            txtCantMP.Name = "txtCantMP";
            txtCantMP.PlaceholderText = "Kg";
            txtCantMP.Size = new Size(153, 29);
            txtCantMP.TabIndex = 18;
            txtCantMP.KeyPress += txtCantMP_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 0);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuBar;
            label4.Location = new Point(21, 121);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 17;
            label4.Text = "Costo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 192);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuBar;
            label3.Location = new Point(21, 72);
            label3.Name = "label3";
            label3.Size = new Size(103, 32);
            label3.TabIndex = 16;
            label3.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // txtNomMP
            // 
            txtNomMP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomMP.Location = new Point(162, 20);
            txtNomMP.MaxLength = 50;
            txtNomMP.Name = "txtNomMP";
            txtNomMP.PlaceholderText = "Nombre";
            txtNomMP.Size = new Size(153, 29);
            txtNomMP.TabIndex = 13;
            txtNomMP.KeyPress += txtNomMP_KeyPress;
            // 
            // txtCostoMP
            // 
            txtCostoMP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCostoMP.Location = new Point(162, 121);
            txtCostoMP.MaxLength = 50;
            txtCostoMP.Name = "txtCostoMP";
            txtCostoMP.PlaceholderText = "$$$$$$";
            txtCostoMP.Size = new Size(153, 29);
            txtCostoMP.TabIndex = 12;
            txtCostoMP.KeyPress += txtCostoMP_KeyPress;
            // 
            // btnVD
            // 
            btnVD.BackColor = Color.Transparent;
            btnVD.Image = (Image)resources.GetObject("btnVD.Image");
            btnVD.Location = new Point(12, 12);
            btnVD.Name = "btnVD";
            btnVD.Size = new Size(60, 50);
            btnVD.TabIndex = 19;
            btnVD.UseVisualStyleBackColor = false;
            btnVD.Click += btnVD_Click;
            // 
            // btnAC
            // 
            btnAC.BackColor = Color.FromArgb(255, 128, 0);
            btnAC.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAC.ForeColor = Color.White;
            btnAC.Location = new Point(582, 19);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(191, 43);
            btnAC.TabIndex = 24;
            btnAC.Text = "Actualizar Cantidades";
            btnAC.UseVisualStyleBackColor = false;
            btnAC.Click += btnAC_Click;
            // 
            // FormAgregarMateriaPrima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAC);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(panel1);
            Controls.Add(btnVD);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAgregarMateriaPrima";
            Text = "DORICHIPS";
            Load += FormAgregarMateriaPrima_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Label label2;
        private Button btnAgregar;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private TextBox txtNomMP;
        private TextBox txtCostoMP;
        private Button btnVD;
        private TextBox txtCantMP;
        private Label label4;
        private Button btnAC;
    }
}