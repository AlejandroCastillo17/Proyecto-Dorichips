namespace GDI_Dorichips
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            btnContinuar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.FromArgb(255, 129, 0);
            btnContinuar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinuar.ForeColor = SystemColors.Window;
            btnContinuar.Location = new Point(318, 397);
            btnContinuar.Margin = new Padding(0);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(189, 44);
            btnContinuar.TabIndex = 0;
            btnContinuar.Text = "Continuar";
            btnContinuar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(557, 35);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido al gestor de inventario de Dorichps";
            label1.Click += label1_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 475);
            Controls.Add(label1);
            Controls.Add(btnContinuar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInicio";
            Text = "DORICHIPS";
            Load += FormInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContinuar;
        private Label label1;
    }
}