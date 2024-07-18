using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;
using Control = System.Windows.Forms.Control;
using Panel = System.Windows.Forms.Panel;

namespace InvoiceCalculate
{
    public partial class MainForm : Form
    {
        bool sideBarCollapse;
        bool invoiceCollapse;
        bool unreceiptedCollapse;
        bool expenseCollapse;

        //Counters
        int countSideBar = 0;
        int countHomePageClick = 0;
        int countInvoiceClick = 0;
        int countUnreceiptedClick = 0;
        int countExpenseClick = 0;

        

        //Fields
        private IconButton btnCurrent;
        private Panel btnLeftBorder;

        public MainForm()
        {
            InitializeComponent();
            btnLeftBorder = new Panel();
            btnLeftBorder.Size = new Size(7, 60);
            flpSideBar.Controls.Add(btnLeftBorder);
        }
        //Structs
        private struct RGBColors
        {
            public static Color color0 = Color.FromArgb(255, 255, 255);
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
        private void btnAbled()
        {
            btnMainPage.Enabled = true;
            btnInvoice.Enabled = true;
            btnUnreceipted.Enabled = true;
            btnExpense.Enabled = true;
        }
        private void btnDisabled()
        {
            btnMainPage.Enabled = false;
            btnInvoice.Enabled = false;
            btnUnreceipted.Enabled = false;
            btnExpense.Enabled = false;
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
            if (sideBarCollapse)
            {
                flpSideBar.Width += 10;
                if (flpSideBar.Width >= flpSideBar.MaximumSize.Width)
                {
                    sideBarCollapse = false;
                    tmrSideBar.Stop();
                }
            }
            else
            {
                flpSideBar.Width -= 10;
                if (flpSideBar.Width <= flpSideBar.MinimumSize.Width)
                {
                    sideBarCollapse = true;
                    tmrSideBar.Stop();
                }
            }
        }
        
        private void tmrTickHeight()
        {
            tmrInvoice.Stop();
            tmrUnreceipted.Stop();
            tmrExpense.Stop();

            // Collapse all panels
            if (!invoiceCollapse)
            {
                flpInvoiceContainer.Height = flpInvoiceContainer.MinimumSize.Height;
                invoiceCollapse = true;
            }
            if (!unreceiptedCollapse)
            {
                flpUnreceiptedContainer.Height = flpUnreceiptedContainer.MinimumSize.Height;
                unreceiptedCollapse = true;
            }
            if (!expenseCollapse)
            {
                flpExpenseContainer.Height = flpExpenseContainer.MinimumSize.Height;
                expenseCollapse = true;
            }
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            countSideBar++;
            if (countSideBar % 2 == 1)
            {
                tmrSideBar.Start();
                btnDisabled();
                tmrTickHeight();
                btnDisable();
            }
            else
            {
                tmrSideBar.Start();
                btnAbled();
                countSideBar = 0;
            }
            countHomePageClick = 0;
            countInvoiceClick = 0;
            countExpenseClick = 0;
            countUnreceiptedClick = 0;
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            countHomePageClick++;
            tmrTickHeight();

            if (countHomePageClick %2 == 0)
            {
                btnDisable();
            }
            else
            {
                btnActive(sender, RGBColors.color0);
            }
            countInvoiceClick = 0;
            countExpenseClick = 0;
            countUnreceiptedClick = 0;
        }

        private void tmrInvoice_Tick(object sender, EventArgs e)
        {
            TogglePanel(ref invoiceCollapse, flpInvoiceContainer, tmrInvoice);
        }
        
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            countInvoiceClick++;
            tmrTickHeight();

            if (countInvoiceClick % 2 == 0)
            {
                btnDisable();
            }
            else
            {
                //set time interval to lowest to make it smoother
                tmrInvoice.Start();
                btnActive(sender, RGBColors.color1);
            }
            countHomePageClick = 0;
            countUnreceiptedClick = 0;
            countExpenseClick = 0;
        }

        private void tmrUnreceipted_Tick(object sender, EventArgs e)
        {
            TogglePanel(ref unreceiptedCollapse, flpUnreceiptedContainer, tmrUnreceipted);
        }
        private void btnUnreceipted_Click(object sender, EventArgs e)
        {
            countUnreceiptedClick++;
            tmrTickHeight();

            if (countUnreceiptedClick % 2 == 0)
            {
                btnDisable();
            }
            else
            {
                //set time interval to lowest to make it smoother
                tmrUnreceipted.Start();
                btnActive(sender, RGBColors.color2);
            }
            countHomePageClick = 0;
            countInvoiceClick = 0;
            countExpenseClick = 0;
        }

        private void tmrExpense_Tick(object sender, EventArgs e)
        {
            TogglePanel(ref expenseCollapse, flpExpenseContainer, tmrExpense);
        }
        private void btnExpense_Click(object sender, EventArgs e)
        {
            countExpenseClick++;
            tmrTickHeight();

            if (countExpenseClick % 2 == 0)
            {
                btnDisable();
            }
            else
            {
                //set time interval to lowest to make it smoother
                tmrExpense.Start();
                btnActive(sender, RGBColors.color3);
            }
            countHomePageClick = 0;
            countInvoiceClick = 0;
            countUnreceiptedClick = 0;
        }

        private void TogglePanel(ref bool collapse, FlowLayoutPanel panel, Timer timer)
        {
            if (collapse)
            {
                panel.Height += 10;
                if (panel.Height >= panel.MaximumSize.Height)
                {
                    collapse = false;
                    timer.Stop();
                }
            }
            else
            {
                panel.Height -= 10;
                if (panel.Height <= panel.MinimumSize.Height)
                {
                    collapse = true;
                    timer.Stop();
                }
            }
        }

        private void btnInArrange_Click(object sender, EventArgs e)
        {

        }
    }
}
