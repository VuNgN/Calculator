using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinh
{
    public partial class Form1 : Form
    {
        clickBtn click;
        menu menu1;
        public clickBtn Click1 { get => click; set => click = value; }
        public menu Menu1 { get => menu1; set => menu1 = value; }

        public Form1()
        {
            InitializeComponent();
            click = new clickBtn(CongBtn, TruBtn, NhanBtn, ChiaBtn, textBox1, label1);
            menu1 = new menu();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            click.numberBtn(b);
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            click.operationBtn(b);
        }

        private void nequal_Click(object sender, EventArgs e)
        {
            click.bangBtn();           
            HistoryMenuItem.Enabled = true;           
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            click.xoaBtn();
            
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            click.xoaHetBtn();            
        }

        private void amBtn_Click(object sender, EventArgs e)
        {
            click.amBtn();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            menu1.doiMau(colorDialog1, oneBtn, twoBtn, threeBtn, fourBtn, 
                            fiveBtn, sixBtn, sevenBtn, eightBtn, nineNtb, 
                            zeroNumberBtn, CongBtn, TruBtn, NhanBtn, ChiaBtn, 
                            amBtn, dotButton, ceButton, cButton, bangButton);
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            menu1.doiFont(fontDialog1, oneBtn, twoBtn, threeBtn, fourBtn, 
                          fiveBtn, sixBtn, sevenBtn, eightBtn, nineNtb, 
                          zeroNumberBtn, CongBtn, TruBtn, NhanBtn, ChiaBtn, 
                          amBtn, dotButton, ceButton, cButton, bangButton,textBox1);
        }

        private void HistoryMenuItem_Click(object sender, EventArgs e)
        {
            click.showHistory();
        }

        private void StandardMenuItem_Click(object sender, EventArgs e)
        {
            menu1.formOpen();
        }

        private void hìnhChữNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu1.tinhDienTichHCN();
        }

        private void hìnhVuôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu1.tinhDienTichVuong();
        }

        private void hìnhTamGiácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu1.tinhDienTichTamGiac();
        }

        private void hìnhTrònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu1.tinhDienTichTron();
        }

        private void hìnhChữNhậtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menu1.tinhChuViHCN();
        }

        private void hìnhVuôngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menu1.tinhChuViHV();
        }

        private void hìnhTamGiácToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menu1.tinhChuViHTG();
        }

        private void hìnhTrònToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menu1.tinhChuViHT();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát hay không ?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}