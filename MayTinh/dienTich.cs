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
    public partial class dienTich : Form
    {
        int hinh;
        int chucNang;
        double result;
        string resultText;
        clickBtn click;
        public clickBtn Click1 { get => click; set => click = value; }
        public dienTich(int hinh, int chucNang)
        {
            InitializeComponent();
            this.chucNang = chucNang;
            if (hinh == 1)
            {
                label1.Text = "Chiều dài: ";
                label2.Text = "Chiều rộng: ";
                label3.Visible = false;
                textBox3.Visible = false;
                label6.Visible = false;
                this.hinh = hinh;
            }
            else if (hinh == 2)
            {
                label2.Text = "Cạnh hình vuông: ";
                label1.Visible = false;
                textBox1.Visible = false;
                label3.Visible = false;
                textBox3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                this.hinh = hinh;
            }
            else if (hinh == 3)
            {
                label1.Text = "Cạnh a: ";
                label2.Text = "Cạnh b: ";
                label3.Text = "Cạnh c: ";
                this.hinh = hinh;
            }
            else
            {
                label2.Text = "Bán kính: ";
                label1.Visible = false;
                textBox1.Visible = false;
                label3.Visible = false;
                textBox3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                this.hinh = hinh;
            }
            if (chucNang == 2)
            {
                this.Text = "Chu Vi";
            }
            else
            {
                this.Text = "Diện Tích";
            }
            click = new clickBtn();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (chucNang == 1)
            {
                if (hinh == 1)
                {
                    result = click.dienTichHCN(textBox1, textBox2);
                    if (result == 0)
                    {
                        MessageBox.Show("Nhập dữ liệu không hợp lệ");
                        textBox4.Clear();
                        return;
                    }
                    else if (result > 0)
                    {
                        resultText = "Diện tích của hình chữ nhật: " + result.ToString() + " cm2";
                        textBox4.Text = resultText;
                    }


                }
                else if (hinh == 2)
                {
                    result = click.dienTichHV(textBox2);
                    if (result == 0)
                    {
                        MessageBox.Show("Nhập dữ liệu không hợp lệ");
                        textBox4.Clear();
                        return;
                    }
                    else if (result > 0)
                    {
                        resultText = "Diện tích của hình vuông: " + result.ToString() + " cm2";
                        textBox4.Text = resultText;
                    }
                }
                else if (hinh == 3)
                {
                    result = click.dienTichTG(textBox1, textBox2, textBox3);
                    if (result == 0)
                    {
                        MessageBox.Show("Nhập dữ liệu không hợp lệ");
                        textBox4.Clear();
                        return;
                    }
                    else if (result > 0)
                    {
                        resultText = "Diện tích của hình tam giác: " + result.ToString() + " cm2";
                        textBox4.Text = resultText;
                    }
                }
                else
                {
                    result = click.dienTichHT(textBox2);
                    if (result == 0)
                    {
                        MessageBox.Show("Nhập dữ liệu không hợp lệ");
                        textBox4.Clear();
                        return;
                    }
                    else if (result > 0)
                    {
                        resultText = "Diện tích của hình tròn: " + result.ToString() + " cm2";
                        textBox4.Text = resultText;
                    }
                }
            }
            else
            {
                if (hinh == 1)
                {
                    result = click.chuViHCN(textBox1, textBox2);
                    if (result == 0)
                    {
                        MessageBox.Show("Nhập dữ liệu không hợp lệ");
                        textBox4.Clear();
                        return;
                    }
                    else if (result > 0)
                    {
                        resultText = "Chu vi của hình chữ nhật: " + result.ToString() + " cm";
                        textBox4.Text = resultText;
                    }


                }
                else if (hinh == 2)
                {
                    result = click.chuViHV(textBox2);
                    if (result == 0)
                    {
                        MessageBox.Show("Nhập dữ liệu không hợp lệ");
                        textBox4.Clear();
                        return;
                    }
                    else if (result > 0)
                    {
                        resultText = "Chu vi của hình vuông: " + result.ToString() + " cm";
                        textBox4.Text = resultText;
                    }
                }
                else if (hinh == 3)
                {
                    result = click.chuViHTG(textBox1, textBox2, textBox3);
                    if (result == 0)
                    {
                        MessageBox.Show("Nhập dữ liệu không hợp lệ");
                        textBox4.Clear();
                        return;
                    }
                    else if (result > 0)
                    {
                        resultText = "Chu vi của hình tam giác: " + result.ToString() + " cm";
                        textBox4.Text = resultText;
                    }
                }
                else
                {
                    result = click.chuViHT(textBox2);
                    if (result == 0)
                    {
                        MessageBox.Show("Nhập dữ liệu không hợp lệ");
                        textBox4.Clear();
                        return;
                    }
                    else if (result > 0)
                    {
                        resultText = "Chu vi của hình tròn: " + result.ToString() + " cm";
                        textBox4.Text = resultText;
                    }
                }
            }
        }

        
    }
}
