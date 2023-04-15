namespace BookKeep
{
    partial class SearchSys
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
            this.btn_searchsysClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_searchsysClose
            // 
            this.btn_searchsysClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_searchsysClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_searchsysClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchsysClose.Location = new System.Drawing.Point(515, 565);
            this.btn_searchsysClose.Name = "btn_searchsysClose";
            this.btn_searchsysClose.Size = new System.Drawing.Size(75, 23);
            this.btn_searchsysClose.TabIndex = 3;
            this.btn_searchsysClose.Text = "დახურვა";
            this.btn_searchsysClose.UseVisualStyleBackColor = false;
            this.btn_searchsysClose.Click += new System.EventHandler(this.btn_searchsysClose_Click);
            // 
            // SearchSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 600);
            this.Controls.Add(this.btn_searchsysClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1259, 91);
            this.Name = "SearchSys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_searchsysClose;
    }
}