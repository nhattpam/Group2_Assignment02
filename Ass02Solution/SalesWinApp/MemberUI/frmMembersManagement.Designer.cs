namespace SalesWinApp.MemberUI
{
    partial class frmMembersManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembersManagement));
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.radioByName = new System.Windows.Forms.RadioButton();
            this.radioByID = new System.Windows.Forms.RadioButton();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(25, 155);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(94, 15);
            this.lbCompanyName.TabIndex = 43;
            this.lbCompanyName.Text = "Company Name";
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.radioByName);
            this.grSearch.Controls.Add(this.radioByID);
            this.grSearch.Controls.Add(this.txtSearchValue);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.lbSearch);
            this.grSearch.Location = new System.Drawing.Point(390, 336);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(586, 89);
            this.grSearch.TabIndex = 41;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search";
            // 
            // radioByName
            // 
            this.radioByName.AutoSize = true;
            this.radioByName.Checked = true;
            this.radioByName.Location = new System.Drawing.Point(435, 54);
            this.radioByName.Name = "radioByName";
            this.radioByName.Size = new System.Drawing.Size(73, 19);
            this.radioByName.TabIndex = 23;
            this.radioByName.TabStop = true;
            this.radioByName.Text = "By Name";
            this.radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            this.radioByID.AutoSize = true;
            this.radioByID.Location = new System.Drawing.Point(435, 24);
            this.radioByID.Name = "radioByID";
            this.radioByID.Size = new System.Drawing.Size(52, 19);
            this.radioByID.TabIndex = 22;
            this.radioByID.TabStop = true;
            this.radioByID.Text = "By ID";
            this.radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(64, 21);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(325, 23);
            this.txtSearchValue.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(130, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(16, 24);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(42, 15);
            this.lbSearch.TabIndex = 16;
            this.lbSearch.Text = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(818, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(602, 314);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(177, 23);
            this.btnNew.TabIndex = 39;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(349, 314);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(208, 23);
            this.btnLoad.TabIndex = 38;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(126, 277);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(184, 23);
            this.txtCountry.TabIndex = 37;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(60, 280);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(50, 15);
            this.lbCountry.TabIndex = 36;
            this.lbCountry.Text = "Country";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(126, 236);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(184, 23);
            this.txtCity.TabIndex = 35;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(60, 238);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 34;
            this.lbCity.Text = "City";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 194);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(184, 23);
            this.txtPassword.TabIndex = 33;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(60, 197);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 32;
            this.lbPassword.Text = "Password";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(129, 152);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(184, 23);
            this.txtCompanyName.TabIndex = 31;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 23);
            this.txtEmail.TabIndex = 30;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(25, 119);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 29;
            this.lbEmail.Text = "Email";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(129, 75);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(184, 23);
            this.txtMemberName.TabIndex = 28;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(25, 78);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(56, 15);
            this.lbMemberName.TabIndex = 27;
            this.lbMemberName.Text = "Fullname";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(129, 34);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(184, 23);
            this.txtMemberID.TabIndex = 26;
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(25, 37);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(66, 15);
            this.lbMemberID.TabIndex = 25;
            this.lbMemberID.Text = "Member ID";
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(349, 10);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 25;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(650, 298);
            this.dgvMemberList.TabIndex = 44;
            this.dgvMemberList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SalesWinApp.Properties.Resources.logo_fpt_shop;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // frmMembersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1036, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbMemberID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMembersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.Load += new System.EventHandler(this.frmMembersManagement_Load);
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCompanyName;
        private GroupBox grSearch;
        private RadioButton radioByName;
        private RadioButton radioByID;
        private TextBox txtSearchValue;
        private Button btnSearch;
        private Label lbSearch;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private TextBox txtCountry;
        private Label lbCountry;
        private TextBox txtCity;
        private Label lbCity;
        private TextBox txtPassword;
        private Label lbPassword;
        private TextBox txtCompanyName;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtMemberName;
        private Label lbMemberName;
        private TextBox txtMemberID;
        private Label lbMemberID;
        private DataGridView dgvMemberList;
        private PictureBox pictureBox1;
    }
}