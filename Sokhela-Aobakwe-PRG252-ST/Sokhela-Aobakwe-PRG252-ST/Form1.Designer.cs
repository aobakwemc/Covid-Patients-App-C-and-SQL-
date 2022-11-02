namespace Sokhela_Aobakwe_PRG252_ST
{
    partial class Form1
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.gpxPatientReg = new System.Windows.Forms.GroupBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPatientIDReg = new System.Windows.Forms.TextBox();
            this.txtNameReg = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSurnameReg = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtGenderReg = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDateAdmitted = new System.Windows.Forms.Label();
            this.dtpDtAdmitReg = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gbxDisplay = new System.Windows.Forms.GroupBox();
            this.txtIDDisplay = new System.Windows.Forms.TextBox();
            this.lblIDDisplay = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.gbxAppend = new System.Windows.Forms.GroupBox();
            this.txtIDAppend = new System.Windows.Forms.TextBox();
            this.lblIDAppend = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.dtpDtAdmitAppend = new System.Windows.Forms.DateTimePicker();
            this.lblDtAdmitAppend = new System.Windows.Forms.Label();
            this.txtGenderAppend = new System.Windows.Forms.TextBox();
            this.lblGenderAppend = new System.Windows.Forms.Label();
            this.txtSurnameAppend = new System.Windows.Forms.TextBox();
            this.lblSurnameAppend = new System.Windows.Forms.Label();
            this.txtNameAppend = new System.Windows.Forms.TextBox();
            this.lblNameAppend = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gpxPatientReg.SuspendLayout();
            this.gbxDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.gbxAppend.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(306, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(165, 18);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Zone 15 Registration";
            // 
            // gpxPatientReg
            // 
            this.gpxPatientReg.Controls.Add(this.btnRegister);
            this.gpxPatientReg.Controls.Add(this.dtpDtAdmitReg);
            this.gpxPatientReg.Controls.Add(this.lblDateAdmitted);
            this.gpxPatientReg.Controls.Add(this.txtGenderReg);
            this.gpxPatientReg.Controls.Add(this.lblGender);
            this.gpxPatientReg.Controls.Add(this.txtSurnameReg);
            this.gpxPatientReg.Controls.Add(this.lblSurname);
            this.gpxPatientReg.Controls.Add(this.txtNameReg);
            this.gpxPatientReg.Controls.Add(this.lblName);
            this.gpxPatientReg.Controls.Add(this.txtPatientIDReg);
            this.gpxPatientReg.Controls.Add(this.lblPatientID);
            this.gpxPatientReg.Location = new System.Drawing.Point(8, 47);
            this.gpxPatientReg.Name = "gpxPatientReg";
            this.gpxPatientReg.Size = new System.Drawing.Size(223, 260);
            this.gpxPatientReg.TabIndex = 1;
            this.gpxPatientReg.TabStop = false;
            this.gpxPatientReg.Text = "Patient Registration";
            this.gpxPatientReg.Enter += new System.EventHandler(this.gpxPatientReg_Enter);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(6, 22);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(54, 13);
            this.lblPatientID.TabIndex = 0;
            this.lblPatientID.Text = "Patient ID";
            this.lblPatientID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPatientIDReg
            // 
            this.txtPatientIDReg.Location = new System.Drawing.Point(80, 19);
            this.txtPatientIDReg.Name = "txtPatientIDReg";
            this.txtPatientIDReg.Size = new System.Drawing.Size(137, 20);
            this.txtPatientIDReg.TabIndex = 1;
            // 
            // txtNameReg
            // 
            this.txtNameReg.Location = new System.Drawing.Point(80, 54);
            this.txtNameReg.Name = "txtNameReg";
            this.txtNameReg.Size = new System.Drawing.Size(137, 20);
            this.txtNameReg.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtSurnameReg
            // 
            this.txtSurnameReg.Location = new System.Drawing.Point(80, 90);
            this.txtSurnameReg.Name = "txtSurnameReg";
            this.txtSurnameReg.Size = new System.Drawing.Size(137, 20);
            this.txtSurnameReg.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 93);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname";
            // 
            // txtGenderReg
            // 
            this.txtGenderReg.Location = new System.Drawing.Point(80, 127);
            this.txtGenderReg.Name = "txtGenderReg";
            this.txtGenderReg.Size = new System.Drawing.Size(137, 20);
            this.txtGenderReg.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 130);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblDateAdmitted
            // 
            this.lblDateAdmitted.AutoSize = true;
            this.lblDateAdmitted.Location = new System.Drawing.Point(0, 168);
            this.lblDateAdmitted.Name = "lblDateAdmitted";
            this.lblDateAdmitted.Size = new System.Drawing.Size(74, 13);
            this.lblDateAdmitted.TabIndex = 8;
            this.lblDateAdmitted.Text = "Date Admitted";
            // 
            // dtpDtAdmitReg
            // 
            this.dtpDtAdmitReg.Location = new System.Drawing.Point(80, 164);
            this.dtpDtAdmitReg.Name = "dtpDtAdmitReg";
            this.dtpDtAdmitReg.Size = new System.Drawing.Size(137, 20);
            this.dtpDtAdmitReg.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(60, 231);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // gbxDisplay
            // 
            this.gbxDisplay.Controls.Add(this.btnViewAll);
            this.gbxDisplay.Controls.Add(this.dgvDisplay);
            this.gbxDisplay.Controls.Add(this.btnSearch);
            this.gbxDisplay.Controls.Add(this.txtIDDisplay);
            this.gbxDisplay.Controls.Add(this.lblIDDisplay);
            this.gbxDisplay.Location = new System.Drawing.Point(239, 47);
            this.gbxDisplay.Name = "gbxDisplay";
            this.gbxDisplay.Size = new System.Drawing.Size(455, 260);
            this.gbxDisplay.TabIndex = 11;
            this.gbxDisplay.TabStop = false;
            this.gbxDisplay.Text = "Display";
            // 
            // txtIDDisplay
            // 
            this.txtIDDisplay.Location = new System.Drawing.Point(81, 23);
            this.txtIDDisplay.Name = "txtIDDisplay";
            this.txtIDDisplay.Size = new System.Drawing.Size(146, 20);
            this.txtIDDisplay.TabIndex = 3;
            this.txtIDDisplay.TextChanged += new System.EventHandler(this.txtIDDisplay_TextChanged);
            // 
            // lblIDDisplay
            // 
            this.lblIDDisplay.AutoSize = true;
            this.lblIDDisplay.Location = new System.Drawing.Point(16, 26);
            this.lblIDDisplay.Name = "lblIDDisplay";
            this.lblIDDisplay.Size = new System.Drawing.Size(54, 13);
            this.lblIDDisplay.TabIndex = 2;
            this.lblIDDisplay.Text = "Patient ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(252, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(6, 54);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(443, 150);
            this.dgvDisplay.TabIndex = 5;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(192, 231);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 6;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // gbxAppend
            // 
            this.gbxAppend.Controls.Add(this.btnUpdate);
            this.gbxAppend.Controls.Add(this.btnDelete);
            this.gbxAppend.Controls.Add(this.dtpDtAdmitAppend);
            this.gbxAppend.Controls.Add(this.lblDtAdmitAppend);
            this.gbxAppend.Controls.Add(this.txtGenderAppend);
            this.gbxAppend.Controls.Add(this.lblGenderAppend);
            this.gbxAppend.Controls.Add(this.txtSurnameAppend);
            this.gbxAppend.Controls.Add(this.lblSurnameAppend);
            this.gbxAppend.Controls.Add(this.txtNameAppend);
            this.gbxAppend.Controls.Add(this.lblNameAppend);
            this.gbxAppend.Controls.Add(this.panel1);
            this.gbxAppend.Location = new System.Drawing.Point(702, 47);
            this.gbxAppend.Name = "gbxAppend";
            this.gbxAppend.Size = new System.Drawing.Size(210, 260);
            this.gbxAppend.TabIndex = 12;
            this.gbxAppend.TabStop = false;
            this.gbxAppend.Text = "Append";
            // 
            // txtIDAppend
            // 
            this.txtIDAppend.Location = new System.Drawing.Point(68, 13);
            this.txtIDAppend.Name = "txtIDAppend";
            this.txtIDAppend.Size = new System.Drawing.Size(64, 20);
            this.txtIDAppend.TabIndex = 5;
            // 
            // lblIDAppend
            // 
            this.lblIDAppend.AutoSize = true;
            this.lblIDAppend.Location = new System.Drawing.Point(3, 16);
            this.lblIDAppend.Name = "lblIDAppend";
            this.lblIDAppend.Size = new System.Drawing.Size(54, 13);
            this.lblIDAppend.TabIndex = 4;
            this.lblIDAppend.Text = "Patient ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.lblIDAppend);
            this.panel1.Controls.Add(this.txtIDAppend);
            this.panel1.Location = new System.Drawing.Point(3, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 43);
            this.panel1.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(139, 13);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(56, 20);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dtpDtAdmitAppend
            // 
            this.dtpDtAdmitAppend.Location = new System.Drawing.Point(80, 184);
            this.dtpDtAdmitAppend.Name = "dtpDtAdmitAppend";
            this.dtpDtAdmitAppend.Size = new System.Drawing.Size(125, 20);
            this.dtpDtAdmitAppend.TabIndex = 17;
            // 
            // lblDtAdmitAppend
            // 
            this.lblDtAdmitAppend.AutoSize = true;
            this.lblDtAdmitAppend.Location = new System.Drawing.Point(0, 188);
            this.lblDtAdmitAppend.Name = "lblDtAdmitAppend";
            this.lblDtAdmitAppend.Size = new System.Drawing.Size(74, 13);
            this.lblDtAdmitAppend.TabIndex = 16;
            this.lblDtAdmitAppend.Text = "Date Admitted";
            // 
            // txtGenderAppend
            // 
            this.txtGenderAppend.Location = new System.Drawing.Point(80, 147);
            this.txtGenderAppend.Name = "txtGenderAppend";
            this.txtGenderAppend.Size = new System.Drawing.Size(125, 20);
            this.txtGenderAppend.TabIndex = 15;
            // 
            // lblGenderAppend
            // 
            this.lblGenderAppend.AutoSize = true;
            this.lblGenderAppend.Location = new System.Drawing.Point(6, 150);
            this.lblGenderAppend.Name = "lblGenderAppend";
            this.lblGenderAppend.Size = new System.Drawing.Size(42, 13);
            this.lblGenderAppend.TabIndex = 14;
            this.lblGenderAppend.Text = "Gender";
            // 
            // txtSurnameAppend
            // 
            this.txtSurnameAppend.Location = new System.Drawing.Point(80, 110);
            this.txtSurnameAppend.Name = "txtSurnameAppend";
            this.txtSurnameAppend.Size = new System.Drawing.Size(125, 20);
            this.txtSurnameAppend.TabIndex = 13;
            // 
            // lblSurnameAppend
            // 
            this.lblSurnameAppend.AutoSize = true;
            this.lblSurnameAppend.Location = new System.Drawing.Point(6, 113);
            this.lblSurnameAppend.Name = "lblSurnameAppend";
            this.lblSurnameAppend.Size = new System.Drawing.Size(49, 13);
            this.lblSurnameAppend.TabIndex = 12;
            this.lblSurnameAppend.Text = "Surname";
            // 
            // txtNameAppend
            // 
            this.txtNameAppend.Location = new System.Drawing.Point(80, 74);
            this.txtNameAppend.Name = "txtNameAppend";
            this.txtNameAppend.Size = new System.Drawing.Size(125, 20);
            this.txtNameAppend.TabIndex = 11;
            // 
            // lblNameAppend
            // 
            this.lblNameAppend.AutoSize = true;
            this.lblNameAppend.Location = new System.Drawing.Point(6, 77);
            this.lblNameAppend.Name = "lblNameAppend";
            this.lblNameAppend.Size = new System.Drawing.Size(35, 13);
            this.lblNameAppend.TabIndex = 10;
            this.lblNameAppend.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(9, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(105, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 480);
            this.Controls.Add(this.gbxAppend);
            this.Controls.Add(this.gbxDisplay);
            this.Controls.Add(this.gpxPatientReg);
            this.Controls.Add(this.lblHeading);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpxPatientReg.ResumeLayout(false);
            this.gpxPatientReg.PerformLayout();
            this.gbxDisplay.ResumeLayout(false);
            this.gbxDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.gbxAppend.ResumeLayout(false);
            this.gbxAppend.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox gpxPatientReg;
        private System.Windows.Forms.TextBox txtPatientIDReg;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpDtAdmitReg;
        private System.Windows.Forms.Label lblDateAdmitted;
        private System.Windows.Forms.TextBox txtGenderReg;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtSurnameReg;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtNameReg;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxDisplay;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIDDisplay;
        private System.Windows.Forms.Label lblIDDisplay;
        private System.Windows.Forms.GroupBox gbxAppend;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpDtAdmitAppend;
        private System.Windows.Forms.Label lblDtAdmitAppend;
        private System.Windows.Forms.TextBox txtGenderAppend;
        private System.Windows.Forms.Label lblGenderAppend;
        private System.Windows.Forms.TextBox txtSurnameAppend;
        private System.Windows.Forms.Label lblSurnameAppend;
        private System.Windows.Forms.TextBox txtNameAppend;
        private System.Windows.Forms.Label lblNameAppend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblIDAppend;
        private System.Windows.Forms.TextBox txtIDAppend;
        private System.Windows.Forms.Button btnUpdate;
    }
}

