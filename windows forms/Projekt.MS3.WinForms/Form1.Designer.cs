namespace Projekt.MS3.WinForms
{
    partial class Form1
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
            this.gvBooksList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.gpBooksList = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthors = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBinding = new System.Windows.Forms.TextBox();
            this.txtDimensions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPagesNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchSimple = new System.Windows.Forms.TextBox();
            this.btnShowAdvancedSearch = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnAdvancedSearch = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchISBN = new System.Windows.Forms.TextBox();
            this.nudSearchPages = new System.Windows.Forms.NumericUpDown();
            this.cbSearchPagesType = new System.Windows.Forms.ComboBox();
            this.cbSearchBinding = new System.Windows.Forms.ComboBox();
            this.txtSearchPublisher = new System.Windows.Forms.TextBox();
            this.txtSearchAuthor = new System.Windows.Forms.TextBox();
            this.cbSearchBoth = new System.Windows.Forms.CheckBox();
            this.txtSearchQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpleSearch = new System.Windows.Forms.Button();
            this.panelListAndSearch = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooksList)).BeginInit();
            this.gpBooksList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearchPages)).BeginInit();
            this.panelListAndSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvBooksList
            // 
            this.gvBooksList.AllowUserToAddRows = false;
            this.gvBooksList.AllowUserToDeleteRows = false;
            this.gvBooksList.AllowUserToOrderColumns = true;
            this.gvBooksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvBooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBooksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.tytul});
            this.gvBooksList.Location = new System.Drawing.Point(6, 19);
            this.gvBooksList.MultiSelect = false;
            this.gvBooksList.Name = "gvBooksList";
            this.gvBooksList.ReadOnly = true;
            this.gvBooksList.RowHeadersVisible = false;
            this.gvBooksList.Size = new System.Drawing.Size(413, 130);
            this.gvBooksList.TabIndex = 0;
            this.gvBooksList.SelectionChanged += new System.EventHandler(this.gvBooksList_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // tytul
            // 
            this.tytul.HeaderText = "Tytuł";
            this.tytul.Name = "tytul";
            this.tytul.ReadOnly = true;
            this.tytul.Width = 57;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1222, 503);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 450;
            this.lineShape1.X2 = 450;
            this.lineShape1.Y1 = 10;
            this.lineShape1.Y2 = 425;
            // 
            // gpBooksList
            // 
            this.gpBooksList.Controls.Add(this.gvBooksList);
            this.gpBooksList.Location = new System.Drawing.Point(0, 7);
            this.gpBooksList.Name = "gpBooksList";
            this.gpBooksList.Size = new System.Drawing.Size(430, 160);
            this.gpBooksList.TabIndex = 3;
            this.gpBooksList.TabStop = false;
            this.gpBooksList.Text = "Lista książek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opis:";
            // 
            // txtDescription
            // 
            this.txtDescription.HideSelection = false;
            this.txtDescription.Location = new System.Drawing.Point(17, 28);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(586, 210);
            this.txtDescription.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wydawnictwo:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(101, 302);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(166, 20);
            this.txtPublisher.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(609, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.loginToolStripMenuItem.Text = "Zaloguj";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.closeToolStripMenuItem.Text = "Zamknij";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(509, 273);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(240, 23);
            this.btnEditBook.TabIndex = 10;
            this.btnEditBook.Text = "Edytuj zaznaczoną książkę";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Visible = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(509, 311);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(240, 23);
            this.btnDeleteBook.TabIndex = 11;
            this.btnDeleteBook.Text = "Usuń zaznaczoną książkę";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Visible = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(509, 349);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(240, 23);
            this.btnAddBook.TabIndex = 12;
            this.btnAddBook.Text = "Dodaj nową książkę";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Autorzy:";
            // 
            // txtAuthors
            // 
            this.txtAuthors.Location = new System.Drawing.Point(101, 270);
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.ReadOnly = true;
            this.txtAuthors.Size = new System.Drawing.Size(166, 20);
            this.txtAuthors.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Oprawa:";
            // 
            // txtBinding
            // 
            this.txtBinding.Location = new System.Drawing.Point(101, 329);
            this.txtBinding.Name = "txtBinding";
            this.txtBinding.ReadOnly = true;
            this.txtBinding.Size = new System.Drawing.Size(166, 20);
            this.txtBinding.TabIndex = 16;
            // 
            // txtDimensions
            // 
            this.txtDimensions.Location = new System.Drawing.Point(101, 356);
            this.txtDimensions.Name = "txtDimensions";
            this.txtDimensions.ReadOnly = true;
            this.txtDimensions.Size = new System.Drawing.Size(137, 20);
            this.txtDimensions.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Wymiary:";
            // 
            // txtPagesNumber
            // 
            this.txtPagesNumber.Location = new System.Drawing.Point(101, 383);
            this.txtPagesNumber.Name = "txtPagesNumber";
            this.txtPagesNumber.ReadOnly = true;
            this.txtPagesNumber.Size = new System.Drawing.Size(166, 20);
            this.txtPagesNumber.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ilość stron:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(101, 411);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(166, 20);
            this.txtISBN.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "ISBN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "mm";
            // 
            // txtSearchSimple
            // 
            this.txtSearchSimple.Location = new System.Drawing.Point(6, 171);
            this.txtSearchSimple.Name = "txtSearchSimple";
            this.txtSearchSimple.Size = new System.Drawing.Size(288, 20);
            this.txtSearchSimple.TabIndex = 26;
            this.txtSearchSimple.Enter += new System.EventHandler(this.txtSearchSimple_Enter);
            this.txtSearchSimple.Leave += new System.EventHandler(this.txtSearchSimple_Leave);
            // 
            // btnShowAdvancedSearch
            // 
            this.btnShowAdvancedSearch.Location = new System.Drawing.Point(6, 199);
            this.btnShowAdvancedSearch.Name = "btnShowAdvancedSearch";
            this.btnShowAdvancedSearch.Size = new System.Drawing.Size(413, 23);
            this.btnShowAdvancedSearch.TabIndex = 27;
            this.btnShowAdvancedSearch.Text = "Rozwiń szukanie zaawansowane";
            this.btnShowAdvancedSearch.UseVisualStyleBackColor = true;
            this.btnShowAdvancedSearch.Click += new System.EventHandler(this.btnShowAdvancedSearch_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnAdvancedSearch);
            this.panelSearch.Controls.Add(this.label15);
            this.panelSearch.Controls.Add(this.label14);
            this.panelSearch.Controls.Add(this.label13);
            this.panelSearch.Controls.Add(this.label12);
            this.panelSearch.Controls.Add(this.label11);
            this.panelSearch.Controls.Add(this.label6);
            this.panelSearch.Controls.Add(this.txtSearchISBN);
            this.panelSearch.Controls.Add(this.nudSearchPages);
            this.panelSearch.Controls.Add(this.cbSearchPagesType);
            this.panelSearch.Controls.Add(this.cbSearchBinding);
            this.panelSearch.Controls.Add(this.txtSearchPublisher);
            this.panelSearch.Controls.Add(this.txtSearchAuthor);
            this.panelSearch.Controls.Add(this.cbSearchBoth);
            this.panelSearch.Controls.Add(this.txtSearchQuery);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Location = new System.Drawing.Point(6, 228);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(413, 230);
            this.panelSearch.TabIndex = 28;
            this.panelSearch.Visible = false;
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.Location = new System.Drawing.Point(6, 198);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(391, 23);
            this.btnAdvancedSearch.TabIndex = 15;
            this.btnAdvancedSearch.Text = "Szukaj";
            this.btnAdvancedSearch.UseVisualStyleBackColor = true;
            this.btnAdvancedSearch.Click += new System.EventHandler(this.btnAdvancedSearch_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "(pomija poprzednie pola)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "ISBN:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ilość stron:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Oprawa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Wydawnictwo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Autor:";
            // 
            // txtSearchISBN
            // 
            this.txtSearchISBN.Location = new System.Drawing.Point(132, 157);
            this.txtSearchISBN.Name = "txtSearchISBN";
            this.txtSearchISBN.Size = new System.Drawing.Size(265, 20);
            this.txtSearchISBN.TabIndex = 8;
            // 
            // nudSearchPages
            // 
            this.nudSearchPages.Location = new System.Drawing.Point(177, 131);
            this.nudSearchPages.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSearchPages.Name = "nudSearchPages";
            this.nudSearchPages.Size = new System.Drawing.Size(220, 20);
            this.nudSearchPages.TabIndex = 7;
            // 
            // cbSearchPagesType
            // 
            this.cbSearchPagesType.FormattingEnabled = true;
            this.cbSearchPagesType.Items.AddRange(new object[] {
            "<",
            "=",
            ">"});
            this.cbSearchPagesType.Location = new System.Drawing.Point(132, 129);
            this.cbSearchPagesType.Name = "cbSearchPagesType";
            this.cbSearchPagesType.Size = new System.Drawing.Size(39, 21);
            this.cbSearchPagesType.TabIndex = 6;
            // 
            // cbSearchBinding
            // 
            this.cbSearchBinding.FormattingEnabled = true;
            this.cbSearchBinding.Items.AddRange(new object[] {
            "dowolna",
            "miękka",
            "twarda"});
            this.cbSearchBinding.Location = new System.Drawing.Point(132, 104);
            this.cbSearchBinding.Name = "cbSearchBinding";
            this.cbSearchBinding.Size = new System.Drawing.Size(265, 21);
            this.cbSearchBinding.TabIndex = 5;
            // 
            // txtSearchPublisher
            // 
            this.txtSearchPublisher.Location = new System.Drawing.Point(132, 78);
            this.txtSearchPublisher.Name = "txtSearchPublisher";
            this.txtSearchPublisher.Size = new System.Drawing.Size(265, 20);
            this.txtSearchPublisher.TabIndex = 4;
            // 
            // txtSearchAuthor
            // 
            this.txtSearchAuthor.Location = new System.Drawing.Point(132, 52);
            this.txtSearchAuthor.Name = "txtSearchAuthor";
            this.txtSearchAuthor.Size = new System.Drawing.Size(265, 20);
            this.txtSearchAuthor.TabIndex = 3;
            // 
            // cbSearchBoth
            // 
            this.cbSearchBoth.AutoSize = true;
            this.cbSearchBoth.Location = new System.Drawing.Point(132, 29);
            this.cbSearchBoth.Name = "cbSearchBoth";
            this.cbSearchBoth.Size = new System.Drawing.Size(130, 17);
            this.cbSearchBoth.TabIndex = 2;
            this.cbSearchBoth.Text = "szukaj w tytule i opisie";
            this.cbSearchBoth.UseVisualStyleBackColor = true;
            // 
            // txtSearchQuery
            // 
            this.txtSearchQuery.Location = new System.Drawing.Point(132, 4);
            this.txtSearchQuery.Name = "txtSearchQuery";
            this.txtSearchQuery.Size = new System.Drawing.Size(265, 20);
            this.txtSearchQuery.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szukany tekst:";
            // 
            // btnSimpleSearch
            // 
            this.btnSimpleSearch.Location = new System.Drawing.Point(300, 170);
            this.btnSimpleSearch.Name = "btnSimpleSearch";
            this.btnSimpleSearch.Size = new System.Drawing.Size(119, 23);
            this.btnSimpleSearch.TabIndex = 29;
            this.btnSimpleSearch.Text = "Szukaj";
            this.btnSimpleSearch.UseVisualStyleBackColor = true;
            this.btnSimpleSearch.Click += new System.EventHandler(this.btnSimpleSearch_Click);
            // 
            // panelListAndSearch
            // 
            this.panelListAndSearch.Controls.Add(this.btnSimpleSearch);
            this.panelListAndSearch.Controls.Add(this.panelSearch);
            this.panelListAndSearch.Controls.Add(this.btnShowAdvancedSearch);
            this.panelListAndSearch.Controls.Add(this.txtSearchSimple);
            this.panelListAndSearch.Controls.Add(this.gpBooksList);
            this.panelListAndSearch.Location = new System.Drawing.Point(13, 23);
            this.panelListAndSearch.Name = "panelListAndSearch";
            this.panelListAndSearch.Size = new System.Drawing.Size(433, 470);
            this.panelListAndSearch.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtISBN);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPagesNumber);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDimensions);
            this.panel2.Controls.Add(this.txtBinding);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAuthors);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnAddBook);
            this.panel2.Controls.Add(this.btnDeleteBook);
            this.panel2.Controls.Add(this.btnEditBook);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtPublisher);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Location = new System.Drawing.Point(452, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 470);
            this.panel2.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelListAndSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mini biblioteka";
            ((System.ComponentModel.ISupportInitialize)(this.gvBooksList)).EndInit();
            this.gpBooksList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearchPages)).EndInit();
            this.panelListAndSearch.ResumeLayout(false);
            this.panelListAndSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBooksList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytul;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox gpBooksList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBinding;
        private System.Windows.Forms.TextBox txtDimensions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPagesNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchSimple;
        private System.Windows.Forms.Button btnShowAdvancedSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnSimpleSearch;
        private System.Windows.Forms.TextBox txtSearchAuthor;
        private System.Windows.Forms.CheckBox cbSearchBoth;
        private System.Windows.Forms.TextBox txtSearchQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchISBN;
        private System.Windows.Forms.NumericUpDown nudSearchPages;
        private System.Windows.Forms.ComboBox cbSearchPagesType;
        private System.Windows.Forms.ComboBox cbSearchBinding;
        private System.Windows.Forms.TextBox txtSearchPublisher;
        private System.Windows.Forms.Button btnAdvancedSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelListAndSearch;
        private System.Windows.Forms.Panel panel2;

    }
}

