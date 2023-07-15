namespace WindowsFormsApp1.Dynamic_Panel.Manager_Layout
{
    partial class paymentLayout
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
            this.lbl_orderDate = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_orderDetails = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.acceptBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lbl_orderDate
            // 
            this.lbl_orderDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDate.Location = new System.Drawing.Point(713, 14);
            this.lbl_orderDate.Name = "lbl_orderDate";
            this.lbl_orderDate.Size = new System.Drawing.Size(199, 21);
            this.lbl_orderDate.TabIndex = 10;
            this.lbl_orderDate.Text = "order date";
            this.lbl_orderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_amount
            // 
            this.lbl_amount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(525, 14);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(115, 21);
            this.lbl_amount.TabIndex = 8;
            this.lbl_amount.Text = "total amount";
            this.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_orderDetails
            // 
            this.lbl_orderDetails.AutoSize = true;
            this.lbl_orderDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDetails.Location = new System.Drawing.Point(181, 14);
            this.lbl_orderDetails.Name = "lbl_orderDetails";
            this.lbl_orderDetails.Size = new System.Drawing.Size(74, 21);
            this.lbl_orderDetails.TabIndex = 7;
            this.lbl_orderDetails.Text = "product";
            this.lbl_orderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(40, 14);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(65, 21);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "orderid";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptBtn
            // 
            this.acceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptBtn.Location = new System.Drawing.Point(983, 12);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.acceptBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.acceptBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.acceptBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.acceptBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.acceptBtn.OverrideFocus.Back.ColorAngle = 45F;
            this.acceptBtn.Size = new System.Drawing.Size(146, 23);
            this.acceptBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.acceptBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.acceptBtn.StateCommon.Back.ColorAngle = 45F;
            this.acceptBtn.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.acceptBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.acceptBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.acceptBtn.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.acceptBtn.TabIndex = 11;
            this.acceptBtn.Values.Text = "Accept Payment";
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // paymentLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.lbl_orderDate);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_orderDetails);
            this.Controls.Add(this.lbl_id);
            this.Name = "paymentLayout";
            this.Size = new System.Drawing.Size(1150, 48);
            this.Load += new System.EventHandler(this.paymentLayout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orderDate;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_orderDetails;
        private System.Windows.Forms.Label lbl_id;
        private ComponentFactory.Krypton.Toolkit.KryptonButton acceptBtn;
    }
}
