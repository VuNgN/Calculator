using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinh
{
    public class clickBtn
    {
       
        Button CongBtn;
        Button TruBtn;
        Button NhanBtn;
        Button ChiaBtn;
        TextBox textBox1;
        Label label1;
        menu menu1 = new menu();
        variable var = new variable();

        public Button TruBtn1 { get => TruBtn; set => TruBtn = value; }
        public Button CongBtn1 { get => CongBtn; set => CongBtn = value; }
        public Button NhanBtn1 { get => NhanBtn; set => NhanBtn = value; }
        public Button ChiaBtn1 { get => ChiaBtn; set => ChiaBtn = value; }
        public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public variable Var { get => var; set => var = value; }
        public menu Menu1 { get => menu1; set => menu1 = value; }

        public clickBtn()
        {
        }

        public clickBtn(Button CongBtn,
                        Button TruBtn,
                        Button NhanBtn,
                        Button ChiaBtn,
                        TextBox textBox1,
                        Label label1)
        {
            this.CongBtn1 = CongBtn;
            this.TruBtn1 = TruBtn;
            this.NhanBtn1 = NhanBtn;
            this.ChiaBtn1 = ChiaBtn;
            this.TextBox1 = textBox1;
            this.Label1 = label1;
        }

        public void numberBtn(Button B)
        {
            if (!Var.check)
            {
                TextBox1.Clear();
                Var.FirstNumber = 0;
                Var.check = true;
            }
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = B.Text;
            }
            else if (TextBox1.Text == ".")
            {
                TextBox1.Text = "0." + B.Text;
            }
            else
            {
                TextBox1.Text += B.Text;
            }
        }

        public void operationBtn(Button B)
        {
            Var.FirstNumber = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "0";
            Var.Operation = B.Text;
            CongBtn1.Enabled = false;
            TruBtn1.Enabled = false;
            NhanBtn1.Enabled = false;
            ChiaBtn1.Enabled = false;
            Label1.Visible = true;
            Label1.Text = B.Text;
            Var.check = true;
        }

        public void bangBtn()
        {
            Var.SecondNumber = Convert.ToDouble(TextBox1.Text);

            if (Var.Operation == "+")
            {
                var.cong();
                TextBox1.Text = Convert.ToString(Var.Result);
            }
            if (Var.Operation == "-")
            {
                var.tru();
                TextBox1.Text = Convert.ToString(Var.Result);
            }
            if (Var.Operation == "*")
            {
                var.nhan();
                TextBox1.Text = Convert.ToString(Var.Result);
            }
            if (Var.Operation == "/")
            {
                if (Var.SecondNumber == 0)
                {
                    TextBox1.Text = "0";
                    MessageBox.Show("Lỗi chia cho 0");
                }
                else
                {
                    var.chia();
                    TextBox1.Text = Convert.ToString(Var.Result);
                }
            }
            var.history += var.count.ToString() + ".\t" + var.FirstNumber.ToString() + " " + var.Operation + " " + var.SecondNumber.ToString() + " = " + var.Result.ToString() + "\n";
            ++var.count;
            menu1.capnhat(var.history);
            CongBtn1.Enabled = true;
            TruBtn1.Enabled = true;
            NhanBtn1.Enabled = true;
            ChiaBtn1.Enabled = true;
            Label1.Visible = false;
            Var.check = false;
        }

        public void xoaBtn()
        {
            textBox1.Text = var.FirstNumber.ToString();
            CongBtn.Enabled = true;
            TruBtn.Enabled = true;
            NhanBtn.Enabled = true;
            ChiaBtn.Enabled = true;
            label1.Visible = false;
        }

        public void xoaHetBtn()
        {
            textBox1.Text = "0";
            var.FirstNumber = 0;
            CongBtn.Enabled = true;
            TruBtn.Enabled = true;
            NhanBtn.Enabled = true;
            ChiaBtn.Enabled = true;
            label1.Visible = false;
        }

        public void amBtn()
        {
            textBox1.Text = "-";
            var.check = true;
        }

        public void showHistory()
        {
            menu1.showHistory();
        }

        public void tinhPhuongTrinhBacHai(TextBox textBox1, TextBox textBox2, 
                                          TextBox textBox3, TextBox textBox4, 
                                          TextBox textBox5, Label label3, Label label4)
        {
            double aNumber ;
            double bNumber ;
            double cNumber ;

            if (double.TryParse(textBox1.Text, out aNumber)
                && double.TryParse(textBox2.Text, out bNumber)
                && double.TryParse(textBox3.Text, out cNumber))
            {
                double delta = bNumber * bNumber - 4 * aNumber * cNumber;
                if (delta < 0)
                {
                    textBox4.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    textBox5.Visible = false;
                    MessageBox.Show("Phương trình vô nghiệm", "Notification");
                }
                else if (delta == 0)
                {
                    textBox4.Text = (-bNumber / (2 * aNumber)).ToString();
                    label3.Text = "Nghiệm duy nhất: ";
                    textBox4.Visible = true;
                    label3.Visible = true;
                    label4.Visible = false;
                    textBox5.Visible = false;
                    MessageBox.Show("Phương trình có nghiệm duy nhất", "Notification");
                }
                else
                {
                    textBox4.Text = ((-bNumber + System.Math.Sqrt(delta)) / (2 * aNumber)).ToString();
                    textBox5.Text = ((-bNumber - System.Math.Sqrt(delta)) / (2 * aNumber)).ToString();
                    label3.Text = "Nghiệm thứ nhất: ";
                    label4.Text = "Nghiệm thứ hai: ";
                    textBox4.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    textBox5.Visible = true;
                    MessageBox.Show("Phương trình có hai nghiệm", "Notification");
                }
            }
        }

        public double dienTichHCN(TextBox textBox1, TextBox textBox2)
        {
            double cd;
            double cr;
            if (double.TryParse(textBox1.Text, out cd)
            && double.TryParse(textBox2.Text, out cr))
            {
                return cd * cr;
            }
            return 0;
        }

        public double dienTichHV(TextBox textBox2)
        {
            double c;
            if (double.TryParse(textBox2.Text, out c))
            {
                return c*c;
            }           
            return 0;
        }

        public double dienTichTG(TextBox textBox1, TextBox textBox2, TextBox textBox3)
        {
            double ca;
            double cb;
            double cc;
            if (double.TryParse(textBox1.Text, out ca)
            && double.TryParse(textBox2.Text, out cb)
            && double.TryParse(textBox3.Text, out cc))
            {
                if (ca >= cb + cc || cb >= ca + cc || cc >= cb + ca)
                {
                    MessageBox.Show("Ba cạnh vừa nhập không phải tam giác");
                    return -1;
                }
                else
                {
                    double p = ca + cb + cc;
                    return System.Math.Sqrt(p * (p - ca) * (p - cb) * (p - cc));
                }
            }
            return 0;
        }

        public double dienTichHT(TextBox textBox2)
        {
            double r;
            if (double.TryParse(textBox2.Text, out r))
            {
                return r * r * System.Math.PI;

            }
            return 0;
        }

        public double chuViHCN(TextBox textBox1, TextBox textBox2)
        {
            double cd;
            double cr;
            if (double.TryParse(textBox1.Text, out cd)
            && double.TryParse(textBox2.Text, out cr))
            {
                if (cd == 0 || cr == 0) return 0;
                return (cd + cr) * 2;
            }
            return 0;
        }

        public double chuViHV(TextBox textBox2)
        {
            double c;
            if (double.TryParse(textBox2.Text, out c))
            {
                if (c == 0) return 0;
                return c * 4;
            }
            return 0;
        }

        public double chuViHTG(TextBox textBox1, TextBox textBox2, TextBox textBox3)
        {
            double ca;
            double cb;
            double cc;
            if (double.TryParse(textBox1.Text, out ca)
            && double.TryParse(textBox2.Text, out cb)
            && double.TryParse(textBox3.Text, out cc))
            {
                if (ca >= cb + cc || cb >= ca + cc || cc >= cb + ca)
                {
                    MessageBox.Show("Ba cạnh vừa nhập không phải tam giác");
                    return -1;
                }
                else
                {
                    if (ca == 0 || cb == 0 || cc == 0) return 0;
                    double p = ca + cb + cc;
                    return p;
                }
            }
            return 0;
        }

        public double chuViHT(TextBox textBox2)
        {
            double r;
            if (double.TryParse(textBox2.Text, out r))
            {
                if (r == 0) return 0;
                return 2 * r * System.Math.PI;

            }
            return 0;
        }
    }
}
