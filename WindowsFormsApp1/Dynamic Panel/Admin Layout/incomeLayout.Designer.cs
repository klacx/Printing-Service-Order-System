namespace WindowsFormsApp1.Dynamic_Panel.Admin_Layout
{
    partial class incomeLayout
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
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalAmount.Location = new System.Drawing.Point(320, 15);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(148, 21);
            this.lbl_totalAmount.TabIndex = 28;
            this.lbl_totalAmount.Text = "RM0.00";
            this.lbl_totalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(13, 15);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(124, 21);
            this.lbl_productName.TabIndex = 27;
            this.lbl_productName.Text = "Product Name";
            // 
            // incomeLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_totalAmount);
            this.Controls.Add(this.lbl_productName);
            this.Name = "incomeLayout";
            this.Size = new System.Drawing.Size(480, 50);
            this.Load += new System.EventHandler(this.incomeLayout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_totalAmount;
        private System.Windows.Forms.Label lbl_productName;
    }
}
