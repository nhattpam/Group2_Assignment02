using DataAccess.Repository.CartRepo;
using DataAccess.Repository.MemberRepo;
using SalesWinApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public MemberPresenter LoginMember { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        public ICartRepository CartRepository { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        //private void btnMemberManagement_Click(object sender, EventArgs e)
        //{
        //    frmMembersManagement frmMemberManagement = null;
        //    frmMemberManagement = new frmMembersManagement
        //    {
        //        LoginMember = this.LoginMember
        //    };
        //    frmMemberManagement.Closed += (s, args) => this.Close();
        //    this.Hide();
        //    frmMemberManagement.Show();
        //}
    }
}
