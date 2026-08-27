namespace MiniERP
{
    partial class MainForm
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
            pnlSidebar = new Panel();
            btnExit = new Button();
            btnCustomers = new Button();
            btnCompanies = new Button();
            btnDashboard = new Button();
            lblTitle = new Label();
            Label1 = new Label();
            panelContent = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(btnExit);
            pnlSidebar.Controls.Add(btnCustomers);
            pnlSidebar.Controls.Add(btnCompanies);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 429);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += panel1_Paint;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(54, 225);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(54, 164);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(94, 29);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnCompanies
            // 
            btnCompanies.Location = new Point(54, 108);
            btnCompanies.Name = "btnCompanies";
            btnCompanies.Size = new Size(94, 29);
            btnCompanies.TabIndex = 2;
            btnCompanies.Text = "Companies";
            btnCompanies.UseVisualStyleBackColor = true;
            btnCompanies.Click += btnCompanies_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(54, 48);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(94, 29);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(66, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(63, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MiniERP";
            lblTitle.Click += label1_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(222, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(82, 20);
            Label1.TabIndex = 1;
            Label1.Text = "Dashboard";
            Label1.Click += label1_Click_1;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(771, 429);
            panelContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 429);
            Controls.Add(panelContent);
            Controls.Add(Label1);
            Controls.Add(pnlSidebar);
            Name = "MainForm";
            Text = "Form1";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblTitle;
        private Label Label1;
        private Button btnExit;
        private Button btnCustomers;
        private Button btnCompanies;
        private Button btnDashboard;
        private Panel panelContent;
    }
}
