using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakmi_GM_X5_32
{
    public partial class Form1 : Form
    {
        private int i;
        double Potongan, HargaMenu, HargaBeverage, HargaSideDish; 
        public Form1()
        {
      InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtnotlp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

             if (textBox1.Text == "HEMAT")
            { MessageBox.Show("Anda akan mendapat potongan harga sebesar Rp 10.000");
              lblpotongan.Text = "Rp 10.000";
              Potongan = 10000;
            }
            else
            { MessageBox.Show("KUPON ANDA TIDAK VALID");
              lblpotongan.Text = "0";
              Potongan = 0;
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 50; i++)
                comboBoxjumlahmenu.Items.Add(i);
            for (int i = 1; i <= 50; i++)
                comboBoxjumlahbeverage.Items.Add(i);
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtnama.Clear();
            txtalamat.Clear();
            txtnotlp.Clear();
            comboBoxmenu.Text = "--pilih--";
            comboBoxjumlahmenu.Text = "";
            comboBoxbeverage.Text = "--pilih--";
            comboBoxjumlahbeverage.Text = "";
            comboBoxsidedish.Text = "--pilih--";
            textBox1.Clear();
            lblpotongan.Text = " ";
            lbltotal.Text = " ";
            MessageBox.Show("Apakah anda yakin ingin keluar ?");
            Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtnama.Clear();
            txtalamat.Clear();
            txtnotlp.Clear();
            comboBoxmenu.Text = "--pilih--";
            comboBoxjumlahmenu.Text = "";
            comboBoxbeverage.Text = "--pilih--";
            comboBoxjumlahbeverage.Text = "";
            comboBoxsidedish.Text = "--pilih--";
            textBox1.Clear();
            lblpotongan.Text = " ";
            lbltotal.Text = " ";


        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double Menu, Beverage, Side, JM, JB, Total;
            Menu = HargaMenu;
            Beverage = HargaBeverage;
            Side = HargaSideDish;
            JM = Convert.ToDouble(comboBoxjumlahmenu.Text);
            JB = Convert.ToDouble(comboBoxjumlahbeverage.Text);
            Total = (Menu * JM) + (Beverage * JB) + (Side) - Potongan;
            lbltotal.Text = "Rp" + Convert.ToString(Total);
        }

        private void btnstruk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nama:" + txtnama.Text + "\n" + "Alamat:" + txtalamat.Text + "\n" + "No. Tlp:" + txtnotlp.Text + "\n" + "\n" + "Pesanan:" + "-" + comboBoxmenu.Text + "(" + comboBoxjumlahmenu.Text + ")" + "\n" + "                " + "-" + comboBoxbeverage.Text + "(" + comboBoxjumlahbeverage.Text + ")" + "\n" + "                " + "-" + comboBoxsidedish.Text + "\n" + "\n" + "Total Bayar:" + lbltotal.Text);
        }

        private void comboBoxsidedish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxsidedish.Text== "Pangsit Goreng (5pcs)")
            { HargaSideDish = 15455 * 10 / 100; }
            else
            { HargaSideDish = 12727 * 10 / 100; }
        }

        private void comboBoxbeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxmenu.Text == "Iced Lychee Tea")
            { HargaBeverage = 19091 + (19091 * 10 / 100); }
            else if (comboBoxmenu.Text == "Iced Coffee Jelly")
            { HargaBeverage = 25454 + (25454 * 10 / 100); }
            else if (comboBoxmenu.Text == "Fruit Punch")
            { HargaBeverage = 20454 + (20454 * 10 / 100); }
            else if (comboBoxmenu.Text == "Iced Green Tea")
            { HargaBeverage = 10000 + (10000 * 10 / 100); }
            else
            { HargaBeverage = 15454 + (15454 * 10 / 100); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxmenu.Text == "Bakmi Special GM")
                { HargaMenu = 26364 + 26364 * 10 / 100; }
            else if (comboBoxmenu.Text == "Bakmi Special GM Pangsit Goreng")
                { HargaMenu = 29091 + 29091 * 10 / 100; }
            else if (comboBoxmenu.Text == "Bakmi Special GM Pangsit Rebus")
                { HargaMenu = 29091 + 29091 * 10 / 100; }
            else if (comboBoxmenu.Text == "Bakmi Ayam")
                { HargaMenu = 25909 + 25909 * 10 / 100; }
            else if (comboBoxmenu.Text == "Bakmi Bakso")
                { HargaMenu = 35000 + 35000 * 10 / 100; }
            else if (comboBoxmenu.Text == "Bakmi Ayam Cah Jamur")
                { HargaMenu = 37273 + 37273 * 10 / 100; }
            else if (comboBoxmenu.Text == "Bakmi Ayam Cah Cabai")
                { HargaMenu = 27273 + 27273 * 10 / 100; }
            else if (comboBoxmenu.Text == "Bakmi Brokoli Sapi Lada Hitam")
                { HargaMenu = 45909 + 45909 * 10 / 100; }
            else if (comboBoxmenu.Text == "Bakmi Daging Sapi Cah Cabai")
                { HargaMenu = 45909 + 45909 * 10 / 100; }
            else
                { HargaMenu = 40000 + 40000 * 10 / 100; }

        }
    }
}
