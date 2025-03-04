namespace C__Proyecto_Final
{
    partial class FrmFractales
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFractal3 = new System.Windows.Forms.Button();
            this.btnFractal2 = new System.Windows.Forms.Button();
            this.btnFractal1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picCanvasReferencia = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvasReferencia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFractal3);
            this.groupBox1.Controls.Add(this.btnFractal2);
            this.groupBox1.Controls.Add(this.btnFractal1);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(337, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnFractal3
            // 
            this.btnFractal3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFractal3.Location = new System.Drawing.Point(100, 126);
            this.btnFractal3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFractal3.Name = "btnFractal3";
            this.btnFractal3.Size = new System.Drawing.Size(112, 48);
            this.btnFractal3.TabIndex = 3;
            this.btnFractal3.Text = "Fractal 3";
            this.btnFractal3.UseVisualStyleBackColor = false;
            this.btnFractal3.Click += new System.EventHandler(this.btnFractal3_Click);
            // 
            // btnFractal2
            // 
            this.btnFractal2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFractal2.Location = new System.Drawing.Point(191, 43);
            this.btnFractal2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFractal2.Name = "btnFractal2";
            this.btnFractal2.Size = new System.Drawing.Size(112, 48);
            this.btnFractal2.TabIndex = 2;
            this.btnFractal2.Text = "Fractal 2";
            this.btnFractal2.UseVisualStyleBackColor = false;
            this.btnFractal2.Click += new System.EventHandler(this.btnFractal2_Click);
            // 
            // btnFractal1
            // 
            this.btnFractal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFractal1.Location = new System.Drawing.Point(23, 43);
            this.btnFractal1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFractal1.Name = "btnFractal1";
            this.btnFractal1.Size = new System.Drawing.Size(112, 48);
            this.btnFractal1.TabIndex = 1;
            this.btnFractal1.Text = "Fractal 1";
            this.btnFractal1.UseVisualStyleBackColor = false;
            this.btnFractal1.Click += new System.EventHandler(this.btnFractal1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picCanvas);
            this.groupBox2.Location = new System.Drawing.Point(361, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(828, 608);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen del Fractal";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(8, 23);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(812, 577);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::C__Proyecto_Final.Properties.Resources.salir;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionalidadToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // funcionalidadToolStripMenuItem
            // 
            this.funcionalidadToolStripMenuItem.Image = global::C__Proyecto_Final.Properties.Resources.help;
            this.funcionalidadToolStripMenuItem.Name = "funcionalidadToolStripMenuItem";
            this.funcionalidadToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.funcionalidadToolStripMenuItem.Text = "Funcionalidad";
            this.funcionalidadToolStripMenuItem.Click += new System.EventHandler(this.funcionalidadToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picCanvasReferencia);
            this.groupBox3.Controls.Add(this.lblMensaje);
            this.groupBox3.Location = new System.Drawing.Point(16, 252);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(337, 389);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fractal Referencia";
            // 
            // picCanvasReferencia
            // 
            this.picCanvasReferencia.Location = new System.Drawing.Point(8, 90);
            this.picCanvasReferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCanvasReferencia.Name = "picCanvasReferencia";
            this.picCanvasReferencia.Size = new System.Drawing.Size(321, 292);
            this.picCanvasReferencia.TabIndex = 1;
            this.picCanvasReferencia.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(19, 46);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(16, 22);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = " ";
            // 
            // FrmFractales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 656);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFractales";
            this.Text = "Fractales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvasReferencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFractal1;
        private System.Windows.Forms.Button btnFractal3;
        private System.Windows.Forms.Button btnFractal2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionalidadToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox picCanvasReferencia;
    }
}

