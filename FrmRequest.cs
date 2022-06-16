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
            cboActivities.DataSource = requests;
        }

        private void SetFormText() {
            Text = SelectedRequest.ID + " " + SelectedRequest.Rqst_description;
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e) {

            var currentActivity = cboActivities.SelectedItem as Request;
            /*txtActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" + currentActivity.MaxPoints;
            txtMinForSignature.Text = currentActivity.MinPointsForSignature + "/" + currentActivity.MaxPoints;
            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.MaxPoints;
*/
            var evaluation = OrderRepository.GetOrder(SelectedRequest/*, currentActivity*/);
            
            if (evaluation != null) {
                txtTeacher.Text = evaluation.Evaluator.ToString();
                txtEvaluationDate.Text = evaluation.EvaluationDate.ToString();
                numPoints.Value = evaluation.Points;
            } else {
                txtTeacher.Text = FrmLogin.LoggedEmployee.ToString();
                txtEvaluationDate.Text = "-";
                numPoints.Value = 0;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            var activity = cboActivities.SelectedItem as Request;
            var teacher = FrmLogin.LoggedEmployee;

            int points = (int)numPoints.Value;

            teacher.PerformEvaluation(SelectedRequest, activity, points);
            Close();

        }

    }
}
