namespace controladorPlanificaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTop = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAnalizar = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(30, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(245, 30);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPestañaToolStripMenuItem,
            this.cargarArchivoToolStripMenuItem,
            this.guardarArchivoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevaPestañaToolStripMenuItem
            // 
            this.nuevaPestañaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.nuevaPestañaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nuevaPestañaToolStripMenuItem.Name = "nuevaPestañaToolStripMenuItem";
            this.nuevaPestañaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nuevaPestañaToolStripMenuItem.Text = "Nueva Pestaña";
            this.nuevaPestañaToolStripMenuItem.Click += new System.EventHandler(this.NuevaPestañaToolStripMenuItem_Click);
            // 
            // cargarArchivoToolStripMenuItem
            // 
            this.cargarArchivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.cargarArchivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cargarArchivoToolStripMenuItem.Name = "cargarArchivoToolStripMenuItem";
            this.cargarArchivoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cargarArchivoToolStripMenuItem.Text = "Cargar Archivo";
            this.cargarArchivoToolStripMenuItem.Click += new System.EventHandler(this.CargarArchivoToolStripMenuItem_Click);
            // 
            // guardarArchivoToolStripMenuItem
            // 
            this.guardarArchivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.guardarArchivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.guardarArchivoToolStripMenuItem.Name = "guardarArchivoToolStripMenuItem";
            this.guardarArchivoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.guardarArchivoToolStripMenuItem.Text = "Guardar Archivo";
            this.guardarArchivoToolStripMenuItem.Click += new System.EventHandler(this.GuardarArchivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualAplicaciónToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualAplicaciónToolStripMenuItem
            // 
            this.manualAplicaciónToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.manualAplicaciónToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manualAplicaciónToolStripMenuItem.Name = "manualAplicaciónToolStripMenuItem";
            this.manualAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualAplicaciónToolStripMenuItem.Text = "Manual Aplicación";
            this.manualAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.ManualAplicaciónToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // menuTop
            // 
            this.menuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.menuTop.Controls.Add(this.minimizeButton);
            this.menuTop.Controls.Add(this.closeButton);
            this.menuTop.Controls.Add(this.menu);
            this.menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(1024, 30);
            this.menuTop.TabIndex = 0;
            this.menuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            this.menuTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseMove);
            this.menuTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageLocation = "";
            this.minimizeButton.Location = new System.Drawing.Point(964, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(5);
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(994, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(5);
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(504, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tab1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(198)))));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(504, 520);
            this.textBox1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 546);
            this.tabControl1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(512, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 546);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.treeView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(256, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 273);
            this.panel4.TabIndex = 2;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.White;
            this.treeView.Location = new System.Drawing.Point(10, 22);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(236, 241);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.buttonAnalizar);
            this.panel3.Controls.Add(this.monthCalendar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 273);
            this.panel3.TabIndex = 1;
            // 
            // buttonAnalizar
            // 
            this.buttonAnalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.buttonAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalizar.ForeColor = System.Drawing.Color.White;
            this.buttonAnalizar.Location = new System.Drawing.Point(10, 22);
            this.buttonAnalizar.Name = "buttonAnalizar";
            this.buttonAnalizar.Size = new System.Drawing.Size(236, 65);
            this.buttonAnalizar.TabIndex = 0;
            this.buttonAnalizar.Text = "Analizar";
            this.buttonAnalizar.UseVisualStyleBackColor = false;
            this.buttonAnalizar.Click += new System.EventHandler(this.ButtonAnalizar_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.monthCalendar.Location = new System.Drawing.Point(4, 99);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.richTextBoxDescripcion);
            this.panel2.Controls.Add(this.pictureBoxImagen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 273);
            this.panel2.TabIndex = 0;
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.richTextBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(10, 10);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.ReadOnly = true;
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(264, 253);
            this.richTextBoxDescripcion.TabIndex = 0;
            this.richTextBoxDescripcion.Text = "";
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pictureBoxImagen.Location = new System.Drawing.Point(256, 10);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(246, 253);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 0;
            this.pictureBoxImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.menuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPestañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Panel menuTop;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAnalizar;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
    }
}

