namespace EventGo.Forms
{
    partial class ManagementForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tbSearch = new TextBox();
            cbFilter = new ComboBox();
            btnFilter = new Button();
            btnCreate = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label2 = new Label();
            tbTicketId = new TextBox();
            label3 = new Label();
            numStock = new NumericUpDown();
            cbCategory = new ComboBox();
            label4 = new Label();
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
            managementFormBindingSource = new BindingSource(components);
            dgManagement = new DataGridView();
            tbNewCategory = new TextBox();
            lblNewCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)managementFormBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgManagement).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(400, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 28);
            label1.TabIndex = 1;
            label1.Text = "Management Event And Tiket";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(84, 98);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(219, 27);
            tbSearch.TabIndex = 2;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(842, 97);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(151, 28);
            cbFilter.TabIndex = 3;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(742, 96);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(899, 388);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(899, 433);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(899, 478);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(899, 528);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 365);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 9;
            label2.Text = "Id Ticket :";
            // 
            // tbTicketId
            // 
            tbTicketId.Location = new Point(84, 388);
            tbTicketId.Name = "tbTicketId";
            tbTicketId.Size = new Size(150, 27);
            tbTicketId.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 433);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 11;
            label3.Text = "Total Stock :";
            // 
            // numStock
            // 
            numStock.Location = new Point(84, 456);
            numStock.Name = "numStock";
            numStock.Size = new Size(150, 27);
            numStock.TabIndex = 12;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(84, 529);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 13;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 506);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 14;
            label4.Text = "Category :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 365);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 15;
            label5.Text = "Id Event :";
            // 
            // tbEventId
            // 
            tbEventId.Location = new Point(370, 388);
            tbEventId.Name = "tbEventId";
            tbEventId.Size = new Size(157, 27);
            tbEventId.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(370, 433);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 17;
            label6.Text = "Event Title :";
            // 
            // tbEventTitle
            // 
            tbEventTitle.Location = new Point(370, 456);
            tbEventTitle.Name = "tbEventTitle";
            tbEventTitle.Size = new Size(157, 27);
            tbEventTitle.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 506);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 19;
            label7.Text = "Event Status :";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Coming Soon", "Ended" });
            cbStatus.Location = new Point(370, 529);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(157, 28);
            cbStatus.TabIndex = 20;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(605, 388);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(231, 81);
            rtbDescription.TabIndex = 21;
            rtbDescription.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(605, 365);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 22;
            label8.Text = "Description :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(605, 482);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 23;
            label9.Text = "Open Date :";
            // 
            // dtOpen
            // 
            dtOpen.Location = new Point(605, 506);
            dtOpen.Name = "dtOpen";
            dtOpen.Size = new Size(159, 27);
            dtOpen.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(605, 548);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 25;
            label10.Text = "Closed Date :";
            // 
            // dtClosed
            // 
            dtClosed.Location = new Point(605, 571);
            dtClosed.Name = "dtClosed";
            dtClosed.Size = new Size(159, 27);
            dtClosed.TabIndex = 26;
            // 
            // dgManagement
            // 
            dgManagement.AllowUserToAddRows = false;
            dgManagement.AllowUserToDeleteRows = false;
            dgManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgManagement.Location = new Point(84, 144);
            dgManagement.Name = "dgManagement";
            dgManagement.ReadOnly = true;
            dgManagement.RowHeadersVisible = false;
            dgManagement.RowHeadersWidth = 51;
            dgManagement.Size = new Size(909, 204);
            dgManagement.TabIndex = 27;
            // 
            // tbNewCategory
            // 
            tbNewCategory.Location = new Point(84, 598);
            tbNewCategory.Name = "tbNewCategory";
            tbNewCategory.Size = new Size(151, 27);
            tbNewCategory.TabIndex = 28;
            // 
            // lblNewCategory
            // 
            lblNewCategory.AutoSize = true;
            lblNewCategory.Location = new Point(84, 575);
            lblNewCategory.Name = "lblNewCategory";
            lblNewCategory.Size = new Size(110, 20);
            lblNewCategory.TabIndex = 29;
            lblNewCategory.Text = "New Category :";
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 699);
            Controls.Add(lblNewCategory);
            Controls.Add(tbNewCategory);
            Controls.Add(dgManagement);
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
            Controls.Add(label4);
            Controls.Add(cbCategory);
            Controls.Add(numStock);
            Controls.Add(label3);
            Controls.Add(tbTicketId);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCreate);
            Controls.Add(btnFilter);
            Controls.Add(cbFilter);
            Controls.Add(tbSearch);
            Controls.Add(label1);
            Name = "ManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagementForm";
            Load += ManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)managementFormBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgManagement).EndInit();
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
        private Label label2;
        private TextBox tbTicketId;
        private Label label3;
        private NumericUpDown numStock;
        private ComboBox cbCategory;
        private Label label4;
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
        private BindingSource managementFormBindingSource;
        private DataGridView dgManagement;
        private TextBox tbNewCategory;
        private Label lblNewCategory;
    }
}