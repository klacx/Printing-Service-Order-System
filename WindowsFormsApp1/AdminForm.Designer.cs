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
            this.incomeRptBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.requestRptBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userPanel = new System.Windows.Forms.Panel();
            this.LogOutBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ProfileBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.AvatarIcon = new WindowsFormsApp1.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarIcon)).BeginInit();
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
            this.kryptonPanel1.Controls.Add(this.incomeRptBtn);
            this.kryptonPanel1.Controls.Add(this.requestRptBtn);
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
            // incomeRptBtn
            // 
            this.incomeRptBtn.Location = new System.Drawing.Point(923, 0);
            this.incomeRptBtn.Name = "incomeRptBtn";
            this.incomeRptBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.incomeRptBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.incomeRptBtn.OverrideDefault.Back.ColorAngle = 10F;
            this.incomeRptBtn.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.incomeRptBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.incomeRptBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.incomeRptBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.incomeRptBtn.Size = new System.Drawing.Size(122, 48);
            this.incomeRptBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.incomeRptBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.incomeRptBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.incomeRptBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.incomeRptBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.incomeRptBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.incomeRptBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.incomeRptBtn.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.incomeRptBtn.StatePressed.Back.ColorAngle = 8F;
            this.incomeRptBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.incomeRptBtn.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.incomeRptBtn.StateTracking.Back.ColorAngle = 8F;
            this.incomeRptBtn.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.incomeRptBtn.TabIndex = 5;
            this.incomeRptBtn.Values.Text = "Income";
            this.incomeRptBtn.Click += new System.EventHandler(this.incomeRptBtn_Click);
            // 
            // requestRptBtn
            // 
            this.requestRptBtn.Location = new System.Drawing.Point(801, 0);
            this.requestRptBtn.Name = "requestRptBtn";
            this.requestRptBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.requestRptBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.requestRptBtn.OverrideDefault.Back.ColorAngle = 10F;
            this.requestRptBtn.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.requestRptBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.requestRptBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.requestRptBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.requestRptBtn.Size = new System.Drawing.Size(122, 48);
            this.requestRptBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.requestRptBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.requestRptBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.requestRptBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.requestRptBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.requestRptBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.requestRptBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.requestRptBtn.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.requestRptBtn.StatePressed.Back.ColorAngle = 8F;
            this.requestRptBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.requestRptBtn.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.requestRptBtn.StateTracking.Back.ColorAngle = 8F;
            this.requestRptBtn.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.requestRptBtn.TabIndex = 4;
            this.requestRptBtn.Values.Text = "Request Report";
            this.requestRptBtn.Click += new System.EventHandler(this.requestRptBtn_Click);
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
            // AvatarIcon
            // 
            this.AvatarIcon.Image = global::WindowsFormsApp1.Properties.Resources.photo_1603366615917_1fa6dad5c4fa;
            this.AvatarIcon.Location = new System.Drawing.Point(1210, 3);
            this.AvatarIcon.Name = "AvatarIcon";
            this.AvatarIcon.Size = new System.Drawing.Size(40, 40);
            this.AvatarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarIcon.TabIndex = 4;
            this.AvatarIcon.TabStop = false;
            this.AvatarIcon.Click += new System.EventHandler(this.roundPictureBox1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.AvatarIcon);
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
            ((System.ComponentModel.ISupportInitialize)(this.AvatarIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AddUserBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton incomeRptBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton requestRptBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel userPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton LogOutBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ProfileBtn;
        private RoundPictureBox AvatarIcon;
        private System.Windows.Forms.Panel panelContainer;
    }
}