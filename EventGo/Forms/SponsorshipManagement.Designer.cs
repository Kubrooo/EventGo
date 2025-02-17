namespace EventGo.Forms
{
    partial class SponsorshipManagement
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
            label1 = new Label();
            dgvSponsors = new DataGridView();
            cbEventList = new ComboBox();
            label2 = new Label();
            tbSponsorName = new TextBox();
            label3 = new Label();
            numAmount = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            tbPicName = new TextBox();
            tbPicNumber = new TextBox();
            label6 = new Label();
            btnAddSponsor = new Button();
            btnEditSponsor = new Button();
            btnDeleteSponsor = new Button();
            btnRestoreSponsor = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            label7 = new Label();
            lblTotalAmount = new Label();
            btnShowDeleted = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSponsors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 33);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 0;
            label1.Text = "Sponsorship Management";
            // 
            // dgvSponsors
            // 
            dgvSponsors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSponsors.Location = new Point(64, 72);
            dgvSponsors.Name = "dgvSponsors";
            dgvSponsors.RowHeadersVisible = false;
            dgvSponsors.RowHeadersWidth = 51;
            dgvSponsors.Size = new Size(751, 188);
            dgvSponsors.TabIndex = 1;
            dgvSponsors.CellClick += dgvSponsors_CellClick;
            // 
            // cbEventList
            // 
            cbEventList.FormattingEnabled = true;
            cbEventList.Location = new Point(64, 296);
            cbEventList.Name = "cbEventList";
            cbEventList.Size = new Size(189, 28);
            cbEventList.TabIndex = 2;
            cbEventList.SelectedIndexChanged += cbEventList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 274);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Event :";
            // 
            // tbSponsorName
            // 
            tbSponsorName.Location = new Point(64, 354);
            tbSponsorName.Name = "tbSponsorName";
            tbSponsorName.Size = new Size(189, 27);
            tbSponsorName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 331);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 5;
            label3.Text = "Sponsor name :";
            // 
            // numAmount
            // 
            numAmount.Location = new Point(64, 414);
            numAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(189, 27);
            numAmount.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 391);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 7;
            label4.Text = "Nominal sponsor :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 274);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 8;
            label5.Text = "Pic Name :";
            // 
            // tbPicName
            // 
            tbPicName.Location = new Point(276, 296);
            tbPicName.Name = "tbPicName";
            tbPicName.Size = new Size(194, 27);
            tbPicName.TabIndex = 9;
            // 
            // tbPicNumber
            // 
            tbPicNumber.Location = new Point(276, 354);
            tbPicNumber.Name = "tbPicNumber";
            tbPicNumber.Size = new Size(193, 27);
            tbPicNumber.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 331);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 11;
            label6.Text = "Pic Number :";
            // 
            // btnAddSponsor
            // 
            btnAddSponsor.Location = new Point(275, 391);
            btnAddSponsor.Name = "btnAddSponsor";
            btnAddSponsor.Size = new Size(94, 29);
            btnAddSponsor.TabIndex = 12;
            btnAddSponsor.Text = "Create ";
            btnAddSponsor.UseVisualStyleBackColor = true;
            btnAddSponsor.Click += btnAddSponsor_Click;
            // 
            // btnEditSponsor
            // 
            btnEditSponsor.Location = new Point(276, 426);
            btnEditSponsor.Name = "btnEditSponsor";
            btnEditSponsor.Size = new Size(94, 29);
            btnEditSponsor.TabIndex = 13;
            btnEditSponsor.Text = "Edit";
            btnEditSponsor.UseVisualStyleBackColor = true;
            btnEditSponsor.Click += btnEditSponsor_Click;
            // 
            // btnDeleteSponsor
            // 
            btnDeleteSponsor.Location = new Point(276, 461);
            btnDeleteSponsor.Name = "btnDeleteSponsor";
            btnDeleteSponsor.Size = new Size(94, 29);
            btnDeleteSponsor.TabIndex = 14;
            btnDeleteSponsor.Text = "Delete";
            btnDeleteSponsor.UseVisualStyleBackColor = true;
            btnDeleteSponsor.Click += btnDeleteSponsor_Click;
            // 
            // btnRestoreSponsor
            // 
            btnRestoreSponsor.Location = new Point(375, 391);
            btnRestoreSponsor.Name = "btnRestoreSponsor";
            btnRestoreSponsor.Size = new Size(94, 29);
            btnRestoreSponsor.TabIndex = 15;
            btnRestoreSponsor.Text = "Restore";
            btnRestoreSponsor.UseVisualStyleBackColor = true;
            btnRestoreSponsor.Click += btnRestoreSponsor_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(376, 426);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(376, 461);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(533, 274);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 18;
            label7.Text = "Total Dana :";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 14F);
            lblTotalAmount.Location = new Point(533, 296);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(78, 32);
            lblTotalAmount.TabIndex = 19;
            lblTotalAmount.Text = "label8";
            // 
            // btnShowDeleted
            // 
            btnShowDeleted.Location = new Point(672, 461);
            btnShowDeleted.Name = "btnShowDeleted";
            btnShowDeleted.Size = new Size(143, 29);
            btnShowDeleted.TabIndex = 20;
            btnShowDeleted.Text = "Show Deleted";
            btnShowDeleted.UseVisualStyleBackColor = true;
            // 
            // SponsorshipManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 523);
            Controls.Add(btnShowDeleted);
            Controls.Add(lblTotalAmount);
            Controls.Add(label7);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnRestoreSponsor);
            Controls.Add(btnDeleteSponsor);
            Controls.Add(btnEditSponsor);
            Controls.Add(btnAddSponsor);
            Controls.Add(label6);
            Controls.Add(tbPicNumber);
            Controls.Add(tbPicName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numAmount);
            Controls.Add(label3);
            Controls.Add(tbSponsorName);
            Controls.Add(label2);
            Controls.Add(cbEventList);
            Controls.Add(dgvSponsors);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SponsorshipManagement";
            Text = "SponsorshipManagement";
            Load += SponsorshipManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSponsors).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvSponsors;
        private ComboBox cbEventList;
        private Label label2;
        private TextBox tbSponsorName;
        private Label label3;
        private NumericUpDown numAmount;
        private Label label4;
        private Label label5;
        private TextBox tbPicName;
        private TextBox tbPicNumber;
        private Label label6;
        private Button btnAddSponsor;
        private Button btnEditSponsor;
        private Button btnDeleteSponsor;
        private Button btnRestoreSponsor;
        private Button btnCancel;
        private Button btnSave;
        private Label label7;
        private Label lblTotalAmount;
        private Button btnShowDeleted;
    }
}