namespace BookKeep
{
    partial class AddBook
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
            this.btn_addbookClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addbookClose
            // 
            this.btn_addbookClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_addbookClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_addbookClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addbookClose.Location = new System.Drawing.Point(515, 565);
            this.btn_addbookClose.Name = "btn_addbookClose";
            this.btn_addbookClose.Size = new System.Drawing.Size(75, 23);
            this.btn_addbookClose.TabIndex = 0;
            this.btn_addbookClose.Text = "დახურვა";
            this.btn_addbookClose.UseVisualStyleBackColor = false;
            this.btn_addbookClose.Click += new System.EventHandler(this.btn_addbookClose_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(602, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btn_addbookClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1259, 91);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addbookClose;
    }
}