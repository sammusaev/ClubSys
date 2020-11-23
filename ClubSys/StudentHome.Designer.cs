namespace ClubSys
{
    partial class StudentHome
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.lstClubs = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dynamicPanel = new System.Windows.Forms.Panel();
            this.lblClubEstablished = new System.Windows.Forms.Label();
            this.lblClubSecretary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblClubVicePresident = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblClubPresident = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClubDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClubName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.dynamicPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(1478, 100);
            this.pnlNav.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.lstClubs);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 694);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(43, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search";
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(670, 110);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(98, 85);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View More";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lstClubs
            // 
            this.lstClubs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstClubs.FormattingEnabled = true;
            this.lstClubs.ItemHeight = 28;
            this.lstClubs.Location = new System.Drawing.Point(48, 110);
            this.lstClubs.Name = "lstClubs";
            this.lstClubs.Size = new System.Drawing.Size(616, 536);
            this.lstClubs.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(144, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(520, 37);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dynamicPanel
            // 
            this.dynamicPanel.Controls.Add(this.lblClubEstablished);
            this.dynamicPanel.Controls.Add(this.lblClubSecretary);
            this.dynamicPanel.Controls.Add(this.label2);
            this.dynamicPanel.Controls.Add(this.label9);
            this.dynamicPanel.Controls.Add(this.lblClubVicePresident);
            this.dynamicPanel.Controls.Add(this.label7);
            this.dynamicPanel.Controls.Add(this.lblClubPresident);
            this.dynamicPanel.Controls.Add(this.label5);
            this.dynamicPanel.Controls.Add(this.lblClubDescription);
            this.dynamicPanel.Controls.Add(this.label3);
            this.dynamicPanel.Controls.Add(this.lblClubName);
            this.dynamicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dynamicPanel.Location = new System.Drawing.Point(795, 100);
            this.dynamicPanel.Name = "dynamicPanel";
            this.dynamicPanel.Size = new System.Drawing.Size(683, 694);
            this.dynamicPanel.TabIndex = 2;
            // 
            // lblClubEstablished
            // 
            this.lblClubEstablished.AutoSize = true;
            this.lblClubEstablished.Location = new System.Drawing.Point(345, 566);
            this.lblClubEstablished.Name = "lblClubEstablished";
            this.lblClubEstablished.Size = new System.Drawing.Size(125, 28);
            this.lblClubEstablished.TabIndex = 0;
            this.lblClubEstablished.Text = "[clubname]";
            // 
            // lblClubSecretary
            // 
            this.lblClubSecretary.AutoSize = true;
            this.lblClubSecretary.Location = new System.Drawing.Point(345, 465);
            this.lblClubSecretary.Name = "lblClubSecretary";
            this.lblClubSecretary.Size = new System.Drawing.Size(125, 28);
            this.lblClubSecretary.TabIndex = 0;
            this.lblClubSecretary.Text = "[clubname]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(43, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Club Established:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(43, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Club Secretary:";
            // 
            // lblClubVicePresident
            // 
            this.lblClubVicePresident.AutoSize = true;
            this.lblClubVicePresident.Location = new System.Drawing.Point(345, 368);
            this.lblClubVicePresident.Name = "lblClubVicePresident";
            this.lblClubVicePresident.Size = new System.Drawing.Size(125, 28);
            this.lblClubVicePresident.TabIndex = 0;
            this.lblClubVicePresident.Text = "[clubname]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(43, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Club Vice President:";
            // 
            // lblClubPresident
            // 
            this.lblClubPresident.AutoSize = true;
            this.lblClubPresident.Location = new System.Drawing.Point(345, 264);
            this.lblClubPresident.Name = "lblClubPresident";
            this.lblClubPresident.Size = new System.Drawing.Size(125, 28);
            this.lblClubPresident.TabIndex = 0;
            this.lblClubPresident.Text = "[clubname]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(43, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Club President:";
            // 
            // lblClubDescription
            // 
            this.lblClubDescription.AutoSize = true;
            this.lblClubDescription.Location = new System.Drawing.Point(345, 167);
            this.lblClubDescription.Name = "lblClubDescription";
            this.lblClubDescription.Size = new System.Drawing.Size(125, 28);
            this.lblClubDescription.TabIndex = 0;
            this.lblClubDescription.Text = "[clubname]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Club Description:";
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.Font = new System.Drawing.Font("Helvetica", 20F, System.Drawing.FontStyle.Bold);
            this.lblClubName.Location = new System.Drawing.Point(40, 44);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(234, 47);
            this.lblClubName.TabIndex = 0;
            this.lblClubName.Text = "[clubname]";
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 794);
            this.Controls.Add(this.dynamicPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNav);
            this.Font = new System.Drawing.Font("Helvetica", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StudentHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClubSys - Student Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentHome_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dynamicPanel.ResumeLayout(false);
            this.dynamicPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListBox lstClubs;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel dynamicPanel;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Label lblClubSecretary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblClubVicePresident;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblClubPresident;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClubDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClubEstablished;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}