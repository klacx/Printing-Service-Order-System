namespace WindowsFormsApp1.Dynamic_Panel.Manager_Layout
{
    partial class newRequestLayout
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
            this.assignBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.lbl_orderDetails = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.workerComboBox = new System.Windows.Forms.ComboBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // assignBtn
            // 
            this.assignBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assignBtn.Enabled = false;
            this.assignBtn.Location = new System.Drawing.Point(1021, 13);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.assignBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.assignBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.assignBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.assignBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.assignBtn.OverrideFocus.Back.ColorAngle = 45F;
            this.assignBtn.Size = new System.Drawing.Size(88, 23);
            this.assignBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.assignBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.assignBtn.StateCommon.Back.ColorAngle = 45F;
            this.assignBtn.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.assignBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.assignBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignBtn.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.assignBtn.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.assignBtn.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.assignBtn.StateDisabled.Back.Color2 = System.Drawing.Color.DarkGray;
            this.assignBtn.TabIndex = 16;
            this.assignBtn.Values.Text = "Assign";
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalAmount.Location = new System.Drawing.Point(601, 15);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(115, 21);
            this.lbl_totalAmount.TabIndex = 14;
            this.lbl_totalAmount.Text = "total amount";
            this.lbl_totalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_orderDetails
            // 
            this.lbl_orderDetails.AutoSize = true;
            this.lbl_orderDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDetails.Location = new System.Drawing.Point(294, 15);
            this.lbl_orderDetails.Name = "lbl_orderDetails";
            this.lbl_orderDetails.Size = new System.Drawing.Size(74, 21);
            this.lbl_orderDetails.TabIndex = 13;
            this.lbl_orderDetails.Text = "product";
            this.lbl_orderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(31, 15);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(65, 21);
            this.lbl_id.TabIndex = 12;
            this.lbl_id.Text = "orderid";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workerComboBox
            // 
            this.workerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerComboBox.FormattingEnabled = true;
            this.workerComboBox.Location = new System.Drawing.Point(790, 10);
            this.workerComboBox.Name = "workerComboBox";
            this.workerComboBox.Size = new System.Drawing.Size(121, 29);
            this.workerComboBox.TabIndex = 17;
            this.workerComboBox.SelectedValueChanged += new System.EventHandler(this.workerComboBox_SelectedValueChanged);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(162, 15);
            this.lbl_user.MaximumSize = new System.Drawing.Size(100, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(74, 21);
            this.lbl_user.TabIndex = 18;
            this.lbl_user.Text = "order by";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newRequestLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.workerComboBox);
            this.Controls.Add(this.assignBtn);
            this.Controls.Add(this.lbl_totalAmount);
            this.Controls.Add(this.lbl_orderDetails);
            this.Controls.Add(this.lbl_id);
            this.Name = "newRequestLayout";
            this.Size = new System.Drawing.Size(1150, 48);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton assignBtn;
        private System.Windows.Forms.Label lbl_totalAmount;
        private System.Windows.Forms.Label lbl_orderDetails;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_user;
        public System.Windows.Forms.ComboBox workerComboBox;
    }
}
