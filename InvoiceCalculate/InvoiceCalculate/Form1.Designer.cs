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
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.flpInvoiceContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.ıconButton4 = new FontAwesome.Sharp.IconButton();
            this.flpUnreceiptedContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ıconButton5 = new FontAwesome.Sharp.IconButton();
            this.ıconButton6 = new FontAwesome.Sharp.IconButton();
            this.ıconButton7 = new FontAwesome.Sharp.IconButton();
            this.flpExpenseContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ıconButton8 = new FontAwesome.Sharp.IconButton();
            this.ıconButton9 = new FontAwesome.Sharp.IconButton();
            this.ıconButton10 = new FontAwesome.Sharp.IconButton();
            this.ıconButton11 = new FontAwesome.Sharp.IconButton();
            this.btnExpenseArrange = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUnreceipted = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnExpenseHome = new System.Windows.Forms.Button();
            this.btnExpenseCar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInvoiceCreate = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnInvoiceArrange = new System.Windows.Forms.Button();
            this.tmrSideBar = new System.Windows.Forms.Timer(this.components);
            this.flpOptionBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.tmrInvoice = new System.Windows.Forms.Timer(this.components);
            this.tmrUnreceipted = new System.Windows.Forms.Timer(this.components);
            this.tmrExpense = new System.Windows.Forms.Timer(this.components);
            this.ıconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.btnUnreceiptedArrange = new System.Windows.Forms.Button();
            this.btnUnreceiptedAdd = new System.Windows.Forms.Button();
            this.flpSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.flpInvoiceContainer.SuspendLayout();
            this.flpUnreceiptedContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flpExpenseContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.panel2.Controls.Add(this.ıconButton3);
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 44);
            this.panel2.TabIndex = 1;
            // 
            // ıconButton3
            // 
            this.ıconButton3.FlatAppearance.BorderSize = 0;
            this.ıconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton3.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold);
            this.ıconButton3.ForeColor = System.Drawing.Color.White;
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.ıconButton3.IconColor = System.Drawing.Color.White;
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.IconSize = 30;
            this.ıconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.Location = new System.Drawing.Point(3, 0);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(174, 44);
            this.ıconButton3.TabIndex = 8;
            this.ıconButton3.Text = "ANA SAYFA";
            this.ıconButton3.UseVisualStyleBackColor = true;
            // 
            // flpInvoiceContainer
            // 
            this.flpInvoiceContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.flpInvoiceContainer.Controls.Add(this.ıconButton1);
            this.flpInvoiceContainer.Controls.Add(this.ıconButton2);
            this.flpInvoiceContainer.Controls.Add(this.ıconButton4);
            this.flpInvoiceContainer.Location = new System.Drawing.Point(3, 111);
            this.flpInvoiceContainer.MaximumSize = new System.Drawing.Size(180, 120);
            this.flpInvoiceContainer.MinimumSize = new System.Drawing.Size(180, 44);
            this.flpInvoiceContainer.Name = "flpInvoiceContainer";
            this.flpInvoiceContainer.Size = new System.Drawing.Size(180, 120);
            this.flpInvoiceContainer.TabIndex = 5;
            // 
            // ıconButton1
            // 
            this.ıconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ıconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold);
            this.ıconButton1.ForeColor = System.Drawing.Color.White;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.ıconButton1.IconColor = System.Drawing.Color.White;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.IconSize = 30;
            this.ıconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.Location = new System.Drawing.Point(3, 3);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(174, 44);
            this.ıconButton1.TabIndex = 8;
            this.ıconButton1.Text = "FATURA";
            this.ıconButton1.UseVisualStyleBackColor = false;
            // 
            // ıconButton2
            // 
            this.ıconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton2.FlatAppearance.BorderSize = 0;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.ıconButton2.ForeColor = System.Drawing.Color.White;
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.ıconButton2.IconColor = System.Drawing.Color.White;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.IconSize = 24;
            this.ıconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.Location = new System.Drawing.Point(3, 53);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(177, 30);
            this.ıconButton2.TabIndex = 8;
            this.ıconButton2.Text = "FATURA KES";
            this.ıconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton2.UseVisualStyleBackColor = true;
            // 
            // ıconButton4
            // 
            this.ıconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton4.FlatAppearance.BorderSize = 0;
            this.ıconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton4.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.ıconButton4.ForeColor = System.Drawing.Color.White;
            this.ıconButton4.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.ıconButton4.IconColor = System.Drawing.Color.White;
            this.ıconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton4.IconSize = 24;
            this.ıconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton4.Location = new System.Drawing.Point(3, 89);
            this.ıconButton4.Name = "ıconButton4";
            this.ıconButton4.Size = new System.Drawing.Size(177, 30);
            this.ıconButton4.TabIndex = 8;
            this.ıconButton4.Text = "FATURA DÜZENLE";
            this.ıconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton4.UseVisualStyleBackColor = true;
            // 
            // flpUnreceiptedContainer
            // 
            this.flpUnreceiptedContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.flpUnreceiptedContainer.Controls.Add(this.panel4);
            this.flpUnreceiptedContainer.Controls.Add(this.ıconButton6);
            this.flpUnreceiptedContainer.Controls.Add(this.ıconButton7);
            this.flpUnreceiptedContainer.Location = new System.Drawing.Point(3, 237);
            this.flpUnreceiptedContainer.MaximumSize = new System.Drawing.Size(180, 120);
            this.flpUnreceiptedContainer.MinimumSize = new System.Drawing.Size(180, 44);
            this.flpUnreceiptedContainer.Name = "flpUnreceiptedContainer";
            this.flpUnreceiptedContainer.Size = new System.Drawing.Size(180, 120);
            this.flpUnreceiptedContainer.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ıconButton5);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 44);
            this.panel4.TabIndex = 3;
            // 
            // ıconButton5
            // 
            this.ıconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ıconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton5.FlatAppearance.BorderSize = 0;
            this.ıconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton5.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold);
            this.ıconButton5.ForeColor = System.Drawing.Color.White;
            this.ıconButton5.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.ıconButton5.IconColor = System.Drawing.Color.White;
            this.ıconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton5.IconSize = 30;
            this.ıconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton5.Location = new System.Drawing.Point(0, 0);
            this.ıconButton5.Name = "ıconButton5";
            this.ıconButton5.Size = new System.Drawing.Size(177, 44);
            this.ıconButton5.TabIndex = 9;
            this.ıconButton5.Text = "GELİR";
            this.ıconButton5.UseVisualStyleBackColor = false;
            // 
            // ıconButton6
            // 
            this.ıconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton6.FlatAppearance.BorderSize = 0;
            this.ıconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton6.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.ıconButton6.ForeColor = System.Drawing.Color.White;
            this.ıconButton6.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.ıconButton6.IconColor = System.Drawing.Color.White;
            this.ıconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton6.IconSize = 24;
            this.ıconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton6.Location = new System.Drawing.Point(3, 53);
            this.ıconButton6.Name = "ıconButton6";
            this.ıconButton6.Size = new System.Drawing.Size(177, 30);
            this.ıconButton6.TabIndex = 9;
            this.ıconButton6.Text = "GELİR EKLE";
            this.ıconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton6.UseVisualStyleBackColor = true;
            // 
            // ıconButton7
            // 
            this.ıconButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton7.FlatAppearance.BorderSize = 0;
            this.ıconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton7.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.ıconButton7.ForeColor = System.Drawing.Color.White;
            this.ıconButton7.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.ıconButton7.IconColor = System.Drawing.Color.White;
            this.ıconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton7.IconSize = 24;
            this.ıconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton7.Location = new System.Drawing.Point(3, 89);
            this.ıconButton7.Name = "ıconButton7";
            this.ıconButton7.Size = new System.Drawing.Size(177, 30);
            this.ıconButton7.TabIndex = 10;
            this.ıconButton7.Text = "GELİR DÜZENLE";
            this.ıconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton7.UseVisualStyleBackColor = true;
            // 
            // flpExpenseContainer
            // 
            this.flpExpenseContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.flpExpenseContainer.Controls.Add(this.panel5);
            this.flpExpenseContainer.Controls.Add(this.ıconButton9);
            this.flpExpenseContainer.Controls.Add(this.ıconButton10);
            this.flpExpenseContainer.Controls.Add(this.ıconButton11);
            this.flpExpenseContainer.Location = new System.Drawing.Point(3, 363);
            this.flpExpenseContainer.MaximumSize = new System.Drawing.Size(180, 160);
            this.flpExpenseContainer.MinimumSize = new System.Drawing.Size(180, 44);
            this.flpExpenseContainer.Name = "flpExpenseContainer";
            this.flpExpenseContainer.Size = new System.Drawing.Size(180, 160);
            this.flpExpenseContainer.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ıconButton8);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 44);
            this.panel5.TabIndex = 4;
            // 
            // ıconButton8
            // 
            this.ıconButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ıconButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton8.FlatAppearance.BorderSize = 0;
            this.ıconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton8.Font = new System.Drawing.Font("RomanD", 9.75F, System.Drawing.FontStyle.Bold);
            this.ıconButton8.ForeColor = System.Drawing.Color.White;
            this.ıconButton8.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.ıconButton8.IconColor = System.Drawing.Color.White;
            this.ıconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton8.IconSize = 30;
            this.ıconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton8.Location = new System.Drawing.Point(0, 0);
            this.ıconButton8.Name = "ıconButton8";
            this.ıconButton8.Size = new System.Drawing.Size(177, 44);
            this.ıconButton8.TabIndex = 10;
            this.ıconButton8.Text = "HARCAMA";
            this.ıconButton8.UseVisualStyleBackColor = false;
            // 
            // ıconButton9
            // 
            this.ıconButton9.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton9.FlatAppearance.BorderSize = 0;
            this.ıconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton9.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.ıconButton9.ForeColor = System.Drawing.Color.White;
            this.ıconButton9.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.ıconButton9.IconColor = System.Drawing.Color.White;
            this.ıconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton9.IconSize = 24;
            this.ıconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton9.Location = new System.Drawing.Point(3, 53);
            this.ıconButton9.Name = "ıconButton9";
            this.ıconButton9.Size = new System.Drawing.Size(177, 30);
            this.ıconButton9.TabIndex = 10;
            this.ıconButton9.Text = "GİDER / EV";
            this.ıconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton9.UseVisualStyleBackColor = true;
            // 
            // ıconButton10
            // 
            this.ıconButton10.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton10.FlatAppearance.BorderSize = 0;
            this.ıconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton10.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.ıconButton10.ForeColor = System.Drawing.Color.White;
            this.ıconButton10.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.ıconButton10.IconColor = System.Drawing.Color.White;
            this.ıconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton10.IconSize = 24;
            this.ıconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton10.Location = new System.Drawing.Point(3, 89);
            this.ıconButton10.Name = "ıconButton10";
            this.ıconButton10.Size = new System.Drawing.Size(177, 30);
            this.ıconButton10.TabIndex = 11;
            this.ıconButton10.Text = "GİDER / ARABA";
            this.ıconButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton10.UseVisualStyleBackColor = true;
            // 
            // ıconButton11
            // 
            this.ıconButton11.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton11.FlatAppearance.BorderSize = 0;
            this.ıconButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton11.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold);
            this.ıconButton11.ForeColor = System.Drawing.Color.White;
            this.ıconButton11.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.ıconButton11.IconColor = System.Drawing.Color.White;
            this.ıconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton11.IconSize = 24;
            this.ıconButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton11.Location = new System.Drawing.Point(3, 125);
            this.ıconButton11.Name = "ıconButton11";
            this.ıconButton11.Size = new System.Drawing.Size(177, 30);
            this.ıconButton11.TabIndex = 12;
            this.ıconButton11.Text = "GİDER DÜZENLE";
            this.ıconButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton11.UseVisualStyleBackColor = true;
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
            this.btnExpenseArrange.Location = new System.Drawing.Point(754, 452);
            this.btnExpenseArrange.Name = "btnExpenseArrange";
            this.btnExpenseArrange.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExpenseArrange.Size = new System.Drawing.Size(177, 30);
            this.btnExpenseArrange.TabIndex = 2;
            this.btnExpenseArrange.Text = "   DÜZENLE";
            this.btnExpenseArrange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseArrange.UseVisualStyleBackColor = false;
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
            this.btnHome.Location = new System.Drawing.Point(581, 187);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(180, 44);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "    ANA SAYFA";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
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
            this.btnUnreceipted.Location = new System.Drawing.Point(431, 318);
            this.btnUnreceipted.Name = "btnUnreceipted";
            this.btnUnreceipted.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUnreceipted.Size = new System.Drawing.Size(180, 44);
            this.btnUnreceipted.TabIndex = 2;
            this.btnUnreceipted.Text = "    GELİR";
            this.btnUnreceipted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnreceipted.UseVisualStyleBackColor = false;
            this.btnUnreceipted.Click += new System.EventHandler(this.btnUnreceipted_Click);
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
            this.btnExpense.Location = new System.Drawing.Point(495, 416);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExpense.Size = new System.Drawing.Size(180, 44);
            this.btnExpense.TabIndex = 2;
            this.btnExpense.Text = "    HARCAMA";
            this.btnExpense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
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
            this.btnExpenseHome.Location = new System.Drawing.Point(722, 318);
            this.btnExpenseHome.Name = "btnExpenseHome";
            this.btnExpenseHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExpenseHome.Size = new System.Drawing.Size(177, 30);
            this.btnExpenseHome.TabIndex = 2;
            this.btnExpenseHome.Text = "   EV";
            this.btnExpenseHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseHome.UseVisualStyleBackColor = false;
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
            this.btnExpenseCar.Location = new System.Drawing.Point(768, 395);
            this.btnExpenseCar.Name = "btnExpenseCar";
            this.btnExpenseCar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExpenseCar.Size = new System.Drawing.Size(177, 30);
            this.btnExpenseCar.TabIndex = 2;
            this.btnExpenseCar.Text = "   ARABA";
            this.btnExpenseCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseCar.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnInvoice);
            this.panel6.Location = new System.Drawing.Point(483, 111);
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
            this.btnInvoice.Location = new System.Drawing.Point(12, 0);
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
            this.panel3.Location = new System.Drawing.Point(319, 209);
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
            this.panel8.Location = new System.Drawing.Point(251, 136);
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
            this.btnInvoiceArrange.Location = new System.Drawing.Point(3, 3);
            this.btnInvoiceArrange.Name = "btnInvoiceArrange";
            this.btnInvoiceArrange.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInvoiceArrange.Size = new System.Drawing.Size(177, 30);
            this.btnInvoiceArrange.TabIndex = 2;
            this.btnInvoiceArrange.Text = "   FATURA DÜZENLE";
            this.btnInvoiceArrange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoiceArrange.UseVisualStyleBackColor = false;
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
            // btnUnreceiptedArrange
            // 
            this.btnUnreceiptedArrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnUnreceiptedArrange.FlatAppearance.BorderSize = 0;
            this.btnUnreceiptedArrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnreceiptedArrange.Font = new System.Drawing.Font("RomanD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnreceiptedArrange.ForeColor = System.Drawing.Color.White;
            this.btnUnreceiptedArrange.Image = global::InvoiceCalculate.Properties.Resources.circle_solid_12;
            this.btnUnreceiptedArrange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnreceiptedArrange.Location = new System.Drawing.Point(251, 374);
            this.btnUnreceiptedArrange.Name = "btnUnreceiptedArrange";
            this.btnUnreceiptedArrange.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUnreceiptedArrange.Size = new System.Drawing.Size(177, 30);
            this.btnUnreceiptedArrange.TabIndex = 2;
            this.btnUnreceiptedArrange.Text = "   GELİR DÜZENLE";
            this.btnUnreceiptedArrange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnreceiptedArrange.UseVisualStyleBackColor = false;
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
            this.btnUnreceiptedAdd.Location = new System.Drawing.Point(254, 332);
            this.btnUnreceiptedAdd.Name = "btnUnreceiptedAdd";
            this.btnUnreceiptedAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUnreceiptedAdd.Size = new System.Drawing.Size(177, 30);
            this.btnUnreceiptedAdd.TabIndex = 2;
            this.btnUnreceiptedAdd.Text = "   GELİR EKLE";
            this.btnUnreceiptedAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnreceiptedAdd.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 680);
            this.Controls.Add(this.btnExpenseArrange);
            this.Controls.Add(this.btnExpenseCar);
            this.Controls.Add(this.btnExpenseHome);
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.btnUnreceiptedArrange);
            this.Controls.Add(this.btnUnreceiptedAdd);
            this.Controls.Add(this.btnUnreceipted);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
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
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.flpOptionBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSideBar;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.FlowLayoutPanel flpOptionBar;
        private System.Windows.Forms.FlowLayoutPanel flpInvoiceContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnInvoiceArrange;
        private System.Windows.Forms.Timer tmrInvoice;
        private System.Windows.Forms.FlowLayoutPanel flpUnreceiptedContainer;
        private System.Windows.Forms.Timer tmrUnreceipted;
        private System.Windows.Forms.FlowLayoutPanel flpExpenseContainer;
        private System.Windows.Forms.Button btnExpenseHome;
        private System.Windows.Forms.Button btnExpenseCar;
        private System.Windows.Forms.Button btnExpenseArrange;
        private System.Windows.Forms.Timer tmrExpense;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconDropDownButton ıconDropDownButton1;
        private FontAwesome.Sharp.IconButton ıconButton4;
        private FontAwesome.Sharp.IconButton ıconButton5;
        private FontAwesome.Sharp.IconButton ıconButton6;
        private FontAwesome.Sharp.IconButton ıconButton7;
        private FontAwesome.Sharp.IconButton ıconButton8;
        private System.Windows.Forms.Button btnUnreceiptedArrange;
        private System.Windows.Forms.Button btnUnreceiptedAdd;
        private FontAwesome.Sharp.IconButton ıconButton9;
        private FontAwesome.Sharp.IconButton ıconButton10;
        private FontAwesome.Sharp.IconButton ıconButton11;
    }
}

