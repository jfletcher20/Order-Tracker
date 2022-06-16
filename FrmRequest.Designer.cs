
namespace OrderTracker
{
    partial class FrmRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNameLastName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblScreenTitle = new System.Windows.Forms.Label();
            this.PnlSection1 = new System.Windows.Forms.Panel();
            this.LblSection1 = new System.Windows.Forms.Label();
            this.PnlSection2 = new System.Windows.Forms.Panel();
            this.LblSection2 = new System.Windows.Forms.Label();
            this.txtRqstDescription = new System.Windows.Forms.TextBox();
            this.LblDesc = new System.Windows.Forms.Label();
            this.cboFinancing = new System.Windows.Forms.ComboBox();
            this.LblFinancing = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnNewOffer = new System.Windows.Forms.Button();
            this.dgvOffers = new System.Windows.Forms.DataGridView();
            this.LblOffers = new System.Windows.Forms.Label();
            this.BtnDeleteOffer = new System.Windows.Forms.Button();
            this.BtnOpenOffer = new System.Windows.Forms.Button();
            this.PnlSection3 = new System.Windows.Forms.Panel();
            this.LblSection3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlSection1.SuspendLayout();
            this.PnlSection2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).BeginInit();
            this.PnlSection3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktivnost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uvjet za potpis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 621);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uvjet za ocjenu:";
            // 
            // LblNameLastName
            // 
            this.LblNameLastName.AutoSize = true;
            this.LblNameLastName.Location = new System.Drawing.Point(16, 148);
            this.LblNameLastName.Name = "LblNameLastName";
            this.LblNameLastName.Size = new System.Drawing.Size(149, 13);
            this.LblNameLastName.TabIndex = 3;
            this.LblNameLastName.Text = "Ime i prezime podnositelja/ice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum evaluacije:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bodovi:";
            // 
            // cboActivities
            // 
            this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(18, 533);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(251, 21);
            this.cboActivities.TabIndex = 6;
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(300, 533);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(100, 20);
            this.txtMinForSignature.TabIndex = 7;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(300, 638);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(100, 20);
            this.txtMinForGrade.TabIndex = 8;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(18, 560);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.ReadOnly = true;
            this.txtActivityDescription.Size = new System.Drawing.Size(251, 98);
            this.txtActivityDescription.TabIndex = 9;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(169, 144);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(338, 20);
            this.txtEmployee.TabIndex = 10;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(169, 170);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.ReadOnly = true;
            this.txtEvaluationDate.Size = new System.Drawing.Size(157, 20);
            this.txtEvaluationDate.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 61);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(373, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 61);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(300, 584);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(81, 20);
            this.numPoints.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(15, 663);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 67);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.LblScreenTitle);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(15, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 78);
            this.panel2.TabIndex = 16;
            // 
            // LblScreenTitle
            // 
            this.LblScreenTitle.AutoSize = true;
            this.LblScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblScreenTitle.ForeColor = System.Drawing.Color.White;
            this.LblScreenTitle.Location = new System.Drawing.Point(170, 25);
            this.LblScreenTitle.Name = "LblScreenTitle";
            this.LblScreenTitle.Size = new System.Drawing.Size(162, 24);
            this.LblScreenTitle.TabIndex = 7;
            this.LblScreenTitle.Text = "Zahtjev za nabavu";
            this.LblScreenTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlSection1
            // 
            this.PnlSection1.BackColor = System.Drawing.Color.Red;
            this.PnlSection1.Controls.Add(this.LblSection1);
            this.PnlSection1.ForeColor = System.Drawing.Color.White;
            this.PnlSection1.Location = new System.Drawing.Point(15, 108);
            this.PnlSection1.Name = "PnlSection1";
            this.PnlSection1.Size = new System.Drawing.Size(495, 30);
            this.PnlSection1.TabIndex = 17;
            // 
            // LblSection1
            // 
            this.LblSection1.AutoSize = true;
            this.LblSection1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblSection1.ForeColor = System.Drawing.Color.White;
            this.LblSection1.Location = new System.Drawing.Point(10, 6);
            this.LblSection1.Margin = new System.Windows.Forms.Padding(3);
            this.LblSection1.Name = "LblSection1";
            this.LblSection1.Size = new System.Drawing.Size(123, 17);
            this.LblSection1.TabIndex = 7;
            this.LblSection1.Text = "Automatski podaci";
            this.LblSection1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlSection2
            // 
            this.PnlSection2.BackColor = System.Drawing.Color.Red;
            this.PnlSection2.Controls.Add(this.LblSection2);
            this.PnlSection2.ForeColor = System.Drawing.Color.White;
            this.PnlSection2.Location = new System.Drawing.Point(15, 212);
            this.PnlSection2.Name = "PnlSection2";
            this.PnlSection2.Size = new System.Drawing.Size(495, 30);
            this.PnlSection2.TabIndex = 18;
            // 
            // LblSection2
            // 
            this.LblSection2.AutoSize = true;
            this.LblSection2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblSection2.ForeColor = System.Drawing.Color.White;
            this.LblSection2.Location = new System.Drawing.Point(10, 6);
            this.LblSection2.Margin = new System.Windows.Forms.Padding(3);
            this.LblSection2.Name = "LblSection2";
            this.LblSection2.Size = new System.Drawing.Size(112, 17);
            this.LblSection2.TabIndex = 7;
            this.LblSection2.Text = "Predmet nabave";
            this.LblSection2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRqstDescription
            // 
            this.txtRqstDescription.Location = new System.Drawing.Point(169, 248);
            this.txtRqstDescription.Multiline = true;
            this.txtRqstDescription.Name = "txtRqstDescription";
            this.txtRqstDescription.ReadOnly = true;
            this.txtRqstDescription.Size = new System.Drawing.Size(338, 69);
            this.txtRqstDescription.TabIndex = 19;
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Location = new System.Drawing.Point(16, 253);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(117, 13);
            this.LblDesc.TabIndex = 20;
            this.LblDesc.Text = "Opis predmeta nabave:";
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
            this.cboFinancing.Location = new System.Drawing.Point(169, 323);
            this.cboFinancing.Name = "cboFinancing";
            this.cboFinancing.Size = new System.Drawing.Size(338, 21);
            this.cboFinancing.TabIndex = 22;
            this.cboFinancing.SelectedIndexChanged += new System.EventHandler(this.cboFinancing_SelectedIndexChanged);
            // 
            // LblFinancing
            // 
            this.LblFinancing.AutoSize = true;
            this.LblFinancing.Location = new System.Drawing.Point(16, 326);
            this.LblFinancing.Name = "LblFinancing";
            this.LblFinancing.Size = new System.Drawing.Size(90, 13);
            this.LblFinancing.TabIndex = 21;
            this.LblFinancing.Text = "Izvor financiranja:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.BtnNewOffer);
            this.panel3.Controls.Add(this.dgvOffers);
            this.panel3.Controls.Add(this.LblOffers);
            this.panel3.Controls.Add(this.BtnDeleteOffer);
            this.panel3.Controls.Add(this.BtnOpenOffer);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(15, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 67);
            this.panel3.TabIndex = 23;
            // 
            // BtnNewOffer
            // 
            this.BtnNewOffer.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnNewOffer.Location = new System.Drawing.Point(14, 33);
            this.BtnNewOffer.Name = "BtnNewOffer";
            this.BtnNewOffer.Size = new System.Drawing.Size(119, 25);
            this.BtnNewOffer.TabIndex = 17;
            this.BtnNewOffer.Text = "Stvori novu ponudu";
            this.BtnNewOffer.UseVisualStyleBackColor = false;
            // 
            // dgvOffers
            // 
            this.dgvOffers.AllowUserToAddRows = false;
            this.dgvOffers.AllowUserToDeleteRows = false;
            this.dgvOffers.AllowUserToResizeColumns = false;
            this.dgvOffers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOffers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffers.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvOffers.Location = new System.Drawing.Point(139, 6);
            this.dgvOffers.MultiSelect = false;
            this.dgvOffers.Name = "dgvOffers";
            this.dgvOffers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOffers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOffers.Size = new System.Drawing.Size(228, 53);
            this.dgvOffers.TabIndex = 16;
            // 
            // LblOffers
            // 
            this.LblOffers.AutoSize = true;
            this.LblOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblOffers.ForeColor = System.Drawing.Color.White;
            this.LblOffers.Location = new System.Drawing.Point(10, 10);
            this.LblOffers.Margin = new System.Windows.Forms.Padding(3);
            this.LblOffers.Name = "LblOffers";
            this.LblOffers.Size = new System.Drawing.Size(57, 17);
            this.LblOffers.TabIndex = 15;
            this.LblOffers.Text = "Ponude";
            this.LblOffers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDeleteOffer
            // 
            this.BtnDeleteOffer.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDeleteOffer.Location = new System.Drawing.Point(373, 34);
            this.BtnDeleteOffer.Name = "BtnDeleteOffer";
            this.BtnDeleteOffer.Size = new System.Drawing.Size(119, 25);
            this.BtnDeleteOffer.TabIndex = 14;
            this.BtnDeleteOffer.Text = "Izbriši";
            this.BtnDeleteOffer.UseVisualStyleBackColor = false;
            // 
            // BtnOpenOffer
            // 
            this.BtnOpenOffer.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnOpenOffer.Location = new System.Drawing.Point(373, 6);
            this.BtnOpenOffer.Name = "BtnOpenOffer";
            this.BtnOpenOffer.Size = new System.Drawing.Size(119, 25);
            this.BtnOpenOffer.TabIndex = 13;
            this.BtnOpenOffer.Text = "Otvori";
            this.BtnOpenOffer.UseVisualStyleBackColor = false;
            // 
            // PnlSection3
            // 
            this.PnlSection3.BackColor = System.Drawing.Color.Red;
            this.PnlSection3.Controls.Add(this.LblSection3);
            this.PnlSection3.ForeColor = System.Drawing.Color.White;
            this.PnlSection3.Location = new System.Drawing.Point(15, 423);
            this.PnlSection3.Name = "PnlSection3";
            this.PnlSection3.Size = new System.Drawing.Size(495, 30);
            this.PnlSection3.TabIndex = 19;
            // 
            // LblSection3
            // 
            this.LblSection3.AutoSize = true;
            this.LblSection3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblSection3.ForeColor = System.Drawing.Color.White;
            this.LblSection3.Location = new System.Drawing.Point(10, 6);
            this.LblSection3.Margin = new System.Windows.Forms.Padding(3);
            this.LblSection3.Name = "LblSection3";
            this.LblSection3.Size = new System.Drawing.Size(52, 17);
            this.LblSection3.TabIndex = 7;
            this.LblSection3.Text = "Projekt";
            this.LblSection3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 742);
            this.Controls.Add(this.PnlSection3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cboFinancing);
            this.Controls.Add(this.LblFinancing);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.txtRqstDescription);
            this.Controls.Add(this.PnlSection2);
            this.Controls.Add(this.PnlSection1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblNameLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRequest";
            this.Text = "FrmRequest";
            this.Load += new System.EventHandler(this.FrmRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlSection1.ResumeLayout(false);
            this.PnlSection1.PerformLayout();
            this.PnlSection2.ResumeLayout(false);
            this.PnlSection2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).EndInit();
            this.PnlSection3.ResumeLayout(false);
            this.PnlSection3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblNameLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblScreenTitle;
        private System.Windows.Forms.Panel PnlSection1;
        private System.Windows.Forms.Label LblSection1;
        private System.Windows.Forms.Panel PnlSection2;
        private System.Windows.Forms.Label LblSection2;
        private System.Windows.Forms.TextBox txtRqstDescription;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.ComboBox cboFinancing;
        private System.Windows.Forms.Label LblFinancing;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblOffers;
        private System.Windows.Forms.Button BtnDeleteOffer;
        private System.Windows.Forms.Button BtnOpenOffer;
        private System.Windows.Forms.DataGridView dgvOffers;
        private System.Windows.Forms.Button BtnNewOffer;
        private System.Windows.Forms.Panel PnlSection3;
        private System.Windows.Forms.Label LblSection3;
    }
}