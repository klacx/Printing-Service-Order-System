namespace WindowsFormsApp1.Dynamic_Panel.Worker_Layout
{
    partial class workerHistoryLayout
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
            this.SuspendLayout();
            // 
            // lbl_orderDate
            // 
            this.lbl_orderDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDate.Location = new System.Drawing.Point(507, 13);
            this.lbl_orderDate.Name = "lbl_orderDate";
            this.lbl_orderDate.Size = new System.Drawing.Size(208, 21);
            this.lbl_orderDate.TabIndex = 21;
            this.lbl_orderDate.Text = "order date";
            this.lbl_orderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_orderStatus
            // 
            this.lbl_orderStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderStatus.ForeColor = System.Drawing.Color.Green;
            this.lbl_orderStatus.Location = new System.Drawing.Point(835, 13);
            this.lbl_orderStatus.Name = "lbl_orderStatus";
            this.lbl_orderStatus.Size = new System.Drawing.Size(138, 21);
            this.lbl_orderStatus.TabIndex = 20;
            this.lbl_orderStatus.Text = "status";
            this.lbl_orderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_orderDetails
            // 
            this.lbl_orderDetails.AutoSize = true;
            this.lbl_orderDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDetails.Location = new System.Drawing.Point(183, 13);
            this.lbl_orderDetails.Name = "lbl_orderDetails";
            this.lbl_orderDetails.Size = new System.Drawing.Size(74, 21);
            this.lbl_orderDetails.TabIndex = 19;
            this.lbl_orderDetails.Text = "product";
            this.lbl_orderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(18, 13);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(65, 21);
            this.lbl_id.TabIndex = 18;
            this.lbl_id.Text = "orderid";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workerHistoryLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_orderDate);
            this.Controls.Add(this.lbl_orderStatus);
            this.Controls.Add(this.lbl_orderDetails);
            this.Controls.Add(this.lbl_id);
            this.Name = "workerHistoryLayout";
            this.Size = new System.Drawing.Size(1000, 48);
            this.Load += new System.EventHandler(this.workerHistoryLayout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orderDate;
        private System.Windows.Forms.Label lbl_orderStatus;
        private System.Windows.Forms.Label lbl_orderDetails;
        private System.Windows.Forms.Label lbl_id;
    }
}
