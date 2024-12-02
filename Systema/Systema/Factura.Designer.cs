namespace prototipo_progra
{
    partial class Factura
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
            lblBuscarAlumnos = new Label();
            txtBuscarAlumnos = new TextBox();
            grdDatosAlumnos = new DataGridView();
            idAlumno = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            GrbDatosInventario = new GroupBox();
            lblDuiAlumno = new Label();
            txtDuiAlumno = new TextBox();
            lblTelefonoAlumno = new Label();
            txtTelefonoAlumno = new TextBox();
            lblDireccionAlumno = new Label();
            txtDireccionAlumno = new TextBox();
            lblNombreAlumno = new Label();
            txtNombreAlumno = new TextBox();
            lblCodigoAlumno = new Label();
            txtCodigoAlumno = new TextBox();
            grbNavegacionAlumno = new GroupBox();
            lblRegistrosAlumnos = new Label();
            btnUltimoAlumno = new Button();
            btnSiguienteAlumno = new Button();
            btnAnteriorAlumno = new Button();
            btnPrimeroAlumno = new Button();
            grbEdicionAlumno = new GroupBox();
            btnEliminarAlumno = new Button();
            btnModificarAlumno = new Button();
            btnNuevoAlumno = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)grdDatosAlumnos).BeginInit();
            GrbDatosInventario.SuspendLayout();
            grbNavegacionAlumno.SuspendLayout();
            grbEdicionAlumno.SuspendLayout();
            SuspendLayout();
            // 
            // lblBuscarAlumnos
            // 
            lblBuscarAlumnos.AutoSize = true;
            lblBuscarAlumnos.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscarAlumnos.Location = new Point(378, 19);
            lblBuscarAlumnos.Margin = new Padding(4, 0, 4, 0);
            lblBuscarAlumnos.Name = "lblBuscarAlumnos";
            lblBuscarAlumnos.Size = new Size(91, 24);
            lblBuscarAlumnos.TabIndex = 13;
            lblBuscarAlumnos.Text = "BUSCAR:";
            // 
            // txtBuscarAlumnos
            // 
            txtBuscarAlumnos.Location = new Point(485, 25);
            txtBuscarAlumnos.Margin = new Padding(4, 3, 4, 3);
            txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            txtBuscarAlumnos.Size = new Size(404, 23);
            txtBuscarAlumnos.TabIndex = 12;
            // 
            // grdDatosAlumnos
            // 
            grdDatosAlumnos.AllowUserToAddRows = false;
            grdDatosAlumnos.AllowUserToDeleteRows = false;
            grdDatosAlumnos.BackgroundColor = SystemColors.Control;
            grdDatosAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDatosAlumnos.Columns.AddRange(new DataGridViewColumn[] { idAlumno, codigo, nombre, direccion, telefono });
            grdDatosAlumnos.Location = new Point(383, 55);
            grdDatosAlumnos.Margin = new Padding(4, 3, 4, 3);
            grdDatosAlumnos.Name = "grdDatosAlumnos";
            grdDatosAlumnos.ReadOnly = true;
            grdDatosAlumnos.Size = new Size(506, 291);
            grdDatosAlumnos.TabIndex = 11;
            // 
            // idAlumno
            // 
            idAlumno.DataPropertyName = "idAlumno";
            idAlumno.HeaderText = "ID";
            idAlumno.Name = "idAlumno";
            idAlumno.ReadOnly = true;
            idAlumno.Visible = false;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.HeaderText = "CODIGO";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "NOMBRE";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.DataPropertyName = "direccion";
            direccion.HeaderText = "DIRECCION";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "TELEFONO";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // GrbDatosInventario
            // 
            GrbDatosInventario.Controls.Add(lblDuiAlumno);
            GrbDatosInventario.Controls.Add(txtDuiAlumno);
            GrbDatosInventario.Controls.Add(lblTelefonoAlumno);
            GrbDatosInventario.Controls.Add(txtTelefonoAlumno);
            GrbDatosInventario.Controls.Add(lblDireccionAlumno);
            GrbDatosInventario.Controls.Add(txtDireccionAlumno);
            GrbDatosInventario.Controls.Add(lblNombreAlumno);
            GrbDatosInventario.Controls.Add(txtNombreAlumno);
            GrbDatosInventario.Controls.Add(lblCodigoAlumno);
            GrbDatosInventario.Controls.Add(txtCodigoAlumno);
            GrbDatosInventario.Enabled = false;
            GrbDatosInventario.Location = new Point(13, 12);
            GrbDatosInventario.Margin = new Padding(4, 3, 4, 3);
            GrbDatosInventario.Name = "GrbDatosInventario";
            GrbDatosInventario.Padding = new Padding(4, 3, 4, 3);
            GrbDatosInventario.Size = new Size(357, 273);
            GrbDatosInventario.TabIndex = 14;
            GrbDatosInventario.TabStop = false;
            GrbDatosInventario.Text = "agregar Factura ";
            // 
            // lblDuiAlumno
            // 
            lblDuiAlumno.AutoSize = true;
            lblDuiAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDuiAlumno.Location = new Point(37, 231);
            lblDuiAlumno.Margin = new Padding(4, 0, 4, 0);
            lblDuiAlumno.Name = "lblDuiAlumno";
            lblDuiAlumno.Size = new Size(43, 24);
            lblDuiAlumno.TabIndex = 9;
            lblDuiAlumno.Text = "Dui:";
            // 
            // txtDuiAlumno
            // 
            txtDuiAlumno.Location = new Point(153, 235);
            txtDuiAlumno.Margin = new Padding(4, 3, 4, 3);
            txtDuiAlumno.Name = "txtDuiAlumno";
            txtDuiAlumno.Size = new Size(116, 23);
            txtDuiAlumno.TabIndex = 8;
            // 
            // lblTelefonoAlumno
            // 
            lblTelefonoAlumno.AutoSize = true;
            lblTelefonoAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefonoAlumno.Location = new Point(37, 179);
            lblTelefonoAlumno.Margin = new Padding(4, 0, 4, 0);
            lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            lblTelefonoAlumno.Size = new Size(90, 24);
            lblTelefonoAlumno.TabIndex = 7;
            lblTelefonoAlumno.Text = "Telefono:";
            // 
            // txtTelefonoAlumno
            // 
            txtTelefonoAlumno.Location = new Point(153, 183);
            txtTelefonoAlumno.Margin = new Padding(4, 3, 4, 3);
            txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            txtTelefonoAlumno.Size = new Size(116, 23);
            txtTelefonoAlumno.TabIndex = 6;
            // 
            // lblDireccionAlumno
            // 
            lblDireccionAlumno.AutoSize = true;
            lblDireccionAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccionAlumno.Location = new Point(37, 134);
            lblDireccionAlumno.Margin = new Padding(4, 0, 4, 0);
            lblDireccionAlumno.Name = "lblDireccionAlumno";
            lblDireccionAlumno.Size = new Size(95, 24);
            lblDireccionAlumno.TabIndex = 5;
            lblDireccionAlumno.Text = "Direccion:";
            // 
            // txtDireccionAlumno
            // 
            txtDireccionAlumno.Location = new Point(153, 138);
            txtDireccionAlumno.Margin = new Padding(4, 3, 4, 3);
            txtDireccionAlumno.Name = "txtDireccionAlumno";
            txtDireccionAlumno.Size = new Size(196, 23);
            txtDireccionAlumno.TabIndex = 4;
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreAlumno.Location = new Point(37, 88);
            lblNombreAlumno.Margin = new Padding(4, 0, 4, 0);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(84, 24);
            lblNombreAlumno.TabIndex = 3;
            lblNombreAlumno.Text = "Nombre:";
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(153, 92);
            txtNombreAlumno.Margin = new Padding(4, 3, 4, 3);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(196, 23);
            txtNombreAlumno.TabIndex = 2;
            // 
            // lblCodigoAlumno
            // 
            lblCodigoAlumno.AutoSize = true;
            lblCodigoAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigoAlumno.Location = new Point(37, 43);
            lblCodigoAlumno.Margin = new Padding(4, 0, 4, 0);
            lblCodigoAlumno.Name = "lblCodigoAlumno";
            lblCodigoAlumno.Size = new Size(76, 24);
            lblCodigoAlumno.TabIndex = 1;
            lblCodigoAlumno.Text = "Codigo:";
            // 
            // txtCodigoAlumno
            // 
            txtCodigoAlumno.Location = new Point(153, 47);
            txtCodigoAlumno.Margin = new Padding(4, 3, 4, 3);
            txtCodigoAlumno.Name = "txtCodigoAlumno";
            txtCodigoAlumno.Size = new Size(116, 23);
            txtCodigoAlumno.TabIndex = 0;
            // 
            // grbNavegacionAlumno
            // 
            grbNavegacionAlumno.Controls.Add(lblRegistrosAlumnos);
            grbNavegacionAlumno.Controls.Add(btnUltimoAlumno);
            grbNavegacionAlumno.Controls.Add(btnSiguienteAlumno);
            grbNavegacionAlumno.Controls.Add(btnAnteriorAlumno);
            grbNavegacionAlumno.Controls.Add(btnPrimeroAlumno);
            grbNavegacionAlumno.Location = new Point(13, 371);
            grbNavegacionAlumno.Margin = new Padding(4, 3, 4, 3);
            grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            grbNavegacionAlumno.Padding = new Padding(4, 3, 4, 3);
            grbNavegacionAlumno.Size = new Size(248, 67);
            grbNavegacionAlumno.TabIndex = 15;
            grbNavegacionAlumno.TabStop = false;
            grbNavegacionAlumno.Text = "Navegacion";
            // 
            // lblRegistrosAlumnos
            // 
            lblRegistrosAlumnos.AutoSize = true;
            lblRegistrosAlumnos.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrosAlumnos.Location = new Point(90, 28);
            lblRegistrosAlumnos.Margin = new Padding(4, 0, 4, 0);
            lblRegistrosAlumnos.Name = "lblRegistrosAlumnos";
            lblRegistrosAlumnos.Size = new Size(63, 24);
            lblRegistrosAlumnos.TabIndex = 10;
            lblRegistrosAlumnos.Text = "x de n";
            // 
            // btnUltimoAlumno
            // 
            btnUltimoAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUltimoAlumno.Location = new Point(201, 16);
            btnUltimoAlumno.Margin = new Padding(4, 3, 4, 3);
            btnUltimoAlumno.Name = "btnUltimoAlumno";
            btnUltimoAlumno.Size = new Size(41, 44);
            btnUltimoAlumno.TabIndex = 3;
            btnUltimoAlumno.Text = ">|";
            btnUltimoAlumno.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteAlumno
            // 
            btnSiguienteAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguienteAlumno.Location = new Point(162, 16);
            btnSiguienteAlumno.Margin = new Padding(4, 3, 4, 3);
            btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            btnSiguienteAlumno.Size = new Size(41, 44);
            btnSiguienteAlumno.TabIndex = 2;
            btnSiguienteAlumno.Text = ">";
            btnSiguienteAlumno.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorAlumno
            // 
            btnAnteriorAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnteriorAlumno.Location = new Point(47, 21);
            btnAnteriorAlumno.Margin = new Padding(4, 3, 4, 3);
            btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            btnAnteriorAlumno.Size = new Size(41, 44);
            btnAnteriorAlumno.TabIndex = 1;
            btnAnteriorAlumno.Text = "<";
            btnAnteriorAlumno.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroAlumno
            // 
            btnPrimeroAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrimeroAlumno.Location = new Point(8, 21);
            btnPrimeroAlumno.Margin = new Padding(4, 3, 4, 3);
            btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            btnPrimeroAlumno.Size = new Size(41, 44);
            btnPrimeroAlumno.TabIndex = 0;
            btnPrimeroAlumno.Text = "|<";
            btnPrimeroAlumno.UseVisualStyleBackColor = true;
            // 
            // grbEdicionAlumno
            // 
            grbEdicionAlumno.Controls.Add(btnEliminarAlumno);
            grbEdicionAlumno.Controls.Add(btnModificarAlumno);
            grbEdicionAlumno.Controls.Add(btnNuevoAlumno);
            grbEdicionAlumno.Location = new Point(292, 371);
            grbEdicionAlumno.Margin = new Padding(4, 3, 4, 3);
            grbEdicionAlumno.Name = "grbEdicionAlumno";
            grbEdicionAlumno.Padding = new Padding(4, 3, 4, 3);
            grbEdicionAlumno.Size = new Size(343, 67);
            grbEdicionAlumno.TabIndex = 16;
            grbEdicionAlumno.TabStop = false;
            grbEdicionAlumno.Text = "Navegacion";
            // 
            // btnEliminarAlumno
            // 
            btnEliminarAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarAlumno.Location = new Point(220, 22);
            btnEliminarAlumno.Margin = new Padding(4, 3, 4, 3);
            btnEliminarAlumno.Name = "btnEliminarAlumno";
            btnEliminarAlumno.Size = new Size(113, 44);
            btnEliminarAlumno.TabIndex = 6;
            btnEliminarAlumno.Text = "Eliminar";
            btnEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumno
            // 
            btnModificarAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarAlumno.Location = new Point(102, 22);
            btnModificarAlumno.Margin = new Padding(4, 3, 4, 3);
            btnModificarAlumno.Name = "btnModificarAlumno";
            btnModificarAlumno.Size = new Size(121, 44);
            btnModificarAlumno.TabIndex = 5;
            btnModificarAlumno.Text = "Modificar";
            btnModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnNuevoAlumno
            // 
            btnNuevoAlumno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoAlumno.Location = new Point(7, 22);
            btnNuevoAlumno.Margin = new Padding(4, 3, 4, 3);
            btnNuevoAlumno.Name = "btnNuevoAlumno";
            btnNuevoAlumno.Size = new Size(97, 44);
            btnNuevoAlumno.TabIndex = 4;
            btnNuevoAlumno.Text = "Nuevo";
            btnNuevoAlumno.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(738, 399);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(71, 37);
            button1.TabIndex = 9;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(817, 397);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(72, 39);
            button2.TabIndex = 10;
            button2.Text = "salir ";
            button2.UseVisualStyleBackColor = true;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(902, 450);
            Controls.Add(button1);
            Controls.Add(grbEdicionAlumno);
            Controls.Add(button2);
            Controls.Add(grbNavegacionAlumno);
            Controls.Add(GrbDatosInventario);
            Controls.Add(lblBuscarAlumnos);
            Controls.Add(txtBuscarAlumnos);
            Controls.Add(grdDatosAlumnos);
            Name = "Factura";
            Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)grdDatosAlumnos).EndInit();
            GrbDatosInventario.ResumeLayout(false);
            GrbDatosInventario.PerformLayout();
            grbNavegacionAlumno.ResumeLayout(false);
            grbNavegacionAlumno.PerformLayout();
            grbEdicionAlumno.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscarAlumnos;
        private TextBox txtBuscarAlumnos;
        private DataGridView grdDatosAlumnos;
        private DataGridViewTextBoxColumn idAlumno;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn telefono;
        private GroupBox GrbDatosInventario;
        private Label lblDuiAlumno;
        private TextBox txtDuiAlumno;
        private Label lblTelefonoAlumno;
        private TextBox txtTelefonoAlumno;
        private Label lblDireccionAlumno;
        private TextBox txtDireccionAlumno;
        private Label lblNombreAlumno;
        private TextBox txtNombreAlumno;
        private Label lblCodigoAlumno;
        private TextBox txtCodigoAlumno;
        private GroupBox grbNavegacionAlumno;
        private Label lblRegistrosAlumnos;
        private Button btnUltimoAlumno;
        private Button btnSiguienteAlumno;
        private Button btnAnteriorAlumno;
        private Button btnPrimeroAlumno;
        private GroupBox grbEdicionAlumno;
        private Button btnEliminarAlumno;
        private Button btnModificarAlumno;
        private Button btnNuevoAlumno;
        private Button button1;
        private Button button2;
    }
}