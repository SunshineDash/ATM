using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Login : MaterialForm
    {
        UserCabinet userCabinet = new UserCabinet();
        private List<Bank> Banks { get; }
        static public List<string> Pathes { get; set; } = new List<string>() { "/Users/Asus/source/repos/ATM/ATM/Data Base/Credit Card.txt", "/Users/Asus/source/repos/ATM/ATM/Data Base/Banned Cards.txt", "/Users/Asus/source/repos/ATM/ATM/Data Base/Bill.txt", "/Users/Asus/source/repos/ATM/ATM/Data Base/Banknotes.txt", "/Users/Asus/source/repos/ATM/ATM/Data Base/Banks.txt" };
        static public CreditCard card { get; set; }
        
        public Login()
        {
            InitializeComponent();
            //Pathes = new List<string>();
            //Pathes.Add("/Users/Asus/source/repos/ATM/ATM/Data Base/Credit Card.txt");
            //Pathes.Add("/Users/Asus/source/repos/ATM/ATM/Data Base/Banned Cards.txt");
            //Pathes.Add("/Users/Asus/source/repos/ATM/ATM/Data Base/Bill.txt");
            //Pathes.Add("/Users/Asus/source/repos/ATM/ATM/Data Base/Banknotes.txt");
            //Pathes.Add("/Users/Asus/source/repos/ATM/ATM/Data Base/Banks.txt");
            Banks = BanksOperation.GetBanks(Pathes[4]);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            CardNumberInf.BackColor = BackColor;
            PinCodeInf.BackColor = BackColor;
            LoginButton.BackColor = BackColor;
            Validity.BackColor = BackColor;
            PinCodeState.BackColor = BackColor;
        }

        private string CheckValid()
        {
            bool flag = false;
            string name = "Unvalid credit card number";
            Validity.ForeColor = Color.Red;
            for (int i = 0; i < Banks.Count; i++) 
            {
                for (int j = 0; j < Banks[i].StartNumber.Count - 1; j++)
                {
                    if (CardNumberBox.Text.Substring(0, Banks[i].StartNumber[j].Length) == Banks[i].StartNumber[j])
                    {
                        name = Banks[i].Name;
                        Validity.ForeColor = Color.Green;
                        flag = true;
                        break;
                    }
                }
                if (flag) break;
            }
            return name;  
        }

        private void CardNumberBox_TextChanged(object sender, EventArgs e)
        {
            ATMOperations.InputSymbols(sender);
            if(CardNumberBox.Text.Length >= 4)  Validity.Text = CheckValid();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            List<CreditCard> creditCards = CardOperations.ReadBase(Pathes[0], Pathes[1], Pathes[2]);
            card = CardOperations.GetCard(CardNumberBox.Text, creditCards);
            if (!CardOperations.Validity(CardOperations.GetNumbers(CardNumberBox.Text)) || card.CardNumber != CardNumberBox.Text)
            {
                Validity.ForeColor = Color.Red;
                Validity.Text = "Unvalid credit card number";
            }
            if (PinCodeBox.Text.Length < 4 || card.PinCode != PinCodeBox.Text)
            {
                PinCodeState.Text = "Wrong PinCode";
                card.Attempts--;
                for (int i = 0; i < creditCards.Count; i++)
                {
                    if (creditCards[i].CardNumber == card.CardNumber)
                    {
                        creditCards[i] = card;
                        break;
                    }
                }
                CardOperations.SaveCreditCard(Pathes[0], Pathes[2], Pathes[1], creditCards);
            }
            if (card.Ban || card.Attempts <= 0)
            {
                MessageBox.Show("Card is banned");
            }

            if(CardOperations.Validity(CardOperations.GetNumbers(CardNumberBox.Text)) || card.CardNumber == CardNumberBox.Text)
            {
                if (PinCodeBox.Text.Length == 4 && card.PinCode == PinCodeBox.Text)
                {
                    if (!card.Ban && card.Attempts > 0)
                    {
                        Hide();
                        userCabinet.Show();
                    }
                }
            }
        }
    }
}
