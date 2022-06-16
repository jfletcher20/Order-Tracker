namespace OrderTracker {
    partial class FrmGenReport {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFinancing = new System.Windows.Forms.ComboBox();
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnGenReport = new System.Windows.Forms.Button();
            this.RedPanel = new System.Windows.Forms.Panel();
            this.LblScreenTitle = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.txtNumberOfRequests = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.RedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtNumberOfRequests);
            this.panel1.Controls.Add(this.cboFinancing);
            this.panel1.Controls.Add(this.lblSearchBar);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnGenReport);
            this.panel1.Location = new System.Drawing.Point(9, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1460, 57);
            this.panel1.TabIndex = 11;
            // 
            // cboFinancing
            // 
            this.cboFinancing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFinancing.FormattingEnabled = true;
            this.cboFinancing.Items.AddRange(new object[] {
            "1. Temeljno financiranje znanosti \"5.000,00 kn\" (potpora)",
            "2. Zanstveno-nastavno usavršavanje \"5.000,00 kn\"",
            "3. Odluka - oprema - znan.-nast., nast. i surad. zvanja \"4.500,00 kn+PDV\"",
            "4. EU projekt",
            "5. Komercijalni projekt",
            "6. Komercijalna djelatnost (edukacije, izrada aplikacija, i dr.)",
            "7. Sredstva proračuna (opći prihodi i primici)",
            "8. Sredstva FOI (ostalo)"});
            this.cboFinancing.Location = new System.Drawing.Point(11, 26);
            this.cboFinancing.Name = "cboFinancing";
            this.cboFinancing.Size = new System.Drawing.Size(338, 21);
            this.cboFinancing.TabIndex = 24;
            this.cboFinancing.SelectedIndexChanged += new System.EventHandler(this.cboFinancing_SelectedIndexChanged);
            // 
            // lblSearchBar
            // 
            this.lblSearchBar.AutoSize = true;
            this.lblSearchBar.ForeColor = System.Drawing.Color.White;
            this.lblSearchBar.Location = new System.Drawing.Point(8, 10);
            this.lblSearchBar.Name = "lblSearchBar";
            this.lblSearchBar.Size = new System.Drawing.Size(133, 13);
            this.lblSearchBar.TabIndex = 14;
            this.lblSearchBar.Text = "Odabir metode financiranja";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(1326, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(131, 51);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Odustani";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnGenReport
            // 
            this.BtnGenReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenReport.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGenReport.ForeColor = System.Drawing.Color.White;
            this.BtnGenReport.Location = new System.Drawing.Point(1189, 3);
            this.BtnGenReport.Name = "BtnGenReport";
            this.BtnGenReport.Size = new System.Drawing.Size(131, 51);
            this.BtnGenReport.TabIndex = 10;
            this.BtnGenReport.Text = "Povratak";
            this.BtnGenReport.UseVisualStyleBackColor = false;
            this.BtnGenReport.Visible = false;
            // 
            // RedPanel
            // 
            this.RedPanel.BackColor = System.Drawing.Color.Red;
            this.RedPanel.Controls.Add(this.LblScreenTitle);
            this.RedPanel.Location = new System.Drawing.Point(9, 12);
            this.RedPanel.Name = "RedPanel";
            this.RedPanel.Size = new System.Drawing.Size(1460, 78);
            this.RedPanel.TabIndex = 10;
            // 
            // LblScreenTitle
            // 
            this.LblScreenTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblScreenTitle.AutoSize = true;
            this.LblScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblScreenTitle.ForeColor = System.Drawing.Color.White;
            this.LblScreenTitle.Location = new System.Drawing.Point(617, 27);
            this.LblScreenTitle.Name = "LblScreenTitle";
            this.LblScreenTitle.Size = new System.Drawing.Size(404, 24);
            this.LblScreenTitle.TabIndex = 6;
            this.LblScreenTitle.Text = "Izvještaj o zahtjevima prema metodi financiranja";
            this.LblScreenTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRequests
            // 
            this.dgvRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequests.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvRequests.Location = new System.Drawing.Point(9, 103);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(1460, 301);
            this.dgvRequests.TabIndex = 9;
            // 
            // txtNumberOfRequests
            // 
            this.txtNumberOfRequests.Location = new System.Drawing.Point(355, 26);
            this.txtNumberOfRequests.Name = "txtNumberOfRequests";
            this.txtNumberOfRequests.ReadOnly = true;
            this.txtNumberOfRequests.Size = new System.Drawing.Size(22, 20);
            this.txtNumberOfRequests.TabIndex = 25;
            // 
            // FrmGenReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RedPanel);
            this.Controls.Add(this.dgvRequests);
            this.Name = "FrmGenReport";
            this.Text = "FrmStudents";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RedPanel.ResumeLayout(false);
            this.RedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchBar;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnGenReport;
        private System.Windows.Forms.Panel RedPanel;
        private System.Windows.Forms.Label LblScreenTitle;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.ComboBox cboFinancing;
        private System.Windows.Forms.TextBox txtNumberOfRequests;
    }
}