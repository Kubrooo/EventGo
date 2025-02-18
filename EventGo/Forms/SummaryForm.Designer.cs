namespace EventGo.Forms
{
    partial class SummaryForm
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
            gbDetailEvent = new GroupBox();
            txtEventStatus = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dtEndDate = new DateTimePicker();
            label3 = new Label();
            dtStartDate = new DateTimePicker();
            label2 = new Label();
            rtbDesctiption = new RichTextBox();
            txtEventName = new TextBox();
            lblEventName = new Label();
            gbKeuangan = new GroupBox();
            txtTotalRevenue = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtTotalSponsorship = new TextBox();
            label6 = new Label();
            txtTotalTicketRevenue = new TextBox();
            groupBox1 = new GroupBox();
            label10 = new Label();
            txtSponsorshipPercentage = new TextBox();
            label9 = new Label();
            txtSalesPercentage = new TextBox();
            btnRefresh = new Button();
            btnClose = new Button();
            cbEventList = new ComboBox();
            label11 = new Label();
            gbDetailEvent.SuspendLayout();
            gbKeuangan.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 22);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Summary Form";
            // 
            // gbDetailEvent
            // 
            gbDetailEvent.Controls.Add(txtEventStatus);
            gbDetailEvent.Controls.Add(label5);
            gbDetailEvent.Controls.Add(label4);
            gbDetailEvent.Controls.Add(dtEndDate);
            gbDetailEvent.Controls.Add(label3);
            gbDetailEvent.Controls.Add(dtStartDate);
            gbDetailEvent.Controls.Add(label2);
            gbDetailEvent.Controls.Add(rtbDesctiption);
            gbDetailEvent.Controls.Add(txtEventName);
            gbDetailEvent.Controls.Add(lblEventName);
            gbDetailEvent.Location = new Point(27, 105);
            gbDetailEvent.Name = "gbDetailEvent";
            gbDetailEvent.Size = new Size(254, 397);
            gbDetailEvent.TabIndex = 1;
            gbDetailEvent.TabStop = false;
            gbDetailEvent.Text = "Detail Event";
            // 
            // txtEventStatus
            // 
            txtEventStatus.Location = new Point(16, 325);
            txtEventStatus.Name = "txtEventStatus";
            txtEventStatus.Size = new Size(216, 27);
            txtEventStatus.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 302);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 8;
            label5.Text = "Event Status :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 249);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 7;
            label4.Text = "End Date :";
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(16, 272);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(216, 27);
            dtEndDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 190);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Start Date :";
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(16, 213);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(216, 27);
            dtStartDate.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 92);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 3;
            label2.Text = "Description Event :";
            // 
            // rtbDesctiption
            // 
            rtbDesctiption.Location = new Point(16, 115);
            rtbDesctiption.Name = "rtbDesctiption";
            rtbDesctiption.Size = new Size(216, 69);
            rtbDesctiption.TabIndex = 2;
            rtbDesctiption.Text = "";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(16, 56);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(216, 27);
            txtEventName.TabIndex = 1;
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.Location = new Point(16, 33);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(96, 20);
            lblEventName.TabIndex = 0;
            lblEventName.Text = "Event Name :";
            // 
            // gbKeuangan
            // 
            gbKeuangan.Controls.Add(txtTotalRevenue);
            gbKeuangan.Controls.Add(label8);
            gbKeuangan.Controls.Add(label7);
            gbKeuangan.Controls.Add(txtTotalSponsorship);
            gbKeuangan.Controls.Add(label6);
            gbKeuangan.Controls.Add(txtTotalTicketRevenue);
            gbKeuangan.Location = new Point(297, 105);
            gbKeuangan.Name = "gbKeuangan";
            gbKeuangan.Size = new Size(222, 226);
            gbKeuangan.TabIndex = 3;
            gbKeuangan.TabStop = false;
            gbKeuangan.Text = "Finance";
            // 
            // txtTotalRevenue
            // 
            txtTotalRevenue.Location = new Point(15, 177);
            txtTotalRevenue.Name = "txtTotalRevenue";
            txtTotalRevenue.Size = new Size(190, 27);
            txtTotalRevenue.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 154);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 7;
            label8.Text = "Total Revenue :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 92);
            label7.Name = "label7";
            label7.Size = new Size(194, 20);
            label7.TabIndex = 6;
            label7.Text = "Total Sponsorship Revenue :";
            // 
            // txtTotalSponsorship
            // 
            txtTotalSponsorship.Location = new Point(15, 115);
            txtTotalSponsorship.Name = "txtTotalSponsorship";
            txtTotalSponsorship.Size = new Size(190, 27);
            txtTotalSponsorship.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 33);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 4;
            label6.Text = "Total Ticket Revenue :";
            // 
            // txtTotalTicketRevenue
            // 
            txtTotalTicketRevenue.Location = new Point(15, 56);
            txtTotalTicketRevenue.Name = "txtTotalTicketRevenue";
            txtTotalTicketRevenue.Size = new Size(190, 27);
            txtTotalTicketRevenue.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtSponsorshipPercentage);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtSalesPercentage);
            groupBox1.Location = new Point(297, 337);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 165);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statistic";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 92);
            label10.Name = "label10";
            label10.Size = new Size(174, 20);
            label10.TabIndex = 3;
            label10.Text = "Sponsorship Percentage :";
            // 
            // txtSponsorshipPercentage
            // 
            txtSponsorshipPercentage.Location = new Point(15, 115);
            txtSponsorshipPercentage.Name = "txtSponsorshipPercentage";
            txtSponsorshipPercentage.Size = new Size(194, 27);
            txtSponsorshipPercentage.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 31);
            label9.Name = "label9";
            label9.Size = new Size(170, 20);
            label9.TabIndex = 1;
            label9.Text = "Ticket Sales Percentage :";
            // 
            // txtSalesPercentage
            // 
            txtSalesPercentage.Location = new Point(15, 54);
            txtSalesPercentage.Name = "txtSalesPercentage";
            txtSalesPercentage.Size = new Size(194, 27);
            txtSalesPercentage.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(641, 172);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(541, 172);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbEventList
            // 
            cbEventList.FormattingEnabled = true;
            cbEventList.Location = new Point(539, 128);
            cbEventList.Name = "cbEventList";
            cbEventList.Size = new Size(151, 28);
            cbEventList.TabIndex = 7;
            cbEventList.SelectedIndexChanged += cbEventList_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(539, 105);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 8;
            label11.Text = "Event List :";
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 733);
            Controls.Add(label11);
            Controls.Add(cbEventList);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(groupBox1);
            Controls.Add(gbKeuangan);
            Controls.Add(gbDetailEvent);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SummaryForm";
            Text = "SummaryForm";
            Load += SummaryForm_Load;
            gbDetailEvent.ResumeLayout(false);
            gbDetailEvent.PerformLayout();
            gbKeuangan.ResumeLayout(false);
            gbKeuangan.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbDetailEvent;
        private Label lblEventName;
        private TextBox txtEventName;
        private Label label2;
        private RichTextBox rtbDesctiption;
        private DateTimePicker dtStartDate;
        private Label label5;
        private Label label4;
        private DateTimePicker dtEndDate;
        private Label label3;
        private TextBox txtEventStatus;
        private GroupBox gbKeuangan;
        private Label label6;
        private TextBox txtTotalTicketRevenue;
        private TextBox txtTotalSponsorship;
        private TextBox txtTotalRevenue;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox txtSponsorshipPercentage;
        private Label label9;
        private TextBox txtSalesPercentage;
        private Label label10;
        private Button btnRefresh;
        private Button btnClose;
        private ComboBox cbEventList;
        private Label label11;
    }
}