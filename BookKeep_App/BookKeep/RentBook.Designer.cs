namespace BookKeep
{
    partial class RentBook
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
            this.btn_rentbookClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_rentbookClose
            // 
            this.btn_rentbookClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_rentbookClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_rentbookClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rentbookClose.Location = new System.Drawing.Point(515, 565);
            this.btn_rentbookClose.Name = "btn_rentbookClose";
            this.btn_rentbookClose.Size = new System.Drawing.Size(75, 23);
            this.btn_rentbookClose.TabIndex = 1;
            this.btn_rentbookClose.Text = "დახურვა";
            this.btn_rentbookClose.UseVisualStyleBackColor = false;
            this.btn_rentbookClose.Click += new System.EventHandler(this.btn_rentbookClose_Click);
            // 
            // RentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(602, 600);
            this.Controls.Add(this.btn_rentbookClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1259, 91);
            this.Name = "RentBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_rentbookClose;
    }
}