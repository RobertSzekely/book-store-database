namespace BookStoreDatabase
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookTitleBox = new System.Windows.Forms.TextBox();
            this.pubDateBox = new System.Windows.Forms.TextBox();
            this.publisherIDBox = new System.Windows.Forms.TextBox();
            this.languageBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addBookRecordButton = new System.Windows.Forms.Button();
            this.publishersDataGrid = new System.Windows.Forms.DataGridView();
            this.prevPubButton = new System.Windows.Forms.Button();
            this.nexPubtButton = new System.Windows.Forms.Button();
            this.lastPubButton = new System.Windows.Forms.Button();
            this.firstPubButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pubNameBox = new System.Windows.Forms.TextBox();
            this.pubCityBox = new System.Windows.Forms.TextBox();
            this.pubCountryBox = new System.Windows.Forms.TextBox();
            this.booksDataGrid = new System.Windows.Forms.DataGridView();
            this.nextBookButton = new System.Windows.Forms.Button();
            this.prevBookButton = new System.Windows.Forms.Button();
            this.firstBookButton = new System.Windows.Forms.Button();
            this.lastBookButton = new System.Windows.Forms.Button();
            this.addPubRecord = new System.Windows.Forms.Button();
            this.refreshPubButton = new System.Windows.Forms.Button();
            this.refreshBooksButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.publishersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(749, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Publication Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publisher ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(749, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Language:";
            // 
            // bookTitleBox
            // 
            this.bookTitleBox.Location = new System.Drawing.Point(881, 76);
            this.bookTitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookTitleBox.Name = "bookTitleBox";
            this.bookTitleBox.Size = new System.Drawing.Size(490, 26);
            this.bookTitleBox.TabIndex = 4;
            // 
            // pubDateBox
            // 
            this.pubDateBox.Location = new System.Drawing.Point(881, 115);
            this.pubDateBox.Margin = new System.Windows.Forms.Padding(2);
            this.pubDateBox.Name = "pubDateBox";
            this.pubDateBox.Size = new System.Drawing.Size(490, 26);
            this.pubDateBox.TabIndex = 5;
            // 
            // publisherIDBox
            // 
            this.publisherIDBox.Location = new System.Drawing.Point(881, 157);
            this.publisherIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.publisherIDBox.Name = "publisherIDBox";
            this.publisherIDBox.Size = new System.Drawing.Size(490, 26);
            this.publisherIDBox.TabIndex = 6;
            // 
            // languageBox
            // 
            this.languageBox.Location = new System.Drawing.Point(881, 197);
            this.languageBox.Margin = new System.Windows.Forms.Padding(2);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(490, 26);
            this.languageBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(749, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add a book to the database:";
            // 
            // addBookRecordButton
            // 
            this.addBookRecordButton.Location = new System.Drawing.Point(749, 239);
            this.addBookRecordButton.Margin = new System.Windows.Forms.Padding(2);
            this.addBookRecordButton.Name = "addBookRecordButton";
            this.addBookRecordButton.Size = new System.Drawing.Size(130, 37);
            this.addBookRecordButton.TabIndex = 9;
            this.addBookRecordButton.Text = "Add Record";
            this.addBookRecordButton.UseVisualStyleBackColor = true;
            this.addBookRecordButton.Click += new System.EventHandler(this.addBookRecordButton_Click);
            // 
            // publishersDataGrid
            // 
            this.publishersDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.publishersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publishersDataGrid.Location = new System.Drawing.Point(42, 291);
            this.publishersDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.publishersDataGrid.Name = "publishersDataGrid";
            this.publishersDataGrid.RowTemplate.Height = 31;
            this.publishersDataGrid.Size = new System.Drawing.Size(687, 636);
            this.publishersDataGrid.TabIndex = 10;
            // 
            // prevPubButton
            // 
            this.prevPubButton.Location = new System.Drawing.Point(247, 947);
            this.prevPubButton.Margin = new System.Windows.Forms.Padding(2);
            this.prevPubButton.Name = "prevPubButton";
            this.prevPubButton.Size = new System.Drawing.Size(102, 38);
            this.prevPubButton.TabIndex = 13;
            this.prevPubButton.Text = "Previous";
            this.prevPubButton.UseVisualStyleBackColor = true;
            this.prevPubButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nexPubtButton
            // 
            this.nexPubtButton.Location = new System.Drawing.Point(364, 947);
            this.nexPubtButton.Margin = new System.Windows.Forms.Padding(2);
            this.nexPubtButton.Name = "nexPubtButton";
            this.nexPubtButton.Size = new System.Drawing.Size(109, 38);
            this.nexPubtButton.TabIndex = 14;
            this.nexPubtButton.Text = "Next";
            this.nexPubtButton.UseVisualStyleBackColor = true;
            this.nexPubtButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lastPubButton
            // 
            this.lastPubButton.Location = new System.Drawing.Point(488, 947);
            this.lastPubButton.Margin = new System.Windows.Forms.Padding(2);
            this.lastPubButton.Name = "lastPubButton";
            this.lastPubButton.Size = new System.Drawing.Size(118, 38);
            this.lastPubButton.TabIndex = 15;
            this.lastPubButton.Text = "Last";
            this.lastPubButton.UseVisualStyleBackColor = true;
            this.lastPubButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // firstPubButton
            // 
            this.firstPubButton.Location = new System.Drawing.Point(136, 947);
            this.firstPubButton.Margin = new System.Windows.Forms.Padding(2);
            this.firstPubButton.Name = "firstPubButton";
            this.firstPubButton.Size = new System.Drawing.Size(96, 38);
            this.firstPubButton.TabIndex = 16;
            this.firstPubButton.Text = "First";
            this.firstPubButton.UseVisualStyleBackColor = true;
            this.firstPubButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 1007);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Add a publisher to the database:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "City:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Country:";
            // 
            // pubNameBox
            // 
            this.pubNameBox.Location = new System.Drawing.Point(124, 82);
            this.pubNameBox.Name = "pubNameBox";
            this.pubNameBox.Size = new System.Drawing.Size(494, 26);
            this.pubNameBox.TabIndex = 24;
            // 
            // pubCityBox
            // 
            this.pubCityBox.Location = new System.Drawing.Point(124, 120);
            this.pubCityBox.Name = "pubCityBox";
            this.pubCityBox.Size = new System.Drawing.Size(494, 26);
            this.pubCityBox.TabIndex = 25;
            // 
            // pubCountryBox
            // 
            this.pubCountryBox.Location = new System.Drawing.Point(124, 162);
            this.pubCountryBox.Name = "pubCountryBox";
            this.pubCountryBox.Size = new System.Drawing.Size(494, 26);
            this.pubCountryBox.TabIndex = 26;
            // 
            // booksDataGrid
            // 
            this.booksDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.booksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGrid.Location = new System.Drawing.Point(749, 291);
            this.booksDataGrid.Name = "booksDataGrid";
            this.booksDataGrid.RowTemplate.Height = 28;
            this.booksDataGrid.Size = new System.Drawing.Size(695, 636);
            this.booksDataGrid.TabIndex = 28;
            // 
            // nextBookButton
            // 
            this.nextBookButton.Location = new System.Drawing.Point(1111, 947);
            this.nextBookButton.Name = "nextBookButton";
            this.nextBookButton.Size = new System.Drawing.Size(121, 39);
            this.nextBookButton.TabIndex = 30;
            this.nextBookButton.Text = "Next";
            this.nextBookButton.UseVisualStyleBackColor = true;
            this.nextBookButton.Click += new System.EventHandler(this.nextBook_Click);
            // 
            // prevBookButton
            // 
            this.prevBookButton.Location = new System.Drawing.Point(975, 947);
            this.prevBookButton.Name = "prevBookButton";
            this.prevBookButton.Size = new System.Drawing.Size(121, 39);
            this.prevBookButton.TabIndex = 31;
            this.prevBookButton.Text = "Previous";
            this.prevBookButton.UseVisualStyleBackColor = true;
            this.prevBookButton.Click += new System.EventHandler(this.prevBook_Click);
            // 
            // firstBookButton
            // 
            this.firstBookButton.Location = new System.Drawing.Point(838, 947);
            this.firstBookButton.Name = "firstBookButton";
            this.firstBookButton.Size = new System.Drawing.Size(121, 39);
            this.firstBookButton.TabIndex = 32;
            this.firstBookButton.Text = "First";
            this.firstBookButton.UseVisualStyleBackColor = true;
            this.firstBookButton.Click += new System.EventHandler(this.firstBookButton_Click);
            // 
            // lastBookButton
            // 
            this.lastBookButton.Location = new System.Drawing.Point(1250, 947);
            this.lastBookButton.Name = "lastBookButton";
            this.lastBookButton.Size = new System.Drawing.Size(121, 39);
            this.lastBookButton.TabIndex = 33;
            this.lastBookButton.Text = "Last";
            this.lastBookButton.UseVisualStyleBackColor = true;
            this.lastBookButton.Click += new System.EventHandler(this.lastBookButton_Click);
            // 
            // addPubRecord
            // 
            this.addPubRecord.Location = new System.Drawing.Point(42, 239);
            this.addPubRecord.Name = "addPubRecord";
            this.addPubRecord.Size = new System.Drawing.Size(129, 37);
            this.addPubRecord.TabIndex = 34;
            this.addPubRecord.Text = "Add Record";
            this.addPubRecord.UseVisualStyleBackColor = true;
            this.addPubRecord.Click += new System.EventHandler(this.addPubRecord_Click);
            // 
            // refreshPubButton
            // 
            this.refreshPubButton.Location = new System.Drawing.Point(190, 239);
            this.refreshPubButton.Name = "refreshPubButton";
            this.refreshPubButton.Size = new System.Drawing.Size(129, 37);
            this.refreshPubButton.TabIndex = 35;
            this.refreshPubButton.Text = "Refresh";
            this.refreshPubButton.UseVisualStyleBackColor = true;
            this.refreshPubButton.Click += new System.EventHandler(this.refreshPubButton_Click);
            // 
            // refreshBooksButton
            // 
            this.refreshBooksButton.Location = new System.Drawing.Point(908, 239);
            this.refreshBooksButton.Name = "refreshBooksButton";
            this.refreshBooksButton.Size = new System.Drawing.Size(129, 37);
            this.refreshBooksButton.TabIndex = 36;
            this.refreshBooksButton.Text = "Refresh";
            this.refreshBooksButton.UseVisualStyleBackColor = true;
            this.refreshBooksButton.Click += new System.EventHandler(this.refreshBooksButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1500, 1051);
            this.Controls.Add(this.refreshBooksButton);
            this.Controls.Add(this.refreshPubButton);
            this.Controls.Add(this.addPubRecord);
            this.Controls.Add(this.lastBookButton);
            this.Controls.Add(this.firstBookButton);
            this.Controls.Add(this.prevBookButton);
            this.Controls.Add(this.nextBookButton);
            this.Controls.Add(this.booksDataGrid);
            this.Controls.Add(this.pubCountryBox);
            this.Controls.Add(this.pubCityBox);
            this.Controls.Add(this.pubNameBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.firstPubButton);
            this.Controls.Add(this.lastPubButton);
            this.Controls.Add(this.nexPubtButton);
            this.Controls.Add(this.prevPubButton);
            this.Controls.Add(this.publishersDataGrid);
            this.Controls.Add(this.addBookRecordButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.languageBox);
            this.Controls.Add(this.publisherIDBox);
            this.Controls.Add(this.pubDateBox);
            this.Controls.Add(this.bookTitleBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publishersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookTitleBox;
        private System.Windows.Forms.TextBox pubDateBox;
        private System.Windows.Forms.TextBox publisherIDBox;
        private System.Windows.Forms.TextBox languageBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBookRecordButton;
        private System.Windows.Forms.DataGridView publishersDataGrid;
        private System.Windows.Forms.Button prevPubButton;
        private System.Windows.Forms.Button nexPubtButton;
        private System.Windows.Forms.Button lastPubButton;
        private System.Windows.Forms.Button firstPubButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pubNameBox;
        private System.Windows.Forms.TextBox pubCityBox;
        private System.Windows.Forms.TextBox pubCountryBox;
        private System.Windows.Forms.DataGridView booksDataGrid;
        private System.Windows.Forms.Button nextBookButton;
        private System.Windows.Forms.Button prevBookButton;
        private System.Windows.Forms.Button firstBookButton;
        private System.Windows.Forms.Button lastBookButton;
        private System.Windows.Forms.Button addPubRecord;
        private System.Windows.Forms.Button refreshPubButton;
        private System.Windows.Forms.Button refreshBooksButton;
    }
}

