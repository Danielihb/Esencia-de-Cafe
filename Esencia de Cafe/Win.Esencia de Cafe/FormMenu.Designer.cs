namespace Win.Esencia_de_Cafe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.transaccionToolStripMenuItem,
            this.segridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClientesToolStripMenuItem,
            this.registroDeProductosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeClientesToolStripMenuItem.Text = "Registro de Clientes";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.registroDeClientesToolStripMenuItem_Click);
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeProductosToolStripMenuItem.Text = "Registro de Productos";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeClientesToolStripMenuItem,
            this.reportesDeProductosToolStripMenuItem,
            this.reportesDeFacturasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            this.reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            this.reporteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes ";
            this.reporteDeClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeClientesToolStripMenuItem_Click);
            // 
            // reportesDeProductosToolStripMenuItem
            // 
            this.reportesDeProductosToolStripMenuItem.Name = "reportesDeProductosToolStripMenuItem";
            this.reportesDeProductosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.reportesDeProductosToolStripMenuItem.Text = "Reportes de Productos";
            this.reportesDeProductosToolStripMenuItem.Click += new System.EventHandler(this.reportesDeProductosToolStripMenuItem_Click);
            // 
            // reportesDeFacturasToolStripMenuItem
            // 
            this.reportesDeFacturasToolStripMenuItem.Name = "reportesDeFacturasToolStripMenuItem";
            this.reportesDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.reportesDeFacturasToolStripMenuItem.Text = "Reportes de Facturas";
            this.reportesDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.reportesDeFacturasToolStripMenuItem_Click);
            // 
            // transaccionToolStripMenuItem
            // 
            this.transaccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem});
            this.transaccionToolStripMenuItem.Name = "transaccionToolStripMenuItem";
            this.transaccionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transaccionToolStripMenuItem.Text = "Transaccion ";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // segridadToolStripMenuItem
            // 
            this.segridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.segridadToolStripMenuItem.Name = "segridadToolStripMenuItem";
            this.segridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.segridadToolStripMenuItem.Text = "Seguridad";
            this.segridadToolStripMenuItem.Click += new System.EventHandler(this.segridadToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(610, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Usuario";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 277);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(610, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // statusStrip3
            // 
            this.statusStrip3.Location = new System.Drawing.Point(0, 255);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(610, 22);
            this.statusStrip3.TabIndex = 5;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 321);
            this.Controls.Add(this.statusStrip3);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeFacturasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.StatusStrip statusStrip3;
    }
}