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
            this.dg = new System.Windows.Forms.DataGridView();
            this.displayButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Publication Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publisher ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Language:";
            // 
            // bookTitleBox
            // 
            this.bookTitleBox.Location = new System.Drawing.Point(142, 85);
            this.bookTitleBox.Name = "bookTitleBox";
            this.bookTitleBox.Size = new System.Drawing.Size(304, 29);
            this.bookTitleBox.TabIndex = 4;
            // 
            // pubDateBox
            // 
            this.pubDateBox.Location = new System.Drawing.Point(197, 127);
            this.pubDateBox.Name = "pubDateBox";
            this.pubDateBox.Size = new System.Drawing.Size(249, 29);
            this.pubDateBox.TabIndex = 5;
            // 
            // publisherIDBox
            // 
            this.publisherIDBox.Location = new System.Drawing.Point(594, 84);
            this.publisherIDBox.Name = "publisherIDBox";
            this.publisherIDBox.Size = new System.Drawing.Size(134, 29);
            this.publisherIDBox.TabIndex = 6;
            // 
            // languageBox
            // 
            this.languageBox.Location = new System.Drawing.Point(577, 128);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(151, 29);
            this.languageBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add a book to the database:";
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(754, 75);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(139, 46);
            this.addRecordButton.TabIndex = 9;
            this.addRecordButton.Text = "Add Record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(36, 188);
            this.dg.Name = "dg";
            this.dg.RowTemplate.Height = 31;
            this.dg.Size = new System.Drawing.Size(1034, 629);
            this.dg.TabIndex = 10;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(915, 75);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(139, 45);
            this.displayButton.TabIndex = 11;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(915, 126);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 45);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1101, 847);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.dg);
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
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
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
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

