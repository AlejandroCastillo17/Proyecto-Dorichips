namespace GDI_Dorichips
{
    partial class FormGestionProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionProductos));
            btnVD = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnEditarProductos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ScrollBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(714, 342);
            dataGridView1.TabIndex = 2;
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
            // btnEditarProductos
            // 
            btnEditarProductos.BackColor = Color.FromArgb(0, 0, 192);
            btnEditarProductos.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarProductos.ForeColor = SystemColors.Window;
            btnEditarProductos.Location = new Point(548, 20);
            btnEditarProductos.Name = "btnEditarProductos";
            btnEditarProductos.Size = new Size(213, 52);
            btnEditarProductos.TabIndex = 6;
            btnEditarProductos.Text = "Edición de Productos";
            btnEditarProductos.UseVisualStyleBackColor = false;
            btnEditarProductos.Click += btnEditarProductos_Click;
            // 
            // FormGestionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditarProductos);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnVD);
            Name = "FormGestionProductos";
            Text = "FormGestionProductos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVD;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnEditarProductos;
    }
}