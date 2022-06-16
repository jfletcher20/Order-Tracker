
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
            this.LblNameLastName = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblScreenTitle = new System.Windows.Forms.Label();
            this.PnlSection2 = new System.Windows.Forms.Panel();
            this.LblSection2 = new System.Windows.Forms.Label();
            this.txtRqstDescription = new System.Windows.Forms.TextBox();
            this.LblDesc = new System.Windows.Forms.Label();
            this.cboFinancing = new System.Windows.Forms.ComboBox();
            this.LblFinancing = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtP2odabrana = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtP2sPDV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtP2bezPDV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtP1odabrana = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtP1sPDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtP1bezPDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblOffer1 = new System.Windows.Forms.Label();
            this.PnlSection3 = new System.Windows.Forms.Panel();
            this.LblSection3 = new System.Windows.Forms.Label();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProjectLeader = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProjectLeaderSigned = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBookkeepingSigned = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVicedeanSigned = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFinancingDescription = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlSection2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PnlSection3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNameLastName
            // 
            this.LblNameLastName.AutoSize = true;
            this.LblNameLastName.Location = new System.Drawing.Point(15, 105);
            this.LblNameLastName.Name = "LblNameLastName";
            this.LblNameLastName.Size = new System.Drawing.Size(149, 13);
            this.LblNameLastName.TabIndex = 3;
            this.LblNameLastName.Text = "Ime i prezime podnositelja/ice:";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(168, 101);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(338, 20);
            this.txtEmployee.TabIndex = 10;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(15, 744);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 67);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.LblScreenTitle);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(15, 16);
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
            // PnlSection2
            // 
            this.PnlSection2.BackColor = System.Drawing.Color.Red;
            this.PnlSection2.Controls.Add(this.LblSection2);
            this.PnlSection2.ForeColor = System.Drawing.Color.White;
            this.PnlSection2.Location = new System.Drawing.Point(14, 127);
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
            this.txtRqstDescription.Location = new System.Drawing.Point(168, 163);
            this.txtRqstDescription.Multiline = true;
            this.txtRqstDescription.Name = "txtRqstDescription";
            this.txtRqstDescription.Size = new System.Drawing.Size(338, 53);
            this.txtRqstDescription.TabIndex = 19;
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Location = new System.Drawing.Point(15, 168);
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
            this.cboFinancing.Location = new System.Drawing.Point(168, 222);
            this.cboFinancing.Name = "cboFinancing";
            this.cboFinancing.Size = new System.Drawing.Size(338, 21);
            this.cboFinancing.TabIndex = 22;
            this.cboFinancing.SelectedIndexChanged += new System.EventHandler(this.cboFinancing_SelectedIndexChanged);
            // 
            // LblFinancing
            // 
            this.LblFinancing.AutoSize = true;
            this.LblFinancing.Location = new System.Drawing.Point(15, 225);
            this.LblFinancing.Name = "LblFinancing";
            this.LblFinancing.Size = new System.Drawing.Size(90, 13);
            this.LblFinancing.TabIndex = 21;
            this.LblFinancing.Text = "Izvor financiranja:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.txtP2odabrana);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtP2sPDV);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtP2bezPDV);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtP1odabrana);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtP1sPDV);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtP1bezPDV);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.LblOffer1);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(14, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 222);
            this.panel3.TabIndex = 23;
            // 
            // txtP2odabrana
            // 
            this.txtP2odabrana.Location = new System.Drawing.Point(160, 189);
            this.txtP2odabrana.Name = "txtP2odabrana";
            this.txtP2odabrana.Size = new System.Drawing.Size(99, 20);
            this.txtP2odabrana.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Je li ponuda odabrana:";
            // 
            // txtP2sPDV
            // 
            this.txtP2sPDV.Location = new System.Drawing.Point(160, 162);
            this.txtP2sPDV.Name = "txtP2sPDV";
            this.txtP2sPDV.Size = new System.Drawing.Size(288, 20);
            this.txtP2sPDV.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cijena s PDV-om:";
            // 
            // txtP2bezPDV
            // 
            this.txtP2bezPDV.Location = new System.Drawing.Point(160, 136);
            this.txtP2bezPDV.Name = "txtP2bezPDV";
            this.txtP2bezPDV.Size = new System.Drawing.Size(288, 20);
            this.txtP2bezPDV.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cijena bez PDV-a:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ponuda 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtP1odabrana
            // 
            this.txtP1odabrana.Location = new System.Drawing.Point(160, 84);
            this.txtP1odabrana.Name = "txtP1odabrana";
            this.txtP1odabrana.Size = new System.Drawing.Size(99, 20);
            this.txtP1odabrana.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Je li ponuda odabrana:";
            // 
            // txtP1sPDV
            // 
            this.txtP1sPDV.Location = new System.Drawing.Point(160, 57);
            this.txtP1sPDV.Name = "txtP1sPDV";
            this.txtP1sPDV.Size = new System.Drawing.Size(288, 20);
            this.txtP1sPDV.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cijena s PDV-om:";
            // 
            // txtP1bezPDV
            // 
            this.txtP1bezPDV.Location = new System.Drawing.Point(160, 31);
            this.txtP1bezPDV.Name = "txtP1bezPDV";
            this.txtP1bezPDV.Size = new System.Drawing.Size(288, 20);
            this.txtP1bezPDV.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cijena bez PDV-a:";
            // 
            // LblOffer1
            // 
            this.LblOffer1.AutoSize = true;
            this.LblOffer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblOffer1.ForeColor = System.Drawing.Color.White;
            this.LblOffer1.Location = new System.Drawing.Point(10, 10);
            this.LblOffer1.Margin = new System.Windows.Forms.Padding(3);
            this.LblOffer1.Name = "LblOffer1";
            this.LblOffer1.Size = new System.Drawing.Size(69, 17);
            this.LblOffer1.TabIndex = 15;
            this.LblOffer1.Text = "Ponuda 1";
            this.LblOffer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlSection3
            // 
            this.PnlSection3.BackColor = System.Drawing.Color.Red;
            this.PnlSection3.Controls.Add(this.LblSection3);
            this.PnlSection3.ForeColor = System.Drawing.Color.White;
            this.PnlSection3.Location = new System.Drawing.Point(14, 541);
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
            this.LblSection3.Size = new System.Drawing.Size(49, 17);
            this.LblSection3.TabIndex = 7;
            this.LblSection3.Text = "Ostalo";
            this.LblSection3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Location = new System.Drawing.Point(99, 577);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(65, 20);
            this.txtProjectID.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 581);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Broj projekta:";
            // 
            // txtProjectLeader
            // 
            this.txtProjectLeader.Location = new System.Drawing.Point(239, 577);
            this.txtProjectLeader.Name = "txtProjectLeader";
            this.txtProjectLeader.ReadOnly = true;
            this.txtProjectLeader.Size = new System.Drawing.Size(267, 20);
            this.txtProjectLeader.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 581);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Voditelj/ica:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(99, 603);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.ReadOnly = true;
            this.txtProjectName.Size = new System.Drawing.Size(407, 20);
            this.txtProjectName.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 606);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Naziv projekta:";
            // 
            // txtProjectLeaderSigned
            // 
            this.txtProjectLeaderSigned.Location = new System.Drawing.Point(222, 629);
            this.txtProjectLeaderSigned.Name = "txtProjectLeaderSigned";
            this.txtProjectLeaderSigned.ReadOnly = true;
            this.txtProjectLeaderSigned.Size = new System.Drawing.Size(223, 20);
            this.txtProjectLeaderSigned.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 632);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Odobrenje voditelja/ice projekta:";
            // 
            // txtBookkeepingSigned
            // 
            this.txtBookkeepingSigned.Location = new System.Drawing.Point(222, 655);
            this.txtBookkeepingSigned.Name = "txtBookkeepingSigned";
            this.txtBookkeepingSigned.ReadOnly = true;
            this.txtBookkeepingSigned.Size = new System.Drawing.Size(223, 20);
            this.txtBookkeepingSigned.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 658);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Odobrenje voditelja/ice računovodstva:";
            // 
            // txtVicedeanSigned
            // 
            this.txtVicedeanSigned.Location = new System.Drawing.Point(222, 681);
            this.txtVicedeanSigned.Name = "txtVicedeanSigned";
            this.txtVicedeanSigned.ReadOnly = true;
            this.txtVicedeanSigned.Size = new System.Drawing.Size(223, 20);
            this.txtVicedeanSigned.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 684);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Odobrenje prodekan/ice za poslovanje:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(101, 711);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(405, 20);
            this.txtStatus.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 714);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Status zahtjeva";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Opis financiranja:";
            // 
            // txtFinancingDescription
            // 
            this.txtFinancingDescription.Location = new System.Drawing.Point(168, 253);
            this.txtFinancingDescription.Multiline = true;
            this.txtFinancingDescription.Name = "txtFinancingDescription";
            this.txtFinancingDescription.Size = new System.Drawing.Size(338, 53);
            this.txtFinancingDescription.TabIndex = 36;
            // 
            // FrmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 820);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtFinancingDescription);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtVicedeanSigned);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBookkeepingSigned);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtProjectLeaderSigned);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProjectLeader);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.PnlSection3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cboFinancing);
            this.Controls.Add(this.LblFinancing);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.txtRqstDescription);
            this.Controls.Add(this.PnlSection2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.LblNameLastName);
            this.Name = "FrmRequest";
            this.Text = "FrmRequest";
            this.Load += new System.EventHandler(this.FrmRequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlSection2.ResumeLayout(false);
            this.PnlSection2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PnlSection3.ResumeLayout(false);
            this.PnlSection3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblNameLastName;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblScreenTitle;
        private System.Windows.Forms.Panel PnlSection2;
        private System.Windows.Forms.Label LblSection2;
        private System.Windows.Forms.TextBox txtRqstDescription;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.ComboBox cboFinancing;
        private System.Windows.Forms.Label LblFinancing;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblOffer1;
        private System.Windows.Forms.Panel PnlSection3;
        private System.Windows.Forms.Label LblSection3;
        private System.Windows.Forms.TextBox txtP1bezPDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP2odabrana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtP2sPDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtP2bezPDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtP1odabrana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtP1sPDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProjectLeader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProjectLeaderSigned;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBookkeepingSigned;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVicedeanSigned;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFinancingDescription;
    }
}