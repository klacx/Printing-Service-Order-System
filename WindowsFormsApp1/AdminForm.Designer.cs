namespace WindowsFormsApp1
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.AddUserBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userPanel = new System.Windows.Forms.Panel();
            this.LogOutBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ProfileBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.roundPictureBox1 = new WindowsFormsApp1.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Width = 1;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Controls.Add(this.AddUserBtn);
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1280, 48);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPanel1.StateCommon.ColorAngle = 45F;
            this.kryptonPanel1.StateDisabled.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateDisabled.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPanel1.StateNormal.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPanel1.TabIndex = 3;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(679, 0);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.AddUserBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.AddUserBtn.OverrideDefault.Back.ColorAngle = 10F;
            this.AddUserBtn.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.AddUserBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.AddUserBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.AddUserBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddUserBtn.Size = new System.Drawing.Size(122, 48);
            this.AddUserBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.AddUserBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.AddUserBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.AddUserBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.AddUserBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddUserBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.AddUserBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.AddUserBtn.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.AddUserBtn.StatePressed.Back.ColorAngle = 8F;
            this.AddUserBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.AddUserBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddUserBtn.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.AddUserBtn.StateTracking.Back.ColorAngle = 8F;
            this.AddUserBtn.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.AddUserBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddUserBtn.TabIndex = 6;
            this.AddUserBtn.Values.Text = "Add User";
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(923, 0);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.kryptonButton2.OverrideDefault.Back.ColorAngle = 10F;
            this.kryptonButton2.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.kryptonButton2.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.Size = new System.Drawing.Size(122, 48);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.kryptonButton2.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonButton2.StatePressed.Back.ColorAngle = 8F;
            this.kryptonButton2.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.kryptonButton2.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonButton2.StateTracking.Back.ColorAngle = 8F;
            this.kryptonButton2.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.kryptonButton2.TabIndex = 5;
            this.kryptonButton2.Values.Text = "Income";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(801, 0);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.kryptonButton1.OverrideDefault.Back.ColorAngle = 10F;
            this.kryptonButton1.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.Size = new System.Drawing.Size(122, 48);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonButton1.StatePressed.Back.ColorAngle = 8F;
            this.kryptonButton1.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonButton1.StateTracking.Back.ColorAngle = 8F;
            this.kryptonButton1.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.kryptonButton1.TabIndex = 4;
            this.kryptonButton1.Values.Text = "Request";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.APU__2___2__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.LogOutBtn);
            this.userPanel.Controls.Add(this.ProfileBtn);
            this.userPanel.Location = new System.Drawing.Point(1127, 1);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(129, 131);
            this.userPanel.TabIndex = 6;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(0, 86);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.LogOutBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.LogOutBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.LogOutBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.LogOutBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LogOutBtn.OverrideDefault.Border.Rounding = 8;
            this.LogOutBtn.Size = new System.Drawing.Size(126, 45);
            this.LogOutBtn.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.LogOutBtn.StateCommon.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.LogOutBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.LogOutBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.LogOutBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LogOutBtn.StateCommon.Border.Rounding = 8;
            this.LogOutBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.LogOutBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.LogOutBtn.StatePressed.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.LogOutBtn.StatePressed.Back.Color2 = System.Drawing.Color.LightGray;
            this.LogOutBtn.StatePressed.Back.ColorAngle = 8F;
            this.LogOutBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.LogOutBtn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.LogOutBtn.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.LogOutBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LogOutBtn.StateTracking.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.LogOutBtn.StateTracking.Back.Color2 = System.Drawing.Color.LightGray;
            this.LogOutBtn.StateTracking.Back.ColorAngle = 8F;
            this.LogOutBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.LogOutBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.LogOutBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LogOutBtn.StateTracking.Border.Rounding = 8;
            this.LogOutBtn.TabIndex = 8;
            this.LogOutBtn.Values.Text = "Log Out";
            this.LogOutBtn.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.Location = new System.Drawing.Point(0, 44);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.ProfileBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.ProfileBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.ProfileBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.ProfileBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProfileBtn.Size = new System.Drawing.Size(126, 45);
            this.ProfileBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ProfileBtn.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.ProfileBtn.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.ProfileBtn.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.ProfileBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProfileBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.ProfileBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.ProfileBtn.StatePressed.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.ProfileBtn.StatePressed.Back.Color2 = System.Drawing.Color.LightGray;
            this.ProfileBtn.StatePressed.Back.ColorAngle = 8F;
            this.ProfileBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.ProfileBtn.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.ProfileBtn.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.ProfileBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProfileBtn.StateTracking.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.ProfileBtn.StateTracking.Back.Color2 = System.Drawing.Color.LightGray;
            this.ProfileBtn.StateTracking.Back.ColorAngle = 8F;
            this.ProfileBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.ProfileBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.ProfileBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProfileBtn.TabIndex = 7;
            this.ProfileBtn.Values.Text = "Profile";
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(0, 54);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1260, 638);
            this.panelContainer.TabIndex = 11;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.photo_1603366615917_1fa6dad5c4fa;
            this.roundPictureBox1.Location = new System.Drawing.Point(1210, 3);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roundPictureBox1.TabIndex = 4;
            this.roundPictureBox1.TabStop = false;
            this.roundPictureBox1.Click += new System.EventHandler(this.roundPictureBox1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.roundPictureBox1);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.StateActive.Back.Color2 = System.Drawing.Color.LightGray;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Width = 1;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.userPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AddUserBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel userPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton LogOutBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ProfileBtn;
        private RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Panel panelContainer;
    }
}