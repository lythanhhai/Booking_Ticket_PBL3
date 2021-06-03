
namespace PBL3_DATVEXE.View
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lbHome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonTKV = new FontAwesome.Sharp.IconButton();
            this.iconButtonQLX = new FontAwesome.Sharp.IconButton();
            this.iconButtonQLCTT = new FontAwesome.Sharp.IconButton();
            this.iconButtonQLT = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu.SuspendLayout();
            this.panelShadow.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMenu.Controls.Add(this.iconButtonTKV);
            this.panelMenu.Controls.Add(this.iconButtonQLX);
            this.panelMenu.Controls.Add(this.iconButtonQLCTT);
            this.panelMenu.Controls.Add(this.iconButtonQLT);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(276, 642);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(276, 212);
            this.panelLogo.TabIndex = 0;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.panelShadow.Controls.Add(this.bunifuImageButton1);
            this.panelShadow.Controls.Add(this.bunifuDropdown1);
            this.panelShadow.Controls.Add(this.lbHome);
            this.panelShadow.Controls.Add(this.iconCurrentChildForm);
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(276, 0);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1056, 82);
            this.panelShadow.TabIndex = 1;
            this.panelShadow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.bunifuDropdown1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.bunifuDropdown1.BorderRadius = 1;
            this.bunifuDropdown1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifuDropdown1.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.FillDropDown = true;
            this.bunifuDropdown1.FillIndicator = false;
            this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.FormattingEnabled = true;
            this.bunifuDropdown1.Icon = null;
            this.bunifuDropdown1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.IndicatorColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.ItemHeight = 26;
            this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDropdown1.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemTopMargin = 3;
            this.bunifuDropdown1.Location = new System.Drawing.Point(1011, 26);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size(34, 32);
            this.bunifuDropdown1.TabIndex = 2;
            this.bunifuDropdown1.Text = null;
            this.bunifuDropdown1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.TextLeftMargin = 5;
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbHome.Location = new System.Drawing.Point(107, 27);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(64, 25);
            this.lbHome.TabIndex = 1;
            this.lbHome.Text = "Home";
            this.lbHome.Click += new System.EventHandler(this.lbHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(276, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 2);
            this.panel2.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LightCyan;
            this.panelMain.Controls.Add(this.flowLayoutPanel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(276, 84);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1056, 558);
            this.panelMain.TabIndex = 3;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 0;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(47, 44);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(48, 45);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(957, 18);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = false;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(48, 45);
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 0;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.iconCurrentChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 82;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(0, 0);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(101, 82);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // iconButtonTKV
            // 
            this.iconButtonTKV.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonTKV.FlatAppearance.BorderSize = 0;
            this.iconButtonTKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTKV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonTKV.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.iconButtonTKV.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.iconButtonTKV.IconColor = System.Drawing.Color.MediumAquamarine;
            this.iconButtonTKV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTKV.IconSize = 32;
            this.iconButtonTKV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTKV.Location = new System.Drawing.Point(0, 380);
            this.iconButtonTKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonTKV.Name = "iconButtonTKV";
            this.iconButtonTKV.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.iconButtonTKV.Size = new System.Drawing.Size(276, 56);
            this.iconButtonTKV.TabIndex = 4;
            this.iconButtonTKV.Text = "Thống kê-vé";
            this.iconButtonTKV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTKV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTKV.UseVisualStyleBackColor = true;
            this.iconButtonTKV.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButtonQLX
            // 
            this.iconButtonQLX.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonQLX.FlatAppearance.BorderSize = 0;
            this.iconButtonQLX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQLX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonQLX.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.iconButtonQLX.IconChar = FontAwesome.Sharp.IconChar.BusAlt;
            this.iconButtonQLX.IconColor = System.Drawing.Color.MediumAquamarine;
            this.iconButtonQLX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQLX.IconSize = 32;
            this.iconButtonQLX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLX.Location = new System.Drawing.Point(0, 324);
            this.iconButtonQLX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonQLX.Name = "iconButtonQLX";
            this.iconButtonQLX.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.iconButtonQLX.Size = new System.Drawing.Size(276, 56);
            this.iconButtonQLX.TabIndex = 3;
            this.iconButtonQLX.Text = "Quản lý xe";
            this.iconButtonQLX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonQLX.UseVisualStyleBackColor = true;
            this.iconButtonQLX.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButtonQLCTT
            // 
            this.iconButtonQLCTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonQLCTT.FlatAppearance.BorderSize = 0;
            this.iconButtonQLCTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQLCTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonQLCTT.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.iconButtonQLCTT.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.iconButtonQLCTT.IconColor = System.Drawing.Color.MediumAquamarine;
            this.iconButtonQLCTT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQLCTT.IconSize = 32;
            this.iconButtonQLCTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLCTT.Location = new System.Drawing.Point(0, 268);
            this.iconButtonQLCTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonQLCTT.Name = "iconButtonQLCTT";
            this.iconButtonQLCTT.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.iconButtonQLCTT.Size = new System.Drawing.Size(276, 56);
            this.iconButtonQLCTT.TabIndex = 2;
            this.iconButtonQLCTT.Text = "Quản lý chi tiết tuyến";
            this.iconButtonQLCTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLCTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonQLCTT.UseVisualStyleBackColor = true;
            this.iconButtonQLCTT.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButtonQLT
            // 
            this.iconButtonQLT.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonQLT.FlatAppearance.BorderSize = 0;
            this.iconButtonQLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonQLT.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.iconButtonQLT.IconChar = FontAwesome.Sharp.IconChar.Route;
            this.iconButtonQLT.IconColor = System.Drawing.Color.MediumAquamarine;
            this.iconButtonQLT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQLT.IconSize = 32;
            this.iconButtonQLT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLT.Location = new System.Drawing.Point(0, 212);
            this.iconButtonQLT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonQLT.Name = "iconButtonQLT";
            this.iconButtonQLT.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.iconButtonQLT.Size = new System.Drawing.Size(276, 56);
            this.iconButtonQLT.TabIndex = 1;
            this.iconButtonQLT.Text = "Quản lý tuyến";
            this.iconButtonQLT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonQLT.UseVisualStyleBackColor = true;
            this.iconButtonQLT.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(216, 86);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(608, 197);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 642);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelShadow.ResumeLayout(false);
            this.panelShadow.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonTKV;
        private FontAwesome.Sharp.IconButton iconButtonQLX;
        private FontAwesome.Sharp.IconButton iconButtonQLCTT;
        private FontAwesome.Sharp.IconButton iconButtonQLT;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Label lbHome;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}