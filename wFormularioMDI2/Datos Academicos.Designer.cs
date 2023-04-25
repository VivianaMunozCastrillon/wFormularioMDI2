namespace wFormularioMDI2
{
    partial class frmDatosAcademicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosAcademicos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbBaseDatos = new System.Windows.Forms.RadioButton();
            this.rdbCalculo = new System.Windows.Forms.RadioButton();
            this.rdbInteligenciaArtificial = new System.Windows.Forms.RadioButton();
            this.rdbSeguridadInformatica = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNoActivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(912, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarMenu2,
            this.limpiarToolStripMenuItem});
            this.opcionesToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // guardarMenu2
            // 
            this.guardarMenu2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardarMenu2.MergeIndex = 1;
            this.guardarMenu2.Name = "guardarMenu2";
            this.guardarMenu2.Size = new System.Drawing.Size(145, 26);
            this.guardarMenu2.Text = "&Guardar";
            this.guardarMenu2.Click += new System.EventHandler(this.guardarMenu2_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.limpiarToolStripMenuItem.Text = "&Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // rdbBaseDatos
            // 
            this.rdbBaseDatos.AutoSize = true;
            this.rdbBaseDatos.BackColor = System.Drawing.Color.Black;
            this.rdbBaseDatos.ForeColor = System.Drawing.Color.White;
            this.rdbBaseDatos.Location = new System.Drawing.Point(41, 67);
            this.rdbBaseDatos.Name = "rdbBaseDatos";
            this.rdbBaseDatos.Size = new System.Drawing.Size(164, 29);
            this.rdbBaseDatos.TabIndex = 2;
            this.rdbBaseDatos.Text = "Base De Datos";
            this.rdbBaseDatos.UseVisualStyleBackColor = false;
            this.rdbBaseDatos.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbCalculo
            // 
            this.rdbCalculo.AutoSize = true;
            this.rdbCalculo.BackColor = System.Drawing.Color.Black;
            this.rdbCalculo.ForeColor = System.Drawing.Color.White;
            this.rdbCalculo.Location = new System.Drawing.Point(41, 115);
            this.rdbCalculo.Name = "rdbCalculo";
            this.rdbCalculo.Size = new System.Drawing.Size(99, 29);
            this.rdbCalculo.TabIndex = 3;
            this.rdbCalculo.Text = "Calculo";
            this.rdbCalculo.UseVisualStyleBackColor = false;
            this.rdbCalculo.CheckedChanged += new System.EventHandler(this.rdbCalculo_CheckedChanged);
            // 
            // rdbInteligenciaArtificial
            // 
            this.rdbInteligenciaArtificial.AutoSize = true;
            this.rdbInteligenciaArtificial.BackColor = System.Drawing.Color.Black;
            this.rdbInteligenciaArtificial.ForeColor = System.Drawing.Color.White;
            this.rdbInteligenciaArtificial.Location = new System.Drawing.Point(41, 160);
            this.rdbInteligenciaArtificial.Name = "rdbInteligenciaArtificial";
            this.rdbInteligenciaArtificial.Size = new System.Drawing.Size(200, 29);
            this.rdbInteligenciaArtificial.TabIndex = 4;
            this.rdbInteligenciaArtificial.Text = "Inteligencia artificial";
            this.rdbInteligenciaArtificial.UseVisualStyleBackColor = false;
            this.rdbInteligenciaArtificial.CheckedChanged += new System.EventHandler(this.rdbInteligenciaArtificial_CheckedChanged);
            // 
            // rdbSeguridadInformatica
            // 
            this.rdbSeguridadInformatica.AutoSize = true;
            this.rdbSeguridadInformatica.BackColor = System.Drawing.Color.Black;
            this.rdbSeguridadInformatica.ForeColor = System.Drawing.Color.White;
            this.rdbSeguridadInformatica.Location = new System.Drawing.Point(41, 209);
            this.rdbSeguridadInformatica.Name = "rdbSeguridadInformatica";
            this.rdbSeguridadInformatica.Size = new System.Drawing.Size(223, 29);
            this.rdbSeguridadInformatica.TabIndex = 5;
            this.rdbSeguridadInformatica.Text = "Seguridad Informatica";
            this.rdbSeguridadInformatica.UseVisualStyleBackColor = false;
            this.rdbSeguridadInformatica.CheckedChanged += new System.EventHandler(this.rdbSeguridadInformatica_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.cboSemestre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbNoActivo);
            this.groupBox1.Controls.Add(this.rdbActivo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(470, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 198);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado del estudiante";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboSemestre
            // 
            this.cboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboSemestre.Location = new System.Drawing.Point(153, 124);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(171, 33);
            this.cboSemestre.TabIndex = 8;
            this.cboSemestre.SelectedIndexChanged += new System.EventHandler(this.cboSemestre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Semestre";
            // 
            // rdbNoActivo
            // 
            this.rdbNoActivo.AutoSize = true;
            this.rdbNoActivo.ForeColor = System.Drawing.Color.White;
            this.rdbNoActivo.Location = new System.Drawing.Point(32, 84);
            this.rdbNoActivo.Name = "rdbNoActivo";
            this.rdbNoActivo.Size = new System.Drawing.Size(114, 29);
            this.rdbNoActivo.TabIndex = 1;
            this.rdbNoActivo.Text = "No activo";
            this.rdbNoActivo.UseVisualStyleBackColor = true;
            this.rdbNoActivo.CheckedChanged += new System.EventHandler(this.rdbNoActivo_CheckedChanged);
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.ForeColor = System.Drawing.Color.White;
            this.rdbActivo.Location = new System.Drawing.Point(32, 42);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(87, 29);
            this.rdbActivo.TabIndex = 0;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            this.rdbActivo.CheckedChanged += new System.EventHandler(this.rdbActivo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.rdbSeguridadInformatica);
            this.groupBox2.Controls.Add(this.rdbInteligenciaArtificial);
            this.groupBox2.Controls.Add(this.rdbCalculo);
            this.groupBox2.Controls.Add(this.rdbBaseDatos);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(26, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 287);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Materia";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(238, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 55);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(405, 370);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(138, 55);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(580, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 55);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmDatosAcademicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 459);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDatosAcademicos";
            this.Text = "Datos Academicos";
            this.Load += new System.EventHandler(this.frmDatosAcademicos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbBaseDatos;
        private System.Windows.Forms.RadioButton rdbCalculo;
        private System.Windows.Forms.RadioButton rdbInteligenciaArtificial;
        private System.Windows.Forms.RadioButton rdbSeguridadInformatica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbNoActivo;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ToolStripMenuItem guardarMenu2;
        private System.Windows.Forms.Button btnSalir;
    }
}