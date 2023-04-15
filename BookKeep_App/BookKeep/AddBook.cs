using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookKeep
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btn_addbookClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ნამდვილად გსურთ დახურვა?", "დახურვა?", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
