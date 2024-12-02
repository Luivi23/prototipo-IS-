namespace prototipo_progra
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            BtnPrincInven = new Button();
            BtnPrincRegistro = new Button();
            BtnPrincFactura = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(301, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(69, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(613, 99);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // BtnPrincInven
            // 
            BtnPrincInven.Location = new Point(94, 214);
            BtnPrincInven.Name = "BtnPrincInven";
            BtnPrincInven.Size = new Size(75, 23);
            BtnPrincInven.TabIndex = 3;
            BtnPrincInven.Text = "Inventario";
            BtnPrincInven.UseVisualStyleBackColor = true;
            BtnPrincInven.Click += button1_Click;
            // 
            // BtnPrincRegistro
            // 
            BtnPrincRegistro.Location = new Point(364, 214);
            BtnPrincRegistro.Name = "BtnPrincRegistro";
            BtnPrincRegistro.Size = new Size(75, 23);
            BtnPrincRegistro.TabIndex = 4;
            BtnPrincRegistro.Text = "Registro";
            BtnPrincRegistro.UseVisualStyleBackColor = true;
            BtnPrincRegistro.Click += button2_Click;
            // 
            // BtnPrincFactura
            // 
            BtnPrincFactura.Location = new Point(634, 214);
            BtnPrincFactura.Name = "BtnPrincFactura";
            BtnPrincFactura.Size = new Size(75, 23);
            BtnPrincFactura.TabIndex = 5;
            BtnPrincFactura.Text = "Facturas";
            BtnPrincFactura.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(670, 357);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "cerrar sesión";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(BtnPrincFactura);
            Controls.Add(BtnPrincRegistro);
            Controls.Add(BtnPrincInven);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Principal";
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button BtnPrincInven;
        private Button BtnPrincRegistro;
        private Button BtnPrincFactura;
        private Button btnSalir;
    }
}