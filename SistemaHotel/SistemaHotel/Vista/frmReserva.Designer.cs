namespace SistemaHotel.Vista
{
    partial class FrmReserva
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent ()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserva));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.data_reserva = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.data_cliente = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label_lista = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lista_huesped = new System.Windows.Forms.ListBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btn_cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btn_editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_addhuesped = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_nuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_cancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combox_estado = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combox_divisa = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combox_pago = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_reserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SistemaHotel.Properties.Resources.Fondo_Menu;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.data_reserva);
            this.panel1.Controls.Add(this.data_cliente);
            this.panel1.Controls.Add(this.label_lista);
            this.panel1.Controls.Add(this.bunifuSeparator4);
            this.panel1.Controls.Add(this.lista_huesped);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuSeparator6);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_addhuesped);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.combox_estado);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.combox_divisa);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.combox_pago);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 561);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "REGISTRO DE RESERVAS";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(589, 101);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(141, 21);
            this.bunifuCustomLabel6.TabIndex = 60;
            this.bunifuCustomLabel6.Text = "Lista de huespedes";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ColumnWidth = 5;
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(415, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 208);
            this.listBox1.TabIndex = 59;
            // 
            // data_reserva
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.data_reserva.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_reserva.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.data_reserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_reserva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_reserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_reserva.DoubleBuffered = true;
            this.data_reserva.EnableHeadersVisualStyles = false;
            this.data_reserva.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.data_reserva.HeaderForeColor = System.Drawing.Color.White;
            this.data_reserva.Location = new System.Drawing.Point(411, 393);
            this.data_reserva.Name = "data_reserva";
            this.data_reserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_reserva.Size = new System.Drawing.Size(359, 150);
            this.data_reserva.TabIndex = 58;
            // 
            // data_cliente
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.data_cliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_cliente.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.data_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_cliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_cliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cliente.DoubleBuffered = true;
            this.data_cliente.EnableHeadersVisualStyles = false;
            this.data_cliente.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.data_cliente.HeaderForeColor = System.Drawing.Color.White;
            this.data_cliente.Location = new System.Drawing.Point(24, 393);
            this.data_cliente.Name = "data_cliente";
            this.data_cliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_cliente.Size = new System.Drawing.Size(365, 150);
            this.data_cliente.TabIndex = 57;
            // 
            // label_lista
            // 
            this.label_lista.AutoSize = true;
            this.label_lista.BackColor = System.Drawing.Color.Transparent;
            this.label_lista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_lista.Location = new System.Drawing.Point(412, 101);
            this.label_lista.Name = "label_lista";
            this.label_lista.Size = new System.Drawing.Size(139, 21);
            this.label_lista.TabIndex = 56;
            this.label_lista.Text = "Reserva del cliente";
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(395, 61);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(14, 570);
            this.bunifuSeparator4.TabIndex = 55;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = true;
            // 
            // lista_huesped
            // 
            this.lista_huesped.AllowDrop = true;
            this.lista_huesped.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista_huesped.ColumnWidth = 5;
            this.lista_huesped.Enabled = false;
            this.lista_huesped.FormattingEnabled = true;
            this.lista_huesped.Location = new System.Drawing.Point(593, 146);
            this.lista_huesped.Name = "lista_huesped";
            this.lista_huesped.Size = new System.Drawing.Size(170, 208);
            this.lista_huesped.TabIndex = 54;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(524, 369);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(150, 21);
            this.bunifuCustomLabel5.TabIndex = 50;
            this.bunifuCustomLabel5.Text = "LISTA DE RESERVAS";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(148, 369);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(143, 21);
            this.bunifuCustomLabel4.TabIndex = 49;
            this.bunifuCustomLabel4.Text = "LISTA DE CLIENTES";
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(776, 53);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(10, 505);
            this.bunifuSeparator6.TabIndex = 48;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.Image = global::SistemaHotel.Properties.Resources.shield;
            this.btn_cerrar.ImageActive = null;
            this.btn_cerrar.Location = new System.Drawing.Point(937, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(41, 39);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cerrar.TabIndex = 46;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Zoom = 2;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(8, 37);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(778, 10);
            this.bunifuSeparator2.TabIndex = 43;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(1, 61);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(17, 581);
            this.bunifuSeparator1.TabIndex = 42;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Active = false;
            this.btn_editar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.BorderRadius = 7;
            this.btn_editar.ButtonText = "Editar";
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_editar.Enabled = false;
            this.btn_editar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_editar.Iconimage = global::SistemaHotel.Properties.Resources.icons8_support_50;
            this.btn_editar.Iconimage_right = null;
            this.btn_editar.Iconimage_right_Selected = null;
            this.btn_editar.Iconimage_Selected = null;
            this.btn_editar.IconMarginLeft = 0;
            this.btn_editar.IconMarginRight = 0;
            this.btn_editar.IconRightVisible = true;
            this.btn_editar.IconRightZoom = 70D;
            this.btn_editar.IconVisible = true;
            this.btn_editar.IconZoom = 60D;
            this.btn_editar.IsTab = false;
            this.btn_editar.Location = new System.Drawing.Point(593, 61);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_editar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_editar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editar.selected = false;
            this.btn_editar.Size = new System.Drawing.Size(146, 37);
            this.btn_editar.TabIndex = 41;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Textcolor = System.Drawing.Color.White;
            this.btn_editar.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_addhuesped
            // 
            this.btn_addhuesped.Active = false;
            this.btn_addhuesped.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_addhuesped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_addhuesped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addhuesped.BorderRadius = 7;
            this.btn_addhuesped.ButtonText = "Añadir Huesped";
            this.btn_addhuesped.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addhuesped.DisabledColor = System.Drawing.Color.Gray;
            this.btn_addhuesped.Enabled = false;
            this.btn_addhuesped.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_addhuesped.Iconimage = null;
            this.btn_addhuesped.Iconimage_right = null;
            this.btn_addhuesped.Iconimage_right_Selected = null;
            this.btn_addhuesped.Iconimage_Selected = null;
            this.btn_addhuesped.IconMarginLeft = 0;
            this.btn_addhuesped.IconMarginRight = 0;
            this.btn_addhuesped.IconRightVisible = true;
            this.btn_addhuesped.IconRightZoom = 0D;
            this.btn_addhuesped.IconVisible = true;
            this.btn_addhuesped.IconZoom = 90D;
            this.btn_addhuesped.IsTab = false;
            this.btn_addhuesped.Location = new System.Drawing.Point(411, 63);
            this.btn_addhuesped.Name = "btn_addhuesped";
            this.btn_addhuesped.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_addhuesped.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_addhuesped.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_addhuesped.selected = false;
            this.btn_addhuesped.Size = new System.Drawing.Size(157, 35);
            this.btn_addhuesped.TabIndex = 40;
            this.btn_addhuesped.Text = "Añadir Huesped";
            this.btn_addhuesped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addhuesped.Textcolor = System.Drawing.Color.White;
            this.btn_addhuesped.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Active = false;
            this.btn_nuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.BorderRadius = 1;
            this.btn_nuevo.ButtonText = "Nueva";
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_nuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_nuevo.Iconimage = global::SistemaHotel.Properties.Resources.icons8_bookmark_501;
            this.btn_nuevo.Iconimage_right = null;
            this.btn_nuevo.Iconimage_right_Selected = null;
            this.btn_nuevo.Iconimage_Selected = null;
            this.btn_nuevo.IconMarginLeft = 0;
            this.btn_nuevo.IconMarginRight = 0;
            this.btn_nuevo.IconRightVisible = true;
            this.btn_nuevo.IconRightZoom = 0D;
            this.btn_nuevo.IconVisible = true;
            this.btn_nuevo.IconZoom = 70D;
            this.btn_nuevo.IsTab = false;
            this.btn_nuevo.Location = new System.Drawing.Point(152, 259);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_nuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_nuevo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_nuevo.selected = false;
            this.btn_nuevo.Size = new System.Drawing.Size(197, 35);
            this.btn_nuevo.TabIndex = 39;
            this.btn_nuevo.Text = "Nueva";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Textcolor = System.Drawing.Color.White;
            this.btn_nuevo.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Active = false;
            this.btn_cancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.BorderRadius = 1;
            this.btn_cancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_cancelar.ButtonText = "Cancelar";
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Iconimage")));
            this.btn_cancelar.Iconimage_right = null;
            this.btn_cancelar.Iconimage_right_Selected = null;
            this.btn_cancelar.Iconimage_Selected = null;
            this.btn_cancelar.IconMarginLeft = 0;
            this.btn_cancelar.IconMarginRight = 0;
            this.btn_cancelar.IconRightVisible = true;
            this.btn_cancelar.IconRightZoom = 0D;
            this.btn_cancelar.IconVisible = true;
            this.btn_cancelar.IconZoom = 90D;
            this.btn_cancelar.IsTab = false;
            this.btn_cancelar.Location = new System.Drawing.Point(242, 317);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_cancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_cancelar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancelar.selected = false;
            this.btn_cancelar.Size = new System.Drawing.Size(125, 37);
            this.btn_cancelar.TabIndex = 37;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Textcolor = System.Drawing.Color.White;
            this.btn_cancelar.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_guardar
            // 
            this.btn_guardar.Active = false;
            this.btn_guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.BorderRadius = 1;
            this.btn_guardar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_guardar.ButtonText = "Guardar Reserva";
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_guardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Iconimage")));
            this.btn_guardar.Iconimage_right = null;
            this.btn_guardar.Iconimage_right_Selected = null;
            this.btn_guardar.Iconimage_Selected = null;
            this.btn_guardar.IconMarginLeft = 0;
            this.btn_guardar.IconMarginRight = 0;
            this.btn_guardar.IconRightVisible = true;
            this.btn_guardar.IconRightZoom = 0D;
            this.btn_guardar.IconVisible = true;
            this.btn_guardar.IconZoom = 90D;
            this.btn_guardar.IsTab = false;
            this.btn_guardar.Location = new System.Drawing.Point(75, 317);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_guardar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_guardar.selected = false;
            this.btn_guardar.Size = new System.Drawing.Size(161, 37);
            this.btn_guardar.TabIndex = 36;
            this.btn_guardar.Text = "Guardar Reserva";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Textcolor = System.Drawing.Color.White;
            this.btn_guardar.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(29, 207);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(59, 21);
            this.bunifuCustomLabel3.TabIndex = 35;
            this.bunifuCustomLabel3.Text = "Estado:";
            // 
            // combox_estado
            // 
            this.combox_estado.BackColor = System.Drawing.Color.Transparent;
            this.combox_estado.BorderRadius = 3;
            this.combox_estado.DisabledColor = System.Drawing.Color.Gray;
            this.combox_estado.ForeColor = System.Drawing.Color.White;
            this.combox_estado.items = new string[0];
            this.combox_estado.Location = new System.Drawing.Point(152, 200);
            this.combox_estado.Name = "combox_estado";
            this.combox_estado.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.combox_estado.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.combox_estado.selectedIndex = -1;
            this.combox_estado.Size = new System.Drawing.Size(197, 35);
            this.combox_estado.TabIndex = 34;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(29, 154);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(55, 21);
            this.bunifuCustomLabel2.TabIndex = 33;
            this.bunifuCustomLabel2.Text = "Divisa:";
            // 
            // combox_divisa
            // 
            this.combox_divisa.BackColor = System.Drawing.Color.Transparent;
            this.combox_divisa.BorderRadius = 3;
            this.combox_divisa.DisabledColor = System.Drawing.Color.Gray;
            this.combox_divisa.ForeColor = System.Drawing.Color.White;
            this.combox_divisa.items = new string[] {
        "COR",
        "EUR",
        "DOL"};
            this.combox_divisa.Location = new System.Drawing.Point(152, 147);
            this.combox_divisa.Name = "combox_divisa";
            this.combox_divisa.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.combox_divisa.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.combox_divisa.selectedIndex = 0;
            this.combox_divisa.Size = new System.Drawing.Size(197, 35);
            this.combox_divisa.TabIndex = 32;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 101);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(118, 21);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "Forma de Pago:";
            // 
            // combox_pago
            // 
            this.combox_pago.BackColor = System.Drawing.Color.Transparent;
            this.combox_pago.BorderRadius = 3;
            this.combox_pago.DisabledColor = System.Drawing.Color.Gray;
            this.combox_pago.ForeColor = System.Drawing.Color.White;
            this.combox_pago.items = new string[] {
        "CONTADO",
        "CREDITO",
        "CHEQUE"};
            this.combox_pago.Location = new System.Drawing.Point(152, 94);
            this.combox_pago.Name = "combox_pago";
            this.combox_pago.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.combox_pago.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.combox_pago.selectedIndex = 0;
            this.combox_pago.Size = new System.Drawing.Size(197, 35);
            this.combox_pago.TabIndex = 30;
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Name = "FrmReserva";
            this.Size = new System.Drawing.Size(789, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_reserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        public System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid data_reserva;
        private Bunifu.Framework.UI.BunifuCustomDataGrid data_cliente;
        private Bunifu.Framework.UI.BunifuCustomLabel label_lista;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        public System.Windows.Forms.ListBox lista_huesped;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private Bunifu.Framework.UI.BunifuImageButton btn_cerrar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_editar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_addhuesped;
        private Bunifu.Framework.UI.BunifuFlatButton btn_nuevo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_guardar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown combox_estado;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown combox_divisa;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown combox_pago;
        private System.Windows.Forms.Label label1;
    }
}
