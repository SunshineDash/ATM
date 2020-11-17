using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    class ATMOperations
    {
        static public Banknotes GetBanknotes(string path)
        {
            Banknotes banknotes = new Banknotes();
            string[] banknote = System.IO.File.ReadAllLines(path);
            string[] buffer = banknote[0].Split('/');
            banknotes.FiveRubles = Int32.Parse(buffer[1]);
            buffer = banknote[1].Split('/');
            banknotes.TenRubles = Int32.Parse(buffer[1]);
            buffer = banknote[2].Split('/');
            banknotes.TwentyRubles = Int32.Parse(buffer[1]);
            buffer = banknote[3].Split('/');
            banknotes.FiftyRubles = Int32.Parse(buffer[1]);
            buffer = banknote[4].Split('/');
            banknotes.HundredRubles = Int32.Parse(buffer[1]);
            buffer = banknote[5].Split('/');
            banknotes.FiveHundredRubles = Int32.Parse(buffer[1]);
            return banknotes;
        }

        static public bool CheckBalance(int banknote, double balance)
        {
            if (balance >= banknote) return true;
            else return false;
        }

        static public void InputSymbols(object sender)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^0-9]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        static public void SaveBanknotes(string path, Banknotes banknotes)
        {
            string[] buffer = new string[6];
            buffer[5] = "5/" + banknotes.FiveRubles.ToString();
            buffer[4] = "10/" + banknotes.TenRubles.ToString();
            buffer[3] = "20/" + banknotes.TwentyRubles.ToString();
            buffer[2] = "50/" + banknotes.FiftyRubles.ToString();
            buffer[1] = "100/" + banknotes.HundredRubles.ToString();
            buffer[0] = "500/" + banknotes.FiveHundredRubles.ToString();
            System.IO.File.WriteAllLines(path, buffer);
        }
    }
}
