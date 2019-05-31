using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_ElizabethLombardi
{
    public partial class EL_Assign1 : Form
    {
        Account acct;

        public EL_Assign1()
        {
            InitializeComponent();
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is Button)
                c.Enabled = false;
            }

            btnOpenNewAcct.Enabled = true;
            btnOpenNewAcct.Focus();
        }

        private void BtnOpenNewAcct_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                    c.Enabled = true;
            }
            btnOpenNewAcct.Enabled = false;
            txtAmount.Focus();

            acct = new Account();
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAmount.Text))
            {
                lblErrorMsg.Text = "Please enter a deposit amount";
            }
            else
            {
                double deposit;
                bool success = double.TryParse(txtAmount.Text, out deposit);
                if (!success)
                    lblErrorMsg.Text = "Please enter a numerical value";
                else
                {
                    lblErrorMsg.Text = "";
                    try
                    {
                        lblBalanceAmt.Text = acct.depositFunds(deposit).ToString("C");
                    }
                    catch (Exception ex)
                    {
                        lblErrorMsg.Text = ex.Message;
                    }
                }
            } 
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAmount.Text))
            {
                lblErrorMsg.Text = "Please enter a withdrawl amount";
            }
            else
            {
                double withdraw;
                bool success = double.TryParse(txtAmount.Text, out withdraw);
                if (!success)
                    lblErrorMsg.Text = "Please enter a numerical value";
                else
                {
                    lblErrorMsg.Text = "";
                    try
                    {
                        lblBalanceAmt.Text = acct.withdrawFunds(withdraw).ToString("C");
                    }
                    catch (Exception ex)
                    {
                        lblErrorMsg.Text = ex.Message;
                    }
                }
            }
        }
        private void BtnCalcInterest_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInterestRate.Text))
            {
                lblErrorMsg.Text = "Please enter a withdrawl amount";
            }
            else
            {
                double interest;
                bool success = double.TryParse(txtInterestRate.Text, out interest);
                if (!success)
                    lblErrorMsg.Text = "Please enter a numerical value";
                else
                {
                    lblErrorMsg.Text = "";
                    try
                    {
                        lblBalanceAmt.Text = acct.calcInterest(interest).ToString("C");
                    }
                    catch (Exception ex)
                    {
                        lblErrorMsg.Text = ex.Message;
                    }
                }
            }
        }




        private void EL_Assign1_Load(object sender, EventArgs e){ }

    }

    
}
