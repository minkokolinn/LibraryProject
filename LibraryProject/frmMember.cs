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
    public partial class frmMember : Form
    {
        dslibraryTableAdapters.tblMemberTableAdapter objMember = new dslibraryTableAdapters.tblMemberTableAdapter();
        DataTable dtMember = new DataTable();

        string memberid;

        public frmMember()
        {
            InitializeComponent();
        }

        private void cleartext()
        {
            txtPhone.Clear();
            txtNRC.Clear();
            txtMemberName.Clear();
            txtAddress.Clear();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            refresh();
            getAutoGenerateID();
        }

        private void refresh()
        {
            dtMember = objMember.GetData();
            dgvMember.DataSource = dtMember;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().Show();
        }

        private void getAutoGenerateID()
        {
            int count = dtMember.Rows.Count;

            if (count == 0)
            {
                txtMemberID.Text = "M-00001";
            }
            else
            {
                string oldID = Convert.ToString(dtMember.Rows[count - 1][0]);
                int newID = Convert.ToInt32(oldID.Substring(2));
                int lastID = newID + 1;
                if (lastID < 10)
                {
                    txtMemberID.Text = "M-0000" + lastID;
                }
                else if (lastID > 9)
                {
                    txtMemberID.Text = "M-000" + lastID;
                }
                else if (lastID > 99)
                {
                    txtMemberID.Text = "M-00" + lastID;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text == "")
            {
                MessageBox.Show("Enter your ID");
            }
            if (txtMemberName.Text == "")
            {
                MessageBox.Show("Enter your name");
            }
            if (txtNRC.Text == "")
            {
                MessageBox.Show("Enter your NRC No.");
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter your address");
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Enter your phone number");
            }
            else
            {
                objMember.Insert(txtMemberID.Text, txtMemberName.Text, txtNRC.Text,
                    txtAddress.Text, txtPhone.Text);

                refresh();

                MessageBox.Show("Successfully Saved!");
                cleartext();
                getAutoGenerateID();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objMember.DeleteMember(memberid);

            MessageBox.Show("Deleted Successfully to the user "+memberid);
            refresh();
            cleartext();
            getAutoGenerateID();
        }

        private void dgvMember_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedrow = this.dgvMember.Rows[e.RowIndex];

                memberid = selectedrow.Cells[0].Value.ToString();

                txtMemberID.Text = selectedrow.Cells[0].Value.ToString();
                txtMemberName.Text = selectedrow.Cells[1].Value.ToString();
                txtNRC.Text = selectedrow.Cells[2].Value.ToString();
                txtAddress.Text = selectedrow.Cells[3].Value.ToString();
                txtPhone.Text = selectedrow.Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            objMember.UpdateMember(txtMemberName.Text,
                txtNRC.Text,txtAddress.Text,txtPhone.Text,txtMemberID.Text);

            MessageBox.Show("Save successfully. The data is updated!");

            cleartext();

            refresh();

            dgvMember.Refresh();
            getAutoGenerateID();
        }
    }
}
