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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_buscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_reservar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.date_FechaSalida = new Bunifu.Framework.UI.BunifuDatepicker();
            this.date_fechaEntrada = new Bunifu.Framework.UI.BunifuDatepicker();
            this.combox_idHab = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.tabla_habitación = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.image_hab = new System.Windows.Forms.PictureBox();
            this.combox_hab = new Bunifu.Framework.UI.BunifuDropdown();
            this.switch_habilitar = new Bunifu.Framework.UI.BunifuSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_habitación)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_hab)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Active = false;
            this.btn_buscar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.BorderRadius = 1;
            this.btn_buscar.ButtonText = "Buscar";
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_buscar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_buscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Iconimage")));
            this.btn_buscar.Iconimage_right = null;
            this.btn_buscar.Iconimage_right_Selected = null;
            this.btn_buscar.Iconimage_Selected = null;
            this.btn_buscar.IconMarginLeft = 0;
            this.btn_buscar.IconMarginRight = 0;
            this.btn_buscar.IconRightVisible = false;
            this.btn_buscar.IconRightZoom = 0D;
            this.btn_buscar.IconVisible = false;
            this.btn_buscar.IconZoom = 90D;
            this.btn_buscar.IsTab = false;
            this.btn_buscar.Location = new System.Drawing.Point(589, 232);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_buscar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_buscar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_buscar.selected = false;
            this.btn_buscar.Size = new System.Drawing.Size(142, 31);
            this.btn_buscar.TabIndex = 23;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_buscar.Textcolor = System.Drawing.Color.White;
            this.btn_buscar.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_reservar
            // 
            this.btn_reservar.Active = false;
            this.btn_reservar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_reservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_reservar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reservar.BorderRadius = 1;
            this.btn_reservar.ButtonText = "Reservar";
            this.btn_reservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reservar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_reservar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_reservar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_reservar.Iconimage")));
            this.btn_reservar.Iconimage_right = null;
            this.btn_reservar.Iconimage_right_Selected = null;
            this.btn_reservar.Iconimage_Selected = null;
            this.btn_reservar.IconMarginLeft = 0;
            this.btn_reservar.IconMarginRight = 0;
            this.btn_reservar.IconRightVisible = false;
            this.btn_reservar.IconRightZoom = 0D;
            this.btn_reservar.IconVisible = false;
            this.btn_reservar.IconZoom = 90D;
            this.btn_reservar.IsTab = false;
            this.btn_reservar.Location = new System.Drawing.Point(428, 232);
            this.btn_reservar.Name = "btn_reservar";
            this.btn_reservar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_reservar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_reservar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_reservar.selected = false;
            this.btn_reservar.Size = new System.Drawing.Size(142, 31);
            this.btn_reservar.TabIndex = 22;
            this.btn_reservar.Text = "Reservar";
            this.btn_reservar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reservar.Textcolor = System.Drawing.Color.White;
            this.btn_reservar.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservar.Click += new System.EventHandler(this.btn_reservar_Click);
            // 
            // date_FechaSalida
            // 
            this.date_FechaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.date_FechaSalida.BorderRadius = 0;
            this.date_FechaSalida.ForeColor = System.Drawing.Color.White;
            this.date_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_FechaSalida.FormatCustom = null;
            this.date_FechaSalida.Location = new System.Drawing.Point(493, 181);
            this.date_FechaSalida.Name = "date_FechaSalida";
            this.date_FechaSalida.Size = new System.Drawing.Size(238, 36);
            this.date_FechaSalida.TabIndex = 21;
            this.date_FechaSalida.Value = new System.DateTime(2019, 4, 3, 20, 37, 3, 345);
            // 
            // date_fechaEntrada
            // 
            this.date_fechaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.date_fechaEntrada.BorderRadius = 0;
            this.date_fechaEntrada.ForeColor = System.Drawing.Color.White;
            this.date_fechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_fechaEntrada.FormatCustom = null;
            this.date_fechaEntrada.Location = new System.Drawing.Point(493, 120);
            this.date_fechaEntrada.Name = "date_fechaEntrada";
            this.date_fechaEntrada.Size = new System.Drawing.Size(238, 36);
            this.date_fechaEntrada.TabIndex = 20;
            this.date_fechaEntrada.Value = new System.DateTime(2019, 4, 3, 0, 0, 0, 0);
            // 
            // combox_idHab
            // 
            this.combox_idHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.combox_idHab.BorderRadius = 3;
            this.combox_idHab.DisabledColor = System.Drawing.Color.Gray;
            this.combox_idHab.ForeColor = System.Drawing.Color.White;
            this.combox_idHab.items = new string[0];
            this.combox_idHab.Location = new System.Drawing.Point(493, 64);
            this.combox_idHab.Name = "combox_idHab";
            this.combox_idHab.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.combox_idHab.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.combox_idHab.selectedIndex = -1;
            this.combox_idHab.Size = new System.Drawing.Size(238, 30);
            this.combox_idHab.TabIndex = 19;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(326, 43);
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
            this.bunifuSeparator2.Location = new System.Drawing.Point(5, 269);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(752, 19);
            this.bunifuSeparator2.TabIndex = 17;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // tabla_habitación
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabla_habitación.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_habitación.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tabla_habitación.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_habitación.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_habitación.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_habitación.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_habitación.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_habitación.DoubleBuffered = true;
            this.tabla_habitación.EnableHeadersVisualStyles = false;
            this.tabla_habitación.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabla_habitación.HeaderForeColor = System.Drawing.Color.White;
            this.tabla_habitación.Location = new System.Drawing.Point(5, 294);
            this.tabla_habitación.Name = "tabla_habitación";
            this.tabla_habitación.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_habitación.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla_habitación.Size = new System.Drawing.Size(768, 251);
            this.tabla_habitación.TabIndex = 16;
            // 
            // image_hab
            // 
            this.image_hab.Image = global::SistemaHotel.Properties.Resources.habitación_básica1;
            this.image_hab.Location = new System.Drawing.Point(5, 85);
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
            this.combox_hab.Location = new System.Drawing.Point(146, 43);
            this.combox_hab.Name = "combox_hab";
            this.combox_hab.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.combox_hab.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.combox_hab.selectedIndex = 0;
            this.combox_hab.Size = new System.Drawing.Size(184, 36);
            this.combox_hab.TabIndex = 14;
            this.combox_hab.onItemSelected += new System.EventHandler(this.combox_hab_onItemSelected);
            // 
            // switch_habilitar
            // 
            this.switch_habilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switch_habilitar.BorderRadius = 0;
            this.switch_habilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch_habilitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switch_habilitar.Location = new System.Drawing.Point(355, 244);
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
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(5, 28);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(752, 10);
            this.bunifuSeparator1.TabIndex = 64;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(6, 51);
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
            this.label3.Location = new System.Drawing.Point(351, 69);
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
            this.label4.Location = new System.Drawing.Point(351, 189);
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
            this.label5.Location = new System.Drawing.Point(351, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Fecha de entrada";
            // 
            // FrmHabitación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaHotel.Properties.Resources.Fondo_Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.switch_habilitar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_reservar);
            this.Controls.Add(this.date_FechaSalida);
            this.Controls.Add(this.date_fechaEntrada);
            this.Controls.Add(this.combox_idHab);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.tabla_habitación);
            this.Controls.Add(this.image_hab);
            this.Controls.Add(this.combox_hab);
            this.Name = "FrmHabitación";
            this.Size = new System.Drawing.Size(776, 548);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_habitación)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_hab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_buscar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_reservar;
        private Bunifu.Framework.UI.BunifuDatepicker date_FechaSalida;
        private Bunifu.Framework.UI.BunifuDatepicker date_fechaEntrada;
        private Bunifu.Framework.UI.BunifuDropdown combox_idHab;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tabla_habitación;
        private System.Windows.Forms.PictureBox image_hab;
        private Bunifu.Framework.UI.BunifuDropdown combox_hab;
        private Bunifu.Framework.UI.BunifuSwitch switch_habilitar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
