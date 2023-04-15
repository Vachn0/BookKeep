using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookKeep
{
    public partial class BookKeep : Form
    {


        public BookKeep()
        {
            InitializeComponent();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("დავასრულოთ მუშაობა?", "დასრულება", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Close();
            }
        }

        private void box_ezsearch_Click(object sender, EventArgs e)
        {
            if (box_ezsearch.Text.Contains("Search Books..."))
            {
                box_ezsearch.Clear();
            }
        }

        private void btn_ezsearch_Click(object sender, EventArgs e)
        {
            box_ezsearch.Clear();
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
                AddBook f1 = new AddBook();
                RentBook f2 = new RentBook();
                ReturnBook f3 = new ReturnBook();
                SearchSys f4 = new SearchSys();

                f2.Close();
                f3.Close();
                f4.Close();
                f1.Show();
        }

        private void btn_rentOut_Click(object sender, EventArgs e)
        {
                AddBook f1 = new AddBook();
                RentBook f2 = new RentBook();
                ReturnBook f3 = new ReturnBook();
                SearchSys f4 = new SearchSys();

                f1.Close();
                f3.Close();
                f4.Close();
                f2.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
                AddBook f1 = new AddBook();
                RentBook f2 = new RentBook();
                ReturnBook f3 = new ReturnBook();
                SearchSys f4 = new SearchSys();

                f1.Close();
                f2.Close();
                f4.Close();
                f3.Show();
        }

        private void btn_searchSys_Click(object sender, EventArgs e)
        {
                AddBook f1 = new AddBook();
                RentBook f2 = new RentBook();
                ReturnBook f3 = new ReturnBook();
                SearchSys f4 = new SearchSys();

                f1.Close();
                f2.Close();
                f3.Close();
                f4.Show();
        }
    }
}
