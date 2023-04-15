namespace BookKeep
{
    partial class BookKeep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookKeep));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.btn_rentOut = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_searchSys = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.box_deleteBook = new System.Windows.Forms.TextBox();
            this.btn_delBook = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.box_ezsearch = new System.Windows.Forms.TextBox();
            this.btn_ezsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1163, 912);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_addBook
            // 
            this.btn_addBook.Location = new System.Drawing.Point(31, 13);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(129, 23);
            this.btn_addBook.TabIndex = 1;
            this.btn_addBook.Text = "წიგნის დამატება";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // btn_rentOut
            // 
            this.btn_rentOut.Location = new System.Drawing.Point(166, 13);
            this.btn_rentOut.Name = "btn_rentOut";
            this.btn_rentOut.Size = new System.Drawing.Size(129, 23);
            this.btn_rentOut.TabIndex = 2;
            this.btn_rentOut.Text = "წიგნის გაცემა";
            this.btn_rentOut.UseVisualStyleBackColor = true;
            this.btn_rentOut.Click += new System.EventHandler(this.btn_rentOut_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(301, 13);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(129, 23);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "წიგნის დაბრუნება";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_searchSys
            // 
            this.btn_searchSys.Location = new System.Drawing.Point(436, 13);
            this.btn_searchSys.Name = "btn_searchSys";
            this.btn_searchSys.Size = new System.Drawing.Size(129, 23);
            this.btn_searchSys.TabIndex = 4;
            this.btn_searchSys.Text = "საძიებო სისტემა";
            this.btn_searchSys.UseVisualStyleBackColor = true;
            this.btn_searchSys.Click += new System.EventHandler(this.btn_searchSys_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.Green;
            this.Refresh.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Refresh.Location = new System.Drawing.Point(1090, 22);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(104, 63);
            this.Refresh.TabIndex = 5;
            this.Refresh.Text = "განახლება";
            this.Refresh.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1400, 824);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "წიგნის ID";
            // 
            // box_deleteBook
            // 
            this.box_deleteBook.Location = new System.Drawing.Point(1514, 828);
            this.box_deleteBook.Name = "box_deleteBook";
            this.box_deleteBook.Size = new System.Drawing.Size(82, 20);
            this.box_deleteBook.TabIndex = 7;
            // 
            // btn_delBook
            // 
            this.btn_delBook.BackColor = System.Drawing.Color.Maroon;
            this.btn_delBook.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_delBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delBook.Location = new System.Drawing.Point(1602, 827);
            this.btn_delBook.Name = "btn_delBook";
            this.btn_delBook.Size = new System.Drawing.Size(75, 25);
            this.btn_delBook.TabIndex = 8;
            this.btn_delBook.Text = "წაშლა";
            this.btn_delBook.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_close.Location = new System.Drawing.Point(1817, 1004);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 25);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "დახურვა";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // box_ezsearch
            // 
            this.box_ezsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box_ezsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_ezsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_ezsearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.box_ezsearch.Location = new System.Drawing.Point(31, 58);
            this.box_ezsearch.Multiline = true;
            this.box_ezsearch.Name = "box_ezsearch";
            this.box_ezsearch.Size = new System.Drawing.Size(534, 27);
            this.box_ezsearch.TabIndex = 11;
            this.box_ezsearch.Text = "Search Books...";
            this.box_ezsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_ezsearch.Click += new System.EventHandler(this.box_ezsearch_Click);
            // 
            // btn_ezsearch
            // 
            this.btn_ezsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ezsearch.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_ezsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ezsearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ezsearch.Location = new System.Drawing.Point(595, 58);
            this.btn_ezsearch.Name = "btn_ezsearch";
            this.btn_ezsearch.Size = new System.Drawing.Size(75, 27);
            this.btn_ezsearch.TabIndex = 12;
            this.btn_ezsearch.Text = "ძიება";
            this.btn_ezsearch.UseVisualStyleBackColor = false;
            this.btn_ezsearch.Click += new System.EventHandler(this.btn_ezsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1352, 745);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "_________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1363, 872);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "_________________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(1387, 780);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "წიგნის წასაშლელად შეიყვანეთ წიგნის ID";
            // 
            // BookKeep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ezsearch);
            this.Controls.Add(this.box_ezsearch);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_delBook);
            this.Controls.Add(this.box_deleteBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.btn_searchSys);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_rentOut);
            this.Controls.Add(this.btn_addBook);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookKeep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BookKeep";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Button btn_rentOut;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_searchSys;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_deleteBook;
        private System.Windows.Forms.Button btn_delBook;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox box_ezsearch;
        private System.Windows.Forms.Button btn_ezsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

