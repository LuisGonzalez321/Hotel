namespace SistemaHotel.Vista {
    partial class FrmCliente {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.txt_PrimerNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_PrimerApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Correo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_SegundoNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Dirección = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_SegundoApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Teléfono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.switch_habilitar = new Bunifu.Framework.UI.BunifuSwitch();
            this.btn_Cancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Nuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabla_cliente = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_PrimerNombre
            // 
            this.txt_PrimerNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_PrimerNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_PrimerNombre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
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
            this.txt_PrimerNombre.Location = new System.Drawing.Point(412, 59);
            this.txt_PrimerNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrimerNombre.MaxLength = 32767;
            this.txt_PrimerNombre.Name = "txt_PrimerNombre";
            this.txt_PrimerNombre.Size = new System.Drawing.Size(158, 37);
            this.txt_PrimerNombre.TabIndex = 0;
            this.txt_PrimerNombre.Text = "Primer Nombre";
            this.txt_PrimerNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_PrimerNombre.Enter += new System.EventHandler(this.txt_PrimerNombre_Enter);
            this.txt_PrimerNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PrimerNombre_KeyDown);
            this.txt_PrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrimerNombre_KeyPress);
            this.txt_PrimerNombre.Leave += new System.EventHandler(this.txt_PrimerNombre_Leave);
            // 
            // txt_PrimerApellido
            // 
            this.txt_PrimerApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_PrimerApellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_PrimerApellido.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
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
            this.txt_PrimerApellido.Location = new System.Drawing.Point(412, 116);
            this.txt_PrimerApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrimerApellido.MaxLength = 32767;
            this.txt_PrimerApellido.Name = "txt_PrimerApellido";
            this.txt_PrimerApellido.Size = new System.Drawing.Size(158, 37);
            this.txt_PrimerApellido.TabIndex = 1;
            this.txt_PrimerApellido.Text = "Primer Apellido";
            this.txt_PrimerApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_PrimerApellido.Enter += new System.EventHandler(this.txt_PrimerApellido_Enter);
            this.txt_PrimerApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PrimerApellido_KeyDown);
            this.txt_PrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrimerApellido_KeyPress);
            this.txt_PrimerApellido.Leave += new System.EventHandler(this.txt_PrimerApellido_Leave);
            // 
            // txt_Correo
            // 
            this.txt_Correo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Correo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Correo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
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
            this.txt_Correo.Location = new System.Drawing.Point(412, 212);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Correo.MaxLength = 32767;
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(328, 37);
            this.txt_Correo.TabIndex = 2;
            this.txt_Correo.Text = "Correo";
            this.txt_Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Correo.Enter += new System.EventHandler(this.txt_Correo_Enter);
            this.txt_Correo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Correo_KeyDown);
            this.txt_Correo.Leave += new System.EventHandler(this.txt_Correo_Leave);
            // 
            // txt_SegundoNombre
            // 
            this.txt_SegundoNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_SegundoNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_SegundoNombre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
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
            this.txt_SegundoNombre.Location = new System.Drawing.Point(578, 59);
            this.txt_SegundoNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SegundoNombre.MaxLength = 32767;
            this.txt_SegundoNombre.Name = "txt_SegundoNombre";
            this.txt_SegundoNombre.Size = new System.Drawing.Size(162, 37);
            this.txt_SegundoNombre.TabIndex = 3;
            this.txt_SegundoNombre.Text = "Segundo Nombre";
            this.txt_SegundoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SegundoNombre.Enter += new System.EventHandler(this.txt_SegundoNombre_Enter);
            this.txt_SegundoNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SegundoNombre_KeyDown);
            this.txt_SegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SegundoNombre_KeyPress);
            this.txt_SegundoNombre.Leave += new System.EventHandler(this.txt_SegundoNombre_Leave);
            // 
            // txt_Dirección
            // 
            this.txt_Dirección.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Dirección.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Dirección.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
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
            this.txt_Dirección.Location = new System.Drawing.Point(412, 164);
            this.txt_Dirección.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Dirección.MaxLength = 32767;
            this.txt_Dirección.Name = "txt_Dirección";
            this.txt_Dirección.Size = new System.Drawing.Size(328, 37);
            this.txt_Dirección.TabIndex = 4;
            this.txt_Dirección.Tag = "";
            this.txt_Dirección.Text = "Dirección";
            this.txt_Dirección.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Dirección.Enter += new System.EventHandler(this.txt_Dirección_Enter);
            this.txt_Dirección.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Dirección_KeyDown);
            this.txt_Dirección.Leave += new System.EventHandler(this.txt_Dirección_Leave);
            // 
            // txt_SegundoApellido
            // 
            this.txt_SegundoApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_SegundoApellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_SegundoApellido.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
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
            this.txt_SegundoApellido.Location = new System.Drawing.Point(578, 116);
            this.txt_SegundoApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SegundoApellido.MaxLength = 32767;
            this.txt_SegundoApellido.Name = "txt_SegundoApellido";
            this.txt_SegundoApellido.Size = new System.Drawing.Size(162, 37);
            this.txt_SegundoApellido.TabIndex = 5;
            this.txt_SegundoApellido.Text = "Segundo Apellido";
            this.txt_SegundoApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SegundoApellido.Enter += new System.EventHandler(this.txt_SegundoApellido_Enter);
            this.txt_SegundoApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SegundoApellido_KeyDown);
            this.txt_SegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SegundoApellido_KeyPress);
            this.txt_SegundoApellido.Leave += new System.EventHandler(this.txt_SegundoApellido_Leave);
            // 
            // txt_Teléfono
            // 
            this.txt_Teléfono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Teléfono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Teléfono.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
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
            this.txt_Teléfono.Location = new System.Drawing.Point(412, 260);
            this.txt_Teléfono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Teléfono.MaxLength = 32767;
            this.txt_Teléfono.Name = "txt_Teléfono";
            this.txt_Teléfono.Size = new System.Drawing.Size(328, 37);
            this.txt_Teléfono.TabIndex = 6;
            this.txt_Teléfono.Text = "Teléfono";
            this.txt_Teléfono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Teléfono.Enter += new System.EventHandler(this.txt_Teléfono_Enter);
            this.txt_Teléfono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Teléfono_KeyPress);
            this.txt_Teléfono.Leave += new System.EventHandler(this.txt_Teléfono_Leave);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 302);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(86, 25);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Habilitar";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(306, 54);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(44, 297);
            this.bunifuSeparator1.TabIndex = 14;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.switch_habilitar);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.btn_Editar);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Controls.Add(this.txt_Teléfono);
            this.panel1.Controls.Add(this.txt_SegundoApellido);
            this.panel1.Controls.Add(this.txt_Dirección);
            this.panel1.Controls.Add(this.txt_SegundoNombre);
            this.panel1.Controls.Add(this.txt_Correo);
            this.panel1.Controls.Add(this.txt_PrimerApellido);
            this.panel1.Controls.Add(this.txt_PrimerNombre);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 340);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "REGISTRO DE CLIENTES";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(14, 38);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(778, 10);
            this.bunifuSeparator2.TabIndex = 62;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // switch_habilitar
            // 
            this.switch_habilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switch_habilitar.BorderRadius = 0;
            this.switch_habilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch_habilitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switch_habilitar.Location = new System.Drawing.Point(121, 308);
            this.switch_habilitar.Name = "switch_habilitar";
            this.switch_habilitar.Oncolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.switch_habilitar.Onoffcolor = System.Drawing.Color.DarkGray;
            this.switch_habilitar.Size = new System.Drawing.Size(51, 19);
            this.switch_habilitar.TabIndex = 16;
            this.switch_habilitar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switch_habilitar.Value = true;
            this.switch_habilitar.Click += new System.EventHandler(this.switch_habilitar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Active = false;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(14, 246);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Cancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_Cancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cancelar.selected = false;
            this.btn_Cancelar.Size = new System.Drawing.Size(241, 42);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Textcolor = System.Drawing.Color.White;
            this.btn_Cancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Active = false;
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
            this.btn_guardar.Location = new System.Drawing.Point(14, 198);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_guardar.selected = false;
            this.btn_guardar.Size = new System.Drawing.Size(241, 42);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Textcolor = System.Drawing.Color.White;
            this.btn_guardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Active = false;
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
            this.btn_Editar.Location = new System.Drawing.Point(14, 150);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Editar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_Editar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Editar.selected = false;
            this.btn_Editar.Size = new System.Drawing.Size(241, 42);
            this.btn_Editar.TabIndex = 8;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Textcolor = System.Drawing.Color.White;
            this.btn_Editar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Active = false;
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
            this.btn_Nuevo.Location = new System.Drawing.Point(14, 102);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_Nuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_Nuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Nuevo.selected = false;
            this.btn_Nuevo.Size = new System.Drawing.Size(241, 42);
            this.btn_Nuevo.TabIndex = 7;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Textcolor = System.Drawing.Color.White;
            this.btn_Nuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // tabla_cliente
            // 
            this.tabla_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_cliente.Location = new System.Drawing.Point(17, 390);
            this.tabla_cliente.Name = "tabla_cliente";
            this.tabla_cliente.Size = new System.Drawing.Size(240, 150);
            this.tabla_cliente.TabIndex = 1;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.tabla_cliente);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCliente";
            this.Size = new System.Drawing.Size(817, 578);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_PrimerNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_PrimerApellido;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Correo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SegundoNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Dirección;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SegundoApellido;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Teléfono;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Nuevo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Editar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_guardar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cancelar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSwitch switch_habilitar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.DataGridView tabla_cliente;
    }
}
