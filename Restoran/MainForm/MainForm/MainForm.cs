using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RestoranMenu
{
    public partial class MainForm : Form
    {
        ArrayList products = new ArrayList();

        public MainForm()
        {
            InitializeComponent();

            products.AddRange(new Product[]
            {
                new Product
                {
                Count = 43,
                Name = "Kabab",
                Price = 4,
                ProductCategory = ProductCategory.MainFoods
                },
                new Product
                {
                Count = 81,
                Name = "Cola",
                Price = 1,
                ProductCategory = ProductCategory.Drinks
                },
                new Product
                {
                Count = 12,
                Name = "Paytaxt",
                Price = 5,
                ProductCategory = ProductCategory.Salat
                },
                new Product
                {
                Count = 43,
                Name = "Merci",
                Price = 2,
                ProductCategory = ProductCategory.Soups
                },
                new Product
                {
                Count = 55,
                Name = "Dolma",
                Price = 6,
                ProductCategory = ProductCategory.MainFoods
                },
            });

            LoadCategories();
        }
        private void LoadCategories()
        {
           string[] categoryNames= Enum.GetNames(typeof(ProductCategory));
            cmbx_categories.DataSource = categoryNames;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbx_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedValue = (sender as ComboBox).SelectedValue.ToString();
          
            ArrayList gorunmeliOlanProductlar = new ArrayList();
            foreach(Product p in products)
            {
                
               ProductCategory selectedCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), selectedValue);
                if(p.ProductCategory == selectedCategory)
                {
                    gorunmeliOlanProductlar.Add(p);
                }
            }
            cmbx_products.DataSource = gorunmeliOlanProductlar;
            cmbx_products.DisplayMember = "Name";

        }
    }
}
