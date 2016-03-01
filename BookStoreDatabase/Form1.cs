using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookStoreDatabase
{
    public partial class MainWindow : Form
    {
        DataSet ds = new DataSet();
        SqlConnection cs = new SqlConnection("Data Source = DESKTOP-3JU4JU4; Initial Catalog = BookStore; Integrated Security = TRUE");
        SqlDataAdapter da = new SqlDataAdapter();

        BindingSource tblBooksBS = new BindingSource();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            
            da.InsertCommand = new SqlCommand("INSERT INTO Books VALUES (@book_title, @pub_date, @pud_id, @language)", cs);
            da.InsertCommand.Parameters.Add("@book_title", SqlDbType.VarChar).Value = bookTitleBox.Text;
            da.InsertCommand.Parameters.Add("@pub_date", SqlDbType.Date).Value = pubDateBox.Text;
            da.InsertCommand.Parameters.Add("@pud_id", SqlDbType.Int).Value = publisherIDBox.Text;
            da.InsertCommand.Parameters.Add("@language", SqlDbType.VarChar).Value = languageBox.Text;

            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM Books", cs);
            ds.Clear();
            //da.Fill(ds);
            da.Fill(ds, "Books");
            dg.DataSource = ds.Tables["Books"];

            tblBooksBS.DataSource = ds.Tables["Books"];

            bookTitleBox.DataBindings.Add(new Binding("Text", tblBooksBS, "book_title"));
            pubDateBox.DataBindings.Add(new Binding("Text", tblBooksBS, "pub_date"));
            publisherIDBox.DataBindings.Add(new Binding("Text", tblBooksBS, "publisher_id"));
            languageBox.DataBindings.Add(new Binding("Text", tblBooksBS, "language"));
            records();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            tblBooksBS.MoveNext();
            dgUpdate();
            records();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            tblBooksBS.MovePrevious();
            dgUpdate();
            records();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            tblBooksBS.MoveLast();
            dgUpdate();
            records();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            tblBooksBS.MoveFirst();
            dgUpdate();
            records();
            
        }

        private void dgUpdate()
        {
            dg.ClearSelection();
            dg.Rows[tblBooksBS.Position].Selected = true;
            records();
        }
        private void records()
        {
            label6.Text = "Record" + tblBooksBS.Position + " of " + (tblBooksBS.Count - 1);
        }
    }
}
