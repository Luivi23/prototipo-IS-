namespace prototipo_progra
{
    partial class Bloqueo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bloqueo));
            ImbLogInicio = new PictureBox();
            LblLogUsuario = new Label();
            LblLogContra = new Label();
            TbxLogUsuario = new TextBox();
            TbxLogContra = new TextBox();
            BtnLogInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)ImbLogInicio).BeginInit();
            SuspendLayout();
            // 
            // ImbLogInicio
            // 
            ImbLogInicio.Image = (Image)resources.GetObject("ImbLogInicio.Image");
            ImbLogInicio.Location = new Point(156, 118);
            ImbLogInicio.Name = "ImbLogInicio";
            ImbLogInicio.Size = new Size(165, 139);
            ImbLogInicio.SizeMode = PictureBoxSizeMode.Zoom;
            ImbLogInicio.TabIndex = 0;
            ImbLogInicio.TabStop = false;
            // 
            // LblLogUsuario
            // 
            LblLogUsuario.AutoSize = true;
            LblLogUsuario.Location = new Point(336, 140);
            LblLogUsuario.Name = "LblLogUsuario";
            LblLogUsuario.Size = new Size(47, 15);
            LblLogUsuario.TabIndex = 1;
            LblLogUsuario.Text = "Usuario";
            // 
            // LblLogContra
            // 
            LblLogContra.AutoSize = true;
            LblLogContra.Location = new Point(336, 197);
            LblLogContra.Name = "LblLogContra";
            LblLogContra.Size = new Size(67, 15);
            LblLogContra.TabIndex = 2;
            LblLogContra.Text = "Contraseña";
            LblLogContra.TextAlign = ContentAlignment.TopRight;
            // 
            // TbxLogUsuario
            // 
            TbxLogUsuario.Location = new Point(393, 137);
            TbxLogUsuario.Name = "TbxLogUsuario";
            TbxLogUsuario.Size = new Size(155, 23);
            TbxLogUsuario.TabIndex = 3;
            // 
            // TbxLogContra
            // 
            TbxLogContra.Location = new Point(409, 194);
            TbxLogContra.Name = "TbxLogContra";
            TbxLogContra.Size = new Size(139, 23);
            TbxLogContra.TabIndex = 4;
            // 
            // BtnLogInicio
            // 
            BtnLogInicio.Location = new Point(381, 261);
            BtnLogInicio.Name = "BtnLogInicio";
            BtnLogInicio.Size = new Size(75, 23);
            BtnLogInicio.TabIndex = 5;
            BtnLogInicio.Text = "Iniciar ";
            BtnLogInicio.UseVisualStyleBackColor = true;
            BtnLogInicio.Click += BtnLogInicio_Click;
            // 
            // Bloqueo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLogInicio);
            Controls.Add(TbxLogContra);
            Controls.Add(TbxLogUsuario);
            Controls.Add(LblLogContra);
            Controls.Add(LblLogUsuario);
            Controls.Add(ImbLogInicio);
            Name = "Bloqueo";
            Text = "Login ";
            ((System.ComponentModel.ISupportInitialize)ImbLogInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImbLogInicio;
        private Label LblLogUsuario;
        private Label LblLogContra;
        private TextBox TbxLogUsuario;
        private TextBox TbxLogContra;
        private Button BtnLogInicio;
    }
}
