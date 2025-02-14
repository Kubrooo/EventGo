namespace EventGo.Forms
{
    partial class EventTicketManagement
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnTicket = new Button();
            btnEvent = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 45);
            label1.Name = "label1";
            label1.Size = new Size(211, 20);
            label1.TabIndex = 0;
            label1.Text = "Event And Ticket Management";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTicket);
            panel2.Controls.Add(btnEvent);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 626);
            panel2.TabIndex = 1;
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(23, 51);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(201, 29);
            btnTicket.TabIndex = 1;
            btnTicket.Text = "Ticket Management";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnEvent
            // 
            btnEvent.Location = new Point(23, 0);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(201, 29);
            btnEvent.TabIndex = 0;
            btnEvent.Text = "Event Management";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click;
            // 
            // EventTicketManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 751);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "EventTicketManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventTicketManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnTicket;
        private Button btnEvent;
    }
}