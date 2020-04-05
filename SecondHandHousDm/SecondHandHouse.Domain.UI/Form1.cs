using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecondHandHouse.Domain;

namespace SecondHandHouse.Domain.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in typeof(EstatePorperty).GetFields())
            {
                if (item.FieldType.IsEnum == true)
                {
                    ctbType.Items.Add(item.Name);
                }
            }
            ctbType.SelectedIndex = 0;

            IsFirstHouse.Checked = true;
            IsOnlyHouse.Checked = true;
            IsMoreThenFiveYearsBtn.Checked = true;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            EstatePorperty porperty = (EstatePorperty)Enum.Parse(typeof(EstatePorperty), ctbType.SelectedItem.ToString());
            //实例化对象
            House house = new House(area: double.Parse(tbArea.Text),
                                    unitPrice: double.Parse(tbUnitPrice.Text),
                                    isMoreThenFiveYears: IsMoreThenFiveYearsBtn.Checked,
                                    porperty: porperty);

            Seller seller = new Seller(house, IsOnlyHouse.Checked);
            Buyer buyer = new Buyer(IsFirstHouse.Checked);

            Transaction transaction = new Transaction(seller, buyer);

            //计算显示
            tbCostTax.Text = transaction.CostTax.ToString();
            tbDeedTax.Text = transaction.DeedTax.ToString();
            tbPincomeTax.Text = transaction.PersonalIncomeTax.ToString();
            tbSalesTax.Text = transaction.SalesTax.ToString();
            tbStampTax.Text = transaction.StampTax.ToString();
            tbSynTax.Text = transaction.SyntheyicalLandTax.ToString();
            tbTotalTax.Text = transaction.TotalTax.ToString();
            tbTotalPrice.Text = (transaction.Seller.House.TotalPrice / 10000).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbArea.Text = "";
            tbCostTax.Text = "";
            tbDeedTax.Text = "";
            tbPincomeTax.Text = "";
            tbSalesTax.Text = "";
            tbStampTax.Text = "";
            tbSynTax.Text = "";
            tbTotalPrice.Text = "";
            tbTotalTax.Text = "";
            tbUnitPrice.Text = "";
        }
    }
}