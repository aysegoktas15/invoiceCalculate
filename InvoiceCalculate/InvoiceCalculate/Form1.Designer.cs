namespace InvoiceCalculate
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flpSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMainPage = new FontAwesome.Sharp.IconButton();
            this.flpInvoiceContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInvoice = new FontAwesome.Sharp.IconButton();
            this.btnInArrange = new FontAwesome.Sharp.IconButton();
            this.btnInEdit = new FontAwesome.Sharp.IconButton();
            this.flpUnreceiptedContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUnreceipted = new FontAwesome.Sharp.IconButton();
            this.btnUnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUnEdit = new FontAwesome.Sharp.IconButton();
            this.flpExpenseContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExpense = new FontAwesome.Sharp.IconButton();
            this.btnExHome = new FontAwesome.Sharp.IconButton();
            this.btnExCar = new FontAwesome.Sharp.IconButton();
            this.btnExOther = new FontAwesome.Sharp.IconButton();
            this.btnExEdit = new FontAwesome.Sharp.IconButton();
            this.tmrSideBar = new System.Windows.Forms.Timer(this.components);
            this.flpOptionBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.tmrInvoice = new System.Windows.Forms.Timer(this.components);
            this.tmrUnreceipted = new System.Windows.Forms.Timer(this.components);
            this.tmrExpense = new System.Windows.Forms.Timer(this.components);
            this.ıconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.flpSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.flpInvoiceContainer.SuspendLayout();
            this.flpUnreceiptedContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flpExpenseContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flpOptionBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSideBar
            // 
            this.flpSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.flpSideBar.Controls.Add(this.panel1);
            this.flpSideBar.Controls.Add(this.panel2);
            this.flpSideBar.Controls.Add(this.flpInvoiceContainer);
            this.flpSideBar.Controls.Add(this.flpUnreceiptedContainer);
            this.flpSideBar.Controls.Add(this.flpExpenseContainer);
            this.flpSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSideBar.Location = new System.Drawing.Point(0, 0);
            this.flpSideBar.MaximumSize = new System.Drawing.Size(180, 980);
            this.flpSideBar.MinimumSize = new System.Drawing.Size(49, 540);
            this.flpSideBar.Name = "flpSideBar";
            this.flpSideBar.Size = new System.Drawing.Size(180, 680);
            this.flpSideBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜ";
            // 
            // picMenu
            // 
            this.picMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenu.Image = global::InvoiceCalculate.Properties.Resources.menu_png;
            this.picMenu.Location = new System.Drawing.Point(9, 3);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(30, 26);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMainPage);
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 44);
            this.panel2.TabIndex = 1;
            // 
            // btnMainPage
            // 
            this.btnMainPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainPage.FlatAppearance.BorderSize = 0;
            this.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainPage.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMainPage.ForeColor = System.Drawing.Color.White;
            this.btnMainPage.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnMainPage.IconColor = System.Drawing.Color.White;
            this.btnMainPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMainPage.IconSize = 30;
            this.btnMainPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainPage.Location = new System.Drawing.Point(0, 0);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnMainPage.Size = new System.Drawing.Size(180, 44);
            this.btnMainPage.TabIndex = 8;
            this.btnMainPage.Text = "ANA SAYFA";
            this.btnMainPage.UseVisualStyleBackColor = true;
            // 
            // flpInvoiceContainer
            // 
            this.flpInvoiceContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.flpInvoiceContainer.Controls.Add(this.btnInvoice);
            this.flpInvoiceContainer.Controls.Add(this.btnInArrange);
            this.flpInvoiceContainer.Controls.Add(this.btnInEdit);
            this.flpInvoiceContainer.Location = new System.Drawing.Point(3, 111);
            this.flpInvoiceContainer.MaximumSize = new System.Drawing.Size(180, 120);
            this.flpInvoiceContainer.MinimumSize = new System.Drawing.Size(180, 44);
            this.flpInvoiceContainer.Name = "flpInvoiceContainer";
            this.flpInvoiceContainer.Size = new System.Drawing.Size(180, 120);
            this.flpInvoiceContainer.TabIndex = 5;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnInvoice.IconColor = System.Drawing.Color.White;
            this.btnInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInvoice.IconSize = 30;
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.Location = new System.Drawing.Point(3, 3);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnInvoice.Size = new System.Drawing.Size(174, 44);
            this.btnInvoice.TabIndex = 8;
            this.btnInvoice.Text = "FATURA";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnInArrange
            // 
            this.btnInArrange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInArrange.FlatAppearance.BorderSize = 0;
            this.btnInArrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInArrange.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnInArrange.ForeColor = System.Drawing.Color.White;
            this.btnInArrange.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnInArrange.IconColor = System.Drawing.Color.White;
            this.btnInArrange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInArrange.IconSize = 24;
            this.btnInArrange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInArrange.Location = new System.Drawing.Point(3, 53);
            this.btnInArrange.Name = "btnInArrange";
            this.btnInArrange.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnInArrange.Size = new System.Drawing.Size(177, 30);
            this.btnInArrange.TabIndex = 8;
            this.btnInArrange.Text = "FATURA KES";
            this.btnInArrange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInArrange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInArrange.UseVisualStyleBackColor = true;
            // 
            // btnInEdit
            // 
            this.btnInEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInEdit.FlatAppearance.BorderSize = 0;
            this.btnInEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInEdit.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnInEdit.ForeColor = System.Drawing.Color.White;
            this.btnInEdit.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnInEdit.IconColor = System.Drawing.Color.White;
            this.btnInEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInEdit.IconSize = 24;
            this.btnInEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInEdit.Location = new System.Drawing.Point(3, 89);
            this.btnInEdit.Name = "btnInEdit";
            this.btnInEdit.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnInEdit.Size = new System.Drawing.Size(177, 30);
            this.btnInEdit.TabIndex = 8;
            this.btnInEdit.Text = "FATURA DÜZENLE";
            this.btnInEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInEdit.UseVisualStyleBackColor = true;
            // 
            // flpUnreceiptedContainer
            // 
            this.flpUnreceiptedContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.flpUnreceiptedContainer.Controls.Add(this.panel4);
            this.flpUnreceiptedContainer.Controls.Add(this.btnUnAdd);
            this.flpUnreceiptedContainer.Controls.Add(this.btnUnEdit);
            this.flpUnreceiptedContainer.Location = new System.Drawing.Point(3, 237);
            this.flpUnreceiptedContainer.MaximumSize = new System.Drawing.Size(180, 120);
            this.flpUnreceiptedContainer.MinimumSize = new System.Drawing.Size(180, 44);
            this.flpUnreceiptedContainer.Name = "flpUnreceiptedContainer";
            this.flpUnreceiptedContainer.Size = new System.Drawing.Size(180, 120);
            this.flpUnreceiptedContainer.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUnreceipted);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 44);
            this.panel4.TabIndex = 3;
            // 
            // btnUnreceipted
            // 
            this.btnUnreceipted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUnreceipted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnreceipted.FlatAppearance.BorderSize = 0;
            this.btnUnreceipted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnreceipted.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUnreceipted.ForeColor = System.Drawing.Color.White;
            this.btnUnreceipted.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            this.btnUnreceipted.IconColor = System.Drawing.Color.White;
            this.btnUnreceipted.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUnreceipted.IconSize = 30;
            this.btnUnreceipted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnreceipted.Location = new System.Drawing.Point(0, 0);
            this.btnUnreceipted.Name = "btnUnreceipted";
            this.btnUnreceipted.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnUnreceipted.Size = new System.Drawing.Size(177, 44);
            this.btnUnreceipted.TabIndex = 9;
            this.btnUnreceipted.Text = "GELİR";
            this.btnUnreceipted.UseVisualStyleBackColor = false;
            this.btnUnreceipted.Click += new System.EventHandler(this.btnUnreceipted_Click);
            // 
            // btnUnAdd
            // 
            this.btnUnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnAdd.FlatAppearance.BorderSize = 0;
            this.btnUnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnAdd.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUnAdd.ForeColor = System.Drawing.Color.White;
            this.btnUnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnUnAdd.IconColor = System.Drawing.Color.White;
            this.btnUnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUnAdd.IconSize = 24;
            this.btnUnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnAdd.Location = new System.Drawing.Point(3, 53);
            this.btnUnAdd.Name = "btnUnAdd";
            this.btnUnAdd.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnUnAdd.Size = new System.Drawing.Size(177, 30);
            this.btnUnAdd.TabIndex = 9;
            this.btnUnAdd.Text = "GELİR EKLE";
            this.btnUnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUnEdit
            // 
            this.btnUnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnEdit.FlatAppearance.BorderSize = 0;
            this.btnUnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnEdit.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUnEdit.ForeColor = System.Drawing.Color.White;
            this.btnUnEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnUnEdit.IconColor = System.Drawing.Color.White;
            this.btnUnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUnEdit.IconSize = 24;
            this.btnUnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnEdit.Location = new System.Drawing.Point(3, 89);
            this.btnUnEdit.Name = "btnUnEdit";
            this.btnUnEdit.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnUnEdit.Size = new System.Drawing.Size(177, 30);
            this.btnUnEdit.TabIndex = 10;
            this.btnUnEdit.Text = "GELİR DÜZENLE";
            this.btnUnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnEdit.UseVisualStyleBackColor = true;
            // 
            // flpExpenseContainer
            // 
            this.flpExpenseContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.flpExpenseContainer.Controls.Add(this.panel5);
            this.flpExpenseContainer.Controls.Add(this.btnExHome);
            this.flpExpenseContainer.Controls.Add(this.btnExCar);
            this.flpExpenseContainer.Controls.Add(this.btnExOther);
            this.flpExpenseContainer.Controls.Add(this.btnExEdit);
            this.flpExpenseContainer.Location = new System.Drawing.Point(3, 363);
            this.flpExpenseContainer.MaximumSize = new System.Drawing.Size(180, 400);
            this.flpExpenseContainer.MinimumSize = new System.Drawing.Size(180, 44);
            this.flpExpenseContainer.Name = "flpExpenseContainer";
            this.flpExpenseContainer.Size = new System.Drawing.Size(180, 206);
            this.flpExpenseContainer.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnExpense);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 44);
            this.panel5.TabIndex = 4;
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExpense.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpense.FlatAppearance.BorderSize = 0;
            this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpense.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExpense.ForeColor = System.Drawing.Color.White;
            this.btnExpense.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.btnExpense.IconColor = System.Drawing.Color.White;
            this.btnExpense.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpense.IconSize = 30;
            this.btnExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpense.Location = new System.Drawing.Point(0, 0);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnExpense.Size = new System.Drawing.Size(177, 44);
            this.btnExpense.TabIndex = 10;
            this.btnExpense.Text = "HARCAMA";
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnExHome
            // 
            this.btnExHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExHome.FlatAppearance.BorderSize = 0;
            this.btnExHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExHome.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExHome.ForeColor = System.Drawing.Color.White;
            this.btnExHome.IconChar = FontAwesome.Sharp.IconChar.HouseCircleCheck;
            this.btnExHome.IconColor = System.Drawing.Color.White;
            this.btnExHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExHome.IconSize = 24;
            this.btnExHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExHome.Location = new System.Drawing.Point(3, 53);
            this.btnExHome.Name = "btnExHome";
            this.btnExHome.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnExHome.Size = new System.Drawing.Size(177, 30);
            this.btnExHome.TabIndex = 10;
            this.btnExHome.Text = "GİDER / EV";
            this.btnExHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExHome.UseVisualStyleBackColor = true;
            // 
            // btnExCar
            // 
            this.btnExCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExCar.FlatAppearance.BorderSize = 0;
            this.btnExCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExCar.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExCar.ForeColor = System.Drawing.Color.White;
            this.btnExCar.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.btnExCar.IconColor = System.Drawing.Color.White;
            this.btnExCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExCar.IconSize = 24;
            this.btnExCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExCar.Location = new System.Drawing.Point(3, 89);
            this.btnExCar.Name = "btnExCar";
            this.btnExCar.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnExCar.Size = new System.Drawing.Size(177, 30);
            this.btnExCar.TabIndex = 11;
            this.btnExCar.Text = "GİDER / ARABA";
            this.btnExCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExCar.UseVisualStyleBackColor = true;
            // 
            // btnExOther
            // 
            this.btnExOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExOther.FlatAppearance.BorderSize = 0;
            this.btnExOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExOther.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExOther.ForeColor = System.Drawing.Color.White;
            this.btnExOther.IconChar = FontAwesome.Sharp.IconChar.Otter;
            this.btnExOther.IconColor = System.Drawing.Color.White;
            this.btnExOther.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExOther.IconSize = 24;
            this.btnExOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExOther.Location = new System.Drawing.Point(3, 125);
            this.btnExOther.Name = "btnExOther";
            this.btnExOther.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnExOther.Size = new System.Drawing.Size(177, 35);
            this.btnExOther.TabIndex = 12;
            this.btnExOther.Text = "GİDER / DİĞER";
            this.btnExOther.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExOther.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExOther.UseVisualStyleBackColor = true;
            // 
            // btnExEdit
            // 
            this.btnExEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExEdit.FlatAppearance.BorderSize = 0;
            this.btnExEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExEdit.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExEdit.ForeColor = System.Drawing.Color.White;
            this.btnExEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnExEdit.IconColor = System.Drawing.Color.White;
            this.btnExEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExEdit.IconSize = 24;
            this.btnExEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExEdit.Location = new System.Drawing.Point(3, 166);
            this.btnExEdit.Name = "btnExEdit";
            this.btnExEdit.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnExEdit.Size = new System.Drawing.Size(177, 35);
            this.btnExEdit.TabIndex = 13;
            this.btnExEdit.Text = "GİDER DÜZENLE";
            this.btnExEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExEdit.UseVisualStyleBackColor = true;
            // 
            // tmrSideBar
            // 
            this.tmrSideBar.Interval = 8;
            this.tmrSideBar.Tick += new System.EventHandler(this.tmrSideBar_Tick);
            // 
            // flpOptionBar
            // 
            this.flpOptionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.flpOptionBar.Controls.Add(this.btnClose);
            this.flpOptionBar.Controls.Add(this.btnRestore);
            this.flpOptionBar.Controls.Add(this.btnMinimize);
            this.flpOptionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpOptionBar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpOptionBar.Location = new System.Drawing.Point(180, 0);
            this.flpOptionBar.Name = "flpOptionBar";
            this.flpOptionBar.Size = new System.Drawing.Size(800, 30);
            this.flpOptionBar.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Image = global::InvoiceCalculate.Properties.Resources.x_regular_24;
            this.btnClose.Location = new System.Drawing.Point(757, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestore.Image = global::InvoiceCalculate.Properties.Resources.windows_regular_20;
            this.btnRestore.Location = new System.Drawing.Point(711, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(40, 25);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.Image = global::InvoiceCalculate.Properties.Resources.minus_regular_24;
            this.btnMinimize.Location = new System.Drawing.Point(665, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 25);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // tmrInvoice
            // 
            this.tmrInvoice.Interval = 8;
            this.tmrInvoice.Tick += new System.EventHandler(this.tmrInvoice_Tick);
            // 
            // tmrUnreceipted
            // 
            this.tmrUnreceipted.Interval = 8;
            this.tmrUnreceipted.Tick += new System.EventHandler(this.tmrUnreceipted_Tick);
            // 
            // tmrExpense
            // 
            this.tmrExpense.Interval = 8;
            this.tmrExpense.Tick += new System.EventHandler(this.tmrExpense_Tick);
            // 
            // ıconDropDownButton1
            // 
            this.ıconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ıconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.ıconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconDropDownButton1.Name = "ıconDropDownButton1";
            this.ıconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.ıconDropDownButton1.Text = "ıconDropDownButton1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 680);
            this.Controls.Add(this.flpOptionBar);
            this.Controls.Add(this.flpSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.flpSideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flpInvoiceContainer.ResumeLayout(false);
            this.flpUnreceiptedContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flpExpenseContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.flpOptionBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrSideBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.FlowLayoutPanel flpOptionBar;
        private System.Windows.Forms.FlowLayoutPanel flpInvoiceContainer;
        private System.Windows.Forms.Timer tmrInvoice;
        private System.Windows.Forms.FlowLayoutPanel flpUnreceiptedContainer;
        private System.Windows.Forms.Timer tmrUnreceipted;
        private System.Windows.Forms.FlowLayoutPanel flpExpenseContainer;
        private System.Windows.Forms.Timer tmrExpense;
        private FontAwesome.Sharp.IconButton btnInvoice;
        private FontAwesome.Sharp.IconButton btnInArrange;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMainPage;
        private FontAwesome.Sharp.IconDropDownButton ıconDropDownButton1;
        private FontAwesome.Sharp.IconButton btnInEdit;
        private FontAwesome.Sharp.IconButton btnUnreceipted;
        private FontAwesome.Sharp.IconButton btnUnAdd;
        private FontAwesome.Sharp.IconButton btnUnEdit;
        private FontAwesome.Sharp.IconButton btnExpense;
        private FontAwesome.Sharp.IconButton btnExHome;
        private FontAwesome.Sharp.IconButton btnExCar;
        private FontAwesome.Sharp.IconButton btnExOther;
        private FontAwesome.Sharp.IconButton btnExEdit;
    }
}

