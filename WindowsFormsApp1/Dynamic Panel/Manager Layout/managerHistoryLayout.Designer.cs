namespace WindowsFormsApp1.Dynamic_Panel.Manager_Layout
{
    partial class managerHistoryLayout
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
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_orderDetails = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.lbl_worker = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.print)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_orderDate
            // 
            this.lbl_orderDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDate.Location = new System.Drawing.Point(542, 14);
            this.lbl_orderDate.Name = "lbl_orderDate";
            this.lbl_orderDate.Size = new System.Drawing.Size(143, 57);
            this.lbl_orderDate.TabIndex = 10;
            this.lbl_orderDate.Text = "order date";
            this.lbl_orderDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_orderStatus
            // 
            this.lbl_orderStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderStatus.Location = new System.Drawing.Point(1004, 14);
            this.lbl_orderStatus.Name = "lbl_orderStatus";
            this.lbl_orderStatus.Size = new System.Drawing.Size(131, 21);
            this.lbl_orderStatus.TabIndex = 9;
            this.lbl_orderStatus.Text = "status";
            this.lbl_orderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(113, 14);
            this.lbl_user.MaximumSize = new System.Drawing.Size(100, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(74, 21);
            this.lbl_user.TabIndex = 8;
            this.lbl_user.Text = "order by";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_orderDetails
            // 
            this.lbl_orderDetails.AutoSize = true;
            this.lbl_orderDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDetails.Location = new System.Drawing.Point(228, 14);
            this.lbl_orderDetails.Name = "lbl_orderDetails";
            this.lbl_orderDetails.Size = new System.Drawing.Size(74, 21);
            this.lbl_orderDetails.TabIndex = 7;
            this.lbl_orderDetails.Text = "product";
            this.lbl_orderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(2, 14);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(65, 21);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "orderid";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_payment
            // 
            this.lbl_payment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment.Location = new System.Drawing.Point(874, 14);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(115, 21);
            this.lbl_payment.TabIndex = 11;
            this.lbl_payment.Text = "payment";
            this.lbl_payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_worker
            // 
            this.lbl_worker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_worker.Location = new System.Drawing.Point(702, 14);
            this.lbl_worker.Name = "lbl_worker";
            this.lbl_worker.Size = new System.Drawing.Size(149, 21);
            this.lbl_worker.TabIndex = 12;
            this.lbl_worker.Text = "workerid";
            this.lbl_worker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // print
            // 
            this.print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print.Image = global::WindowsFormsApp1.Properties.Resources.print_logo;
            this.print.Location = new System.Drawing.Point(1153, 11);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(47, 42);
            this.print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.print.TabIndex = 13;
            this.print.TabStop = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // managerHistoryLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.print);
            this.Controls.Add(this.lbl_worker);
            this.Controls.Add(this.lbl_payment);
            this.Controls.Add(this.lbl_orderDate);
            this.Controls.Add(this.lbl_orderStatus);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_orderDetails);
            this.Controls.Add(this.lbl_id);
            this.Name = "managerHistoryLayout";
            this.Size = new System.Drawing.Size(1225, 48);
            this.Load += new System.EventHandler(this.orderLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.print)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orderDate;
        private System.Windows.Forms.Label lbl_orderStatus;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_orderDetails;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_payment;
        private System.Windows.Forms.Label lbl_worker;
        private System.Windows.Forms.PictureBox print;
    }
}
