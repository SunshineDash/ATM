using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    class BanksOperation
    {
        static public List<Bank> GetBanks(string path) 
        {
            List<Bank> banks = new List<Bank>();
            string[] bankBase = System.IO.File.ReadAllLines(path);
            for(int i = 0; i < bankBase.Length; i++)
            {
                Bank bank = new Bank();
                string[] buffer = bankBase[i].Split('_');
                bank.Name = buffer[0];
                bank.Lenght = buffer[1].Split('/').ToList();
                bank.StartNumber = buffer[2].Split('/').ToList();
                banks.Add(bank);
            }
            return banks;
        }

    }
}

