﻿using AutoMapper;
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

                //menuMemberMng.Click += new EventHandler(menuMemberMng_Click);
                //menuOrderMng.Click += new EventHandler(menuOrderMng_Click);
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
                //menuProfile.Click += new EventHandler(menuProfile_Click);
                menuExit.Click += new EventHandler(menuExit_Click);
            }

        }

        private void LoadProductList()
        {
            try
            {
                IEnumerable<ProductPresenter> presentSource;

                if (filter)
                {
                    presentSource = filterResult.Select
                        (
                            pro => mapper.Map<Product, ProductPresenter>(pro)
                        );
                }
                else
                {
                    presentSource = dataSource.Select
                        (
                            pro => mapper.Map<Product, ProductPresenter>(pro)
                        );
                }

                source = new BindingSource();
                source.DataSource = presentSource;

                if (!filter)
                {
                    //countryList = from member in dataSource
                    //              where !string.IsNullOrEmpty(member.Country.Trim())
                    //              orderby member.Country ascending
                    //              select member.Country;
                    //countryList = countryList.Distinct();
                    //cityDictionary = new Dictionary<string, IEnumerable<string>>();
                    //foreach (var country in countryList)
                    //{
                    //    var cityList = from member in dataSource
                    //                   where !string.IsNullOrEmpty(member.City.Trim()) && (member.Country.Equals(country))
                    //                   orderby member.City ascending
                    //                   select member.City;
                    //    cityList = cityList.Prepend("All");
                    //    cityList = cityList.Distinct();

                    //    cityDictionary.Add(country, cityList);
                    //}

                    //countryList = countryList.Prepend("All");

                    //if (dataSource.Count() > 0)
                    //{
                    //    countrySource = new BindingSource();
                    //    countrySource.DataSource = countryList;
                    //    cboCountry.DataSource = null;
                    //    cboCountry.DataSource = countrySource;

                    //    cboSearchCity.DataBindings.Clear();
                    //    //citySource = new BindingSource();
                    //    //citySource.DataSource = cityList;
                    //    //cboSearchCity.DataSource = null;
                    //    //cboSearchCity.DataSource = citySource;
                    //}
                }

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
            filter = false;
            var products = productRepository.GetProductsList(!LoginMember.Fullname.Equals("Admin"));
            var productList = from product in products
                              orderby product.ProductName descending
                              select product;
            dataSource = productList;
            searchResult = productList;
            filterResult = productList;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                btnNew.Enabled = true;
                dgvProductList.Enabled = true;
                btnLoad.Enabled = true;
                grSearch.Enabled = true;
                grFilter.Enabled = true;
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
            grFilter.Enabled = false;

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
    }
}
