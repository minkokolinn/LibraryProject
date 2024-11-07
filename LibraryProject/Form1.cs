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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMember().Show();
        }

        private void btnBookType_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmBookType().Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmBook().Show();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmBorrow().Show();
        }

        
    }
}
