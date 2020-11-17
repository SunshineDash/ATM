using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string PinCode { get; set; }
        public bool Ban { get; set; }
        public string Bill { get; set; }
        public int Attempts { get; set; }
    }
}
