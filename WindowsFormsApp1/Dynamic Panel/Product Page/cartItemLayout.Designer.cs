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
            this.reduceBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.quantityTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.deleteBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            this.addBtn.Size = new System.Drawing.Size(23, 23);
            this.addBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.addBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.addBtn.StateCommon.Back.ColorAngle = 45F;
            this.addBtn.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.addBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.addBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.addBtn.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.addBtn.TabIndex = 5;
            this.addBtn.Values.Text = "+";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // reduceBtn
            // 
            this.reduceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reduceBtn.Location = new System.Drawing.Point(654, 14);
            this.reduceBtn.Name = "reduceBtn";
            this.reduceBtn.Size = new System.Drawing.Size(23, 23);
            this.reduceBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.reduceBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.reduceBtn.StateCommon.Back.ColorAngle = 45F;
            this.reduceBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.reduceBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduceBtn.TabIndex = 6;
            this.reduceBtn.Values.Text = "-";
            this.reduceBtn.Click += new System.EventHandler(this.reduceBtn_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(613, 14);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(34, 23);
            this.quantityTextBox.TabIndex = 7;
            this.quantityTextBox.Text = "1";
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Location = new System.Drawing.Point(1023, 14);
            this.deleteBtn.Name = "deleteBtn";
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
            // 
            // cartItemLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.reduceBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.lbl_totalAmount);
            this.Controls.Add(this.lbl_unitPrice);
            this.Controls.Add(this.lbl_productName);
            this.Name = "cartItemLayout";
            this.Size = new System.Drawing.Size(1136, 51);
            this.Load += new System.EventHandler(this.cartItemLayout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_unitPrice;
        private System.Windows.Forms.Label lbl_totalAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton reduceBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox quantityTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteBtn;
    }
}
