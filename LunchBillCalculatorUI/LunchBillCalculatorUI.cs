using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchBillCalculatorUI
{
    public partial class LunchBillCalculatorUI : Form
    {
        double rice, fish, meat, totalGross,discountAmount,vatAmount;
            
        public LunchBillCalculatorUI()
        {
            InitializeComponent();
        }

        private void showTotalButton_Click(object sender, EventArgs e)
        {
            rice = Convert.ToDouble(riceUnitPriceTextBox.Text);
            fish = Convert.ToDouble(fishUnitPriceTextBox.Text);
            meat = Convert.ToDouble(meatUnitPriceTextBox.Text);

            totalGross = 20 * rice + 80 * fish + 100 * meat;
            totalGrossTextBox.Text = totalGross.ToString();
        }

        private void showNetBillButton_Click(object sender, EventArgs e)
        {
            discountAmount = Convert.ToDouble(discountTextBox.Text); 
            double discount = totalGross-((discountAmount*totalGross)/100);
            double netBill = ((5 * discount) / 100 + discount);
            MessageBox.Show(netBill.ToString());
        }

        
    }
}
