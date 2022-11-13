using AutoMapper;
using BusinessObject;
using DataAccess.Repository.CartRepo;
using DataAccess.Repository.MemberRepo;
using DataAccess.Repository.OrderDetailRepo;
using DataAccess.Repository.OrderRepo;
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

namespace SalesWinApp.MemberUI
{
    public partial class frmMembersManagement : Form
    {
        public MemberPresenter LoginMember { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        public ICartRepository CartRepository { get; set; }

        BindingSource source;
        BindingSource citySource;
        BindingSource countrySource;

        bool search = false;
        bool filter = false;
        IEnumerable<Member> dataSource;
        IEnumerable<Member> searchResult;
        IEnumerable<Member> filterResult;

        IEnumerable<string> countryList;
        Dictionary<string, IEnumerable<string>> cityDictionary;
        private IMapper mapper;
        private IOrderRepository orderRepository = new OrderRepository();
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        public frmMembersManagement()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }


    }
}
