namespace SistemaHotel.Vista {
    partial class Inicio {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Título = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_ingresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SistemaHotel.Properties.Resources.Fondo_Menu;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Título);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.btn_ingresar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 456);
            this.panel1.TabIndex = 0;
            // 
            // Título
            // 
            this.Título.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.Título.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Título.Enabled = false;
            this.Título.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Título.ForeColor = System.Drawing.Color.White;
            this.Título.HintForeColor = System.Drawing.Color.Empty;
            this.Título.HintText = "";
            this.Título.isPassword = false;
            this.Título.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.Título.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.Título.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.Título.LineThickness = 4;
            this.Título.Location = new System.Drawing.Point(54, 45);
            this.Título.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Título.Name = "Título";
            this.Título.Size = new System.Drawing.Size(255, 38);
            this.Título.TabIndex = 1;
            this.Título.Text = "Sistema Hotel";
            this.Título.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.Image = global::SistemaHotel.Properties.Resources.shield;
            this.btn_cerrar.ImageActive = null;
            this.btn_cerrar.Location = new System.Drawing.Point(321, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(41, 43);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Zoom = 2;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ingresar.BorderRadius = 7;
            this.btn_ingresar.ButtonText = "Ingresar";
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingresar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ingresar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ingresar.Iconimage = null;
            this.btn_ingresar.Iconimage_right = null;
            this.btn_ingresar.Iconimage_right_Selected = null;
            this.btn_ingresar.Iconimage_Selected = null;
            this.btn_ingresar.IconMarginLeft = 0;
            this.btn_ingresar.IconMarginRight = 0;
            this.btn_ingresar.IconRightVisible = true;
            this.btn_ingresar.IconRightZoom = 0D;
            this.btn_ingresar.IconVisible = true;
            this.btn_ingresar.IconZoom = 90D;
            this.btn_ingresar.IsTab = false;
            this.btn_ingresar.Location = new System.Drawing.Point(85, 365);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.btn_ingresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btn_ingresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ingresar.selected = false;
            this.btn_ingresar.Size = new System.Drawing.Size(198, 45);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ingresar.Textcolor = System.Drawing.Color.White;
            this.btn_ingresar.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaHotel.Properties.Resources.user_3__2_;
            this.pictureBox1.Location = new System.Drawing.Point(33, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaHotel.Properties.Resources.padlock;
            this.pictureBox2.Location = new System.Drawing.Point(33, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_pass.ForeColor = System.Drawing.Color.White;
            this.txt_pass.HintForeColor = System.Drawing.Color.Empty;
            this.txt_pass.HintText = "";
            this.txt_pass.isPassword = true;
            this.txt_pass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txt_pass.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_pass.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_pass.LineThickness = 3;
            this.txt_pass.Location = new System.Drawing.Point(74, 248);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(254, 44);
            this.txt_pass.TabIndex = 6;
            this.txt_pass.Text = "Contraseña";
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_user.ForeColor = System.Drawing.Color.White;
            this.txt_user.HintForeColor = System.Drawing.Color.Empty;
            this.txt_user.HintText = "";
            this.txt_user.isPassword = false;
            this.txt_user.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txt_user.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_user.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_user.LineThickness = 3;
            this.txt_user.Location = new System.Drawing.Point(74, 168);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(254, 44);
            this.txt_user.TabIndex = 7;
            this.txt_user.Text = "Usuario";
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            this.txt_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_user_KeyDown);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 456);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Título;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_user;
        public  Bunifu.Framework.UI.BunifuMaterialTextbox txt_pass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ingresar;
        private Bunifu.Framework.UI.BunifuImageButton btn_cerrar;
    }
}