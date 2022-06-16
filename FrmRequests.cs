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
    public partial class FrmRequests : Form {

        public FrmRequests() {
            InitializeComponent();
        }

        private void FrmRequests_Load(object sender, EventArgs e) {
            if (FrmLogin.LoggedEmployee.Permissions == 1) BtnGenReport.Visible = true;
            else BtnGenReport.Visible = false;
            ShowRequests();
        }

        private void ShowRequests() {
            var requests = RequestRepository.GetRequestsByEmployee(FrmLogin.LoggedEmployee);
            dgvRequests.DataSource = requests;
            dgvRequests.Columns["ID"].DisplayIndex = 0;
            dgvRequests.Columns["project_name"].DisplayIndex = 1;
            dgvRequests.Columns["rqst_description"].DisplayIndex = 2;
            dgvRequests.Columns["status"].DisplayIndex = 3;
        }

        private void btnEditRqst_Click(object sender, EventArgs e) {
            Request selectedRequest = dgvRequests.CurrentRow.DataBoundItem as Request;
            if (selectedRequest != null) {
                Hide();
                FrmRequest frmRequest = new FrmRequest(selectedRequest);
                frmRequest.mode = "UPDATE";
                frmRequest.ShowDialog();
                Close();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e) {
            Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            Close();
        }

        private void BtnNewRqst_Click(object sender, EventArgs e) {
            Hide();
            Request rqst = new Request();
            rqst.ID = new Random().Next(10, 1000000000);
            rqst.Rqst_description = "Opis";
            rqst.Status = "Ceka na odobrenje od voditelja/ice projekta.";
            FrmRequest frmRequest = new FrmRequest(rqst);
            frmRequest.mode = "INSERT";
            frmRequest.ShowDialog();
            Close();
        }

        private void BtnDeleteRqst_Click(object sender, EventArgs e) {
            Request selectedRequest = dgvRequests.CurrentRow.DataBoundItem as Request;
            if (selectedRequest != null) {
                Hide();
                RequestRepository.DeleteRequest(selectedRequest);
                FrmRequests frmRequests = new FrmRequests();
                frmRequests.ShowDialog();
                Close();
            }
        }

        private void BtnGenReport_Click(object sender, EventArgs e) {

        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            dgvRequests.DataSource = RequestRepository.FilterRequests(RequestRepository.GetRequestsByEmployee(FrmLogin.LoggedEmployee),
                txtSearch.Text);
        }

    }
}
