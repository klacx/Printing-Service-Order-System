namespace WindowsFormsApp1.Dynamic_Panel.Product_Page
{
    partial class cartItemLayout
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
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_unitPrice = new System.Windows.Forms.Label();
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.addBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.quantityTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.deleteBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DecreaseBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(17, 15);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(147, 21);
            this.lbl_productName.TabIndex = 1;
            this.lbl_productName.Text = "lbl_productName";
            this.lbl_productName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_unitPrice
            // 
            this.lbl_unitPrice.AutoSize = true;
            this.lbl_unitPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unitPrice.Location = new System.Drawing.Point(331, 15);
            this.lbl_unitPrice.Name = "lbl_unitPrice";
            this.lbl_unitPrice.Size = new System.Drawing.Size(57, 21);
            this.lbl_unitPrice.TabIndex = 2;
            this.lbl_unitPrice.Text = "label1";
            this.lbl_unitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.AutoSize = true;
            this.lbl_totalAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalAmount.Location = new System.Drawing.Point(817, 15);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(57, 21);
            this.lbl_totalAmount.TabIndex = 4;
            this.lbl_totalAmount.Text = "label3";
            this.lbl_totalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Location = new System.Drawing.Point(584, 14);
            this.addBtn.Name = "addBtn";
            this.addBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.addBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.addBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.addBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.addBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.addBtn.OverrideFocus.Back.ColorAngle = 45F;
            this.addBtn.Size = new System.Drawing.Size(23, 23);
            this.addBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.addBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.addBtn.StateCommon.Back.ColorAngle = 45F;
            this.addBtn.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.addBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.addBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.addBtn.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.addBtn.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.addBtn.StateDisabled.Back.Color2 = System.Drawing.Color.DarkGray;
            this.addBtn.TabIndex = 5;
            this.addBtn.Values.Text = "+";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(613, 15);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(34, 23);
            this.quantityTextBox.TabIndex = 7;
            this.quantityTextBox.Text = "1";
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantityTextBox_KeyDown);
            this.quantityTextBox.LostFocus += new System.EventHandler(this.quantityTextBox_LossFocus);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Location = new System.Drawing.Point(1023, 14);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.deleteBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.deleteBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.deleteBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.deleteBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.deleteBtn.OverrideFocus.Back.ColorAngle = 45F;
            this.deleteBtn.Size = new System.Drawing.Size(56, 23);
            this.deleteBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.deleteBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.deleteBtn.StateCommon.Back.ColorAngle = 45F;
            this.deleteBtn.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.deleteBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.deleteBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.deleteBtn.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Values.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // DecreaseBtn
            // 
            this.DecreaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecreaseBtn.Location = new System.Drawing.Point(652, 14);
            this.DecreaseBtn.Name = "DecreaseBtn";
            this.DecreaseBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.DecreaseBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.DecreaseBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.DecreaseBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.DecreaseBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.DecreaseBtn.OverrideFocus.Back.ColorAngle = 45F;
            this.DecreaseBtn.Size = new System.Drawing.Size(23, 23);
            this.DecreaseBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.DecreaseBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.DecreaseBtn.StateCommon.Back.ColorAngle = 45F;
            this.DecreaseBtn.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.DecreaseBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DecreaseBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecreaseBtn.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DecreaseBtn.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DecreaseBtn.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DecreaseBtn.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.DecreaseBtn.StateDisabled.Back.Color2 = System.Drawing.Color.DarkGray;
            this.DecreaseBtn.TabIndex = 9;
            this.DecreaseBtn.Values.Text = "-";
            this.DecreaseBtn.Click += new System.EventHandler(this.DecreaseBtn_Click);
            // 
            // cartItemLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DecreaseBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.lbl_totalAmount);
            this.Controls.Add(this.lbl_unitPrice);
            this.Controls.Add(this.lbl_productName);
            this.Name = "cartItemLayout";
            this.Size = new System.Drawing.Size(1144, 51);
            this.Load += new System.EventHandler(this.cartItemLayout_Load);
            this.Click += new System.EventHandler(this.cartItemLayout_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_unitPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox quantityTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton DecreaseBtn;
        public System.Windows.Forms.Label lbl_totalAmount;
    }
}
