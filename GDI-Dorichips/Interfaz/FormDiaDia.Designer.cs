
namespace GDI_Dorichips
{
    partial class FormDiaDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiaDia));
            btnVD = new Button();
            DGproductos = new DataGridView();
            label1 = new Label();
            btnAgregarP = new Button();
            DGpedido = new DataGridView();
            btnAceptarPe = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnEliminarP = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            txtCliente = new TextBox();
            lblTotal = new Label();
            txbObservacion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGproductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGpedido).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnVD
            // 
            btnVD.BackColor = Color.Transparent;
            btnVD.Image = (Image)resources.GetObject("btnVD.Image");
            btnVD.Location = new Point(12, 12);
            btnVD.Name = "btnVD";
            btnVD.Size = new Size(60, 56);
            btnVD.TabIndex = 0;
            btnVD.UseVisualStyleBackColor = false;
            btnVD.Click += btnVD_Click;
            // 
            // DGproductos
            // 
            DGproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGproductos.Location = new Point(-1, 41);
            DGproductos.Name = "DGproductos";
            DGproductos.Size = new Size(274, 305);
            DGproductos.TabIndex = 1;
            DGproductos.CellContentClick += DGproductos_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(16, 3);
            label1.Name = "label1";
            label1.Size = new Size(244, 35);
            label1.TabIndex = 2;
            label1.Text = "Productos Dorichips";
            // 
            // btnAgregarP
            // 
            btnAgregarP.BackColor = Color.LimeGreen;
            btnAgregarP.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarP.Location = new Point(59, 352);
            btnAgregarP.Name = "btnAgregarP";
            btnAgregarP.Size = new Size(156, 50);
            btnAgregarP.TabIndex = 3;
            btnAgregarP.Text = "Agregar al pedido";
            btnAgregarP.UseVisualStyleBackColor = false;
            btnAgregarP.Click += btnAgregarP_Click;
            // 
            // DGpedido
            // 
            DGpedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGpedido.Location = new Point(0, 38);
            DGpedido.Name = "DGpedido";
            DGpedido.Size = new Size(353, 170);
            DGpedido.TabIndex = 4;
            DGpedido.CellContentClick += DGpedido_CellContentClick;
            // 
            // btnAceptarPe
            // 
            btnAceptarPe.BackColor = Color.LimeGreen;
            btnAceptarPe.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptarPe.Location = new Point(72, 327);
            btnAceptarPe.Name = "btnAceptarPe";
            btnAceptarPe.Size = new Size(75, 77);
            btnAceptarPe.TabIndex = 5;
            btnAceptarPe.Text = "Aceptar Pedido";
            btnAceptarPe.UseVisualStyleBackColor = false;
            btnAceptarPe.Click += btnAceptarPe_Click;
            // 
            // btnEliminarP
            // 
            btnEliminarP.BackColor = Color.Firebrick;
            btnEliminarP.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarP.Location = new Point(203, 327);
            btnEliminarP.Name = "btnEliminarP";
            btnEliminarP.Size = new Size(75, 77);
            btnEliminarP.TabIndex = 6;
            btnEliminarP.Text = "Eliminar del Pedido";
            btnEliminarP.UseVisualStyleBackColor = false;
            btnEliminarP.Click += btnEliminarP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Comic Sans MS", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(98, 3);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 7;
            label2.Text = "Pedido Actual";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(DGproductos);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAgregarP);
            panel1.Location = new Point(88, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 414);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(txtCliente);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(txbObservacion);
            panel2.Controls.Add(DGpedido);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnEliminarP);
            panel2.Controls.Add(btnAceptarPe);
            panel2.Location = new Point(418, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 414);
            panel2.TabIndex = 9;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(13, 257);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Nombre del cliente";
            txtCliente.Size = new Size(327, 29);
            txtCliente.TabIndex = 10;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Blue;
            lblTotal.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.Window;
            lblTotal.Location = new Point(81, 217);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 30);
            lblTotal.TabIndex = 9;
            // 
            // txbObservacion
            // 
            txbObservacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbObservacion.Location = new Point(13, 292);
            txbObservacion.Name = "txbObservacion";
            txbObservacion.PlaceholderText = "Observaciones del pedido";
            txbObservacion.Size = new Size(327, 29);
            txbObservacion.TabIndex = 8;
            // 
            // FormDiaDia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 475);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnVD);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDiaDia";
            Text = "DORICHIPS";
            Load += FormDiaDia_Load;
            ((System.ComponentModel.ISupportInitialize)DGproductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGpedido).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private Button btnVD;
        private DataGridView DGproductos;
        private Label label1;
        private Button btnAgregarP;
        private DataGridView DGpedido;
        private Button btnAceptarPe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnEliminarP;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private TextBox txbObservacion;
        private Label lblTotal;
        private TextBox txtCliente;
    }
}