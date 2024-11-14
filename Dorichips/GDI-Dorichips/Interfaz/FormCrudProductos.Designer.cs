
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            txtID = new TextBox();
            label3 = new Label();
            btnAgregar = new Button();
            txtPrePro = new TextBox();
            txtNomPro = new TextBox();
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
            picFotoProducto.Location = new Point(18, 15);
            picFotoProducto.Name = "picFotoProducto";
            picFotoProducto.Size = new Size(173, 174);
            picFotoProducto.TabIndex = 3;
            picFotoProducto.TabStop = false;
            picFotoProducto.Click += picFotoProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(473, 22);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Precio";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNomPro);
            panel1.Controls.Add(txtPrePro);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(picFotoProducto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(103, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 369);
            panel1.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(197, 51);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 24);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 10;
            label3.Text = "ID";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(238, 106);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // txtPrePro
            // 
            txtPrePro.Location = new Point(473, 51);
            txtPrePro.Name = "txtPrePro";
            txtPrePro.Size = new Size(100, 23);
            txtPrePro.TabIndex = 12;
            // 
            // txtNomPro
            // 
            txtNomPro.Location = new Point(326, 51);
            txtNomPro.Name = "txtNomPro";
            txtNomPro.Size = new Size(100, 23);
            txtNomPro.TabIndex = 13;
            // 
            // FormCrudProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnVD);
            Name = "FormCrudProductos";
            Text = "FormCrudProductos";
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
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnAgregar;
        private TextBox txtID;
        private Label label3;
        private TextBox txtNomPro;
        private TextBox txtPrePro;
    }
}