namespace GDI_Dorichips
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            btnVD = new Button();
            btnAMP = new Button();
            label1 = new Label();
            dgvMateriaPrima = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMateriaPrima).BeginInit();
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
            // btnAMP
            // 
            btnAMP.BackColor = Color.FromArgb(0, 0, 192);
            btnAMP.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAMP.ForeColor = Color.White;
            btnAMP.Location = new Point(549, 41);
            btnAMP.Name = "btnAMP";
            btnAMP.Size = new Size(213, 52);
            btnAMP.TabIndex = 9;
            btnAMP.Text = "Agregar Materia Prima";
            btnAMP.UseVisualStyleBackColor = false;
            btnAMP.Click += btnAMP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(99, 25);
            label1.Name = "label1";
            label1.Size = new Size(418, 40);
            label1.TabIndex = 8;
            label1.Text = "Inventario de Materia Prima";
            // 
            // dgvMateriaPrima
            // 
            dgvMateriaPrima.BackgroundColor = SystemColors.ScrollBar;
            dgvMateriaPrima.BorderStyle = BorderStyle.Fixed3D;
            dgvMateriaPrima.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriaPrima.Location = new Point(33, 109);
            dgvMateriaPrima.Name = "dgvMateriaPrima";
            dgvMateriaPrima.Size = new Size(682, 334);
            dgvMateriaPrima.TabIndex = 7;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 475);
            Controls.Add(btnAMP);
            Controls.Add(label1);
            Controls.Add(dgvMateriaPrima);
            Controls.Add(btnVD);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInventario";
            Text = "DORICHIPS";
            Load += FormInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMateriaPrima).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVD;
        private Button btnAMP;
        private Label label1;
        private DataGridView dgvMateriaPrima;
    }
}