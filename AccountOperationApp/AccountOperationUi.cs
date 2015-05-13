using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        private string accountNumber;
        private string customerName;
        private Account account;
        private string messageToShow = "";
        private void createButton_Click(object sender, EventArgs e)
        {
            if (accountNumberTextBox.Text != String.Empty && customerNameTextBox.Text != String.Empty)
            {
                account = new Account();
                account.accountNumber = accountNumberTextBox.Text;
                account.customerName = customerNameTextBox.Text;
                messageToShow = "Account Has been Created\nYour Account Number is: " + account.accountNumber +
                                "\nYour Account Name is: " + account.customerName;
                accountNumberTextBox.Text = String.Empty;
                customerNameTextBox.Text = String.Empty;
                MessageBox.Show(messageToShow);
            }
            else
            {
                MessageBox.Show("Please Enter Information");
            }

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (account != null)
            {

                if (amountTextBox.Text != String.Empty)
                {
                    double amount = Convert.ToDouble(amountTextBox.Text);
                    MessageBox.Show(account.Deposit(amount));
                    amountTextBox.Clear();

                }
                else
                {
                    MessageBox.Show("Please Enter Amount first");
                }
            }
            else
            {
                MessageBox.Show("Create Account First");
            }

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                if (amountTextBox.Text != String.Empty)
                {
                    double amount = Convert.ToDouble(amountTextBox.Text);
                    MessageBox.Show(account.Withdraw(amount));
                    amountTextBox.Clear();
                    
                }

                else
                {
                    MessageBox.Show("Please Enter Amount first");
                }
            }
            else
            {
                MessageBox.Show("Create Account First");
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                messageToShow = account.customerName + ", your account number is: " + account.accountNumber +
                              " and it's balance is: " + account.balance + " Taka";
            }
            else
            {
                messageToShow = "Account is not created.";
            }
            MessageBox.Show(messageToShow);
        }
    }
}
