using AutoMapper;
using DataAccess.Repository.CartRepo;
using DataAccess.Repository.MemberRepo;
using SalesWinApp.Presenter;
using DataValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using Validation = DataValidation.Validation;
using BusinessObject;

namespace SalesWinApp.MemberUI
{
    public partial class frmMemberDetails : Form
    {
        public bool InsertOrUpdate { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        public ICartRepository CartRepository { get; set; }
        public MemberPresenter MemberInfo { get; set; }
        private IMapper mapper;

        public frmMemberDetails()
        {
            InitializeComponent();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = false;
            if (InsertOrUpdate) // Insert
            {
                btnAdd1.Visible = true;
                btnUpdate.Visible = false;
                //txtMemberID.Text = MemberRepository.GetNextMemberId().ToString();

            }
            else
            {
                btnAdd1.Visible = false;
                btnUpdate.Visible = true;
                txtMemberID.Enabled = false;

                txtMemberID.Text = MemberInfo.MemberId.ToString();
                txtMemberName.Text = MemberInfo.Fullname;
                txtEmail.Text = MemberInfo.Email;
                txtPassword.Text = MemberInfo.Password;
                txtConfirm.Text = MemberInfo.Password;
                txtCompanyName.Text = MemberInfo.CompanyName;
                txtCity.Text = MemberInfo.City;
                txtCountry.Text = MemberInfo.Country;

                if (!MemberInfo.Fullname.Equals("Admin"))
                {
                    MenuStrip mainMenu = new MenuStrip();
                    this.Controls.Add(mainMenu);
                    this.MainMenuStrip = mainMenu;

                    ToolStripMenuItem menuOrder = new ToolStripMenuItem("&Order Product");
                    //ToolStripMenuItem menuProfile = new ToolStripMenuItem("My &Profile");
                    ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");

                    // Main Menu
                    mainMenu.Items.AddRange(new ToolStripItem[]
                    {
                        menuOrder,
                        menuExit
                    });

                    //menuOrder.Click += new EventHandler(menuOrder_Click);
                    menuExit.Click += new EventHandler(menuExit_Click);
                }
            }
        }

        private void menuExit_Click(object sender, EventArgs e) => Close();


        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.IsEmail(txtEmail.Text))
                {
                    throw new Exception("Wrong Email!");
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm does not match with Password!!!");
                }

                MemberPresenter memberPresenter = new MemberPresenter
                {
                    MemberId = MemberInfo.MemberId,
                    Fullname = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };

                Member member = mapper.Map<Member>(memberPresenter);

                MemberRepository.UpdateMember(member);
                MemberInfo = mapper.Map<MemberPresenter>(member);
                MessageBox.Show("Update successfully!!", "Update member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMemberName.Text = member.Fullname;
                txtEmail.Text = member.Email;
                txtPassword.Text = member.Password;
                txtConfirm.Text = member.Password;
                txtCity.Text = member.City;
                txtCountry.Text = member.Country;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
