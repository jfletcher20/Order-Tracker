using OrderTracker.Models;
using OrderTracker.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private void ForgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                VisitLink(e);
            } catch (Exception ex) {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink(LinkLabelLinkClickedEventArgs e) {
            // Change the color of the link text by setting LinkVisited
            // to true.
            ForgotPasswordLink.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = "https://spider.foi.hr/OWT/2022/vjezbe/jfletcher20/forgot-password";

            if (!url.Contains("://"))
                url = "https://" + url;

            var si = new ProcessStartInfo(url);
            Process.Start(si);
            ForgotPasswordLink.LinkVisited = true;
        }

    }
}
