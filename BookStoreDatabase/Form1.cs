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
        private DataSet ds = new DataSet();
        private SqlConnection cs = new SqlConnection("Data Source = DESKTOP-3JU4JU4; Initial Catalog = BookStore; Integrated Security = TRUE");
        private SqlDataAdapter da = new SqlDataAdapter();

        private BindingSource tblBooksBS = new BindingSource();
        private BindingSource tblPublishersBS = new BindingSource();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dg.DataSource = tblBooksBS;
            dg.AutoGenerateColumns = true;
          

        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            //add a record to the Book table   
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
            //display all the records from Book table
            da.SelectCommand = new SqlCommand("SELECT book_title, pub_date, publisher_id, language FROM Books", cs);
            ds.Clear();
            //da.Fill(ds);
            da.Fill(ds, "Books");
            dg.DataSource = ds.Tables["Books"];

            tblBooksBS.DataSource = ds.Tables["Books"];

            records();

            //disable the buttons for navigating
            nextButton.Enabled = false;
            prevButton.Enabled = false;
            firstButton.Enabled = false;
            lastButton.Enabled = false;

           // da.SelectCommand = new SqlCommand("SELECT book_title From Books", cs);
            //da.Fill(ds, "Books");
            //listBooks.DataSource = ds.Tables["Books"];
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //enable the navigation buttons
            nextButton.Enabled = true;
            prevButton.Enabled = true;
            firstButton.Enabled = true;
            lastButton.Enabled = true;

            //display all the records from the Publishers table
            //ds.Clear();
            da.SelectCommand = new SqlCommand("SELECT publisher_name, city, country FROM Publishers", cs);
            ds.Clear();
            da.Fill(ds);
            da.Fill(ds, "Publishers");
            dg.DataSource = ds.Tables["Publishers"];

            tblPublishersBS.DataSource = ds.Tables["Publishers"];

            records();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //tblBooksBS.MoveNext();
            tblPublishersBS.MoveNext();
            dgUpdatePublishers();
            records();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            //tblBooksBS.MovePrevious();
            tblPublishersBS.MovePrevious();
            dgUpdatePublishers();
            records();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            //tblBooksBS.MoveLast();
            tblPublishersBS.MoveLast();
            dgUpdatePublishers();
            records();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            //tblBooksBS.MoveFirst();
            tblPublishersBS.MoveFirst();
            dgUpdatePublishers();
            records();
            
        }

        private void dgUpdatePublishers()
        {
            dg.ClearSelection();//clear datagrid selection
            //dg.Rows[tblBooksBS.Position].Selected = true;
            dg.Rows[tblPublishersBS.Position].Selected = true;

            pubNameBox.DataBindings.Add(new Binding("Text", tblPublishersBS, "publisher_name"));
            pubCityBox.DataBindings.Add(new Binding("Text", tblPublishersBS, "city"));
            pubCountryBox.DataBindings.Add(new Binding("Text", tblPublishersBS, "country"));

            pubNameBox.DataBindings.Clear();
            pubCityBox.DataBindings.Clear();
            pubCountryBox.DataBindings.Clear();


            records();
        }
        private void dgUpdateBooks()
        {
            dg.ClearSelection();//clear datagrid selection
            dg.Rows[tblBooksBS.Position].Selected = true;

            bookTitleBox.DataBindings.Add(new Binding("Text", tblBooksBS, "book_title"));
            pubDateBox.DataBindings.Add(new Binding("Text", tblBooksBS, "pub_date"));
            publisherIDBox.DataBindings.Add(new Binding("Text", tblBooksBS, "publisher_id"));
            languageBox.DataBindings.Add(new Binding("Text", tblBooksBS, "language"));

            bookTitleBox.DataBindings.Clear();
            pubDateBox.DataBindings.Clear();
            publisherIDBox.DataBindings.Clear();
            languageBox.DataBindings.Clear();

        }
        private void records()
        {
            label6.Text = "Record" + tblBooksBS.Position + " of " + (tblBooksBS.Count - 1);
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
