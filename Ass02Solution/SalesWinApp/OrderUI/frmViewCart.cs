using AutoMapper;
using DataAccess.Repository.CartRepo;
using DataAccess.Repository.MemberRepo;
using DataAccess.Repository.OrderRepo;
using SalesWinApp.Presenter;
using SalesWinApp.MemberUI;
using SalesWinApp.ProductUI;
using SalesWinApp.OrderUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository.ProductRepo;

namespace SalesWinApp.OrderUI
{
    public partial class frmViewCart : Form
    {
        public MemberPresenter LoginMember { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        public ICartRepository CartRepository { get; set; }
        private IOrderRepository orderRepository = new OrderRepository();

        private IMapper mapper;
        BindingSource source;
        public frmViewCart()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }

        private void CreateMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;

            ToolStripMenuItem menuOrder = new ToolStripMenuItem("&Order Product");
            ToolStripMenuItem menuProfile = new ToolStripMenuItem("My &Profile");
            ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");

            // Main Menu
            mainMenu.Items.AddRange(new ToolStripItem[]
            {
                        menuOrder,
                        menuExit
            });

            menuOrder.Click += new EventHandler(menuOrder_Click);
            menuProfile.Click += new EventHandler(menuProfile_Click);
            menuExit.Click += new EventHandler(menuExit_Click);

        }

        private void menuOrder_Click(object sender, EventArgs e)
        {
            frmProductsManagement frmProductsManagement = new frmProductsManagement()
            {
                LoginMember = this.LoginMember,
                MemberRepository = this.MemberRepository,
                CartRepository = this.CartRepository
            };
            frmProductsManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmProductsManagement.Show();
        }
        private void menuExit_Click(object sender, EventArgs e) => Close();
        private void menuProfile_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Member Details",
                MemberInfo = LoginMember,
                InsertOrUpdate = false,
                MemberRepository = MemberRepository
            };
            frmMemberDetails.Closed += (s, args) => this.Close();
            this.Hide();
            frmMemberDetails.Show();
        }

        private void LoadCart()
        {
            try
            {
                Dictionary<int, CartProduct> cart = CartRepository.GetCart();
                if (cart == null || cart.Count == 0)
                {
                    btnRemoveFromCart.Enabled = false;
                    txtVCProductName.DataBindings.Clear();
                    txtVCProductName.Text = string.Empty;
                    txtVCPrice.DataBindings.Clear();
                    txtVCPrice.Text = string.Empty;
                    txtVCQuantity.DataBindings.Clear();
                    txtVCQuantity.Text = string.Empty;
                    txtVCTotal.DataBindings.Clear();
                    txtVCTotal.Text = string.Empty;
                    dgvCart.DataSource = null;
                    btnCheckOut.Enabled = false;
                }
                else
                {
                    decimal orderTotal = 0;

                    IProductRepository productRepository = new ProductRepository();

                    IEnumerable<CartPresenter> cartPresenters = new List<CartPresenter>();

                    foreach (var cartItem in cart)
                    {
                        CartPresenter cartPresenter = new CartPresenter()
                        {
                            ProductName = productRepository.GetProduct(cartItem.Key).ProductName,
                            Price = cartItem.Value.Price,
                            Quantity = cartItem.Value.Quantity,
                            Total = cartItem.Value.Price * cartItem.Value.Quantity
                        };
                        orderTotal += cartItem.Value.Price * cartItem.Value.Quantity;
                        cartPresenters = cartPresenters.Append(cartPresenter);
                    }

                    source = new BindingSource();
                    source.DataSource = cartPresenters;

                    txtVCProductName.DataBindings.Clear();
                    txtVCPrice.DataBindings.Clear();
                    txtVCQuantity.DataBindings.Clear();
                    txtVCTotal.DataBindings.Clear();

                    txtVCProductName.DataBindings.Add("Text", source, "ProductName");
                    txtVCPrice.DataBindings.Add("Text", source, "Price");
                    txtVCQuantity.DataBindings.Add("Text", source, "Quantity");
                    txtVCTotal.DataBindings.Add("Text", source, "Total");

                    lbOrderTotal.Text = $"Order Total: {orderTotal}";

                    dgvCart.DataSource = null;
                    dgvCart.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "View Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmViewCart_Load(object sender, EventArgs e)
        {
            CreateMainMenu();
            LoadCart();
        }
    }
}
