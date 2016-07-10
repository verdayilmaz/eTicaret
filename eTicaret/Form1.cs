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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Categori> CatList = new List<Categori>();
        Shipper[] ShipDizi = new Shipper[0];
        List<Product> ProList = new List<Product>();

        public IEnumerable<object> Control { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region kategoriDoldur
            Categori c1 = new Categori();
            c1.CategoryName = "Teknoloji";
            c1.Description = "Telefon, Bilg, Ürünler";
            CatList.Add(c1);

            Categori c2 = new Categori();
            c2.CategoryName = "Pets";
            c2.Description = "Evcil Hayvanlar için Ürünler";
            CatList.Add(c2);

            Categori c3 = new Categori();
            c3.CategoryName = "Kozmetik";
            c3.Description = "Cilt Bakımı ve Güzellik";
            CatList.Add(c3);

            foreach (Categori item in CatList)
            {
                comboBox1.Items.Add(item);
            }

            #endregion


            #region Urunler

            Product p1 = new Product();
            p1.ProductName = "Allık";
            p1.Price = 25.99m;
            p1.Stock = 20;
            p1.Description = "acıklama yok";
            p1.Category = c3;
            ProList.Add(p1);

            Product p2 = new Product();
            p2.ProductName = "Ruj";
            p2.Price = 30.99m;
            p2.Stock = 100;
            p2.Description = "acıklama yok";
            p2.Category = c3;
            ProList.Add(p2);

            Product p3 = new Product();
            p3.ProductName = "Bilgisayar";
            p3.Price = 2000;
            p3.Stock = 10;
            p3.Description = "acıklama yok";
            p3.Category = c1;
            ProList.Add(p3);

            Product p4 = new Product();
            p4.ProductName = "Apple";
            p4.Price = 2700;
            p4.Stock = 10;
            p4.Description = "acıklama yok";
            p4.Category = c1;
            ProList.Add(p4);

            Product p5 = new Product();
            p5.ProductName = "Kopek maması";
            p5.Price = 14.99m;
            p5.Stock = 20;
            p5.Description = "şifalı yiyecek";
            p5.Category = c2;
            ProList.Add(p5);

            Product p6 = new Product();
            p6.ProductName = "Kedi kumu";
            p6.Price = 14.99m;
            p6.Stock = 10;
            p6.Description = "extra ferah";
            p6.Category = c2;
            ProList.Add(p6);

            #endregion

            #region ShipperDoldur

            Shipper s1 = new Shipper();
            s1.ShipperName = "Aras";
            s1.Phone = "0212 345 67 89";
            s1.Region = "marmara";
            s1.City = "istanbul";
            s1.Address = "Umraniye";
            Array.Resize(ref ShipDizi, ShipDizi.Length + 1);
            ShipDizi[ShipDizi.Length - 1] = s1;


            Shipper s2 = new Shipper();
            s2.ShipperName = "yurtiçi";
            s2.Phone = "0212 345 66 77";
            s2.Region = "ege";
            s2.City = "izmir";
            s2.Address = "adres yok";
            Array.Resize(ref ShipDizi, ShipDizi.Length + 1);
            ShipDizi[ShipDizi.Length - 1] = s2;


            Shipper s3 = new Shipper();
            s3.ShipperName = "UPS";
            s3.Phone = "0212 345 44 44";
            s3.Region = "iç anadolu";
            s3.City = "ankara";
            s3.Address = "adres yok";
            Array.Resize(ref ShipDizi, ShipDizi.Length + 1);
            ShipDizi[ShipDizi.Length - 1] = s3;


            foreach (Shipper item in ShipDizi)
            {
                foreach (var cont in this.Controls)
                {
                    if (cont is RadioButton)
                    {
                        RadioButton rdbShip = (RadioButton)cont;
                        if (rdbShip.Text == null ||rdbShip.Text == "")
                        {
                            rdbShip.Text = item.ShipperName;
                            rdbShip.Tag = item;
                            break;
                        }
                    }
                }
            }

            #endregion

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Categori secilenKategori = (Categori)comboBox1.SelectedItem;

            foreach (Product item in ProList)
            {
                if (item.Category == secilenKategori)
                {

                    ListViewItem li = new ListViewItem();
                    
                    li.Text = item.ProductName;
                    li.SubItems.Add(item.Price.ToString());
                    li.SubItems.Add(item.Stock.ToString());
                    li.Tag = item;
                    listView1.Items.Add(li);
                }
            } 
        }
        ListView.SelectedListViewItemCollection secilenElemanlar;
        List<Product> secilenUrunler = new List<Product>();

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            secilenElemanlar = listView1.SelectedItems;
            foreach (ListViewItem item in secilenElemanlar)
            {
                Product secilenUrun = (Product)item.Tag;
                secilenUrunler.Add(secilenUrun);
                lstSepet.Items.Add(secilenUrun);

            }

        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            int check = 0;
            RadioButton rdbbtn = new RadioButton();
            foreach (Control item in this.Controls)
            {
                if (item is RadioButton)
                {
                    rdbbtn = (RadioButton)item;
                
                    if (rdbbtn.Checked == true)
                    {
                        check++;
                        break;
                    }
                }
            }

            if ((check == 0) || secilenElemanlar == null)
            {
                MessageBox.Show("Lütfen kargo ya da urununuzu seciniz.");
            }
            else
            {
                Customer myMusteri = new Customer();
                myMusteri.Firstname = "Ozan";
                myMusteri.LastName = "aksoy";

                Order ord = new Order();
                ord.OrderName = Guid.NewGuid().ToString().Replace("-", "");
                ord.Products = secilenUrunler;
                ord.orderDate = DateTime.Now;
                ord.Shipper = (Shipper)rdbbtn.Tag;
                ord.Customer = myMusteri;

                SiparisDetay frm = new SiparisDetay(ord);
                frm.ShowDialog();
            }

        }
    }
}
