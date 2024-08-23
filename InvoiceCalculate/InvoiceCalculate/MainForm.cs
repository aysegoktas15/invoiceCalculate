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
        // State flags for panel collapse
        bool sideBarCollapse;
        bool homeCollapse;
        bool invoiceCollapse;
        bool unreceiptedCollapse;
        bool expenseCollapse;

        // Counters
        int countSideBar = 0;
        int countHomePageClick = 0;
        int countInvoiceClick = 0;
        int countUnreceiptedClick = 0;
        int countExpenseClick = 0;

        // Fields
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
        #region Structs for RGB Colors
        private struct RGBColors
        {
            public static Color color0 = Color.FromArgb(255, 255, 255);
            public static Color color1 = Color.FromArgb(255, 105, 180);
            public static Color color2 = Color.FromArgb(255, 182, 193);
            public static Color color3 = Color.FromArgb(255, 192, 203);
        }
        #endregion

        // Methods
        #region Method to activate a button and update the left border
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
        #endregion

        #region Method to disable button style
        private void btnDisable()
        {
            if (btnCurrent != null)
            {
                btnCurrent.BackColor = Color.FromArgb(30, 40, 48); // Set background color
                btnCurrent.ForeColor = Color.White; // Set text color
                btnCurrent.TextAlign = ContentAlignment.MiddleLeft; // Left the text
                btnCurrent.IconColor = Color.White; // Set icon color
                btnCurrent.TextImageRelation = TextImageRelation.ImageBeforeText; // Place text before icon
                btnCurrent.ImageAlign = ContentAlignment.MiddleLeft; // Align icon to the left
            }
        }
        #endregion

        #region Method to enable all buttons
        private void btnAbled()
        {
            btnMainPage.Enabled = true;
            btnInvoice.Enabled = true;
            btnUnreceipted.Enabled = true;
            btnExpense.Enabled = true;
        }
        #endregion

        #region Method to disable all buttons
        private void btnDisabled()
        {
            btnMainPage.Enabled = false;
            btnInvoice.Enabled = false;
            btnUnreceipted.Enabled = false;
            btnExpense.Enabled = false;
        }
        #endregion

        #region Method to set all panels' height to minimum
        private void SetPanelsHeightToMinimum()
        {
            StopAllTimers();

            SetPanelHeightToMinimum(flpInvoiceContainer, ref invoiceCollapse);
            SetPanelHeightToMinimum(flpUnreceiptedContainer, ref unreceiptedCollapse);
            SetPanelHeightToMinimum(flpExpenseContainer, ref expenseCollapse);
        }
        private void SetPanelHeightToMinimum(FlowLayoutPanel panel, ref bool collapse)
        {
            if (!collapse)
            {
                panel.Height = panel.MinimumSize.Height;
                collapse = true;
            }
        }
        private void StopAllTimers()
        {
            tmrInvoice.Stop();
            tmrUnreceipted.Stop();
            tmrExpense.Stop();
        }
        #endregion

        #region Method to handle just a button 
        private void HandleButton(IconButton clickedButton, Color activeColor)
        {
            // Önceki seçili butonu devre dışı bırak
            btnDisable();

            // Tıklanan butonu etkinleştir
            btnActive(clickedButton, activeColor);

            // Diğer panel işlemlerini sıfırla
            ResetCounters();
        }
        #endregion

        #region Method to handle button clicks and manage panel collapse/expansion
        private void HandleButtonClick(ref int count, Timer timer, FlowLayoutPanel panel, ref bool collapse, Color color, IconButton sender)
        {
            count++;
            SetPanelsHeightToMinimum();

            if (count % 2 == 0)
            {
                //btnDisable();
                HandleButton(sender,color);
            }
            else
            {
                if (timer != null)
                {
                    timer.Start();
                }
                btnActive(sender, color);
            }

            ResetCounters();
        }
        #endregion

        #region Method to reset all counters
        private void ResetCounters()
        {
            countHomePageClick = 0;
            countInvoiceClick = 0;
            countExpenseClick = 0;
            countUnreceiptedClick = 0;
        }
        #endregion

        // Event Handlers
        #region Event handlers for close, minimize, and restore buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            WindowState = (WindowState == FormWindowState.Normal) ? FormWindowState.Maximized : FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Event handler for sidebar timer
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
        #endregion

        #region oldMine
        //private void tmrTickHeight()
        //{
        //    tmrInvoice.Stop();
        //    tmrUnreceipted.Stop();
        //    tmrExpense.Stop();

        //    // Collapse all panels
        //    if (!invoiceCollapse)
        //    {
        //        flpInvoiceContainer.Height = flpInvoiceContainer.MinimumSize.Height;
        //        invoiceCollapse = true;
        //    }
        //    if (!unreceiptedCollapse)
        //    {
        //        flpUnreceiptedContainer.Height = flpUnreceiptedContainer.MinimumSize.Height;
        //        unreceiptedCollapse = true;
        //    }
        //    if (!expenseCollapse)
        //    {
        //        flpExpenseContainer.Height = flpExpenseContainer.MinimumSize.Height;
        //        expenseCollapse = true;
        //    }
        //}
        #endregion

        #region Event handler for sidebar toggle
        private void picMenu_Click(object sender, EventArgs e)
        {
            countSideBar++;
            if (countSideBar % 2 == 1)
            {
                tmrSideBar.Start();
                btnDisabled();
                SetPanelsHeightToMinimum();
            }
            else
            {
                tmrSideBar.Start();
                btnAbled();
                countSideBar = 0;
                //
                ResetCounters();
            }
        }
        #endregion

        #region Event handler for main page button
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            #region oldMine
            //countHomePageClick++;
            //tmrTickHeight();

            //if (countHomePageClick % 2 == 0)
            //{
            //    btnDisable();
            //}
            //else
            //{
            //    btnActive(sender, RGBColors.color0);
            //}
            //countInvoiceClick = 0;
            //countExpenseClick = 0;
            //countUnreceiptedClick = 0;
            #endregion

            HandleButtonClick(ref countHomePageClick, null, null, ref homeCollapse, RGBColors.color0, (IconButton)sender);
        }
        #endregion




        #region Event handler for invoice button
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            HandleButtonClick(ref countInvoiceClick, tmrInvoice, flpInvoiceContainer, ref invoiceCollapse, RGBColors.color1, (IconButton)sender);
        }
        #endregion

        #region Event handler for unreceipted button
        private void btnUnreceipted_Click(object sender, EventArgs e)
        {
            HandleButtonClick(ref countUnreceiptedClick, tmrUnreceipted, flpUnreceiptedContainer, ref unreceiptedCollapse, RGBColors.color2, (IconButton)sender);
        }
        #endregion

        #region Event handler for expense button
        private void btnExpense_Click(object sender, EventArgs e)
        {
            HandleButtonClick(ref countExpenseClick, tmrExpense, flpExpenseContainer, ref expenseCollapse, RGBColors.color3, (IconButton)sender);
        }
        #endregion


        #region  Event handler timer tick for collapsing/expanding panels
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

        #endregion





        //private void tmrInvoice_Tick(object sender, EventArgs e)
        //{
        //    TogglePanel(ref invoiceCollapse, flpInvoiceContainer, tmrInvoice);

        //}

        //private void btnInvoice_Click(object sender, EventArgs e)
        //{
        //    countInvoiceClick++;
        //    tmrTickHeight();

        //    if (countInvoiceClick % 2 == 0)
        //    {
        //        btnDisable();
        //    }
        //    else
        //    {
        //        //set time interval to lowest to make it smoother
        //        tmrInvoice.Start();
        //        btnActive(sender, RGBColors.color1);
        //    }
        //    countHomePageClick = 0;
        //    countUnreceiptedClick = 0;
        //    countExpenseClick = 0;
        //}

        //private void tmrUnreceipted_Tick(object sender, EventArgs e)
        //{
        //    TogglePanel(ref unreceiptedCollapse, flpUnreceiptedContainer, tmrUnreceipted);
        //}
        //private void btnUnreceipted_Click(object sender, EventArgs e)
        //{
        //    countUnreceiptedClick++;
        //    tmrTickHeight();

        //    if (countUnreceiptedClick % 2 == 0)
        //    {
        //        btnDisable();
        //    }
        //    else
        //    {
        //        //set time interval to lowest to make it smoother
        //        tmrUnreceipted.Start();
        //        btnActive(sender, RGBColors.color2);
        //    }
        //    countHomePageClick = 0;
        //    countInvoiceClick = 0;
        //    countExpenseClick = 0;
        //}

        //private void tmrExpense_Tick(object sender, EventArgs e)
        //{
        //    TogglePanel(ref expenseCollapse, flpExpenseContainer, tmrExpense);
        //}
        //private void btnExpense_Click(object sender, EventArgs e)
        //{
        //    countExpenseClick++;
        //    tmrTickHeight();

        //    if (countExpenseClick % 2 == 0)
        //    {
        //        btnDisable();
        //    }
        //    else
        //    {
        //        //set time interval to lowest to make it smoother
        //        tmrExpense.Start();
        //        btnActive(sender, RGBColors.color3);
        //    }
        //    countHomePageClick = 0;
        //    countInvoiceClick = 0;
        //    countUnreceiptedClick = 0;
        //}

        //private void TogglePanel(ref bool collapse, FlowLayoutPanel panel, Timer timer)
        //{
        //    if (collapse)
        //    {
        //        panel.Height += 10;
        //        if (panel.Height >= panel.MaximumSize.Height)
        //        {
        //            collapse = false;
        //            timer.Stop();
        //        }
        //    }
        //    else
        //    {
        //        panel.Height -= 10;
        //        if (panel.Height <= panel.MinimumSize.Height)
        //        {
        //            collapse = true;
        //            timer.Stop();
        //        }
        //    }
        //}

        private void btnInArrange_Click(object sender, EventArgs e)
        {

        }

    }
}
