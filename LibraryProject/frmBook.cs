using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class frmBook : Form
    {
        dslibraryTableAdapters.tblBookTableAdapter objBook = new dslibraryTableAdapters.tblBookTableAdapter();
        DataTable dtBook = new DataTable();
        dslibraryTableAdapters.tblBookTypeTableAdapter objBookType = new dslibraryTableAdapters.tblBookTypeTableAdapter();
        DataTable dtBookType = new DataTable();

        string BookID;
        string BTID="";
        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            refresh_b();
            getAutoIDofBook();
            ShowBookType();
        }
        private void refresh_b()
        {
            dtBook = objBook.GetData();
            dgvBook.DataSource = dtBook;
        }
        private void cleartext()
        {
            txtBookID.Clear();
            
            txtBookName.Clear();
            txtAuthor.Clear();
            
            txtBookStatus.Clear();
        }

        private void getAutoIDofBook()
        {
            int count = dtBook.Rows.Count;

            if (count == 0)
            {
                txtBookID.Text = "B-00001";
            }
            else
            {
                string oldID = Convert.ToString(dtBook.Rows[count - 1][0]);
                int newID = Convert.ToInt32(oldID.Substring(3));
                int lastID = newID + 1;
                if (lastID < 10)
                {
                    txtBookID.Text = "B-0000" + lastID;
                }
                else if (lastID > 9)
                {
                    txtBookID.Text = "B-000" + lastID;
                }
                else if (lastID > 99)
                {
                    txtBookID.Text = "B-00" + lastID;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().Show();
        }

        private void cboBookType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String BookTypeName = cboBookType.SelectedItem.ToString();
            dtBookType = objBookType.GetDataByBookTypeID(BookTypeName);
            BTID = dtBookType.Rows[0][0].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objBook.Insert(txtBookID.Text, BTID,
                txtBookName.Text, txtAuthor.Text, Convert.ToInt32(cboAquantity.Text),
                txtBookStatus.Text);

            refresh_b();

            MessageBox.Show("The book is successfully saved!");
            cleartext();
            getAutoIDofBook();
        }

        private void ShowBookType()
        {

            dtBookType = objBookType.GetData();
            for (int i = 0; i < dtBookType.Rows.Count; i++)
            {
                cboBookType.Items.Add(dtBookType.Rows[i][1].ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            objBook.UpdateBook(BTID,
                txtBookName.Text, txtAuthor.Text, Convert.ToInt32(cboAquantity.Text),
                txtBookStatus.Text, txtBookID.Text);

            MessageBox.Show("Saved successfully. The data is updated!");

            cleartext();
            refresh_b();
            dgvBook.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objBook.DeleteBook(BookID);

            cleartext();
            refresh_b();
            dgvBook.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleartext();
            getAutoIDofBook();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedrow = this.dgvBook.Rows[e.RowIndex];

                BookID = selectedrow.Cells[0].Value.ToString();

                txtBookID.Text = selectedrow.Cells[0].Value.ToString();
                cboBookType.Text = selectedrow.Cells[1].Value.ToString();
                txtBookName.Text = selectedrow.Cells[2].Value.ToString();
                txtAuthor.Text = selectedrow.Cells[3].Value.ToString();
                cboAquantity.Text = selectedrow.Cells[4].Value.ToString();
                txtBookStatus.Text = selectedrow.Cells[5].Value.ToString();
            }
        }

        
    }
}
