using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace InvoiceCalculate
{
    public partial class MainForm : Form
    {
        bool sideBarExpand;
        bool invoiceCollapse;
        bool unreceiptedCollapse;
        bool expenseCollapse;

        //Fields
        private IconButton btnCurrent;
        private Panel btnLeftBorder;

        public MainForm()
        {
            InitializeComponent();
            /**/
            btnLeftBorder = new Panel();
            btnLeftBorder.Size = new Size(7, 60);
            flpSideBar.Controls.Add(btnLeftBorder);
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 105, 180);
            public static Color color2 = Color.FromArgb(255, 182, 193);
            public static Color color3 = Color.FromArgb(255, 192, 203);
        }

        //Methods
        private void btnActive(object btnSender, Color color)
        {
            if (btnSender != null)
            {
                btnDisable();
                //Button
                btnCurrent = (IconButton)btnSender; // Cast the sender to IconButton
                btnCurrent.BackColor = Color.FromArgb(30, 48, 58); // Set background color
                btnCurrent.ForeColor = color; // Set text color
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter; // Center the text
                btnCurrent.IconColor = color; // Set icon color
                btnCurrent.TextImageRelation = TextImageRelation.TextBeforeImage; // Place text before icon
                btnCurrent.ImageAlign = ContentAlignment.MiddleRight; // Align icon to the right

                //Left Border Button
                btnLeftBorder.BackColor = color; // Set left border color
                btnLeftBorder.Location = new Point(0, btnCurrent.Location.Y); // Align border with button
                btnLeftBorder.Visible = true; // Make border visible
                btnLeftBorder.BringToFront(); // Bring border to front of other controls
            }
        }
        private void btnDisable()
        {
            if(btnCurrent != null)
            {
                btnCurrent.BackColor = Color.FromArgb(30, 40, 48); // Set background color
                btnCurrent.ForeColor = Color.White; // Set text color
                btnCurrent.TextAlign = ContentAlignment.MiddleLeft; // Left the text
                btnCurrent.IconColor = Color.White; // Set icon color
                btnCurrent.TextImageRelation = TextImageRelation.ImageBeforeText; // Place text before icon
                btnCurrent.ImageAlign = ContentAlignment.MiddleLeft; // Align icon to the left
            }
        }

        //Button Close-Minimize-Maximize 
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

        //Timer Menus
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
            btnActive(sender, RGBColors.color1);
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
            btnActive(sender, RGBColors.color2);
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
            btnActive(sender, RGBColors.color3);
        }

    }
}
