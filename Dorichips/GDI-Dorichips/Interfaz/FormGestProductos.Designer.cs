namespace GDI_Dorichips
{
    partial class FormGestProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestProductos));
            btnVD = new Button();
            dgvProductos = new DataGridView();
            label1 = new Label();
            btnEP = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnVD
            // 
            btnVD.BackColor = Color.Transparent;
            btnVD.Image = (Image)resources.GetObject("btnVD.Image");
            btnVD.Location = new Point(12, 12);
            btnVD.Name = "btnVD";
            btnVD.Size = new Size(60, 50);
            btnVD.TabIndex = 1;
            btnVD.UseVisualStyleBackColor = false;
            btnVD.Click += btnVD_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = SystemColors.ScrollBar;
            dgvProductos.BorderStyle = BorderStyle.Fixed3D;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(98, 102);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(613, 334);
            dgvProductos.TabIndex = 2;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(98, 12);
            label1.Name = "label1";
            label1.Size = new Size(371, 51);
            label1.TabIndex = 3;
            label1.Text = "Productos Dorichips";
            // 
            // btnEP
            // 
            btnEP.BackColor = Color.FromArgb(0, 0, 192);
            btnEP.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEP.ForeColor = Color.White;
            btnEP.Location = new Point(548, 28);
            btnEP.Name = "btnEP";
            btnEP.Size = new Size(213, 52);
            btnEP.TabIndex = 6;
            btnEP.Text = "Agregar Productos";
            btnEP.UseVisualStyleBackColor = false;
            btnEP.Click += btnEditarProductos_Click;
            // 
            // FormGestProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 475);
            Controls.Add(btnEP);
            Controls.Add(label1);
            Controls.Add(dgvProductos);
            Controls.Add(btnVD);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGestProductos";
            Text = "DORICHIPS";
            Load += FormGestionProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVD;
        private DataGridView dgvProductos;
        private Label label1;
        private Button btnEP;
    }
}