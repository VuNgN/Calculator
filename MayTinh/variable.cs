using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTinh
{
    public class variable
    {
        public double FirstNumber;
        public double SecondNumber;
        public double Result;
        public string Operation;
        public string history;
        public int count = 1;
        public bool check;

        public void cong()
        {
            Result = FirstNumber + SecondNumber;
        }
        public void tru()
        {
            Result = FirstNumber - SecondNumber;
        }
        public void nhan()
        {
            Result = FirstNumber * SecondNumber;
        }
        public void chia()
        {
            Result = FirstNumber / SecondNumber;
        }
        public void hoanDoi()
        {
            FirstNumber = Result;
        }
    }
}
