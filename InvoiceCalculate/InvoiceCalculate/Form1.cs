using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceCalculate
{
    public partial class MainForm : Form
    {
        bool sideBarExpand;
        bool invoiceCollapse;
        bool unreceiptedCollapse;
        bool expenseCollapse;

        private Button btnCurrent;

        public MainForm()
        {
            InitializeComponent();
        }

        private void tmrSideBar_Tick(object sender, EventArgs e)
        {
            //Set the MINIMUM and MAXIMUM of sidebar panel

            if (sideBarExpand)
            {
                //if sidebar is expand,minimize
                flpSideBar.Width = -10;
                if (flpSideBar.Width == flpSideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    tmrSideBar.Stop();
                }
            }
            else
            {
                flpSideBar.Width += 10;
                if (flpSideBar.Width == flpSideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    tmrSideBar.Stop();
                }
            }
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            //set time interval to lowest to make it smoother
            tmrSideBar.Start();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tmrInvoice_Tick(object sender, EventArgs e)
        {
            if(invoiceCollapse)
            {
                flpInvoiceContainer.Height += 10;
                if(flpInvoiceContainer.Height == flpInvoiceContainer.MaximumSize.Height)
                {
                    invoiceCollapse = false;
                    tmrInvoice.Stop();
                }
            }
            else
            {
                flpInvoiceContainer.Height -= 10;
                if (flpInvoiceContainer.Height == flpInvoiceContainer.MinimumSize.Height)
                {
                    invoiceCollapse=true;
                    tmrInvoice.Stop();
                }
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            //set time interval to lowest to make it smoother
            tmrInvoice.Start();
        }

        private void tmrUnreceipted_Tick(object sender, EventArgs e)
        {
            if (unreceiptedCollapse)
            {
                flpUnreceiptedContainer.Height += 10;
                if (flpUnreceiptedContainer.Height == flpUnreceiptedContainer.MaximumSize.Height)
                {
                    unreceiptedCollapse = false;
                    tmrUnreceipted.Stop();
                }
            }
            else
            {
                flpUnreceiptedContainer.Height -= 10;
                if (flpUnreceiptedContainer.Height == flpUnreceiptedContainer.MinimumSize.Height)
                {
                    unreceiptedCollapse = true;
                    tmrUnreceipted.Stop();
                }
            }
        }
        private void btnUnreceipted_Click(object sender, EventArgs e)
        {
            //set time interval to lowest to make it smoother
            tmrUnreceipted.Start();
        }

        private void tmrExpense_Tick(object sender, EventArgs e)
        {
            if (expenseCollapse)
            {
                flpExpenseContainer.Height += 10;
                if (flpExpenseContainer.Height == flpExpenseContainer.MaximumSize.Height)
                {
                    expenseCollapse = false;
                    tmrExpense.Stop();
                }
            }
            else
            {
                flpExpenseContainer.Height -= 10;
                if (flpExpenseContainer.Height == flpExpenseContainer.MinimumSize.Height)
                {
                    expenseCollapse = true;
                    tmrExpense.Stop();
                }
            }
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            //set time interval to lowest to make it smoother
            tmrExpense.Start();
        }

        //<!--------------------------------------------------------->

        private void ActiveButton(object btnSender)
        {
            if (btnCurrent != (Button)btnSender)
            {
                btnCurrent = (Button)btnSender;
            }
        }
    }
}
