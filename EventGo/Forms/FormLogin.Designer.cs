namespace EventGo
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEmail = new Label();
            appTitle = new Label();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(51, 118);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(57, 20);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email  :";
            // 
            // appTitle
            // 
            appTitle.AutoSize = true;
            appTitle.Font = new Font("Segoe UI", 12F);
            appTitle.Location = new Point(181, 37);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(91, 28);
            appTitle.TabIndex = 1;
            appTitle.Text = "Event Go";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(51, 141);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(344, 27);
            tbEmail.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(51, 238);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(344, 27);
            tbPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 215);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 4;
            label1.Text = "Password :";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(301, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 450);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(appTitle);
            Controls.Add(labelEmail);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmail;
        private Label appTitle;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Label label1;
        private Button btnLogin;
    }
}
