using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTicaret
{
    public partial class SiparisDetay : Form
    {
        Order gelenOrder = new Order();

        public SiparisDetay()
        {
            InitializeComponent();
        }

        public SiparisDetay(Order ord)
        {
            InitializeComponent();
            if (ord != null)
            {
                gelenOrder = ord;
            }
        }

        private void SiparisDetay_Load(object sender, EventArgs e)
        {
            decimal Total = 0;
            foreach (Product item in gelenOrder.Products)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.ProductName;
                li.SubItems.Add(item.Category.CategoryName);
                li.SubItems.Add(item.Price.ToString());
                listView1SiparisDetay.Items.Add(li);
                Total += item.Price;
            }
            lblToplamFiyatGoster.Text = Total.ToString();
            lblKargoDetay.Text = String.Format("Kargo: {0}\n telefonu: {1}", gelenOrder.Shipper.ShipperName,gelenOrder.Shipper.Phone);
                 
        }
    }
}
