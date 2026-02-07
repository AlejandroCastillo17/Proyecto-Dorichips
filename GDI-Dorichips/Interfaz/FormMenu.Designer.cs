namespace GDI_Dorichips
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            label1 = new Label();
            btnInciarDia = new Button();
            btnGestorProductos = new Button();
            btnInventario = new Button();
            btnVinforme = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(282, 30);
            label1.Name = "label1";
            label1.Size = new Size(264, 49);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            // 
            // btnInciarDia
            // 
            btnInciarDia.BackColor = Color.FromArgb(255, 128, 0);
            btnInciarDia.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInciarDia.ForeColor = SystemColors.Window;
            btnInciarDia.Location = new Point(266, 119);
            btnInciarDia.Name = "btnInciarDia";
            btnInciarDia.Size = new Size(280, 44);
            btnInciarDia.TabIndex = 1;
            btnInciarDia.Text = "Iniciar Dia";
            btnInciarDia.UseVisualStyleBackColor = false;
            btnInciarDia.Click += btnInciarDia_Click;
            // 
            // btnGestorProductos
            // 
            btnGestorProductos.BackColor = Color.FromArgb(0, 0, 192);
            btnGestorProductos.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            btnGestorProductos.ForeColor = SystemColors.Window;
            btnGestorProductos.Location = new Point(266, 187);
            btnGestorProductos.Name = "btnGestorProductos";
            btnGestorProductos.Size = new Size(280, 44);
            btnGestorProductos.TabIndex = 5;
            btnGestorProductos.Text = "Gestión de Productos";
            btnGestorProductos.UseVisualStyleBackColor = false;
            btnGestorProductos.Click += btnGestorProductos_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(255, 128, 0);
            btnInventario.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            btnInventario.ForeColor = SystemColors.Window;
            btnInventario.Location = new Point(266, 264);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(280, 44);
            btnInventario.TabIndex = 6;
            btnInventario.Text = "Gestión de Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnVinforme
            // 
            btnVinforme.BackColor = Color.FromArgb(0, 0, 192);
            btnVinforme.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            btnVinforme.ForeColor = SystemColors.Window;
            btnVinforme.Location = new Point(266, 337);
            btnVinforme.Name = "btnVinforme";
            btnVinforme.Size = new Size(280, 44);
            btnVinforme.TabIndex = 7;
            btnVinforme.Text = "Ver Informe Semanal";
            btnVinforme.UseVisualStyleBackColor = false;
            btnVinforme.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(-1, 453);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 8;
            label2.Text = "V.1.0.0 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(718, 453);
            label3.Name = "label3";
            label3.Size = new Size(85, 22);
            label3.TabIndex = 9;
            label3.Text = "By Alejo";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 475);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnVinforme);
            Controls.Add(btnInventario);
            Controls.Add(btnGestorProductos);
            Controls.Add(btnInciarDia);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            Text = "DORICHIPS";
            Load += FormMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnInciarDia;
        private Button btnGestorProductos;
        private Button btnInventario;
        private Button btnVinforme;
        private Label label2;
        private Label label3;
    }
}