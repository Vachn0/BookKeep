namespace BookKeep
{
    partial class ReturnBook
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
            this.btn_returnbookClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_returnbookClose
            // 
            this.btn_returnbookClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_returnbookClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_returnbookClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_returnbookClose.Location = new System.Drawing.Point(515, 565);
            this.btn_returnbookClose.Name = "btn_returnbookClose";
            this.btn_returnbookClose.Size = new System.Drawing.Size(75, 23);
            this.btn_returnbookClose.TabIndex = 2;
            this.btn_returnbookClose.Text = "დახურვა";
            this.btn_returnbookClose.UseVisualStyleBackColor = false;
            this.btn_returnbookClose.Click += new System.EventHandler(this.btn_returnbookClose_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(602, 600);
            this.Controls.Add(this.btn_returnbookClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1259, 91);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_returnbookClose;
    }
}