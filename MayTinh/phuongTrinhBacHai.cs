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
    public partial class phuongTrinhBacHai : Form
    {
        clickBtn click;
        public clickBtn Click1 { get => click; set => click = value; }
        public phuongTrinhBacHai()
        {
            InitializeComponent();
            click = new clickBtn();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            click.tinhPhuongTrinhBacHai(textBox1, textBox2, textBox3, textBox4, textBox5, label3, label4);
        }
    }
}
