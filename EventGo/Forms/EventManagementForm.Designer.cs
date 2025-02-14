namespace EventGo.Forms
{
    partial class EventManagementForm
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
            tbSearch = new TextBox();
            cbFilter = new ComboBox();
            btnFilter = new Button();
            btnCreate = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tbEventId = new TextBox();
            label6 = new Label();
            tbEventTitle = new TextBox();
            label7 = new Label();
            cbStatus = new ComboBox();
            rtbDescription = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            dtOpen = new DateTimePicker();
            label10 = new Label();
            dtClosed = new DateTimePicker();
            dgvEvent = new DataGridView();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEvent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(369, 40);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 1;
            label1.Text = "Event Management";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(84, 98);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(219, 27);
            tbSearch.TabIndex = 2;
            tbSearch.Leave += tbSearch_Leave;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Coming Soon", "Ended" });
            cbFilter.Location = new Point(685, 98);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(151, 28);
            cbFilter.TabIndex = 3;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(585, 97);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(565, 383);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(565, 428);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(565, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(565, 523);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 365);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 15;
            label5.Text = "Id Event :";
            // 
            // tbEventId
            // 
            tbEventId.Location = new Point(84, 390);
            tbEventId.Name = "tbEventId";
            tbEventId.Size = new Size(157, 27);
            tbEventId.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 432);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 17;
            label6.Text = "Event Title :";
            // 
            // tbEventTitle
            // 
            tbEventTitle.Location = new Point(84, 455);
            tbEventTitle.Name = "tbEventTitle";
            tbEventTitle.Size = new Size(157, 27);
            tbEventTitle.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 505);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 19;
            label7.Text = "Event Status :";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Coming Soon", "Ended" });
            cbStatus.Location = new Point(84, 528);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(157, 28);
            cbStatus.TabIndex = 20;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(301, 388);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(231, 81);
            rtbDescription.TabIndex = 21;
            rtbDescription.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(301, 365);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 22;
            label8.Text = "Description :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(301, 482);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 23;
            label9.Text = "Open Date :";
            // 
            // dtOpen
            // 
            dtOpen.Location = new Point(301, 506);
            dtOpen.Name = "dtOpen";
            dtOpen.Size = new Size(159, 27);
            dtOpen.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(301, 548);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 25;
            label10.Text = "Closed Date :";
            // 
            // dtClosed
            // 
            dtClosed.Location = new Point(301, 571);
            dtClosed.Name = "dtClosed";
            dtClosed.Size = new Size(159, 27);
            dtClosed.TabIndex = 26;
            // 
            // dgvEvent
            // 
            dgvEvent.AllowUserToAddRows = false;
            dgvEvent.AllowUserToDeleteRows = false;
            dgvEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvent.Location = new Point(84, 144);
            dgvEvent.Name = "dgvEvent";
            dgvEvent.ReadOnly = true;
            dgvEvent.RowHeadersVisible = false;
            dgvEvent.RowHeadersWidth = 51;
            dgvEvent.Size = new Size(752, 204);
            dgvEvent.TabIndex = 27;
            dgvEvent.CellClick += dgvEvent_CellClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(565, 572);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EventManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 699);
            Controls.Add(btnCancel);
            Controls.Add(dgvEvent);
            Controls.Add(dtClosed);
            Controls.Add(label10);
            Controls.Add(dtOpen);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(rtbDescription);
            Controls.Add(cbStatus);
            Controls.Add(label7);
            Controls.Add(tbEventTitle);
            Controls.Add(label6);
            Controls.Add(tbEventId);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCreate);
            Controls.Add(btnFilter);
            Controls.Add(cbFilter);
            Controls.Add(tbSearch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EventManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagementForm";
            Load += ManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEvent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox tbSearch;
        private ComboBox cbFilter;
        private Button btnFilter;
        private Button btnCreate;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox tbEventId;
        private Label label6;
        private TextBox tbEventTitle;
        private Label label7;
        private ComboBox cbStatus;
        private RichTextBox rtbDescription;
        private Label label8;
        private Label label9;
        private DateTimePicker dtOpen;
        private Label label10;
        private DateTimePicker dtClosed;
        private DataGridView dgvEvent;
        private Button btnCancel;
    }
}