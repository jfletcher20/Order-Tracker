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
            ShowRequests();
        }

        private void ShowRequests() {
            /*var students = StudentRepository.GetStudents();
            dgvStudents.DataSource = students;
            dgvStudents.Columns["Id"].DisplayIndex = 0;
            dgvStudents.Columns["FirstName"].DisplayIndex = 1;
            dgvStudents.Columns["LastName"].DisplayIndex = 2;
            dgvStudents.Columns["Grade"].DisplayIndex = 3;*/
            var requests = RequestRepository.GetRequests();
            dgvRequests.DataSource = requests;
            dgvRequests.Columns["ID"].DisplayIndex = 0;
            dgvRequests.Columns["project_name"].DisplayIndex = 1;
            dgvRequests.Columns["rqst_description"].DisplayIndex = 2;
            dgvRequests.Columns["status"].DisplayIndex = 3;
        }

        private void btnEditRqst_Click(object sender, EventArgs e) {
            Request selectedRequest = dgvRequests.CurrentRow.DataBoundItem as Request;
            if (selectedRequest != null) {
                FrmRequest frmEvaluation = new FrmRequest(selectedRequest);
                frmEvaluation.ShowDialog();
            }
        }

    }
}
