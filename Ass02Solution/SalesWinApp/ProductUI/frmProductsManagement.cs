using AutoMapper;
using BusinessObject;
using DataAccess.Repository.CartRepo;
using DataAccess.Repository.MemberRepo;
using DataAccess.Repository.OrderDetailRepo;
using DataAccess.Repository.ProductRepo;
using SalesWinApp.MemberUI;
using SalesWinApp.OrderUI;
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

        IEnumerable<Product> dataSource;
        IEnumerable<Product> searchResult;

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

        private void menuProfile_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Member Details",
                MemberInfo = LoginMember,
                InsertOrUpdate = false,
                MemberRepository = this.MemberRepository,
                CartRepository = this.CartRepository
            };
            frmMemberDetails.Closed += (s, args) => this.Close();
            this.Hide();
            frmMemberDetails.Show();
        }

        private void menuMemberMng_Click(object sender, EventArgs e)
        {
            frmMembersManagement frmMemberManagement = null;
            frmMemberManagement = new frmMembersManagement
            {
                LoginMember = this.LoginMember,
            };
            frmMemberManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmMemberManagement.Show();
        }

        private void menuOrderMng_Click(object sender, EventArgs e)
        {
            frmOrdersManagement frmOrdersManagement = new frmOrdersManagement
            {
                LoginMember = this.LoginMember,
                CartRepository = this.CartRepository,
                MemberRepository = this.MemberRepository
            };
            frmOrdersManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmOrdersManagement.Show();
        }

        private void CreateMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;

            if (LoginMember.Fullname.Equals("Admin"))
            {
                ToolStripMenuItem menuManagement = new ToolStripMenuItem("&Management");
                ToolStripMenuItem menuMemberMng = new ToolStripMenuItem("&Member Management");
                ToolStripMenuItem menuOrderMng = new ToolStripMenuItem("&Order Management");
                ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");

                // Main Menu
                mainMenu.Items.AddRange(new ToolStripItem[]
                {
                menuManagement,
                menuExit
                });

                // Menu Management
                menuManagement.DropDownItems.AddRange(new ToolStripItem[]
                {
                menuMemberMng,
                menuOrderMng
                });

                menuMemberMng.ShortcutKeys = (Keys)((Keys.Control) | Keys.M);
                menuOrderMng.ShortcutKeys = (Keys)((Keys.Control) | Keys.O);

                menuMemberMng.Click += new EventHandler(menuMemberMng_Click);
                menuOrderMng.Click += new EventHandler(menuOrderMng_Click);
                menuExit.Click += new EventHandler(menuExit_Click);
            }
            else
            {
                ToolStripMenuItem menuOrderMng = new ToolStripMenuItem("My &Order");
                ToolStripMenuItem menuProfile = new ToolStripMenuItem("My &Profile");
                ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");

                // Main Menu
                mainMenu.Items.AddRange(new ToolStripItem[]
                {
                    menuOrderMng,
                    menuProfile,
                    menuExit
                });
                //menuOrderMng.Click += new EventHandler(menuOrderMng_Click);
                menuProfile.Click += new EventHandler(menuProfile_Click);
                menuExit.Click += new EventHandler(menuExit_Click);
            }

        }

        private void LoadProductList()
        {
            try
            {
                IEnumerable<ProductPresenter> presentSource;

                
                    presentSource = dataSource.Select
                        (
                            pro => mapper.Map<Product, ProductPresenter>(pro)
                        );

                source = new BindingSource();
                source.DataSource = presentSource;

                
                txtProductID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtCategory.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtCategory.DataBindings.Add("Text", source, "CategoryName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;

                if (dataSource.Count() > 0)
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadFullList()
        {
            search = false;
            var products = productRepository.GetProductsList(!LoginMember.Fullname.Equals("Admin"));
            var productList = from product in products
                              orderby product.ProductName descending
                              select product;
            dataSource = productList;
            searchResult = productList;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                btnNew.Enabled = true;
                dgvProductList.Enabled = true;
                btnLoad.Enabled = true;
                grSearch.Enabled = true;
                LoadFullList();

                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Products List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProductsManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtProductID.Enabled = false;
            txtProductName.Enabled = false;
            txtCategory.Enabled = false;
            txtWeight.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtUnitsInStock.Enabled = false;
            btnNew.Enabled = false;
            dgvProductList.Enabled = false;
            grSearch.Enabled = false;

            btnLoad.Enabled = true;
            if (!LoginMember.Fullname.Equals("Admin"))
            {
                this.Text = "Product Lists";
                btnNew.Text = "View Cart";
                btnDelete.Visible = false;
            }
            CreateMainMenu();
        }

        private void menuExit_Click(object sender, EventArgs e) => Close();


        private void viewCart()
        {
            frmViewCart frmViewCart = new frmViewCart
            {
                LoginMember = this.LoginMember,
                MemberRepository = this.MemberRepository,
                CartRepository = this.CartRepository
            };
            frmViewCart.Closed += (s, args) => this.Close();
            this.Hide();
            frmViewCart.Show();
        }
        private void menuViewCart_Click(object sender, EventArgs e)
        {
            viewCart();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (LoginMember.Fullname.Equals("Admin"))
            {
                frmProductDetail frmProductDetail = new frmProductDetail
                {
                    ProductRepository = this.productRepository,
                    InsertOrUpdate = true,
                    LoginMember = this.LoginMember,
                    Text = "Add new Product"
                };

                if (frmProductDetail.ShowDialog() == DialogResult.OK)
                {
                    LoadFullList();
                    LoadProductList();
                }
            }
            else
            {
                viewCart();
            }
        }

        private ProductPresenter GetProductInfo()
        {
            ProductPresenter productPresenter = null;

            try
            {
                productPresenter = new ProductPresenter()
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryName = txtCategory.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return productPresenter;
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (LoginMember.Fullname.Equals("Admin"))
                {
                    ProductPresenter productPresenter = GetProductInfo();

                    frmProductDetail frmProductDetail = new frmProductDetail
                    {
                        LoginMember = this.LoginMember,
                        ProductRepository = this.productRepository,
                        InsertOrUpdate = false,
                        ProductInfo = productPresenter,
                        Text = "Update Product Info"
                    };

                    if (frmProductDetail.ShowDialog() == DialogResult.OK)
                    {
                        LoadFullList();
                        LoadProductList();
                    }
                }
                else
                {
                    ProductPresenter productPresenter = GetProductInfo();

                    frmProductDetail frmProductDetail = new frmProductDetail
                    {
                        ProductRepository = this.productRepository,
                        InsertOrUpdate = false,
                        ProductInfo = productPresenter,
                        LoginMember = this.LoginMember,
                        CartRepository = this.CartRepository,
                        Text = "Add To Cart"
                    };

                    if (frmProductDetail.ShowDialog() == DialogResult.OK)
                    {
                        LoadFullList();
                        LoadProductList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
