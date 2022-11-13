using AutoMapper;
using DataAccess.Repository.CartRepo;
using DataAccess.Repository.MemberRepo;
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

namespace SalesWinApp.OrderUI
{
    public partial class frmOrdersManagement : Form
    {
        public MemberPresenter LoginMember { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        public ICartRepository CartRepository { get; set; }
        private IOrderRepository orderRepository = new OrderRepository();
        private IEnumerable<OrderPresenter> orderPresenters = new List<OrderPresenter>();
        //private IEnumerable<AdminOrderPresenter> adminOrderPresenters = new List<AdminOrderPresenter>();

        BindingSource source;
        private IMapper mapper;
        public frmOrdersManagement()
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
