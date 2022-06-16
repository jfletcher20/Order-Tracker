using OrderTracker.Models;
using OrderTracker.Repositories;
using System;
using System.Windows.Forms;

namespace OrderTracker {
    public partial class FrmRequest : Form {

        private Request request;
        public Employee loggedEmployee;
        public string mode;

        public Request SelectedRequest { get => request; set => request = value; }

        public FrmRequest(Request selectedRequest) {
            InitializeComponent();
            SelectedRequest = selectedRequest;
        }

        private void FrmRequest_Load(object sender, EventArgs e) {

            loggedEmployee = FrmLogin.LoggedEmployee;
            
            var requests = RequestRepository.GetRequests();
            cboFinancing.SelectedItem = request;
            if (mode == "INSERT") {
                txtEmployee.Text = EmployeeRepository.GetEmployee(FrmLogin.LoggedEmployee.Id).ToString();
                txtRqstDescription.Text = SelectedRequest.Rqst_description;
                txtStatus.Text = SelectedRequest.Status.ToString();
                return;
            }

            cboFinancing.SelectedText = SelectedRequest.Financing;
            SetFormText();

            SetReadOnly(loggedEmployee.Permissions);

        }

        private void SetReadOnly(int permissions) {
            switch(permissions) {
                case 1:
                    if (txtStatus.Text.ToString() == "Na putu."
                        || (txtProjectLeaderSigned.Text == "Odobreno."
                        && txtBookkeepingSigned.Text == "Odobreno."
                        && txtVicedeanSigned.Text == "Odobreno.")) {
                        txtStatus.ReadOnly = false;
                    }
                    break;
                case 2:
                    if (txtStatus.Text.ToString() == "Ceka na odobrenje od voditelja/ice projekta."
                        || (txtProjectLeaderSigned.Text == "")) {
                        txtProjectLeaderSigned.ReadOnly = false;
                        txtStatus.ReadOnly = false;
                    }
                    break;
                case 3:
                    if (txtStatus.Text.ToString() == "Ceka na odobrenje od voditelja/ice racunovodstva."
                        || (txtProjectLeaderSigned.Text == "Odobreno.")) {
                        txtBookkeepingSigned.ReadOnly = false;
                        txtStatus.ReadOnly = false;
                    }
                    break;
                case 4:
                    if (txtStatus.Text.ToString() == "Ceka na odobrenje od prodekan/ice za poslovanje."
                        || (txtProjectLeaderSigned.Text == "Odobreno."
                        && txtBookkeepingSigned.Text == "Odobreno.")) {
                        txtVicedeanSigned.ReadOnly = false;
                        txtStatus.ReadOnly = false;
                    }
                    break;
                default:
                    txtProjectLeaderSigned.ReadOnly = true;
                    txtBookkeepingSigned.ReadOnly = true;
                    txtVicedeanSigned.ReadOnly = true;
                    txtStatus.ReadOnly = true;
                    break;
            }
        }

        private void SetFormText() {
            cboFinancing.Text = SelectedRequest.Financing;
            txtEmployee.Text = EmployeeRepository.GetEmployee(SelectedRequest.Applicant).ToString();
            txtRqstDescription.Text = SelectedRequest.Rqst_description;
            txtP1bezPDV.Text = SelectedRequest.Ponuda1_bez_pdv.ToString();
            txtP1sPDV.Text = SelectedRequest.Ponuda1_s_pdv.ToString();
            txtP1odabrana.Text = SelectedRequest.Ponuda1_odabrana.ToString();
            txtP2bezPDV.Text = SelectedRequest.Ponuda2_bez_pdv.ToString();
            txtP2sPDV.Text = SelectedRequest.Ponuda2_s_pdv.ToString();
            txtP2odabrana.Text = SelectedRequest.Ponuda2_odabrana.ToString();
            txtFinancingDescription.Text = SelectedRequest.Financing_description.ToString();
            txtProjectID.Text = SelectedRequest.Project.ToString();
            txtProjectLeader.Text = ProjectRepository.GetLeader(ProjectRepository.GetProject(SelectedRequest.Project)).ToString();
            txtProjectName.Text = ProjectRepository.GetProject(SelectedRequest.Project).Name.ToString();
            txtProjectLeaderSigned.Text = SelectedRequest.Project_leader.ToString();
            txtBookkeepingSigned.Text = SelectedRequest.Bookkeeping.ToString();
            txtVicedeanSigned.Text = SelectedRequest.Vice_dean.ToString();
            txtStatus.Text = SelectedRequest.Status.ToString();
        }

        private void cboFinancing_SelectedIndexChanged(object sender, EventArgs e) {

            /*var financingMethod = cboFinancing.SelectedItem as Request;

            var request = OrderRepository.GetOrder(SelectedRequest*//*, currentActivity*//*);

            if (request != null) {
                *//*txtTeacher.Text = request.Evaluator.ToString();
                txtEvaluationDate.Text = request.EvaluationDate.ToString();
                numPoints.Value = request.Points;*//*
            } else {
                txtEmployee.Text = FrmLogin.LoggedEmployee.ToString();
                txtRqstDescription.Text = RequestRepository.GetRequest(0).Rqst_description;
                *//*var requests = RequestRepository.GetRequests();
                dgvOffers.DataSource = requests;*//*
            }*/

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            FrmRequests frmRequests = new FrmRequests();
            Hide();
            frmRequests.ShowDialog();
            Close();
        }

        private bool CheckIsFilled() {
            if (cboFinancing.Text == "") {
                MessageBox.Show("Podatak je prazan!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFinancing.Focus();
                return false;
            }
            if (txtEmployee.Text == "") {
                MessageBox.Show("Podatak je prazan!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployee.Focus();
                return false;
            }
            if (txtRqstDescription.Text == "") {
                MessageBox.Show("Podatak je prazan!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRqstDescription.Focus();
                return false;
            }
            if (txtP1bezPDV.Text == "") {
                MessageBox.Show("Podatak je prazan!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtP1bezPDV.Focus();
                return false;
            }
            if (txtP1sPDV.Text == "") {
                MessageBox.Show("Podatak je prazan!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtP1sPDV.Focus();
                return false;
            }
            if (txtP2bezPDV.Text == "") {
                MessageBox.Show("Podatak je prazan!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtP2bezPDV.Focus();
                return false;
            }
            if (txtP2sPDV.Text == "") {
                MessageBox.Show("Podatak je prazan!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtP2sPDV.Focus();
                return false;
            }
            if (txtStatus.Text == "") {
                MessageBox.Show("Podatak je prazan!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStatus.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e) {

            if(!CheckIsFilled()) return;

            Employee employee;
            if (mode == "INSERT") {
                employee = FrmLogin.LoggedEmployee;

                var rqst = OrderRepository.GetOrder(request);
                if (rqst == null) {
                    RequestRepository.InsertRequest(employee.Id.ToString(), cboFinancing.Text.ToString(),
                    txtStatus.Text.ToString(), txtBookkeepingSigned.Text.ToString(), txtVicedeanSigned.Text.ToString(),
                    txtProjectLeaderSigned.Text.ToString(), txtProjectID.Text.ToString(), txtProjectName.Text.ToString(),
                    txtFinancingDescription.Text.ToString(), txtP1sPDV.Text.ToString(), txtP2sPDV.Text.ToString(),
                    txtP1bezPDV.Text.ToString(), txtP2bezPDV.Text.ToString(), txtP1odabrana.Text.ToString(),
                    txtP2odabrana.Text.ToString(), txtRqstDescription.Text.ToString(), SelectedRequest.ID.ToString());
                } else {
                    RequestRepository.UpdateRequest(employee.Id.ToString(), cboFinancing.Text.ToString(),
                    txtStatus.Text.ToString(), txtBookkeepingSigned.Text.ToString(), txtVicedeanSigned.Text.ToString(),
                    txtProjectLeaderSigned.Text.ToString(), txtProjectID.Text.ToString(), txtProjectName.Text.ToString(),
                    txtFinancingDescription.Text.ToString(), txtP1sPDV.Text.ToString(), txtP2sPDV.Text.ToString(),
                    txtP1bezPDV.Text.ToString(), txtP2bezPDV.Text.ToString(), txtP1odabrana.Text.ToString(),
                    txtP2odabrana.Text.ToString(), txtRqstDescription.Text.ToString(), SelectedRequest.ID.ToString());
                }
            } else {
                var rqst = OrderRepository.GetOrder(request);
                if (rqst == null) {
                    RequestRepository.InsertRequest(SelectedRequest.Applicant.ToString(), cboFinancing.Text.ToString(),
                    txtStatus.Text.ToString(), txtBookkeepingSigned.Text.ToString(), txtVicedeanSigned.Text.ToString(),
                    txtProjectLeaderSigned.Text.ToString(), txtProjectID.Text.ToString(), txtProjectName.Text.ToString(),
                    txtFinancingDescription.Text.ToString(), txtP1sPDV.Text.ToString(), txtP2sPDV.Text.ToString(),
                    txtP1bezPDV.Text.ToString(), txtP2bezPDV.Text.ToString(), txtP1odabrana.Text.ToString(),
                    txtP2odabrana.Text.ToString(), txtRqstDescription.Text.ToString(), SelectedRequest.ID.ToString());
                } else {
                    RequestRepository.UpdateRequest(SelectedRequest.Applicant.ToString(), cboFinancing.Text.ToString(),
                    txtStatus.Text.ToString(), txtBookkeepingSigned.Text.ToString(), txtVicedeanSigned.Text.ToString(),
                    txtProjectLeaderSigned.Text.ToString(), txtProjectID.Text.ToString(), txtProjectName.Text.ToString(),
                    txtFinancingDescription.Text.ToString(), txtP1sPDV.Text.ToString(), txtP2sPDV.Text.ToString(),
                    txtP1bezPDV.Text.ToString(), txtP2bezPDV.Text.ToString(), txtP1odabrana.Text.ToString(),
                    txtP2odabrana.Text.ToString(), txtRqstDescription.Text.ToString(), SelectedRequest.ID.ToString());
                }
            }

            Hide();
            FrmRequests frmRequests = new FrmRequests();
            frmRequests.ShowDialog();
            Close();

        }

    }
}
