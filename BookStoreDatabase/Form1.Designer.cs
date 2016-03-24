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
            this.addRecordButton = new System.Windows.Forms.Button();
            this.publishersDataGrid = new System.Windows.Forms.DataGridView();
            this.displayButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DisplayPub = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pubNameBox = new System.Windows.Forms.TextBox();
            this.pubCityBox = new System.Windows.Forms.TextBox();
            this.pubCountryBox = new System.Windows.Forms.TextBox();
            this.booksListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.booksDataGrid = new System.Windows.Forms.DataGridView();
            this.pubIdTextBox = new System.Windows.Forms.TextBox();
            this.nextBook = new System.Windows.Forms.Button();
            this.prevBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.publishersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Publication Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publisher ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Language:";
            // 
            // bookTitleBox
            // 
            this.bookTitleBox.Location = new System.Drawing.Point(721, 85);
            this.bookTitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookTitleBox.Name = "bookTitleBox";
            this.bookTitleBox.Size = new System.Drawing.Size(407, 26);
            this.bookTitleBox.TabIndex = 4;
            // 
            // pubDateBox
            // 
            this.pubDateBox.Location = new System.Drawing.Point(763, 120);
            this.pubDateBox.Margin = new System.Windows.Forms.Padding(2);
            this.pubDateBox.Name = "pubDateBox";
            this.pubDateBox.Size = new System.Drawing.Size(365, 26);
            this.pubDateBox.TabIndex = 5;
            // 
            // publisherIDBox
            // 
            this.publisherIDBox.Location = new System.Drawing.Point(736, 161);
            this.publisherIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.publisherIDBox.Name = "publisherIDBox";
            this.publisherIDBox.Size = new System.Drawing.Size(392, 26);
            this.publisherIDBox.TabIndex = 6;
            // 
            // languageBox
            // 
            this.languageBox.Location = new System.Drawing.Point(722, 198);
            this.languageBox.Margin = new System.Windows.Forms.Padding(2);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(406, 26);
            this.languageBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add a book to the database:";
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(42, 229);
            this.addRecordButton.Margin = new System.Windows.Forms.Padding(2);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(114, 52);
            this.addRecordButton.TabIndex = 9;
            this.addRecordButton.Text = "Add Record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // publishersDataGrid
            // 
            this.publishersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publishersDataGrid.Location = new System.Drawing.Point(42, 328);
            this.publishersDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.publishersDataGrid.Name = "publishersDataGrid";
            this.publishersDataGrid.RowTemplate.Height = 31;
            this.publishersDataGrid.Size = new System.Drawing.Size(513, 599);
            this.publishersDataGrid.TabIndex = 10;
            this.publishersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(747, 245);
            this.displayButton.Margin = new System.Windows.Forms.Padding(2);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(114, 54);
            this.displayButton.TabIndex = 11;
            this.displayButton.Text = "Display Books";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(171, 948);
            this.prevButton.Margin = new System.Windows.Forms.Padding(2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(102, 38);
            this.prevButton.TabIndex = 13;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(288, 948);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(109, 38);
            this.nextButton.TabIndex = 14;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(412, 948);
            this.lastButton.Margin = new System.Windows.Forms.Padding(2);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(118, 38);
            this.lastButton.TabIndex = 15;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(60, 948);
            this.firstButton.Margin = new System.Windows.Forms.Padding(2);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(96, 38);
            this.firstButton.TabIndex = 16;
            this.firstButton.Text = "First";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 995);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 17;
            // 
            // DisplayPub
            // 
            this.DisplayPub.Location = new System.Drawing.Point(165, 229);
            this.DisplayPub.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayPub.Name = "DisplayPub";
            this.DisplayPub.Size = new System.Drawing.Size(114, 52);
            this.DisplayPub.TabIndex = 19;
            this.DisplayPub.Text = "Display Publishers";
            this.DisplayPub.UseVisualStyleBackColor = true;
            this.DisplayPub.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Add a publisher to the database:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "City:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Country:";
            // 
            // pubNameBox
            // 
            this.pubNameBox.Location = new System.Drawing.Point(100, 86);
            this.pubNameBox.Name = "pubNameBox";
            this.pubNameBox.Size = new System.Drawing.Size(424, 26);
            this.pubNameBox.TabIndex = 24;
            // 
            // pubCityBox
            // 
            this.pubCityBox.Location = new System.Drawing.Point(100, 124);
            this.pubCityBox.Name = "pubCityBox";
            this.pubCityBox.Size = new System.Drawing.Size(424, 26);
            this.pubCityBox.TabIndex = 25;
            // 
            // pubCountryBox
            // 
            this.pubCountryBox.Location = new System.Drawing.Point(112, 166);
            this.pubCountryBox.Name = "pubCountryBox";
            this.pubCountryBox.Size = new System.Drawing.Size(412, 26);
            this.pubCountryBox.TabIndex = 26;
            // 
            // booksListView
            // 
            this.booksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.booksListView.Location = new System.Drawing.Point(1255, 491);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(397, 219);
            this.booksListView.TabIndex = 27;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Title";
            this.columnHeader6.Width = 183;
            // 
            // booksDataGrid
            // 
            this.booksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGrid.Location = new System.Drawing.Point(615, 328);
            this.booksDataGrid.Name = "booksDataGrid";
            this.booksDataGrid.RowTemplate.Height = 28;
            this.booksDataGrid.Size = new System.Drawing.Size(513, 599);
            this.booksDataGrid.TabIndex = 28;
            this.booksDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pubIdTextBox
            // 
            this.pubIdTextBox.Location = new System.Drawing.Point(1255, 767);
            this.pubIdTextBox.Name = "pubIdTextBox";
            this.pubIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.pubIdTextBox.TabIndex = 29;
            // 
            // nextBook
            // 
            this.nextBook.Location = new System.Drawing.Point(876, 948);
            this.nextBook.Name = "nextBook";
            this.nextBook.Size = new System.Drawing.Size(121, 39);
            this.nextBook.TabIndex = 30;
            this.nextBook.Text = "Next";
            this.nextBook.UseVisualStyleBackColor = true;
            this.nextBook.Click += new System.EventHandler(this.nextBook_Click);
            // 
            // prevBook
            // 
            this.prevBook.Location = new System.Drawing.Point(731, 948);
            this.prevBook.Name = "prevBook";
            this.prevBook.Size = new System.Drawing.Size(121, 39);
            this.prevBook.TabIndex = 31;
            this.prevBook.Text = "Previous";
            this.prevBook.UseVisualStyleBackColor = true;
            this.prevBook.Click += new System.EventHandler(this.prevBook_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 1051);
            this.Controls.Add(this.prevBook);
            this.Controls.Add(this.nextBook);
            this.Controls.Add(this.pubIdTextBox);
            this.Controls.Add(this.booksDataGrid);
            this.Controls.Add(this.booksListView);
            this.Controls.Add(this.pubCountryBox);
            this.Controls.Add(this.pubCityBox);
            this.Controls.Add(this.pubNameBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DisplayPub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.publishersDataGrid);
            this.Controls.Add(this.addRecordButton);
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
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.DataGridView publishersDataGrid;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DisplayPub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pubNameBox;
        private System.Windows.Forms.TextBox pubCityBox;
        private System.Windows.Forms.TextBox pubCountryBox;
        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DataGridView booksDataGrid;
        private System.Windows.Forms.TextBox pubIdTextBox;
        private System.Windows.Forms.Button nextBook;
        private System.Windows.Forms.Button prevBook;
    }
}

