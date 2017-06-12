namespace Projekt.MS3.WinForms
{
    partial class Details
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDimensions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCoverRemove = new System.Windows.Forms.Button();
            this.btnCoverLoad = new System.Windows.Forms.Button();
            this.ofdCover = new System.Windows.Forms.OpenFileDialog();
            this.cbBinding = new System.Windows.Forms.ComboBox();
            this.numericPagesNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPagesNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(586, 20);
            this.txtTitle.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(99, 426);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(166, 20);
            this.txtISBN.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Ilość stron:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Wymiary:";
            // 
            // txtDimensions
            // 
            this.txtDimensions.Location = new System.Drawing.Point(99, 371);
            this.txtDimensions.Name = "txtDimensions";
            this.txtDimensions.Size = new System.Drawing.Size(137, 20);
            this.txtDimensions.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Oprawa:";
            // 
            // txtAuthors
            // 
            this.txtAuthors.Location = new System.Drawing.Point(99, 285);
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.Size = new System.Drawing.Size(166, 20);
            this.txtAuthors.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Autorzy:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(604, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(99, 317);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(166, 20);
            this.txtPublisher.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Wydawnictwo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Opis:";
            // 
            // txtDescription
            // 
            this.txtDescription.HideSelection = false;
            this.txtDescription.Location = new System.Drawing.Point(12, 64);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(586, 200);
            this.txtDescription.TabIndex = 32;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(675, 429);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Dodaj";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCoverRemove
            // 
            this.btnCoverRemove.Location = new System.Drawing.Point(721, 241);
            this.btnCoverRemove.Name = "btnCoverRemove";
            this.btnCoverRemove.Size = new System.Drawing.Size(23, 23);
            this.btnCoverRemove.TabIndex = 51;
            this.btnCoverRemove.Text = "X";
            this.btnCoverRemove.UseVisualStyleBackColor = true;
            this.btnCoverRemove.Click += new System.EventHandler(this.btnCoverRemove_Click);
            // 
            // btnCoverLoad
            // 
            this.btnCoverLoad.Location = new System.Drawing.Point(604, 241);
            this.btnCoverLoad.Name = "btnCoverLoad";
            this.btnCoverLoad.Size = new System.Drawing.Size(75, 23);
            this.btnCoverLoad.TabIndex = 52;
            this.btnCoverLoad.Text = "Wczytaj";
            this.btnCoverLoad.UseVisualStyleBackColor = true;
            this.btnCoverLoad.Click += new System.EventHandler(this.btnCoverLoad_Click);
            // 
            // ofdCover
            // 
            this.ofdCover.FileName = "openFileDialog1";
            this.ofdCover.Filter = "Obrazki|*.jpg;*.jpeg";
            // 
            // cbBinding
            // 
            this.cbBinding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBinding.FormattingEnabled = true;
            this.cbBinding.Items.AddRange(new object[] {
            "miękka",
            "twarda"});
            this.cbBinding.Location = new System.Drawing.Point(99, 343);
            this.cbBinding.Name = "cbBinding";
            this.cbBinding.Size = new System.Drawing.Size(166, 21);
            this.cbBinding.TabIndex = 53;
            // 
            // numericPagesNumber
            // 
            this.numericPagesNumber.Location = new System.Drawing.Point(99, 399);
            this.numericPagesNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPagesNumber.Name = "numericPagesNumber";
            this.numericPagesNumber.Size = new System.Drawing.Size(166, 20);
            this.numericPagesNumber.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tytuł";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericPagesNumber);
            this.Controls.Add(this.cbBinding);
            this.Controls.Add(this.btnCoverLoad);
            this.Controls.Add(this.btnCoverRemove);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDimensions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAuthors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Name = "Details";
            this.Text = "Dodawanie nowej książki";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPagesNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDimensions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuthors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCoverRemove;
        private System.Windows.Forms.Button btnCoverLoad;
        private System.Windows.Forms.OpenFileDialog ofdCover;
        private System.Windows.Forms.ComboBox cbBinding;
        private System.Windows.Forms.NumericUpDown numericPagesNumber;
        private System.Windows.Forms.Label label1;
    }
}