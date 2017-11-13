using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_kiw
{ 
    public partial class Form1 : Form
    { string pos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }
        public void kku(string menu, string bath)
        {
            string[] kku = { menu, bath };
            var kiw = new ListViewItem(kku);
            listView1.Items.Add(kiw);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            kku("LemonTeaIce", "25");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            kku("NesteaTeaHot", "20");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kku("NesafeHot", "20");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kku("MiloHot", "20");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kku("LemonTeaFrappe", "30");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kku("EsspressoHot", "35");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            kku("EsspressoIce", "40");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            kku("EsspressoFrappe", "50");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kku("AricanoHot", "35");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            kku("AricanoIce", "40");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kku("LateHot", "35");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            kku("LateIce", "40");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            kku("LateFrappe", "50");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kku("MochaHot", "35");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            kku("MochaIce", "40");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            kku("MochaFrappe", "50");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kku("CappuccinoHot", "35");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            kku("CappuccinoIce", "45");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            kku("CappuccinoFrappe", "50");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kku("Green TeaHot", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            kku("Green TeaIce", "25");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            kku("Green TeaFrappe", "30");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kku("ThaiTeaHot", "20");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            kku("ThaiTeaIce", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            kku("ThaiTeaFrappe", "30");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kku("CoCoaHot", "20");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            kku("CoCoaIce", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            kku("CoCoaFrappe", "30");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kku("MilkHot", "20");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            kku("MilkIce", "25");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            kku("MilkFrappe", "30");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            kku("Milk TeaIce", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            kku("Milk TeaFrappe", "30");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            kku("MiloIce", "25");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            kku("NesafeIce", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            kku("NesafeFrappe", "30");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            kku("NesteaTeaIce", "25");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            kku("NesteaTeaFrappe", "30");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            kku("Cantalupr", "25");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            kku("Strawberry", "25");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            kku("Apple", "25");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            kku("BuleHawai", "25");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            kku("Red lime Soda", "25");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            kku("Honey lime Soda", "25");
        }
        double k1;
        public string[] k2()
        {
            k1 = 0;
            string[] k3 = new string[listView1.Items.Count];
            int k4 = listView1.Items.Count;
            for (int i = 0; i < k4; i++)
            {
                k1 += double.Parse(listView1.Items[i].SubItems[1].Text);

                k3[i] = listView1.Items[i].SubItems[0].Text.ToString();

            } label29.Text = k1.ToString();
            return k3;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabcontorl1.Controls.Remove(PayMent);
        }
        public string[] py ()
        {
            string[] k3 = new string[listView1.Items.Count];
            int k5 = listView1.Items.Count;
            for(int i=0;i<k5;i++)
            {
                k3[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return k3;
            



        }
        public void kkk()
        {
            string[] k5 = k2();
            string[] k6 = py();
            string k7 = "coffee pos" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string k8 = "coffee pos";
            k8 += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd/mm/yyyy") + "\r\n" + "\r\n";
            k8 += "Menu" + "\r\n";
            for (int i =0; i< listView1.Items.Count; i++)
            {
                k8 += k5[i] + new string(' ', 20) + k6[i] + "bath" + "\r\n";
            }
            k8 += "\r\n";
            k8 += "Totle Price :" + label29.Text;
            System.IO.File.WriteAllText(pos + @"\" + k7 + ".txt", k8);
            textBox1.Text += k8 + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + pos + @"\" + k7 + ".txt";

        }
        bool k9 = false;

        private void button49_Click(object sender, EventArgs e)
        {
            label29.Text = " ";
            if (k9 == false)
            {
                tabcontorl1.TabPages.Insert(1, PayMent);
                tabcontorl1.SelectedTab = PayMent;
            }
            else tabcontorl1.SelectedTab = PayMent;
            if (listView1.Items.Count > 0)
                kkk();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            k9 = false;
            tabcontorl1.Controls.Remove(PayMent);
            textBox1.Text = "";
            label29.Text = "";
        }
    }
}
