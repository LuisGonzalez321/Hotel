using static System.Windows.Forms.ComboBox;

namespace SistemaHotel.Vista
{
    partial class FrmHabitación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHabitación));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.date_FechaSalida = new Bunifu.Framework.UI.BunifuDatepicker();
            this.date_fechaEntrada = new Bunifu.Framework.UI.BunifuDatepicker();
            this.combox_idHab = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.image_hab = new System.Windows.Forms.PictureBox();
            this.combox_hab = new Bunifu.Framework.UI.BunifuDropdown();
            this.switch_habilitar = new Bunifu.Framework.UI.BunifuSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_reservar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_buscar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tabla_habitación = new System.Windows.Forms.DataGridView();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.image_hab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_habitación)).BeginInit();
            this.SuspendLayout();
            // 
            // date_FechaSalida
            // 
            this.date_FechaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.date_FechaSalida.BorderRadius = 3;
            this.date_FechaSalida.ForeColor = System.Drawing.Color.White;
            this.date_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_FechaSalida.FormatCustom = null;
            this.date_FechaSalida.Location = new System.Drawing.Point(489, 184);
            this.date_FechaSalida.Name = "date_FechaSalida";
            this.date_FechaSalida.Size = new System.Drawing.Size(238, 36);
            this.date_FechaSalida.TabIndex = 21;
            this.date_FechaSalida.Value = new System.DateTime(2019, 4, 3, 20, 37, 3, 345);
            // 
            // date_fechaEntrada
            // 
            this.date_fechaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.date_fechaEntrada.BorderRadius = 3;
            this.date_fechaEntrada.ForeColor = System.Drawing.Color.White;
            this.date_fechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_fechaEntrada.FormatCustom = null;
            this.date_fechaEntrada.Location = new System.Drawing.Point(489, 123);
            this.date_fechaEntrada.Name = "date_fechaEntrada";
            this.date_fechaEntrada.Size = new System.Drawing.Size(238, 36);
            this.date_fechaEntrada.TabIndex = 20;
            this.date_fechaEntrada.Value = new System.DateTime(2020, 1, 31, 0, 0, 0, 0);
            // 
            // combox_idHab
            // 
            this.combox_idHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.combox_idHab.BorderRadius = 3;
            this.combox_idHab.DisabledColor = System.Drawing.Color.Gray;
            this.combox_idHab.ForeColor = System.Drawing.Color.White;
            this.combox_idHab.items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10"};
            this.combox_idHab.Location = new System.Drawing.Point(489, 68);
            this.combox_idHab.Name = "combox_idHab";
            this.combox_idHab.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.combox_idHab.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.combox_idHab.selectedIndex = 0;
            this.combox_idHab.Size = new System.Drawing.Size(238, 29);
            this.combox_idHab.TabIndex = 19;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(322, 46);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(23, 233);
            this.bunifuSeparator3.TabIndex = 18;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, 28);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(752, 10);
            this.bunifuSeparator2.TabIndex = 17;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // image_hab
            // 
            this.image_hab.Image = global::SistemaHotel.Properties.Resources.habitación_básica1;
            this.image_hab.Location = new System.Drawing.Point(1, 88);
            this.image_hab.Name = "image_hab";
            this.image_hab.Size = new System.Drawing.Size(315, 191);
            this.image_hab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_hab.TabIndex = 15;
            this.image_hab.TabStop = false;
            // 
            // combox_hab
            // 
            this.combox_hab.BackColor = System.Drawing.Color.Transparent;
            this.combox_hab.BorderRadius = 3;
            this.combox_hab.DisabledColor = System.Drawing.Color.Gray;
            this.combox_hab.ForeColor = System.Drawing.Color.White;
            this.combox_hab.items = new string[] {
        "-Seleccionar",
        "Basica",
        "Ejecutiva",
        "Presidencial"};
            this.combox_hab.Location = new System.Drawing.Point(142, 44);
            this.combox_hab.Name = "combox_hab";
            this.combox_hab.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.combox_hab.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.combox_hab.selectedIndex = 0;
            this.combox_hab.Size = new System.Drawing.Size(174, 38);
            this.combox_hab.TabIndex = 14;
            this.combox_hab.onItemSelected += new System.EventHandler(this.combox_hab_onItemSelected);
            // 
            // switch_habilitar
            // 
            this.switch_habilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switch_habilitar.BorderRadius = 0;
            this.switch_habilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch_habilitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switch_habilitar.Location = new System.Drawing.Point(351, 256);
            this.switch_habilitar.Name = "switch_habilitar";
            this.switch_habilitar.Oncolor = System.Drawing.Color.Purple;
            this.switch_habilitar.Onoffcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switch_habilitar.Size = new System.Drawing.Size(51, 19);
            this.switch_habilitar.TabIndex = 30;
            this.switch_habilitar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switch_habilitar.Value = true;
            this.switch_habilitar.Click += new System.EventHandler(this.switch_habilitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "DISPONIBILIDAD DE HABITACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(2, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tipo de habitación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(347, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "No habitación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(347, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Fecha de salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(347, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Fecha de entrada";
            // 
            // btn_reservar
            // 
            this.btn_reservar.AllowToggling = false;
            this.btn_reservar.AnimationSpeed = 200;
            this.btn_reservar.AutoGenerateColors = false;
            this.btn_reservar.BackColor = System.Drawing.Color.Transparent;
            this.btn_reservar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_reservar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reservar.BackgroundImage")));
            this.btn_reservar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_reservar.ButtonText = "Reservar";
            this.btn_reservar.ButtonTextMarginLeft = 0;
            this.btn_reservar.ColorContrastOnClick = 45;
            this.btn_reservar.ColorContrastOnHover = 45;
            this.btn_reservar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_reservar.CustomizableEdges = borderEdges1;
            this.btn_reservar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_reservar.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_reservar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_reservar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_reservar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_reservar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservar.ForeColor = System.Drawing.Color.White;
            this.btn_reservar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reservar.IconMarginLeft = 11;
            this.btn_reservar.IconPadding = 10;
            this.btn_reservar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reservar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_reservar.IdleBorderRadius = 3;
            this.btn_reservar.IdleBorderThickness = 1;
            this.btn_reservar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_reservar.IdleIconLeftImage = null;
            this.btn_reservar.IdleIconRightImage = null;
            this.btn_reservar.IndicateFocus = false;
            this.btn_reservar.Location = new System.Drawing.Point(489, 240);
            this.btn_reservar.Name = "btn_reservar";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(57)))), ((int)(((byte)(185)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(57)))), ((int)(((byte)(185)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_reservar.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(57)))), ((int)(((byte)(185)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(57)))), ((int)(((byte)(185)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_reservar.OnPressedState = stateProperties2;
            this.btn_reservar.Size = new System.Drawing.Size(116, 38);
            this.btn_reservar.TabIndex = 70;
            this.btn_reservar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reservar.TextMarginLeft = 0;
            this.btn_reservar.UseDefaultRadiusAndThickness = true;
            this.btn_reservar.Click += new System.EventHandler(this.btn_reservar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.AllowToggling = false;
            this.btn_buscar.AnimationSpeed = 200;
            this.btn_buscar.AutoGenerateColors = false;
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_buscar.ButtonText = "Buscar";
            this.btn_buscar.ButtonTextMarginLeft = 0;
            this.btn_buscar.ColorContrastOnClick = 45;
            this.btn_buscar.ColorContrastOnHover = 45;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_buscar.CustomizableEdges = borderEdges2;
            this.btn_buscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_buscar.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_buscar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_buscar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_buscar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_buscar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.IconMarginLeft = 11;
            this.btn_buscar.IconPadding = 10;
            this.btn_buscar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_buscar.IdleBorderRadius = 3;
            this.btn_buscar.IdleBorderThickness = 1;
            this.btn_buscar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_buscar.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.IdleIconLeftImage")));
            this.btn_buscar.IdleIconRightImage = null;
            this.btn_buscar.IndicateFocus = false;
            this.btn_buscar.Location = new System.Drawing.Point(611, 240);
            this.btn_buscar.Name = "btn_buscar";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(57)))), ((int)(((byte)(185)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(57)))), ((int)(((byte)(185)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btn_buscar.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(57)))), ((int)(((byte)(185)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(57)))), ((int)(((byte)(185)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btn_buscar.OnPressedState = stateProperties4;
            this.btn_buscar.Size = new System.Drawing.Size(116, 39);
            this.btn_buscar.TabIndex = 71;
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_buscar.TextMarginLeft = 0;
            this.btn_buscar.UseDefaultRadiusAndThickness = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // tabla_habitación
            // 
            this.tabla_habitación.AllowUserToAddRows = false;
            this.tabla_habitación.AllowUserToDeleteRows = false;
            this.tabla_habitación.AllowUserToResizeColumns = false;
            this.tabla_habitación.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tabla_habitación.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_habitación.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabla_habitación.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla_habitación.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.tabla_habitación.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabla_habitación.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla_habitación.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tabla_habitación.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_habitación.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(21, 10, 21, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_habitación.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_habitación.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabla_habitación.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.tabla_habitación.Location = new System.Drawing.Point(0, 301);
            this.tabla_habitación.Margin = new System.Windows.Forms.Padding(10);
            this.tabla_habitación.Name = "tabla_habitación";
            this.tabla_habitación.ReadOnly = true;
            this.tabla_habitación.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_habitación.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla_habitación.RowHeadersVisible = false;
            this.tabla_habitación.RowHeadersWidth = 10;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.tabla_habitación.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tabla_habitación.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tabla_habitación.RowTemplate.Height = 30;
            this.tabla_habitación.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tabla_habitación.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_habitación.Size = new System.Drawing.Size(776, 247);
            this.tabla_habitación.TabIndex = 72;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(1, 278);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(752, 10);
            this.bunifuSeparator1.TabIndex = 75;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // FrmHabitación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaHotel.Properties.Resources.Fondo_Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.tabla_habitación);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_reservar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switch_habilitar);
            this.Controls.Add(this.date_FechaSalida);
            this.Controls.Add(this.date_fechaEntrada);
            this.Controls.Add(this.combox_idHab);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.image_hab);
            this.Controls.Add(this.combox_hab);
            this.Name = "FrmHabitación";
            this.Size = new System.Drawing.Size(776, 548);
            ((System.ComponentModel.ISupportInitialize)(this.image_hab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_habitación)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDatepicker date_FechaSalida;
        private Bunifu.Framework.UI.BunifuDatepicker date_fechaEntrada;
        private Bunifu.Framework.UI.BunifuDropdown combox_idHab;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox image_hab;
        private Bunifu.Framework.UI.BunifuDropdown combox_hab;
        private Bunifu.Framework.UI.BunifuSwitch switch_habilitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_reservar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_buscar;
        private System.Windows.Forms.DataGridView tabla_habitación;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
