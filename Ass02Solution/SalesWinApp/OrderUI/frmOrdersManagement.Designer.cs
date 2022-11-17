namespace SalesWinApp.OrderUI
{
    partial class frmOrdersManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdersManagement));
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.lbOrderTotal = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lbMember = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.endDate);
            this.grSearch.Controls.Add(this.lbEndDate);
            this.grSearch.Controls.Add(this.startDate);
            this.grSearch.Controls.Add(this.lbStartDate);
            this.grSearch.Location = new System.Drawing.Point(214, 17);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(211, 132);
            this.grSearch.TabIndex = 18;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(70, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(70, 53);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(135, 23);
            this.endDate.TabIndex = 3;
            this.endDate.Value = new System.DateTime(2021, 6, 29, 17, 4, 20, 0);
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(10, 59);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(54, 15);
            this.lbEndDate.TabIndex = 2;
            this.lbEndDate.Text = "End Date";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(70, 14);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(135, 23);
            this.startDate.TabIndex = 1;
            this.startDate.Value = new System.DateTime(2021, 6, 29, 17, 4, 20, 0);
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(6, 20);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(58, 15);
            this.lbStartDate.TabIndex = 0;
            this.lbStartDate.Text = "Start Date";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Enabled = false;
            this.txtOrderTotal.Location = new System.Drawing.Point(84, 89);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(114, 23);
            this.txtOrderTotal.TabIndex = 16;
            // 
            // lbOrderTotal
            // 
            this.lbOrderTotal.AutoSize = true;
            this.lbOrderTotal.Location = new System.Drawing.Point(13, 92);
            this.lbOrderTotal.Name = "lbOrderTotal";
            this.lbOrderTotal.Size = new System.Drawing.Size(66, 15);
            this.lbOrderTotal.TabIndex = 13;
            this.lbOrderTotal.Text = "Order Total";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Location = new System.Drawing.Point(84, 60);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(114, 23);
            this.txtOrderDate.TabIndex = 12;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(13, 63);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(64, 15);
            this.lbOrderDate.TabIndex = 11;
            this.lbOrderDate.Text = "Order Date";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(84, 31);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(114, 23);
            this.txtOrderID.TabIndex = 10;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(13, 34);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(51, 15);
            this.lbOrderID.TabIndex = 9;
            this.lbOrderID.Text = "Order ID";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(12, 169);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowTemplate.Height = 25;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(785, 148);
            this.dgvOrderList.TabIndex = 8;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Location = new System.Drawing.Point(84, 118);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(114, 23);
            this.txtMemberName.TabIndex = 17;
            // 
            // lbMember
            // 
            this.lbMember.AutoSize = true;
            this.lbMember.Location = new System.Drawing.Point(13, 121);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(52, 15);
            this.lbMember.TabIndex = 15;
            this.lbMember.Text = "Member";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SalesWinApp.Properties.Resources.logo_fpt_shop;
            this.pictureBox1.Location = new System.Drawing.Point(451, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmOrdersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(809, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.lbOrderTotal);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lbMember);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrdersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Management";
            this.Load += new System.EventHandler(this.frmOrdersManagement_Load);
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grSearch;
        private Button btnSearch;
        private DateTimePicker endDate;
        private Label lbEndDate;
        private DateTimePicker startDate;
        private Label lbStartDate;
        private TextBox txtOrderTotal;
        private Label lbOrderTotal;
        private TextBox txtOrderDate;
        private Label lbOrderDate;
        private TextBox txtOrderID;
        private Label lbOrderID;
        private DataGridView dgvOrderList;
        private TextBox txtMemberName;
        private Label lbMember;
        private PictureBox pictureBox1;
    }
}