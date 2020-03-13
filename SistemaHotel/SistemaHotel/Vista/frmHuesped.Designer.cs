namespace SistemaHotel.Vista {
    partial class FrmHuesped {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHuesped));
            this.tabla_huesped = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txt_Buscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_Cancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Nuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Teléfono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_SegundoApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Dirección = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_SegundoNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Correo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_PrimerApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_PrimerNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_nacionalidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_huesped)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_huesped
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabla_huesped.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_huesped.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tabla_huesped.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_huesped.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_huesped.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_huesped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_huesped.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabla_huesped.DoubleBuffered = true;
            this.tabla_huesped.EnableHeadersVisualStyles = false;
            this.tabla_huesped.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabla_huesped.HeaderForeColor = System.Drawing.Color.White;
            this.tabla_huesped.Location = new System.Drawing.Point(0, 357);
            this.tabla_huesped.Name = "tabla_huesped";
            this.tabla_huesped.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla_huesped.Size = new System.Drawing.Size(817, 221);
            this.tabla_huesped.TabIndex = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(316, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(44, 309);
            this.bunifuSeparator1.TabIndex = 32;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.txt_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Buscar.BackgroundImage")));
            this.txt_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.Silver;
            this.txt_Buscar.Icon = ((System.Drawing.Image)(resources.GetObject("txt_Buscar.Icon")));
            this.txt_Buscar.Location = new System.Drawing.Point(21, 22);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(241, 42);
            this.txt_Buscar.TabIndex = 31;
            this.txt_Buscar.text = "Buscar Huésped";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.BorderRadius = 0;
            this.btn_Cancelar.ButtonText = "Cancelar";
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Iconimage")));
            this.btn_Cancelar.Iconimage_right = null;
            this.btn_Cancelar.Iconimage_right_Selected = null;
            this.btn_Cancelar.Iconimage_Selected = null;
            this.btn_Cancelar.IconMarginLeft = 0;
            this.btn_Cancelar.IconMarginRight = 0;
            this.btn_Cancelar.IconRightVisible = true;
            this.btn_Cancelar.IconRightZoom = 0D;
            this.btn_Cancelar.IconVisible = true;
            this.btn_Cancelar.IconZoom = 90D;
            this.btn_Cancelar.IsTab = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(21, 223);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Cancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_Cancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cancelar.selected = false;
            this.btn_Cancelar.Size = new System.Drawing.Size(241, 42);
            this.btn_Cancelar.TabIndex = 29;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Textcolor = System.Drawing.Color.White;
            this.btn_Cancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_guardar
            // 
            this.btn_guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.BorderRadius = 0;
            this.btn_guardar.ButtonText = "Guardar";
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
            this.btn_guardar.Location = new System.Drawing.Point(21, 175);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_guardar.selected = false;
            this.btn_guardar.Size = new System.Drawing.Size(241, 42);
            this.btn_guardar.TabIndex = 28;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Textcolor = System.Drawing.Color.White;
            this.btn_guardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar.BorderRadius = 0;
            this.btn_Editar.ButtonText = "Editar";
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Editar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Editar.Iconimage = global::SistemaHotel.Properties.Resources.user_1;
            this.btn_Editar.Iconimage_right = null;
            this.btn_Editar.Iconimage_right_Selected = null;
            this.btn_Editar.Iconimage_Selected = null;
            this.btn_Editar.IconMarginLeft = 0;
            this.btn_Editar.IconMarginRight = 0;
            this.btn_Editar.IconRightVisible = true;
            this.btn_Editar.IconRightZoom = 0D;
            this.btn_Editar.IconVisible = true;
            this.btn_Editar.IconZoom = 90D;
            this.btn_Editar.IsTab = false;
            this.btn_Editar.Location = new System.Drawing.Point(21, 127);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Editar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_Editar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Editar.selected = false;
            this.btn_Editar.Size = new System.Drawing.Size(241, 42);
            this.btn_Editar.TabIndex = 27;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Textcolor = System.Drawing.Color.White;
            this.btn_Editar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Nuevo.BorderRadius = 0;
            this.btn_Nuevo.ButtonText = "Nuevo";
            this.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Nuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Nuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Iconimage")));
            this.btn_Nuevo.Iconimage_right = null;
            this.btn_Nuevo.Iconimage_right_Selected = null;
            this.btn_Nuevo.Iconimage_Selected = null;
            this.btn_Nuevo.IconMarginLeft = 0;
            this.btn_Nuevo.IconMarginRight = 0;
            this.btn_Nuevo.IconRightVisible = true;
            this.btn_Nuevo.IconRightZoom = 0D;
            this.btn_Nuevo.IconVisible = true;
            this.btn_Nuevo.IconZoom = 90D;
            this.btn_Nuevo.IsTab = false;
            this.btn_Nuevo.Location = new System.Drawing.Point(21, 79);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Nuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_Nuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Nuevo.selected = false;
            this.btn_Nuevo.Size = new System.Drawing.Size(241, 42);
            this.btn_Nuevo.TabIndex = 26;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Textcolor = System.Drawing.Color.White;
            this.btn_Nuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_Teléfono
            // 
            this.txt_Teléfono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Teléfono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Teléfono.ForeColor = System.Drawing.Color.White;
            this.txt_Teléfono.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Teléfono.HintText = "";
            this.txt_Teléfono.isPassword = false;
            this.txt_Teléfono.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txt_Teléfono.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Teléfono.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Teléfono.LineThickness = 3;
            this.txt_Teléfono.Location = new System.Drawing.Point(408, 184);
            this.txt_Teléfono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Teléfono.Name = "txt_Teléfono";
            this.txt_Teléfono.Size = new System.Drawing.Size(328, 33);
            this.txt_Teléfono.TabIndex = 25;
            this.txt_Teléfono.Text = "Teléfono";
            this.txt_Teléfono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_SegundoApellido
            // 
            this.txt_SegundoApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SegundoApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SegundoApellido.ForeColor = System.Drawing.Color.White;
            this.txt_SegundoApellido.HintForeColor = System.Drawing.Color.Empty;
            this.txt_SegundoApellido.HintText = "";
            this.txt_SegundoApellido.isPassword = false;
            this.txt_SegundoApellido.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txt_SegundoApellido.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_SegundoApellido.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SegundoApellido.LineThickness = 3;
            this.txt_SegundoApellido.Location = new System.Drawing.Point(574, 88);
            this.txt_SegundoApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SegundoApellido.Name = "txt_SegundoApellido";
            this.txt_SegundoApellido.Size = new System.Drawing.Size(162, 33);
            this.txt_SegundoApellido.TabIndex = 24;
            this.txt_SegundoApellido.Text = "Segundo Apellido";
            this.txt_SegundoApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Dirección
            // 
            this.txt_Dirección.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Dirección.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Dirección.ForeColor = System.Drawing.Color.White;
            this.txt_Dirección.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Dirección.HintText = "";
            this.txt_Dirección.isPassword = false;
            this.txt_Dirección.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txt_Dirección.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Dirección.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Dirección.LineThickness = 3;
            this.txt_Dirección.Location = new System.Drawing.Point(408, 136);
            this.txt_Dirección.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Dirección.Name = "txt_Dirección";
            this.txt_Dirección.Size = new System.Drawing.Size(328, 33);
            this.txt_Dirección.TabIndex = 23;
            this.txt_Dirección.Tag = "";
            this.txt_Dirección.Text = "Dirección";
            this.txt_Dirección.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_SegundoNombre
            // 
            this.txt_SegundoNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SegundoNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SegundoNombre.ForeColor = System.Drawing.Color.White;
            this.txt_SegundoNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txt_SegundoNombre.HintText = "";
            this.txt_SegundoNombre.isPassword = false;
            this.txt_SegundoNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txt_SegundoNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_SegundoNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SegundoNombre.LineThickness = 3;
            this.txt_SegundoNombre.Location = new System.Drawing.Point(574, 31);
            this.txt_SegundoNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SegundoNombre.Name = "txt_SegundoNombre";
            this.txt_SegundoNombre.Size = new System.Drawing.Size(162, 33);
            this.txt_SegundoNombre.TabIndex = 22;
            this.txt_SegundoNombre.Text = "Segundo Nombre";
            this.txt_SegundoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Correo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Correo.ForeColor = System.Drawing.Color.White;
            this.txt_Correo.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Correo.HintText = "";
            this.txt_Correo.isPassword = false;
            this.txt_Correo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txt_Correo.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Correo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Correo.LineThickness = 3;
            this.txt_Correo.Location = new System.Drawing.Point(408, 280);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(328, 33);
            this.txt_Correo.TabIndex = 21;
            this.txt_Correo.Text = "Correo";
            this.txt_Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_PrimerApellido
            // 
            this.txt_PrimerApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PrimerApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_PrimerApellido.ForeColor = System.Drawing.Color.White;
            this.txt_PrimerApellido.HintForeColor = System.Drawing.Color.Empty;
            this.txt_PrimerApellido.HintText = "";
            this.txt_PrimerApellido.isPassword = false;
            this.txt_PrimerApellido.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txt_PrimerApellido.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_PrimerApellido.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_PrimerApellido.LineThickness = 3;
            this.txt_PrimerApellido.Location = new System.Drawing.Point(408, 88);
            this.txt_PrimerApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrimerApellido.Name = "txt_PrimerApellido";
            this.txt_PrimerApellido.Size = new System.Drawing.Size(158, 33);
            this.txt_PrimerApellido.TabIndex = 20;
            this.txt_PrimerApellido.Text = "Primer Apellido";
            this.txt_PrimerApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_PrimerNombre
            // 
            this.txt_PrimerNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PrimerNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_PrimerNombre.ForeColor = System.Drawing.Color.White;
            this.txt_PrimerNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txt_PrimerNombre.HintText = "";
            this.txt_PrimerNombre.isPassword = false;
            this.txt_PrimerNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txt_PrimerNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_PrimerNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_PrimerNombre.LineThickness = 3;
            this.txt_PrimerNombre.Location = new System.Drawing.Point(408, 31);
            this.txt_PrimerNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrimerNombre.Name = "txt_PrimerNombre";
            this.txt_PrimerNombre.Size = new System.Drawing.Size(158, 33);
            this.txt_PrimerNombre.TabIndex = 19;
            this.txt_PrimerNombre.Text = "Primer Nombre";
            this.txt_PrimerNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_nacionalidad
            // 
            this.txt_nacionalidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nacionalidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_nacionalidad.ForeColor = System.Drawing.Color.White;
            this.txt_nacionalidad.HintForeColor = System.Drawing.Color.Empty;
            this.txt_nacionalidad.HintText = "";
            this.txt_nacionalidad.isPassword = false;
            this.txt_nacionalidad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txt_nacionalidad.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_nacionalidad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nacionalidad.LineThickness = 3;
            this.txt_nacionalidad.Location = new System.Drawing.Point(408, 232);
            this.txt_nacionalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nacionalidad.Name = "txt_nacionalidad";
            this.txt_nacionalidad.Size = new System.Drawing.Size(328, 33);
            this.txt_nacionalidad.TabIndex = 33;
            this.txt_nacionalidad.Text = "Nacionalidad";
            this.txt_nacionalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FrmHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.txt_nacionalidad);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.txt_Teléfono);
            this.Controls.Add(this.txt_SegundoApellido);
            this.Controls.Add(this.txt_Dirección);
            this.Controls.Add(this.txt_SegundoNombre);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.txt_PrimerApellido);
            this.Controls.Add(this.txt_PrimerNombre);
            this.Controls.Add(this.tabla_huesped);
            this.Name = "FrmHuesped";
            this.Size = new System.Drawing.Size(817, 578);
            this.Load += new System.EventHandler(this.frmHuesped_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_huesped)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid tabla_huesped;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuTextbox txt_Buscar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_guardar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Editar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Nuevo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Teléfono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SegundoApellido;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Dirección;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SegundoNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Correo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_PrimerApellido;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_PrimerNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nacionalidad;
    }
}
