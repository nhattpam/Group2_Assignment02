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
            this.btnExport = new System.Windows.Forms.Button();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lbMember = new System.Windows.Forms.Label();
            this.grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
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
            this.lbOrderTotal.Size = new System.Drawing.Size(65, 15);
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
            this.dgvOrderList.Size = new System.Drawing.Size(413, 252);
            this.dgvOrderList.TabIndex = 8;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(156, 431);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(122, 36);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = true;
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
            // frmOrdersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 484);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.lbOrderTotal);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lbMember);
            this.Name = "frmOrdersManagement";
            this.Text = "frmOrdersManagement";
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
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
        private Button btnExport;
        private TextBox txtMemberName;
        private Label lbMember;
    }
}