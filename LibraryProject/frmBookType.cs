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
    public partial class frmBookType : Form
    {
        dslibraryTableAdapters.tblBookTypeTableAdapter objBookType = new dslibraryTableAdapters.tblBookTypeTableAdapter();
        DataTable dtBookType = new DataTable();
        public frmBookType()
        {
            InitializeComponent();
        }

        private void frmBookType_Load(object sender, EventArgs e)
        {
            refresh_bt();
            getAutoIDofBookType();
        }
        string booktypeid;
        private void refresh_bt()
        {
            dtBookType = objBookType.GetData();
            dgvBooktype.DataSource = dtBookType;
        }

        private void cleartext()
        {
            txtBookTypeID.Clear();
            txtBookTypeName.Clear();
        }
        private void getAutoIDofBookType()
        {
            int count = dtBookType.Rows.Count;

            if (count == 0)
            {
                txtBookTypeID.Text = "BT-00001";
            }
            else
            {
                string oldID = Convert.ToString(dtBookType.Rows[count - 1][0]);
                int newID = Convert.ToInt32(oldID.Substring(3));
                int lastID = newID + 1;
                if (lastID < 10)
                {
                    txtBookTypeID.Text = "BT-0000" + lastID;
                }
                else if (lastID > 9)
                {
                    txtBookTypeID.Text = "BT-000" + lastID;
                }
                else if (lastID > 99)
                {
                    txtBookTypeID.Text = "BT-00" + lastID;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtBookTypeID.Text == "")
            {
                MessageBox.Show("Enter your ID");
            }
            if (txtBookTypeName.Text == "")
            {
                MessageBox.Show("Enter your name");
            }
            else
            {
                objBookType.Insert(txtBookTypeID.Text, txtBookTypeName.Text);

                refresh_bt();

                MessageBox.Show("Successfully Saved!");
                cleartext();
                getAutoIDofBookType();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().Show();
        }

        private void dgvBooktype_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedrow = this.dgvBooktype.Rows[e.RowIndex];

                booktypeid = selectedrow.Cells[0].Value.ToString();

                txtBookTypeID.Text = selectedrow.Cells[0].Value.ToString();
                txtBookTypeName.Text = selectedrow.Cells[1].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objBookType.DeleteBookType(booktypeid);

            MessageBox.Show("Deleted Successfully to the user " + booktypeid);
            refresh_bt();
            cleartext();
            getAutoIDofBookType();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            objBookType.UpdateBookType(txtBookTypeName.Text,
                txtBookTypeID.Text);

            MessageBox.Show("Save successfully. The data is updated!");

            cleartext();

            refresh_bt();

            dgvBooktype.Refresh();
            getAutoIDofBookType();
        }
    }
}
