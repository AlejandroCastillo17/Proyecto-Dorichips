namespace GDI_Dorichips
{
    partial class FormInforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInforme));
            btnVD = new Button();
            DGInformeSemanal = new DataGridView();
            dtpinicio = new DateTimePicker();
            dtpfin = new DateTimePicker();
            btnExportar = new Button();
            label2 = new Label();
            lblUtilidad = new Label();
            lblVentaTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)DGInformeSemanal).BeginInit();
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
            // DGInformeSemanal
            // 
            DGInformeSemanal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGInformeSemanal.Location = new Point(75, 156);
            DGInformeSemanal.Name = "DGInformeSemanal";
            DGInformeSemanal.Size = new Size(670, 247);
            DGInformeSemanal.TabIndex = 2;
            // 
            // dtpinicio
            // 
            dtpinicio.CalendarFont = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpinicio.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpinicio.Location = new Point(75, 114);
            dtpinicio.Name = "dtpinicio";
            dtpinicio.Size = new Size(314, 26);
            dtpinicio.TabIndex = 3;
            dtpinicio.Value = new DateTime(2025, 2, 26, 14, 19, 11, 0);
            dtpinicio.ValueChanged += dtpinicio_ValueChanged_1;
            // 
            // dtpfin
            // 
            dtpfin.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpfin.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpfin.Location = new Point(429, 114);
            dtpfin.Name = "dtpfin";
            dtpfin.Size = new Size(316, 26);
            dtpfin.TabIndex = 4;
            dtpfin.Value = new DateTime(2025, 2, 26, 14, 19, 1, 0);
            dtpfin.ValueChanged += dtpfin_ValueChanged_1;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(255, 128, 0);
            btnExportar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(554, 32);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(191, 43);
            btnExportar.TabIndex = 20;
            btnExportar.Text = "Exportar a PDF";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(109, 24);
            label2.Name = "label2";
            label2.Size = new Size(381, 51);
            label2.TabIndex = 21;
            label2.Text = "Informe de Utilidad";
            // 
            // lblUtilidad
            // 
            lblUtilidad.AutoSize = true;
            lblUtilidad.BackColor = Color.FromArgb(255, 128, 0);
            lblUtilidad.BorderStyle = BorderStyle.Fixed3D;
            lblUtilidad.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUtilidad.ForeColor = SystemColors.MenuBar;
            lblUtilidad.Location = new Point(418, 422);
            lblUtilidad.Name = "lblUtilidad";
            lblUtilidad.Size = new Size(2, 32);
            lblUtilidad.TabIndex = 23;
            // 
            // lblVentaTotal
            // 
            lblVentaTotal.AutoSize = true;
            lblVentaTotal.BackColor = Color.FromArgb(255, 128, 0);
            lblVentaTotal.BorderStyle = BorderStyle.Fixed3D;
            lblVentaTotal.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentaTotal.ForeColor = SystemColors.MenuBar;
            lblVentaTotal.Location = new Point(75, 422);
            lblVentaTotal.Name = "lblVentaTotal";
            lblVentaTotal.Size = new Size(2, 32);
            lblVentaTotal.TabIndex = 24;
            // 
            // FormInforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 475);
            Controls.Add(lblVentaTotal);
            Controls.Add(lblUtilidad);
            Controls.Add(label2);
            Controls.Add(btnExportar);
            Controls.Add(dtpfin);
            Controls.Add(dtpinicio);
            Controls.Add(DGInformeSemanal);
            Controls.Add(btnVD);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInforme";
            Text = "DORICHIPS";
            Load += FormInforme_Load;
            ((System.ComponentModel.ISupportInitialize)DGInformeSemanal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVD;
        private DataGridView DGInformeSemanal;
        private DateTimePicker dtpinicio;
        private DateTimePicker dtpfin;
        private Button btnExportar;
        private Label label2;
        private Label lblUtilidad;
        private Label lblVentaTotal;
    }
}