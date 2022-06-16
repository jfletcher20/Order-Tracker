using OrderTracker.Models;
using OrderTracker.Repositories;
using System;
using System.Windows.Forms;

namespace OrderTracker {
    public partial class FrmRequest : Form {

        private Request request;

        public Request SelectedRequest { get => request; set => request = value; }

        public FrmRequest(Request selectedRequest) {
            InitializeComponent();
            SelectedRequest = selectedRequest;
        }

        private void FrmRequest_Load(object sender, EventArgs e) {
            SetFormText();
            var requests = RequestRepository.GetRequests();
            cboFinancing.DataSource = requests;
        }

        private void SetFormText() {
            /*Text = SelectedRequest.ID + " " + SelectedRequest.Rqst_description;*/
        }

        private void cboFinancing_SelectedIndexChanged(object sender, EventArgs e) {

            var financingMethod = cboFinancing.SelectedItem as Request;

            var request = OrderRepository.GetOrder(SelectedRequest/*, currentActivity*/);

            if (request != null) {
                /*txtTeacher.Text = request.Evaluator.ToString();
                txtEvaluationDate.Text = request.EvaluationDate.ToString();
                numPoints.Value = request.Points;*/
            } else {
                txtEmployee.Text = FrmLogin.LoggedEmployee.ToString();
                txtRqstDescription.Text = RequestRepository.GetRequest(0).Rqst_description;
                var requests = RequestRepository.GetRequests();
                dgvOffers.DataSource = requests;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {

            var request = cboFinancing.SelectedItem as Request;
            var employee = FrmLogin.LoggedEmployee;

            /*int points = (int)numPoints.Value;*/

            employee.SubmitRequest(SelectedRequest);
            Close();

        }

    }
}
