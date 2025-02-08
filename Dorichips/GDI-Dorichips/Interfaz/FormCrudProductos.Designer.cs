
namespace GDI_Dorichips
{
    partial class FormCrudProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrudProductos));
            btnVD = new Button();
            picFotoProducto = new PictureBox();
            panel1 = new Panel();
            btnAgregar = new Button();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtNomPro = new TextBox();
            txtPrePro = new TextBox();
            txtID = new TextBox();
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
            picFotoProducto.BackgroundImage = Properties.Resources.icodori;
            picFotoProducto.BackgroundImageLayout = ImageLayout.Stretch;
            picFotoProducto.BorderStyle = BorderStyle.Fixed3D;
            picFotoProducto.Location = new Point(18, 15);
            picFotoProducto.Name = "picFotoProducto";
            picFotoProducto.Size = new Size(173, 174);
            picFotoProducto.TabIndex = 3;
            picFotoProducto.TabStop = false;
            picFotoProducto.Click += picFotoProducto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNomPro);
            panel1.Controls.Add(txtPrePro);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(picFotoProducto);
            panel1.Location = new Point(90, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 369);
            panel1.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 128, 0);
            btnAgregar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(351, 100);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 41);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuBar;
            label3.Location = new Point(495, 22);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 16;
            label3.Text = "Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(361, 22);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 15;
            label1.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuBar;
            label4.Location = new Point(238, 22);
            label4.Name = "label4";
            label4.Size = new Size(33, 25);
            label4.TabIndex = 14;
            label4.Text = "ID";
            label4.Click += label4_Click;
            // 
            // txtNomPro
            // 
            txtNomPro.Location = new Point(351, 51);
            txtNomPro.MaxLength = 50;
            txtNomPro.Name = "txtNomPro";
            txtNomPro.Size = new Size(100, 23);
            txtNomPro.TabIndex = 13;
            // 
            // txtPrePro
            // 
            txtPrePro.Location = new Point(484, 51);
            txtPrePro.MaxLength = 50;
            txtPrePro.Name = "txtPrePro";
            txtPrePro.Size = new Size(100, 23);
            txtPrePro.TabIndex = 12;
            // 
            // txtID
            // 
            txtID.Location = new Point(213, 51);
            txtID.MaxLength = 8;
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 11;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // FormCrudProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 475);
            Controls.Add(panel1);
            Controls.Add(btnVD);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCrudProductos";
            Text = "DORICHIPS";
            Load += FormCrudProductos_Load;
            ((System.ComponentModel.ISupportInitialize)picFotoProducto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private TextBox txtID;
        private TextBox txtNomPro;
        private TextBox txtPrePro;
        private Label label4;
        private Label label1;
        private Label label3;
        private Button btnAgregar;
    }
}