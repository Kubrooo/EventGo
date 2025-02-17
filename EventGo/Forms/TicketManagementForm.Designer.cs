namespace EventGo.Forms
{
    partial class TicketManagementForm
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
            dgvTicket = new DataGridView();
            idTicket = new Label();
            tbTicketId = new TextBox();
            numPrice = new NumericUpDown();
            label2 = new Label();
            cbEventName = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cbCategory = new ComboBox();
            btnCreate = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            numStock = new NumericUpDown();
            label5 = new Label();
            tbCategory = new TextBox();
            label6 = new Label();
            addCategory = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 29);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Ticket Management";
            // 
            // dgvTicket
            // 
            dgvTicket.AllowUserToAddRows = false;
            dgvTicket.AllowUserToDeleteRows = false;
            dgvTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicket.Location = new Point(58, 88);
            dgvTicket.Name = "dgvTicket";
            dgvTicket.ReadOnly = true;
            dgvTicket.RowHeadersVisible = false;
            dgvTicket.RowHeadersWidth = 51;
            dgvTicket.Size = new Size(637, 207);
            dgvTicket.TabIndex = 1;
            dgvTicket.CellClick += dgvTicket_CellClick;
            // 
            // idTicket
            // 
            idTicket.AutoSize = true;
            idTicket.Location = new Point(57, 314);
            idTicket.Name = "idTicket";
            idTicket.Size = new Size(68, 20);
            idTicket.TabIndex = 2;
            idTicket.Text = "idTicket :";
            // 
            // tbTicketId
            // 
            tbTicketId.Location = new Point(57, 337);
            tbTicketId.Name = "tbTicketId";
            tbTicketId.Size = new Size(150, 27);
            tbTicketId.TabIndex = 3;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(57, 403);
            numPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(150, 27);
            numPrice.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 380);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Ticket Price :";
            // 
            // cbEventName
            // 
            cbEventName.FormattingEnabled = true;
            cbEventName.Location = new Point(57, 535);
            cbEventName.Name = "cbEventName";
            cbEventName.Size = new Size(151, 28);
            cbEventName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 512);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 7;
            label3.Text = "Event Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 314);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 8;
            label4.Text = "Category Name :";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(244, 336);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(194, 28);
            cbCategory.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(244, 380);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(244, 426);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(244, 468);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(344, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(344, 426);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numStock
            // 
            numStock.Location = new Point(57, 470);
            numStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(150, 27);
            numStock.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 447);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 16;
            label5.Text = "Total Stock :";
            // 
            // tbCategory
            // 
            tbCategory.Location = new Point(490, 337);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(161, 27);
            tbCategory.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(492, 311);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 18;
            label6.Text = "Add new category :";
            // 
            // addCategory
            // 
            addCategory.Location = new Point(490, 376);
            addCategory.Name = "addCategory";
            addCategory.Size = new Size(139, 29);
            addCategory.TabIndex = 19;
            addCategory.Text = "Add Category";
            addCategory.UseVisualStyleBackColor = true;
            addCategory.Click += addCategory_Click;
            // 
            // TicketManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 618);
            Controls.Add(addCategory);
            Controls.Add(label6);
            Controls.Add(tbCategory);
            Controls.Add(label5);
            Controls.Add(numStock);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCreate);
            Controls.Add(cbCategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbEventName);
            Controls.Add(label2);
            Controls.Add(numPrice);
            Controls.Add(tbTicketId);
            Controls.Add(idTicket);
            Controls.Add(dgvTicket);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TicketManagementForm";
            Text = "TicketManagementForm";
            Load += TicketManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTicket).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvTicket;
        private Label idTicket;
        private TextBox tbTicketId;
        private NumericUpDown numPrice;
        private Label label2;
        private ComboBox cbEventName;
        private Label label3;
        private Label label4;
        private ComboBox cbCategory;
        private Button btnCreate;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnSave;
        private NumericUpDown numStock;
        private Label label5;
        private TextBox tbCategory;
        private Label label6;
        private Button addCategory;
    }
}