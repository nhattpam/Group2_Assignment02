using AutoMapper;
using BusinessObject;
using DataAccess.Repository.CartRepo;
using DataAccess.Repository.MemberRepo;
using DataAccess.Repository.OrderDetailRepo;
using DataAccess.Repository.ProductRepo;
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

namespace SalesWinApp.ProductUI
{
    public partial class frmProductsManagement : Form
    {
        public MemberPresenter LoginMember { get; set; }
        public IMemberRepository MemberRepository { get; set; }

        IProductRepository productRepository = new ProductRepository();
        public ICartRepository CartRepository { get; set; }

        BindingSource source;
        bool search = false;
        bool filter = false;

        IEnumerable<Product> dataSource;
        IEnumerable<Product> searchResult;
        IEnumerable<Product> filterResult;

        private IMapper mapper;
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();


        public frmProductsManagement()
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
