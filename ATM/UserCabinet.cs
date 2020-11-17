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
    public partial class UserCabinet : MaterialForm
    {
        TakeMoney takeMoney = new TakeMoney();
        public UserCabinet()
        {
            InitializeComponent();
        }

        private void UserCabinet_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            balanceButton.BackColor = BackColor;
            giveMoneyButton.BackColor = BackColor;
        }

        private void giveMoneyButton_Click(object sender, EventArgs e)
        {
            Hide();
            takeMoney.Show();
        }

        private void balanceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your balance is " + Login.card.Bill, "Balance", MessageBoxButtons.OK);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            List<CreditCard> creditCards = CardOperations.ReadBase(Login.Pathes[0], Login.Pathes[1], Login.Pathes[2]);
            for (int i = 0; i < creditCards.Count; i++)
            {
                if (creditCards[i].CardNumber == Login.card.CardNumber)
                {
                    creditCards[i] = Login.card;
                    break;
                }
            }
            CardOperations.SaveCreditCard(Login.Pathes[0], Login.Pathes[2], Login.Pathes[1], creditCards);
            Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
