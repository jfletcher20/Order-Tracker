namespace OrderTracker {
    partial class FrmRequests {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.LblScreenTitle = new System.Windows.Forms.Label();
            this.RedPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnGenReport = new System.Windows.Forms.Button();
            this.BtnDeleteRqst = new System.Windows.Forms.Button();
            this.BtnNewRqst = new System.Windows.Forms.Button();
            this.btnEditRqst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.RedPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRequests
            // 
            this.dgvRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequests.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvRequests.Location = new System.Drawing.Point(12, 103);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(1451, 317);
            this.dgvRequests.TabIndex = 0;
            // 
            // LblScreenTitle
            // 
            this.LblScreenTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblScreenTitle.AutoSize = true;
            this.LblScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblScreenTitle.ForeColor = System.Drawing.Color.White;
            this.LblScreenTitle.Location = new System.Drawing.Point(612, 27);
            this.LblScreenTitle.Name = "LblScreenTitle";
            this.LblScreenTitle.Size = new System.Drawing.Size(240, 24);
            this.LblScreenTitle.TabIndex = 6;
            this.LblScreenTitle.Text = "Pregled zahtjeva za nabavu";
            this.LblScreenTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RedPanel
            // 
            this.RedPanel.BackColor = System.Drawing.Color.Red;
            this.RedPanel.Controls.Add(this.LblScreenTitle);
            this.RedPanel.Location = new System.Drawing.Point(12, 12);
            this.RedPanel.Name = "RedPanel";
            this.RedPanel.Size = new System.Drawing.Size(1451, 78);
            this.RedPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnGenReport);
            this.panel1.Controls.Add(this.BtnDeleteRqst);
            this.panel1.Controls.Add(this.BtnNewRqst);
            this.panel1.Controls.Add(this.btnEditRqst);
            this.panel1.Location = new System.Drawing.Point(12, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1451, 57);
            this.panel1.TabIndex = 8;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(1326, 3);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(122, 51);
            this.BtnLogout.TabIndex = 11;
            this.BtnLogout.Text = "Odjava";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnGenReport
            // 
            this.BtnGenReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenReport.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGenReport.ForeColor = System.Drawing.Color.White;
            this.BtnGenReport.Location = new System.Drawing.Point(1198, 3);
            this.BtnGenReport.Name = "BtnGenReport";
            this.BtnGenReport.Size = new System.Drawing.Size(122, 51);
            this.BtnGenReport.TabIndex = 10;
            this.BtnGenReport.Text = "Generiraj izvještaj";
            this.BtnGenReport.UseVisualStyleBackColor = false;
            // 
            // BtnDeleteRqst
            // 
            this.BtnDeleteRqst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteRqst.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDeleteRqst.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteRqst.Location = new System.Drawing.Point(260, 3);
            this.BtnDeleteRqst.Name = "BtnDeleteRqst";
            this.BtnDeleteRqst.Size = new System.Drawing.Size(122, 51);
            this.BtnDeleteRqst.TabIndex = 9;
            this.BtnDeleteRqst.Text = "Izbriši zahtjev";
            this.BtnDeleteRqst.UseVisualStyleBackColor = false;
            // 
            // BtnNewRqst
            // 
            this.BtnNewRqst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewRqst.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnNewRqst.ForeColor = System.Drawing.Color.White;
            this.BtnNewRqst.Location = new System.Drawing.Point(4, 3);
            this.BtnNewRqst.Name = "BtnNewRqst";
            this.BtnNewRqst.Size = new System.Drawing.Size(122, 51);
            this.BtnNewRqst.TabIndex = 8;
            this.BtnNewRqst.Text = "Novi zahtjev";
            this.BtnNewRqst.UseVisualStyleBackColor = false;
            // 
            // btnEditRqst
            // 
            this.btnEditRqst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditRqst.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditRqst.ForeColor = System.Drawing.Color.White;
            this.btnEditRqst.Location = new System.Drawing.Point(132, 3);
            this.btnEditRqst.Name = "btnEditRqst";
            this.btnEditRqst.Size = new System.Drawing.Size(122, 51);
            this.btnEditRqst.TabIndex = 7;
            this.btnEditRqst.Text = "Azuriraj zahtjev";
            this.btnEditRqst.UseVisualStyleBackColor = false;
            this.btnEditRqst.Click += new System.EventHandler(this.btnEditRqst_Click);
            // 
            // FrmRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RedPanel);
            this.Controls.Add(this.dgvRequests);
            this.Name = "FrmRequests";
            this.Text = "FrmStudents";
            this.Load += new System.EventHandler(this.FrmRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.RedPanel.ResumeLayout(false);
            this.RedPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Label LblScreenTitle;
        private System.Windows.Forms.Panel RedPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnGenReport;
        private System.Windows.Forms.Button BtnDeleteRqst;
        private System.Windows.Forms.Button BtnNewRqst;
        private System.Windows.Forms.Button btnEditRqst;
    }
}