namespace GDI_Dorichips.Interfaz
{
    partial class FormAsignarIngredientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignarIngredientes));
            btnVD = new Button();
            cmbProductos = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnAgregar = new Button();
            txtCantidad = new TextBox();
            label2 = new Label();
            cmbIngredientes = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVD
            // 
            btnVD.BackColor = Color.Transparent;
            btnVD.Image = (Image)resources.GetObject("btnVD.Image");
            btnVD.Location = new Point(12, 12);
            btnVD.Name = "btnVD";
            btnVD.Size = new Size(60, 50);
            btnVD.TabIndex = 3;
            btnVD.UseVisualStyleBackColor = false;
            btnVD.Click += btnVD_Click;
            // 
            // cmbProductos
            // 
            cmbProductos.BackColor = Color.Blue;
            cmbProductos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProductos.ForeColor = Color.White;
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(17, 87);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(214, 38);
            cmbProductos.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(cmbIngredientes);
            panel1.Controls.Add(cmbProductos);
            panel1.Location = new Point(65, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 262);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 0);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuBar;
            label4.Location = new Point(509, 33);
            label4.Name = "label4";
            label4.Size = new Size(117, 37);
            label4.TabIndex = 23;
            label4.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 0);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuBar;
            label3.Location = new Point(282, 33);
            label3.Name = "label3";
            label3.Size = new Size(152, 37);
            label3.TabIndex = 22;
            label3.Text = "Ingrediente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(63, 33);
            label1.Name = "label1";
            label1.Size = new Size(117, 37);
            label1.TabIndex = 21;
            label1.Text = "Producto";
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
            btnAgregar.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(147, 167);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 55);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(509, 87);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(124, 33);
            txtCantidad.TabIndex = 6;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(212, 46);
            label2.Name = "label2";
            label2.Size = new Size(397, 51);
            label2.TabIndex = 10;
            label2.Text = "Asignar Ingredientes";
            // 
            // cmbIngredientes
            // 
            cmbIngredientes.BackColor = Color.Blue;
            cmbIngredientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbIngredientes.ForeColor = Color.White;
            cmbIngredientes.FormattingEnabled = true;
            cmbIngredientes.Location = new Point(260, 87);
            cmbIngredientes.Name = "cmbIngredientes";
            cmbIngredientes.Size = new Size(206, 38);
            cmbIngredientes.TabIndex = 5;
            cmbIngredientes.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // FormAsignarIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnVD);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAsignarIngredientes";
            Text = "DORICHIPS";
            Load += FormAsignarIngredientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVD;
        private ComboBox cmbProductos;
        private Panel panel1;
        private TextBox txtCantidad;
        private Button btnClear;
        private Button btnAgregar;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private ComboBox cmbIngredientes;
    }
}