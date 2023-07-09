namespace WindowsFormsApp1
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cartBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.productBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ProcessingBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
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
            this.kryptonPanel1.Controls.Add(this.cartBtn);
            this.kryptonPanel1.Controls.Add(this.productBtn);
            this.kryptonPanel1.Controls.Add(this.ProcessingBtn);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1707, 66);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPanel1.StateCommon.ColorAngle = 45F;
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.kryptonPanel1.StateDisabled.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateDisabled.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPanel1.StateNormal.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPanel1.TabIndex = 2;
            // 
            // cartBtn
            // 
            this.cartBtn.Location = new System.Drawing.Point(1068, 0);
            this.cartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.cartBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.cartBtn.OverrideDefault.Back.ColorAngle = 10F;
            this.cartBtn.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.cartBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.cartBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.cartBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cartBtn.Size = new System.Drawing.Size(163, 59);
            this.cartBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.cartBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.cartBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.cartBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.cartBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cartBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.cartBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.cartBtn.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.cartBtn.StatePressed.Back.ColorAngle = 8F;
            this.cartBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.cartBtn.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.cartBtn.StateTracking.Back.ColorAngle = 8F;
            this.cartBtn.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.cartBtn.TabIndex = 6;
            this.cartBtn.Values.Text = "Shopping Cart";
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.Location = new System.Drawing.Point(905, 0);
            this.productBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productBtn.Name = "productBtn";
            this.productBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.productBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.productBtn.OverrideDefault.Back.ColorAngle = 10F;
            this.productBtn.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.productBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.productBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.productBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productBtn.Size = new System.Drawing.Size(163, 59);
            this.productBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.productBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.productBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.productBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.productBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.productBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.productBtn.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.productBtn.StatePressed.Back.ColorAngle = 8F;
            this.productBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.productBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productBtn.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.productBtn.StateTracking.Back.ColorAngle = 8F;
            this.productBtn.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.productBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productBtn.TabIndex = 1;
            this.productBtn.Values.Text = "Product";
            this.productBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // ProcessingBtn
            // 
            this.ProcessingBtn.Location = new System.Drawing.Point(1231, 0);
            this.ProcessingBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessingBtn.Name = "ProcessingBtn";
            this.ProcessingBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.ProcessingBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.ProcessingBtn.OverrideDefault.Back.ColorAngle = 10F;
            this.ProcessingBtn.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.ProcessingBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.ProcessingBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.ProcessingBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProcessingBtn.Size = new System.Drawing.Size(163, 59);
            this.ProcessingBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ProcessingBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.ProcessingBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.ProcessingBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.ProcessingBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProcessingBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.ProcessingBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.ProcessingBtn.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.ProcessingBtn.StatePressed.Back.ColorAngle = 8F;
            this.ProcessingBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.ProcessingBtn.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.ProcessingBtn.StateTracking.Back.ColorAngle = 8F;
            this.ProcessingBtn.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.ProcessingBtn.TabIndex = 5;
            this.ProcessingBtn.Values.Text = "Processing";
            this.ProcessingBtn.Click += new System.EventHandler(this.ProcessingBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.APU__2___2__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.LogOutBtn);
            this.userPanel.Controls.Add(this.ProfileBtn);
            this.userPanel.Location = new System.Drawing.Point(1503, 1);
            this.userPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(172, 161);
            this.userPanel.TabIndex = 8;
            this.userPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userPanel_Paint);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(0, 106);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.LogOutBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.LogOutBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.LogOutBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.LogOutBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LogOutBtn.OverrideDefault.Border.Rounding = 8;
            this.LogOutBtn.Size = new System.Drawing.Size(168, 55);
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
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.Location = new System.Drawing.Point(0, 54);
            this.ProfileBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.ProfileBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.ProfileBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.ProfileBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.ProfileBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProfileBtn.Size = new System.Drawing.Size(168, 55);
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
            this.panelContainer.Location = new System.Drawing.Point(4, 66);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1671, 785);
            this.panelContainer.TabIndex = 10;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.photo_1603366615917_1fa6dad5c4fa;
            this.roundPictureBox1.Location = new System.Drawing.Point(1613, 4);
            this.roundPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(53, 49);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roundPictureBox1.TabIndex = 9;
            this.roundPictureBox1.TabStop = false;
            this.roundPictureBox1.Click += new System.EventHandler(this.roundPictureBox1_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.roundPictureBox1);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StudentForm_Load);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ProcessingBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton productBtn;
        private System.Windows.Forms.Panel userPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton LogOutBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ProfileBtn;
        private RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Panel panelContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cartBtn;
    }
}