
namespace Sitema_Punto_de_Venta
{
    partial class Frm_Principal
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
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.tmtiempo = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(35, 782);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(74, 15);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "1:48:00 a.m.";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblfecha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblfecha.Location = new System.Drawing.Point(12, 807);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(138, 13);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "13 de diciembre del  2023";
            // 
            // tmtiempo
            // 
            this.tmtiempo.Enabled = true;
            this.tmtiempo.Tick += new System.EventHandler(this.tmtiempo_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.lblfecha);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 829);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PapayaWhip;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeProductosToolStripMenuItem,
            this.gestionDeClienteToolStripMenuItem,
            this.gestionDeProveedoresToolStripMenuItem,
            this.gestionDeCompraToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.gestionDeVentasToolStripMenuItem,
            this.configuracionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(186, 829);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            this.gestionDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.gestionDeProductosToolStripMenuItem.Image = global::Sitema_Punto_de_Venta.Properties.Resources.icono_190__;
            this.gestionDeProductosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 8, 3, 0);
            this.gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            this.gestionDeProductosToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.gestionDeProductosToolStripMenuItem.Text = "Gestion de Productos";
            this.gestionDeProductosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gestionDeClienteToolStripMenuItem
            // 
            this.gestionDeClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.gestionDeClienteToolStripMenuItem.Image = global::Sitema_Punto_de_Venta.Properties.Resources.icono_28__;
            this.gestionDeClienteToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 8, 6, 0);
            this.gestionDeClienteToolStripMenuItem.Name = "gestionDeClienteToolStripMenuItem";
            this.gestionDeClienteToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.gestionDeClienteToolStripMenuItem.Text = "Gestion de cliente";
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            this.gestionDeProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.gestionDeProveedoresToolStripMenuItem.Image = global::Sitema_Punto_de_Venta.Properties.Resources.proveedor;
            this.gestionDeProveedoresToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            this.gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            this.gestionDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.gestionDeProveedoresToolStripMenuItem.Text = "Gestion de Proveedores";
            // 
            // gestionDeCompraToolStripMenuItem
            // 
            this.gestionDeCompraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem});
            this.gestionDeCompraToolStripMenuItem.Image = global::Sitema_Punto_de_Venta.Properties.Resources.icons8_comprar_16;
            this.gestionDeCompraToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 8, 3, 0);
            this.gestionDeCompraToolStripMenuItem.Name = "gestionDeCompraToolStripMenuItem";
            this.gestionDeCompraToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.gestionDeCompraToolStripMenuItem.Text = "Gestion de Compras";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem1});
            this.inventarioToolStripMenuItem.Image = global::Sitema_Punto_de_Venta.Properties.Resources.icono_42__;
            this.inventarioToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 8, 53, 0);
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // gestionDeVentasToolStripMenuItem
            // 
            this.gestionDeVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem});
            this.gestionDeVentasToolStripMenuItem.Image = global::Sitema_Punto_de_Venta.Properties.Resources.compra_ini__;
            this.gestionDeVentasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(6, 8, 33, 0);
            this.gestionDeVentasToolStripMenuItem.Name = "gestionDeVentasToolStripMenuItem";
            this.gestionDeVentasToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.gestionDeVentasToolStripMenuItem.Text = "Gestion de Ventas";
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.Image = global::Sitema_Punto_de_Venta.Properties.Resources.icono_49__;
            this.configuracionesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(6, 8, 33, 0);
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventaToolStripMenuItem.Text = "Ventas";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1411, 829);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer tmtiempo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
    }
}

