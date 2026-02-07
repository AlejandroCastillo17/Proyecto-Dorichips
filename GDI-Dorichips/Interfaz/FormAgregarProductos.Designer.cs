
namespace GDI_Dorichips
{
    partial class FormAgregarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarProductos));
            btnVD = new Button();
            picFotoProducto = new PictureBox();
            panel1 = new Panel();
            btnSleccionarFoto = new Button();
            label3 = new Label();
            label1 = new Label();
            txtNomPro = new TextBox();
            txtPrePro = new TextBox();
            btnAgregar = new Button();
            label2 = new Label();
            btnClear = new Button();
            btnAI = new Button();
            ((System.ComponentModel.ISupportInitialize)picFotoProducto).BeginInit();
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
            btnVD.TabIndex = 2;
            btnVD.UseVisualStyleBackColor = false;
            btnVD.Click += btnVD_Click;
            // 
            // picFotoProducto
            // 
            picFotoProducto.BackColor = SystemColors.Window;
            picFotoProducto.BackgroundImageLayout = ImageLayout.Stretch;
            picFotoProducto.BorderStyle = BorderStyle.Fixed3D;
            picFotoProducto.Image = Properties.Resources.icodori;
            picFotoProducto.Location = new Point(18, 15);
            picFotoProducto.Name = "picFotoProducto";
            picFotoProducto.Size = new Size(173, 174);
            picFotoProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoProducto.TabIndex = 3;
            picFotoProducto.TabStop = false;
            picFotoProducto.Click += picFotoProducto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnSleccionarFoto);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNomPro);
            panel1.Controls.Add(txtPrePro);
            panel1.Controls.Add(picFotoProducto);
            panel1.Location = new Point(99, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 266);
            panel1.TabIndex = 8;
            // 
            // btnSleccionarFoto
            // 
            btnSleccionarFoto.BackColor = Color.FromArgb(255, 128, 0);
            btnSleccionarFoto.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSleccionarFoto.ForeColor = Color.White;
            btnSleccionarFoto.Location = new Point(42, 195);
            btnSleccionarFoto.Name = "btnSleccionarFoto";
            btnSleccionarFoto.Size = new Size(125, 41);
            btnSleccionarFoto.TabIndex = 18;
            btnSleccionarFoto.Text = "Subir Imagen";
            btnSleccionarFoto.UseVisualStyleBackColor = false;
            btnSleccionarFoto.Click += btnSleccionarFoto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 192);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuBar;
            label3.Location = new Point(239, 109);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 16;
            label3.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(239, 22);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 15;
            label1.Text = "Producto";
            // 
            // txtNomPro
            // 
            txtNomPro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomPro.Location = new Point(239, 67);
            txtNomPro.MaxLength = 50;
            txtNomPro.Name = "txtNomPro";
            txtNomPro.PlaceholderText = "Nombre";
            txtNomPro.Size = new Size(153, 29);
            txtNomPro.TabIndex = 13;
            txtNomPro.KeyPress += txtNomPro_KeyPress;
            // 
            // txtPrePro
            // 
            txtPrePro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrePro.Location = new Point(239, 156);
            txtPrePro.MaxLength = 50;
            txtPrePro.Name = "txtPrePro";
            txtPrePro.PlaceholderText = "$$$$$$";
            txtPrePro.Size = new Size(153, 29);
            txtPrePro.TabIndex = 12;
            txtPrePro.KeyPress += txtPrePro_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 0, 192);
            btnAgregar.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(607, 188);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 55);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(88, 80);
            label2.Name = "label2";
            label2.Size = new Size(459, 51);
            label2.TabIndex = 9;
            label2.Text = "Agregar Nuevo Producto";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 0, 192);
            btnClear.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(607, 286);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 55);
            btnClear.TabIndex = 18;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAI
            // 
            btnAI.BackColor = Color.FromArgb(255, 128, 0);
            btnAI.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAI.ForeColor = Color.White;
            btnAI.Location = new Point(582, 19);
            btnAI.Name = "btnAI";
            btnAI.Size = new Size(191, 43);
            btnAI.TabIndex = 19;
            btnAI.Text = "Asignar Ingredientes";
            btnAI.UseVisualStyleBackColor = false;
            btnAI.Click += btnAI_Click;
            // 
            // FormAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 475);
            Controls.Add(btnAI);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(panel1);
            Controls.Add(btnVD);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAgregarProductos";
            Text = "DORICHIPS";
            Load += FormCrudProductos_Load;
            ((System.ComponentModel.ISupportInitialize)picFotoProducto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void picFotoProducto_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnVD;
        private PictureBox picFotoProducto;
        private Panel panel1;
        private TextBox txtNomPro;
        private TextBox txtPrePro;
        private Label label1;
        private Label label3;
        private Button btnAgregar;
        private Button btnSleccionarFoto;
        private Label label2;
        private Button btnClear;
        private Button btnAI;
    }
}