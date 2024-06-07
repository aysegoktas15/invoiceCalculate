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
            this.btnHome = new System.Windows.Forms.Button();
            this.flpInvoiceContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInvoiceCreate = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnInvoiceArrange = new System.Windows.Forms.Button();
            this.flpUnreceiptedContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUnreceipted = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnUnreceiptedAdd = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnUnreceiptedArrange = new System.Windows.Forms.Button();
            this.flpExpenseContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExpense = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnExpenseHome = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnExpenseCar = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnExpenseArrange = new System.Windows.Forms.Button();
            this.tmrSideBar = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.tmrInvoice = new System.Windows.Forms.Timer(this.components);
            this.tmrUnreceipted = new System.Windows.Forms.Timer(this.components);
            this.tmrExpense = new System.Windows.Forms.Timer(this.components);
            this.flpSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.flpInvoiceContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.flpUnreceiptedContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.flpExpenseContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.flpSideBar.MaximumSize = new System.Drawing.Size(180, 900);
            this.flpSideBar.MinimumSize = new System.Drawing.Size(50, 540);
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
            this.panel1.Size = new System.Drawing.Size(177, 57);
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
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(3, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 44);
            this.panel2.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::InvoiceCalculate.Properties.Resources.home_png1;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-3, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(180, 44);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "    ANA SAYFA";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // flpInvoiceContainer
            // 
            this.flpInvoiceContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.flpInvoiceContainer.Controls.Add(this.panel6);
            this.flpInvoiceContainer.Controls.Add(this.panel3);
            this.flpInvoiceContainer.Controls.Add(this.panel8);
            this.flpInvoiceContainer.Location = new System.Drawing.Point(3, 116);
            this.flpInvoiceContainer.MaximumSize = new System.Drawing.Size(180, 120);
            this.flpInvoiceContainer.MinimumSize = new System.Drawing.Size(180, 44);
            this.flpInvoiceContainer.Name = "flpInvoiceContainer";
            this.flpInvoiceContainer.Size = new System.Drawing.Size(180, 120);
            this.flpInvoiceContainer.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnInvoice);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(177, 44);
            this.panel6.TabIndex = 6;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Image = global::InvoiceCalculate.Properties.Resources.invoice_png;
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.Location = new System.Drawing.Point(-6, -3);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInvoice.Size = new System.Drawing.Size(180, 47);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "    FATURA";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnInvoiceCreate);
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 30);
            this.panel3.TabIndex = 2;
            // 
            // btnInvoiceCreate
            // 
            this.btnInvoiceCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnInvoiceCreate.FlatAppearance.BorderSize = 0;
            this.btnInvoiceCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceCreate.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoiceCreate.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceCreate.Image = global::InvoiceCalculate.Properties.Resources.circle_solid_12;
            this.btnInvoiceCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoiceCreate.Location = new System.Drawing.Point(0, 0);
            this.btnInvoiceCreate.Name = "btnInvoiceCreate";
            this.btnInvoiceCreate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInvoiceCreate.Size = new System.Drawing.Size(177, 30);
            this.btnInvoiceCreate.TabIndex = 2;
            this.btnInvoiceCreate.Text = "   FATURA KES";
            this.btnInvoiceCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoiceCreate.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnInvoiceArrange);
            this.panel8.Location = new System.Drawing.Point(3, 89);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(177, 30);
            this.panel8.TabIndex = 7;
            // 
            // btnInvoiceArrange
            // 
            this.btnInvoiceArrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnInvoiceArrange.FlatAppearance.BorderSize = 0;
            this.btnInvoiceArrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceArrange.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoiceArrange.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceArrange.Image = global::InvoiceCalculate.Properties.Resources.circle_solid_12;
            this.btnInvoiceArrange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoiceArrange.Location = new System.Drawing.Point(0, 0);
            this.btnInvoiceArrange.Name = "btnInvoiceArrange";
            this.btnInvoiceArrange.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInvoiceArrange.Size = new System.Drawing.Size(177, 30);
            this.btnInvoiceArrange.TabIndex = 2;
            this.btnInvoiceArrange.Text = "   FATURA DÜZENLE";
            this.btnInvoiceArrange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoiceArrange.UseVisualStyleBackColor = false;
            // 
            // flpUnreceiptedContainer
            // 
            this.flpUnreceiptedContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.flpUnreceiptedContainer.Controls.Add(this.panel4);
            this.flpUnreceiptedContainer.Controls.Add(this.panel10);
            this.flpUnreceiptedContainer.Controls.Add(this.panel11);
            this.flpUnreceiptedContainer.Location = new System.Drawing.Point(3, 242);
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
            this.btnUnreceipted.FlatAppearance.BorderSize = 0;
            this.btnUnreceipted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnreceipted.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnreceipted.ForeColor = System.Drawing.Color.White;
            this.btnUnreceipted.Image = global::InvoiceCalculate.Properties.Resources.income_png;
            this.btnUnreceipted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnreceipted.Location = new System.Drawing.Point(-6, 0);
            this.btnUnreceipted.Name = "btnUnreceipted";
            this.btnUnreceipted.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUnreceipted.Size = new System.Drawing.Size(180, 44);
            this.btnUnreceipted.TabIndex = 2;
            this.btnUnreceipted.Text = "    GELİR";
            this.btnUnreceipted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnreceipted.UseVisualStyleBackColor = false;
            this.btnUnreceipted.Click += new System.EventHandler(this.btnUnreceipted_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnUnreceiptedAdd);
            this.panel10.Location = new System.Drawing.Point(3, 53);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(177, 30);
            this.panel10.TabIndex = 2;
            // 
            // btnUnreceiptedAdd
            // 
            this.btnUnreceiptedAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnUnreceiptedAdd.FlatAppearance.BorderSize = 0;
            this.btnUnreceiptedAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnreceiptedAdd.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnreceiptedAdd.ForeColor = System.Drawing.Color.White;
            this.btnUnreceiptedAdd.Image = global::InvoiceCalculate.Properties.Resources.circle_solid_12;
            this.btnUnreceiptedAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnreceiptedAdd.Location = new System.Drawing.Point(0, 0);
            this.btnUnreceiptedAdd.Name = "btnUnreceiptedAdd";
            this.btnUnreceiptedAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUnreceiptedAdd.Size = new System.Drawing.Size(177, 30);
            this.btnUnreceiptedAdd.TabIndex = 2;
            this.btnUnreceiptedAdd.Text = "   GELİR EKLE";
            this.btnUnreceiptedAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnreceiptedAdd.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnUnreceiptedArrange);
            this.panel11.Location = new System.Drawing.Point(3, 89);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(177, 30);
            this.panel11.TabIndex = 7;
            // 
            // btnUnreceiptedArrange
            // 
            this.btnUnreceiptedArrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnUnreceiptedArrange.FlatAppearance.BorderSize = 0;
            this.btnUnreceiptedArrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnreceiptedArrange.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnreceiptedArrange.ForeColor = System.Drawing.Color.White;
            this.btnUnreceiptedArrange.Image = global::InvoiceCalculate.Properties.Resources.circle_solid_12;
            this.btnUnreceiptedArrange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnreceiptedArrange.Location = new System.Drawing.Point(0, 0);
            this.btnUnreceiptedArrange.Name = "btnUnreceiptedArrange";
            this.btnUnreceiptedArrange.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUnreceiptedArrange.Size = new System.Drawing.Size(177, 30);
            this.btnUnreceiptedArrange.TabIndex = 2;
            this.btnUnreceiptedArrange.Text = "   GELİR DÜZENLE";
            this.btnUnreceiptedArrange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnreceiptedArrange.UseVisualStyleBackColor = false;
            // 
            // flpExpenseContainer
            // 
            this.flpExpenseContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.flpExpenseContainer.Controls.Add(this.panel5);
            this.flpExpenseContainer.Controls.Add(this.panel13);
            this.flpExpenseContainer.Controls.Add(this.panel14);
            this.flpExpenseContainer.Controls.Add(this.panel15);
            this.flpExpenseContainer.Location = new System.Drawing.Point(3, 368);
            this.flpExpenseContainer.MaximumSize = new System.Drawing.Size(180, 160);
            this.flpExpenseContainer.MinimumSize = new System.Drawing.Size(180, 44);
            this.flpExpenseContainer.Name = "flpExpenseContainer";
            this.flpExpenseContainer.Size = new System.Drawing.Size(180, 160);
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
            this.btnExpense.FlatAppearance.BorderSize = 0;
            this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpense.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpense.ForeColor = System.Drawing.Color.White;
            this.btnExpense.Image = global::InvoiceCalculate.Properties.Resources.credit_card_png;
            this.btnExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpense.Location = new System.Drawing.Point(-6, 0);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExpense.Size = new System.Drawing.Size(180, 44);
            this.btnExpense.TabIndex = 2;
            this.btnExpense.Text = "    HARCAMA";
            this.btnExpense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnExpenseHome);
            this.panel13.Location = new System.Drawing.Point(3, 53);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(177, 30);
            this.panel13.TabIndex = 2;
            // 
            // btnExpenseHome
            // 
            this.btnExpenseHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnExpenseHome.FlatAppearance.BorderSize = 0;
            this.btnExpenseHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseHome.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpenseHome.ForeColor = System.Drawing.Color.White;
            this.btnExpenseHome.Image = global::InvoiceCalculate.Properties.Resources.circle_solid_12;
            this.btnExpenseHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseHome.Location = new System.Drawing.Point(0, 0);
            this.btnExpenseHome.Name = "btnExpenseHome";
            this.btnExpenseHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExpenseHome.Size = new System.Drawing.Size(177, 30);
            this.btnExpenseHome.TabIndex = 2;
            this.btnExpenseHome.Text = "   EV";
            this.btnExpenseHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseHome.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnExpenseCar);
            this.panel14.Location = new System.Drawing.Point(3, 89);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(177, 30);
            this.panel14.TabIndex = 7;
            // 
            // btnExpenseCar
            // 
            this.btnExpenseCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnExpenseCar.FlatAppearance.BorderSize = 0;
            this.btnExpenseCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseCar.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpenseCar.ForeColor = System.Drawing.Color.White;
            this.btnExpenseCar.Image = global::InvoiceCalculate.Properties.Resources.circle_solid_12;
            this.btnExpenseCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseCar.Location = new System.Drawing.Point(0, 0);
            this.btnExpenseCar.Name = "btnExpenseCar";
            this.btnExpenseCar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExpenseCar.Size = new System.Drawing.Size(177, 30);
            this.btnExpenseCar.TabIndex = 2;
            this.btnExpenseCar.Text = "   ARABA";
            this.btnExpenseCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseCar.UseVisualStyleBackColor = false;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnExpenseArrange);
            this.panel15.Location = new System.Drawing.Point(3, 125);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(177, 30);
            this.panel15.TabIndex = 6;
            // 
            // btnExpenseArrange
            // 
            this.btnExpenseArrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnExpenseArrange.FlatAppearance.BorderSize = 0;
            this.btnExpenseArrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseArrange.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpenseArrange.ForeColor = System.Drawing.Color.White;
            this.btnExpenseArrange.Image = global::InvoiceCalculate.Properties.Resources.circle_solid_12;
            this.btnExpenseArrange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseArrange.Location = new System.Drawing.Point(0, 0);
            this.btnExpenseArrange.Name = "btnExpenseArrange";
            this.btnExpenseArrange.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExpenseArrange.Size = new System.Drawing.Size(177, 30);
            this.btnExpenseArrange.TabIndex = 2;
            this.btnExpenseArrange.Text = "   DÜZENLE";
            this.btnExpenseArrange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseArrange.UseVisualStyleBackColor = false;
            // 
            // tmrSideBar
            // 
            this.tmrSideBar.Interval = 8;
            this.tmrSideBar.Tick += new System.EventHandler(this.tmrSideBar_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Controls.Add(this.btnRestore);
            this.flowLayoutPanel1.Controls.Add(this.btnMinimize);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(180, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 30);
            this.flowLayoutPanel1.TabIndex = 4;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 680);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.flpUnreceiptedContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.flpExpenseContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInvoiceCreate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUnreceipted;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrSideBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpInvoiceContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnInvoiceArrange;
        private System.Windows.Forms.Timer tmrInvoice;
        private System.Windows.Forms.FlowLayoutPanel flpUnreceiptedContainer;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnUnreceiptedAdd;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnUnreceiptedArrange;
        private System.Windows.Forms.Timer tmrUnreceipted;
        private System.Windows.Forms.FlowLayoutPanel flpExpenseContainer;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnExpenseHome;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnExpenseCar;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnExpenseArrange;
        private System.Windows.Forms.Timer tmrExpense;
    }
}

