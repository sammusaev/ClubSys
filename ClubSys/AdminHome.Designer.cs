namespace ClubSys
{
    partial class AdminHome
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
            this.pnlAdminMain = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lstClubs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlAdminFunctions = new System.Windows.Forms.Panel();
            this.btnGenActivityList = new System.Windows.Forms.Button();
            this.btnGenClubList = new System.Windows.Forms.Button();
            this.btnArchiveClub = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddClub = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.btnUnarchive = new System.Windows.Forms.Button();
            this.btnClubType = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubPageTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlAdminMain.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlAdminFunctions.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(1478, 100);
            this.pnlNav.TabIndex = 0;
            // 
            // pnlAdminMain
            // 
            this.pnlAdminMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdminMain.Controls.Add(this.pnlContainer);
            this.pnlAdminMain.Controls.Add(this.pnlAdminFunctions);
            this.pnlAdminMain.Controls.Add(this.pnlSearch);
            this.pnlAdminMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminMain.Location = new System.Drawing.Point(0, 100);
            this.pnlAdminMain.Name = "pnlAdminMain";
            this.pnlAdminMain.Size = new System.Drawing.Size(1478, 694);
            this.pnlAdminMain.TabIndex = 3;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.lstClubs);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1228, 594);
            this.pnlContainer.TabIndex = 2;
            // 
            // lstClubs
            // 
            this.lstClubs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstClubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstClubs.HideSelection = false;
            this.lstClubs.Location = new System.Drawing.Point(0, 0);
            this.lstClubs.Name = "lstClubs";
            this.lstClubs.Size = new System.Drawing.Size(1228, 594);
            this.lstClubs.TabIndex = 3;
            this.lstClubs.UseCompatibleStateImageBehavior = false;
            this.lstClubs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Club Name";
            this.columnHeader1.Width = 218;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 379;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "President";
            this.columnHeader3.Width = 199;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vice President";
            this.columnHeader4.Width = 177;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Secretary";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Established";
            this.columnHeader6.Width = 144;
            // 
            // pnlAdminFunctions
            // 
            this.pnlAdminFunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.pnlAdminFunctions.Controls.Add(this.btnGenActivityList);
            this.pnlAdminFunctions.Controls.Add(this.btnGenClubList);
            this.pnlAdminFunctions.Controls.Add(this.btnArchiveClub);
            this.pnlAdminFunctions.Controls.Add(this.btnEdit);
            this.pnlAdminFunctions.Controls.Add(this.btnAddClub);
            this.pnlAdminFunctions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAdminFunctions.Location = new System.Drawing.Point(1228, 100);
            this.pnlAdminFunctions.Name = "pnlAdminFunctions";
            this.pnlAdminFunctions.Size = new System.Drawing.Size(250, 594);
            this.pnlAdminFunctions.TabIndex = 1;
            // 
            // btnGenActivityList
            // 
            this.btnGenActivityList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnGenActivityList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenActivityList.FlatAppearance.BorderSize = 0;
            this.btnGenActivityList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnGenActivityList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenActivityList.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenActivityList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenActivityList.Location = new System.Drawing.Point(0, 476);
            this.btnGenActivityList.Name = "btnGenActivityList";
            this.btnGenActivityList.Size = new System.Drawing.Size(250, 119);
            this.btnGenActivityList.TabIndex = 4;
            this.btnGenActivityList.Text = "Generate Activity List";
            this.btnGenActivityList.UseVisualStyleBackColor = false;
            this.btnGenActivityList.Click += new System.EventHandler(this.btnGenActivityList_Click);
            // 
            // btnGenClubList
            // 
            this.btnGenClubList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnGenClubList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenClubList.FlatAppearance.BorderSize = 0;
            this.btnGenClubList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnGenClubList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenClubList.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenClubList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenClubList.Location = new System.Drawing.Point(0, 357);
            this.btnGenClubList.Name = "btnGenClubList";
            this.btnGenClubList.Size = new System.Drawing.Size(250, 119);
            this.btnGenClubList.TabIndex = 3;
            this.btnGenClubList.Text = "Generate Club List";
            this.btnGenClubList.UseVisualStyleBackColor = false;
            this.btnGenClubList.Click += new System.EventHandler(this.btnGenClubList_Click);
            // 
            // btnArchiveClub
            // 
            this.btnArchiveClub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnArchiveClub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchiveClub.FlatAppearance.BorderSize = 0;
            this.btnArchiveClub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnArchiveClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveClub.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveClub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArchiveClub.Location = new System.Drawing.Point(0, 238);
            this.btnArchiveClub.Name = "btnArchiveClub";
            this.btnArchiveClub.Size = new System.Drawing.Size(250, 119);
            this.btnArchiveClub.TabIndex = 2;
            this.btnArchiveClub.Text = "Archive Selected";
            this.btnArchiveClub.UseVisualStyleBackColor = false;
            this.btnArchiveClub.Click += new System.EventHandler(this.btnArchiveClub_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(0, 119);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(250, 119);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddClub
            // 
            this.btnAddClub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnAddClub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddClub.FlatAppearance.BorderSize = 0;
            this.btnAddClub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClub.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClub.Location = new System.Drawing.Point(0, 0);
            this.btnAddClub.Name = "btnAddClub";
            this.btnAddClub.Size = new System.Drawing.Size(250, 119);
            this.btnAddClub.TabIndex = 0;
            this.btnAddClub.Text = "Add New Club";
            this.btnAddClub.UseVisualStyleBackColor = false;
            this.btnAddClub.Click += new System.EventHandler(this.btnAddClub_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.pnlSearch.Controls.Add(this.picRefresh);
            this.pnlSearch.Controls.Add(this.btnUnarchive);
            this.pnlSearch.Controls.Add(this.btnClubType);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.lblSubPageTitle);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1478, 100);
            this.pnlSearch.TabIndex = 0;
            // 
            // picRefresh
            // 
            this.picRefresh.Image = global::ClubSys.Properties.Resources.refresh1;
            this.picRefresh.Location = new System.Drawing.Point(298, 32);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(27, 31);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 4;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // btnUnarchive
            // 
            this.btnUnarchive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUnarchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnUnarchive.FlatAppearance.BorderSize = 0;
            this.btnUnarchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnarchive.Font = new System.Drawing.Font("Helvetica", 10F);
            this.btnUnarchive.ForeColor = System.Drawing.Color.White;
            this.btnUnarchive.Location = new System.Drawing.Point(1038, 33);
            this.btnUnarchive.Name = "btnUnarchive";
            this.btnUnarchive.Size = new System.Drawing.Size(190, 37);
            this.btnUnarchive.TabIndex = 3;
            this.btnUnarchive.Text = "Unarchive";
            this.btnUnarchive.UseVisualStyleBackColor = false;
            this.btnUnarchive.Click += new System.EventHandler(this.btnUnarchive_Click);
            // 
            // btnClubType
            // 
            this.btnClubType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClubType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnClubType.FlatAppearance.BorderSize = 0;
            this.btnClubType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClubType.Font = new System.Drawing.Font("Helvetica", 10F);
            this.btnClubType.ForeColor = System.Drawing.Color.White;
            this.btnClubType.Location = new System.Drawing.Point(1260, 33);
            this.btnClubType.Name = "btnClubType";
            this.btnClubType.Size = new System.Drawing.Size(190, 37);
            this.btnClubType.TabIndex = 2;
            this.btnClubType.Text = "[TYPE]";
            this.btnClubType.UseVisualStyleBackColor = false;
            this.btnClubType.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(402, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // lblSubPageTitle
            // 
            this.lblSubPageTitle.AutoSize = true;
            this.lblSubPageTitle.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubPageTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSubPageTitle.Location = new System.Drawing.Point(12, 35);
            this.lblSubPageTitle.Name = "lblSubPageTitle";
            this.lblSubPageTitle.Size = new System.Drawing.Size(190, 29);
            this.lblSubPageTitle.TabIndex = 1;
            this.lblSubPageTitle.Text = "[Subpage Title]";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(495, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(483, 37);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 794);
            this.Controls.Add(this.pnlAdminMain);
            this.Controls.Add(this.pnlNav);
            this.Font = new System.Drawing.Font("Helvetica", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClubSys - Administrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminHome_FormClosed);
            this.Shown += new System.EventHandler(this.AdminHome_Shown);
            this.pnlAdminMain.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlAdminFunctions.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlAdminFunctions;
        private System.Windows.Forms.Button btnGenActivityList;
        private System.Windows.Forms.Button btnGenClubList;
        private System.Windows.Forms.Button btnArchiveClub;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddClub;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClubType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnUnarchive;
        private System.Windows.Forms.PictureBox picRefresh;
        public System.Windows.Forms.ListView lstClubs;
        public System.Windows.Forms.Label lblSubPageTitle;
        public System.Windows.Forms.Panel pnlAdminMain;
        public System.Windows.Forms.Panel pnlContainer;
    }
}