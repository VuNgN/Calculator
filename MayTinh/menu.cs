using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinh
{
    public class menu
    {
        string history;

        public string History1 { get => history; set => history = value; }


        public menu()
        {
        }
        public void capnhat(string history)
        {
            this.History1 = history;
        }
        public void showHistory()
        {
            MessageBox.Show(History1, "History");
        }
        public void doiMau(ColorDialog dialog, Button oneBtn, Button twoBtn, Button threeBtn, Button fourBtn, Button fiveBtn, Button sixBtn, Button sevenBtn, Button eightBtn, Button nineNtb, Button zeroNumberBtn, Button CongBtn, Button TruBtn, Button NhanBtn, Button ChiaBtn, Button amBtn, Button dotButton, Button ceButton, Button cButton, Button bangButton)
        {
            DialogResult coloResult = dialog.ShowDialog();
            if (coloResult == DialogResult.OK)
            {
                oneBtn.BackColor = dialog.Color;
                twoBtn.BackColor = dialog.Color;
                threeBtn.BackColor = dialog.Color;
                fourBtn.BackColor = dialog.Color;
                fiveBtn.BackColor = dialog.Color;
                sixBtn.BackColor = dialog.Color;
                sevenBtn.BackColor = dialog.Color;
                eightBtn.BackColor = dialog.Color;
                nineNtb.BackColor = dialog.Color;
                zeroNumberBtn.BackColor = dialog.Color;
                CongBtn.BackColor = dialog.Color;
                TruBtn.BackColor = dialog.Color;
                NhanBtn.BackColor = dialog.Color;
                ChiaBtn.BackColor = dialog.Color;
                amBtn.BackColor = dialog.Color;
                dotButton.BackColor = dialog.Color;
                ceButton.BackColor = dialog.Color;
                cButton.BackColor = dialog.Color;
                bangButton.BackColor = dialog.Color;
            }
        }
        public void doiFont(FontDialog dialog, Button oneBtn, Button twoBtn, Button threeBtn, Button fourBtn, Button fiveBtn, Button sixBtn, Button sevenBtn, Button eightBtn, Button nineNtb, Button zeroNumberBtn, Button CongBtn, Button TruBtn, Button NhanBtn, Button ChiaBtn, Button amBtn, Button dotButton, Button ceButton, Button cButton, Button bangButton, TextBox textBox1)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                oneBtn.Font = dialog.Font;
                twoBtn.Font = dialog.Font;
                threeBtn.Font = dialog.Font;
                fourBtn.Font = dialog.Font;
                fiveBtn.Font = dialog.Font;
                sixBtn.Font = dialog.Font;
                sevenBtn.Font = dialog.Font;
                eightBtn.Font = dialog.Font;
                nineNtb.Font = dialog.Font;
                zeroNumberBtn.Font = dialog.Font;
                CongBtn.Font = dialog.Font;
                TruBtn.Font = dialog.Font;
                NhanBtn.Font = dialog.Font;
                ChiaBtn.Font = dialog.Font;
                amBtn.Font = dialog.Font;
                dotButton.Font = dialog.Font;
                ceButton.Font = dialog.Font;
                cButton.Font = dialog.Font;
                bangButton.Font = dialog.Font;
                textBox1.Font = dialog.Font;
            }
        }

        public void formOpen()
        {
            phuongTrinhBacHai ptbhForm = new phuongTrinhBacHai();
            ptbhForm.Show();
        }

        public void tinhDienTichHCN()
        {
            dienTich form3 = new dienTich(1,1);           
            form3.Show();
        }

        public void tinhDienTichVuong()
        {
            dienTich form3 = new dienTich(2,1);
            form3.Show();
        }

        public void tinhDienTichTamGiac()
        {
            dienTich form3 = new dienTich(3,1);
            form3.Show();
        }

        public void tinhDienTichTron()
        {
            dienTich form3 = new dienTich(4,1);
            form3.Show();
        }

        public void tinhChuViHCN()
        {
            dienTich form3 = new dienTich(1,2);
            form3.Show();
        }

        public void tinhChuViHV()
        {
            dienTich form3 = new dienTich(2,2);
            form3.Show();
        }

        public void tinhChuViHTG()
        {
            dienTich form3 = new dienTich(3,2);
            form3.Show();
        }

        public void tinhChuViHT()
        {
            dienTich form3 = new dienTich(4,2);
            form3.Show();
        }
    }
}
