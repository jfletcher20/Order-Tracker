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
    public partial class FrmGenReport : Form {
        public FrmGenReport() {
            InitializeComponent();
        }

        private void cboFinancing_SelectedIndexChanged(object sender, EventArgs e) {
            dgvRequests.DataSource = RequestRepository.FilterRequestsByFinancing(RequestRepository.GetRequests(),
                cboFinancing.Text);
            txtNumberOfRequests.Text = dgvRequests.RowCount.ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            Hide();
            Close();
        }
    }
}
