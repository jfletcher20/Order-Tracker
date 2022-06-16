using OrderTracker.Models;
using OrderTracker.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderTracker {
    public partial class FrmLogin : Form {
        public static Employee LoggedEmployee { get; set; }

        public FrmLogin() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (txtUsername.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtPassword.Text == "") {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                LoggedEmployee = EmployeeRepository.GetEmployee(txtUsername.Text);
                if (LoggedEmployee != null && LoggedEmployee.Password == txtPassword.Text) {
                    FrmRequests frmRequests = new FrmRequests();
                    Hide();
                    frmRequests.ShowDialog();
                    Close();
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
