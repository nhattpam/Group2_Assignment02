using AutoMapper;
using BusinessObject;
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
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        ICartRepository cartRepository = new CartRepository();
        private IMapper mapper;

        public frmLogin()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            Member loginMember = memberRepository.Login(Email, Password);
            MemberPresenter memberPresenter = mapper.Map<MemberPresenter>(loginMember);
            if (loginMember != null)
            {
                MessageBox.Show("Login successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string memberName = loginMember.Fullname;
                if (memberName.Equals("Admin"))
                {
                    //MessageBox.Show("day la admin");
                    frmMain frmMain = null;
                    frmMain = new frmMain
                    {
                        LoginMember = memberPresenter,
                        MemberRepository = memberRepository,
                        CartRepository = this.cartRepository
                    };
                    frmMain.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmMain.Show(); //neu la admin thi hien thi main
                }
                else
                {
                    //user ton tai
                }
            }
            else //sai username or pass
            {
                if (MessageBox.Show("Login failed!!", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }
    }
}
