using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class TakeMoney : MaterialForm
    {
        static private UserCabinet userCabinet = new UserCabinet();
        Banknotes banknotes = new Banknotes();
        string path = Login.Pathes[3];
        public TakeMoney()
        {
            InitializeComponent();
            banknotes = ATMOperations.GetBanknotes(path);
        }

        private void TakeMoney_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            infoBox.BackColor = BackColor;
        }

        private int StandartWithdrawal(int banknote, int sum)
        {
            if (ATMOperations.CheckBalance(sum, double.Parse(Login.card.Bill)))
            {
                if (banknote > 0)
                {
                    banknote--;
                    Login.card.Bill = (double.Parse(Login.card.Bill) - sum).ToString();
                    MessageBox.Show("Take your money", "Cash Withdrawal", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sorry, but this banknote is over", "Cash Withdrawal", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Not enough money", "Cash Withdrawal", MessageBoxButtons.OK);
            }
            return banknote;
        }

        private void CustomWithdrawal(int sum)
        {
            Login.card.Bill = (double.Parse(Login.card.Bill) - sum).ToString();
            while (sum != 0)
            {
                if (sum >= 500 && banknotes.FiveHundredRubles > 0) { sum = sum - 500; banknotes.FiveHundredRubles--; }
                else if (sum >= 100 && banknotes.HundredRubles > 0) { sum = sum - 100; banknotes.HundredRubles--; }
                else if (sum >= 50 && banknotes.FiftyRubles > 0) { sum = sum - 50; banknotes.FiftyRubles--; }
                else if (sum >= 20 && banknotes.TwentyRubles > 0) { sum = sum - 20; banknotes.TwentyRubles--; }
                else if (sum >= 10 && banknotes.TenRubles > 0) { sum = sum - 10; banknotes.TenRubles--; }
                else if (sum >= 5 && banknotes.FiveRubles > 0) { sum = sum - 5; banknotes.FiveRubles--; }
                else if (banknotes.FiveRubles == 0 && banknotes.TenRubles == 0 && banknotes.TwentyRubles == 0 && banknotes.FiftyRubles == 0 && banknotes.HundredRubles == 0 && banknotes.FiveHundredRubles == 0)
                {
                    MessageBox.Show("Sorry, but all banknote is over", "Cash Withdrawal", MessageBoxButtons.OK);
                    break;
                }
            }
            if(sum == 0)
            {
                MessageBox.Show("Take your money", "Cash Withdrawal", MessageBoxButtons.OK);
            }
        }

        private void fiveRubles_Click(object sender, EventArgs e)
        {
            banknotes.FiftyRubles = StandartWithdrawal(banknotes.FiftyRubles, 5);
            ATMOperations.SaveBanknotes(path, banknotes);
            inputBox.Clear();
            Hide();
            userCabinet.Show();
        }

        private void tenRubles_Click(object sender, EventArgs e)
        {
            banknotes.TenRubles = StandartWithdrawal(banknotes.TenRubles, 10);
            ATMOperations.SaveBanknotes(path, banknotes);
            inputBox.Clear();
            Hide();
            userCabinet.Show();
        }

        private void twentyRubles_Click(object sender, EventArgs e)
        {
            banknotes.TwentyRubles = StandartWithdrawal(banknotes.TwentyRubles, 20);
            ATMOperations.SaveBanknotes(path, banknotes);
            inputBox.Clear();
            Hide();
            userCabinet.Show();
        }

        private void fifthRubles_Click(object sender, EventArgs e)
        {
            banknotes.FiftyRubles = StandartWithdrawal(banknotes.FiftyRubles, 50);
            ATMOperations.SaveBanknotes(path, banknotes);
            inputBox.Clear();
            Hide();
            userCabinet.Show();
        }

        private void hundredRubles_Click(object sender, EventArgs e)
        {
            banknotes.HundredRubles = StandartWithdrawal(banknotes.HundredRubles, 100);
            ATMOperations.SaveBanknotes(path, banknotes);
            inputBox.Clear();
            Hide();
            userCabinet.Show();
        }

        private void fiveHundredRubles_Click(object sender, EventArgs e)
        {
            banknotes.FiveHundredRubles = StandartWithdrawal(banknotes.FiveHundredRubles, 500);
            ATMOperations.SaveBanknotes(path, banknotes);
            inputBox.Clear();
            Hide();
            userCabinet.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            ATMOperations.SaveBanknotes(path, banknotes);
            inputBox.Clear();
            Hide();
            userCabinet.Show();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            ATMOperations.InputSymbols(sender);
        }
        
        private void doneButton_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(inputBox.Text) % 5 == 0)
            {
                if(Int32.Parse(inputBox.Text) <= double.Parse(Login.card.Bill))
                {
                    CustomWithdrawal(Int32.Parse(inputBox.Text));
                    ATMOperations.SaveBanknotes(path, banknotes);
                    inputBox.Clear();
                    Hide();
                    userCabinet.Show();
                }
                else
                {
                    MessageBox.Show("Not enough money", "Cash Withdrawal", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Incorrect cash sum", "Cash Withdrawal", MessageBoxButtons.OK);
            }
        }
    }
}
