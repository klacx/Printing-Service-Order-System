namespace WindowsFormsApp1.Dynamic_Panel.Worker_Layout
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
            this.lbl_orderDate = new System.Windows.Forms.Label();
            this.lbl_orderStatus = new System.Windows.Forms.Label();
            this.lbl_orderDetails = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.statusBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lbl_orderDate
            // 
            this.lbl_orderDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDate.Location = new System.Drawing.Point(442, 13);
            this.lbl_orderDate.Name = "lbl_orderDate";
            this.lbl_orderDate.Size = new System.Drawing.Size(208, 21);
            this.lbl_orderDate.TabIndex = 10;
            this.lbl_orderDate.Text = "order date";
            this.lbl_orderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_orderStatus
            // 
            this.lbl_orderStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_orderStatus.Location = new System.Drawing.Point(742, 13);
            this.lbl_orderStatus.Name = "lbl_orderStatus";
            this.lbl_orderStatus.Size = new System.Drawing.Size(138, 21);
            this.lbl_orderStatus.TabIndex = 9;
            this.lbl_orderStatus.Text = "status";
            this.lbl_orderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_orderStatus.Click += new System.EventHandler(this.lbl_orderStatus_Click);
            // 
            // lbl_orderDetails
            // 
            this.lbl_orderDetails.AutoSize = true;
            this.lbl_orderDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDetails.Location = new System.Drawing.Point(148, 13);
            this.lbl_orderDetails.Name = "lbl_orderDetails";
            this.lbl_orderDetails.Size = new System.Drawing.Size(74, 21);
            this.lbl_orderDetails.TabIndex = 7;
            this.lbl_orderDetails.Text = "product";
            this.lbl_orderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(16, 13);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(65, 21);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "orderid";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusBtn
            // 
            this.statusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusBtn.Location = new System.Drawing.Point(971, 13);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.statusBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.statusBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.statusBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.statusBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.statusBtn.OverrideFocus.Back.ColorAngle = 45F;
            this.statusBtn.Size = new System.Drawing.Size(160, 23);
            this.statusBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(254)))));
            this.statusBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.statusBtn.StateCommon.Back.ColorAngle = 45F;
            this.statusBtn.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.statusBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.statusBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBtn.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.statusBtn.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.statusBtn.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.statusBtn.StateDisabled.Back.Color2 = System.Drawing.Color.DarkGray;
            this.statusBtn.TabIndex = 17;
            this.statusBtn.Values.Text = "Start Progressing";
            this.statusBtn.Click += new System.EventHandler(this.statusBtn_Click);
            // 
            // newRequestLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statusBtn);
            this.Controls.Add(this.lbl_orderDate);
            this.Controls.Add(this.lbl_orderStatus);
            this.Controls.Add(this.lbl_orderDetails);
            this.Controls.Add(this.lbl_id);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "newRequestLayout";
            this.Size = new System.Drawing.Size(1150, 48);
            this.Load += new System.EventHandler(this.workerRequestLayout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orderDate;
        private System.Windows.Forms.Label lbl_orderStatus;
        private System.Windows.Forms.Label lbl_orderDetails;
        private System.Windows.Forms.Label lbl_id;
        private ComponentFactory.Krypton.Toolkit.KryptonButton statusBtn;
    }
}
