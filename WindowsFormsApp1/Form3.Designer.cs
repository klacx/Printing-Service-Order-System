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
            this.productBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.HistoryBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.InProgressBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.userPanel = new System.Windows.Forms.Panel();
            this.LogOutBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ProfileBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundPictureBox1 = new WindowsFormsApp1.RoundPictureBox();
            this.cartBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.kryptonPanel1.Controls.Add(this.HistoryBtn);
            this.kryptonPanel1.Controls.Add(this.InProgressBtn);
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
            this.kryptonPanel1.TabIndex = 2;
            // 
            // productBtn
            // 
            this.productBtn.Location = new System.Drawing.Point(557, 0);
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
            this.productBtn.Size = new System.Drawing.Size(122, 48);
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
            // HistoryBtn
            // 
            this.HistoryBtn.Location = new System.Drawing.Point(923, 0);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.HistoryBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.HistoryBtn.OverrideDefault.Back.ColorAngle = 10F;
            this.HistoryBtn.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.HistoryBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.HistoryBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.HistoryBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.HistoryBtn.Size = new System.Drawing.Size(122, 48);
            this.HistoryBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.HistoryBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.HistoryBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.HistoryBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.HistoryBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.HistoryBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.HistoryBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.HistoryBtn.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.HistoryBtn.StatePressed.Back.ColorAngle = 8F;
            this.HistoryBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.HistoryBtn.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.HistoryBtn.StateTracking.Back.ColorAngle = 8F;
            this.HistoryBtn.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.HistoryBtn.TabIndex = 5;
            this.HistoryBtn.Values.Text = "History";
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // InProgressBtn
            // 
            this.InProgressBtn.Location = new System.Drawing.Point(801, 0);
            this.InProgressBtn.Name = "InProgressBtn";
            this.InProgressBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.InProgressBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Gray;
            this.InProgressBtn.OverrideDefault.Back.ColorAngle = 10F;
            this.InProgressBtn.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.InProgressBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.InProgressBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.InProgressBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.InProgressBtn.Size = new System.Drawing.Size(122, 48);
            this.InProgressBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.InProgressBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.InProgressBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.InProgressBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.InProgressBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.InProgressBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.InProgressBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Agency FB", 11.25F);
            this.InProgressBtn.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.InProgressBtn.StatePressed.Back.ColorAngle = 8F;
            this.InProgressBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.InProgressBtn.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.InProgressBtn.StateTracking.Back.ColorAngle = 8F;
            this.InProgressBtn.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.InProgressBtn.TabIndex = 2;
            this.InProgressBtn.Values.Text = "In Progress";
            this.InProgressBtn.Click += new System.EventHandler(this.InProgressBtn_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.LogOutBtn);
            this.userPanel.Controls.Add(this.ProfileBtn);
            this.userPanel.Location = new System.Drawing.Point(1127, 1);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(129, 131);
            this.userPanel.TabIndex = 8;
            this.userPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userPanel_Paint);
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
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
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
            this.panelContainer.TabIndex = 10;
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
            // roundPictureBox1
            // 
            this.roundPictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.photo_1603366615917_1fa6dad5c4fa;
            this.roundPictureBox1.Location = new System.Drawing.Point(1210, 3);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roundPictureBox1.TabIndex = 9;
            this.roundPictureBox1.TabStop = false;
            this.roundPictureBox1.Click += new System.EventHandler(this.roundPictureBox1_Click);
            // 
            // cartBtn
            // 
            this.cartBtn.Location = new System.Drawing.Point(679, 0);
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
            this.cartBtn.Size = new System.Drawing.Size(122, 48);
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
            // 
            // StudentForm
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
            this.Name = "StudentForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton HistoryBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton InProgressBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton productBtn;
        private System.Windows.Forms.Panel userPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton LogOutBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ProfileBtn;
        private RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Panel panelContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cartBtn;
    }
}