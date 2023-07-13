namespace WindowsFormsApp1.Student_UserControl
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.phoneNumberTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dobTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.genderTextBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CNPTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NPTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.updateBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.userIcon = new WindowsFormsApp1.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.genderTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(719, 85);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(224, 38);
            this.firstNameTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.firstNameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.firstNameTextBox.StateCommon.Border.Rounding = 15;
            this.firstNameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.firstNameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Text = "first name";
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(713, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1041, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(1047, 85);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(224, 38);
            this.lastNameTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.lastNameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lastNameTextBox.StateCommon.Border.Rounding = 15;
            this.lastNameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.lastNameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.Text = "last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(713, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(719, 454);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(552, 38);
            this.emailTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.emailTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.emailTextBox.StateCommon.Border.Rounding = 15;
            this.emailTextBox.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.emailTextBox.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.Text = "email";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(719, 208);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(224, 38);
            this.phoneNumberTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.phoneNumberTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.phoneNumberTextBox.StateCommon.Border.Rounding = 15;
            this.phoneNumberTextBox.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.phoneNumberTextBox.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.TabIndex = 7;
            this.phoneNumberTextBox.Text = "phone number";
            // 
            // dobTimePicker
            // 
            this.dobTimePicker.Checked = false;
            this.dobTimePicker.Location = new System.Drawing.Point(719, 331);
            this.dobTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dobTimePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dobTimePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dobTimePicker.Name = "dobTimePicker";
            this.dobTimePicker.Size = new System.Drawing.Size(552, 36);
            this.dobTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.dobTimePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dobTimePicker.StateCommon.Border.Rounding = 15;
            this.dobTimePicker.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.dobTimePicker.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobTimePicker.TabIndex = 9;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DropDownWidth = 158;
            this.genderTextBox.Items.AddRange(new object[] {
            "male",
            "female",
            "other"});
            this.genderTextBox.Location = new System.Drawing.Point(1047, 208);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderTextBox.MinimumSize = new System.Drawing.Size(224, 38);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(224, 38);
            this.genderTextBox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray;
            this.genderTextBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.genderTextBox.StateCommon.ComboBox.Border.Rounding = 15;
            this.genderTextBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DimGray;
            this.genderTextBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTextBox.TabIndex = 12;
            this.genderTextBox.Text = "gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1041, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1041, 549);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Confirm New Password:";
            // 
            // CNPTextBox
            // 
            this.CNPTextBox.Location = new System.Drawing.Point(1047, 577);
            this.CNPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CNPTextBox.Name = "CNPTextBox";
            this.CNPTextBox.PasswordChar = '●';
            this.CNPTextBox.Size = new System.Drawing.Size(224, 37);
            this.CNPTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.CNPTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CNPTextBox.StateCommon.Border.Rounding = 15;
            this.CNPTextBox.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.CNPTextBox.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPTextBox.TabIndex = 16;
            this.CNPTextBox.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(713, 549);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "New Password:";
            // 
            // NPTextBox
            // 
            this.NPTextBox.Location = new System.Drawing.Point(719, 577);
            this.NPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NPTextBox.Name = "NPTextBox";
            this.NPTextBox.PasswordChar = '●';
            this.NPTextBox.Size = new System.Drawing.Size(224, 37);
            this.NPTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.NPTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NPTextBox.StateCommon.Border.Rounding = 15;
            this.NPTextBox.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.NPTextBox.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPTextBox.TabIndex = 14;
            this.NPTextBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(713, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(716, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Date of Birth:";
            // 
            // updateBtn
            // 
            this.updateBtn.Enabled = false;
            this.updateBtn.Location = new System.Drawing.Point(724, 668);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.updateBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.updateBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.updateBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.updateBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.updateBtn.OverrideDefault.Border.ColorAngle = 45F;
            this.updateBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updateBtn.OverrideDefault.Border.Rounding = 15;
            this.updateBtn.OverrideDefault.Border.Width = 1;
            this.updateBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.updateBtn.Size = new System.Drawing.Size(152, 44);
            this.updateBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.updateBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.updateBtn.StateCommon.Back.ColorAngle = 45F;
            this.updateBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.updateBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.updateBtn.StateCommon.Border.ColorAngle = 45F;
            this.updateBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updateBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.updateBtn.StateCommon.Border.Rounding = 15;
            this.updateBtn.StateCommon.Border.Width = 1;
            this.updateBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.updateBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.updateBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.updateBtn.StateDisabled.Back.Color2 = System.Drawing.Color.DarkGray;
            this.updateBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.updateBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.updateBtn.StatePressed.Back.ColorAngle = 135F;
            this.updateBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.updateBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.updateBtn.StatePressed.Border.ColorAngle = 135F;
            this.updateBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updateBtn.StatePressed.Border.Rounding = 15;
            this.updateBtn.StatePressed.Border.Width = 1;
            this.updateBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.updateBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.updateBtn.StateTracking.Back.ColorAngle = 45F;
            this.updateBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.updateBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.updateBtn.StateTracking.Border.ColorAngle = 45F;
            this.updateBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updateBtn.StateTracking.Border.Rounding = 15;
            this.updateBtn.StateTracking.Border.Width = 1;
            this.updateBtn.TabIndex = 20;
            this.updateBtn.Values.Text = "Update";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(424, 331);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton2.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton2.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.OverrideDefault.Border.Rounding = 15;
            this.kryptonButton2.OverrideDefault.Border.Width = 1;
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton2.Size = new System.Drawing.Size(209, 44);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.kryptonButton2.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateCommon.Border.Rounding = 15;
            this.kryptonButton2.StateCommon.Border.Width = 1;
            this.kryptonButton2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton2.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton2.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton2.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton2.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StatePressed.Border.Rounding = 15;
            this.kryptonButton2.StatePressed.Border.Width = 1;
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton2.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton2.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateTracking.Border.Rounding = 15;
            this.kryptonButton2.StateTracking.Border.Width = 1;
            this.kryptonButton2.TabIndex = 0;
            this.kryptonButton2.Values.Text = "Upload Image";
            // 
            // userIcon
            // 
            this.userIcon.Location = new System.Drawing.Point(396, 78);
            this.userIcon.Margin = new System.Windows.Forms.Padding(4);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(264, 229);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIcon.TabIndex = 0;
            this.userIcon.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CNPTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NPTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.dobTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.userIcon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1680, 763);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genderTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundPictureBox userIcon;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox lastNameTextBox;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox emailTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phoneNumberTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dobTimePicker;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox genderTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox CNPTextBox;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox NPTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonButton updateBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}
