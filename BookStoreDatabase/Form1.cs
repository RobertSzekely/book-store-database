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
        private DataSet dataSet1 = new DataSet();
        private DataSet dataSet2 = new DataSet();
        private SqlConnection connection = new SqlConnection("Data Source = DESKTOP-3JU4JU4; Initial Catalog = BookStore; Integrated Security = TRUE");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        private BindingSource publishersBindingSource = new BindingSource();
        private BindingSource booksBindingSource = new BindingSource();


        //private DataGridView masterDataGridView = new DataGridView();
        private BindingSource masterBindingSource = new BindingSource();
        // DataGridView detailsDataGridView = new DataGridView();
        private BindingSource detailsBindingSource = new BindingSource();


        public MainWindow()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Bind the DataGridView controls to the BindingSource
            //components and load the data from the database
            publishersDataGrid.DataSource = masterBindingSource;
            booksDataGrid.DataSource = detailsBindingSource;
            GetData();
            

            //Configure the details in DataGridView so that its columns automatically ajust their widths
            //when the data changes
            booksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



            //dg.DataSource = publishersBindingSource;
            //publishersDataGrid.AutoGenerateColumns = true;
            addRecordButton.Enabled = false;
            nextButton.Enabled = false;
            prevButton.Enabled = false;
            lastButton.Enabled = false;
            firstButton.Enabled = false;
          

        }
        private void GetData()
        {
            try
            {
                //// Create a DataSet
                //DataSet data = new DataSet();
                //data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                //// Add data from the Publishers table in the DataSet.
                //SqlDataAdapter publishersDataAdapter = new
                //    SqlDataAdapter("select * from Publishers", connection);
                //publishersDataAdapter.Fill(data, "Publishers");

                //// Add data from the Books table in the DataSet.
                //SqlDataAdapter booksDataAdapter = new
                //    SqlDataAdapter("select * from Books", connection);
                //booksDataAdapter.Fill(data, "Books");


                //// Establish a relationship between the two tables.
                //DataRelation relation = new DataRelation("PublishersBooks",
                //    data.Tables["Publishers"].Columns["publisher_id"],
                //    data.Tables["Books"].Columns["publisher_id"]);
                //data.Relations.Add(relation);


                ////Bind the publishers data connector to the Publishers table.
                //publishersBindingSource.DataSource = data;
                //publishersBindingSource.DataMember = "Publishers";

                ////Bind the details data connector to the publishers data connector,
                ////using the Datarelation name to filter the information in the 
                ////books table oon the current row in the master table.
                //booksBindingSource.DataSource = publishersBindingSource;
                //booksBindingSource.DataMember = "PublishersBooks";


                // Create a DataSet.
                DataSet data = new DataSet();
                data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                // Add data from the Customers table to the DataSet.
                SqlDataAdapter masterDataAdapter = new
                    SqlDataAdapter("select * from Publishers", connection);
                masterDataAdapter.Fill(data, "Publishers");

                // Add data from the Orders table to the DataSet.
                SqlDataAdapter detailsDataAdapter = new
                    SqlDataAdapter("select * from Books", connection);
                detailsDataAdapter.Fill(data, "Books");

                // Establish a relationship between the two tables.
                DataRelation relation = new DataRelation("PublishersBooks",
                    data.Tables["Publishers"].Columns["publisher_id"],
                    data.Tables["Books"].Columns["publisher_id"]);
                data.Relations.Add(relation);

                // Bind the master data connector to the Customers table.
                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "Publishers";

                // Bind the details data connector to the master data connector,
                // using the DataRelation name to filter the information in the 
                // details table based on the current row in the master table. 
                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "PublishersBooks";
                dgUpdatePublishers();

            } catch (SqlException)
            {
                MessageBox.Show("Can't connect to the database.");
            }
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            //add a record to the Book table   
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO Books VALUES (@book_title, @pub_date, @pud_id, @language)", connection);
            dataAdapter.InsertCommand.Parameters.Add("@book_title", SqlDbType.VarChar).Value = bookTitleBox.Text;
            dataAdapter.InsertCommand.Parameters.Add("@pub_date", SqlDbType.Date).Value = pubDateBox.Text;
            dataAdapter.InsertCommand.Parameters.Add("@pud_id", SqlDbType.Int).Value = publisherIDBox.Text;
            dataAdapter.InsertCommand.Parameters.Add("@language", SqlDbType.VarChar).Value = languageBox.Text;

            connection.Open();
            dataAdapter.InsertCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {

            //SqlCommand cmd = new SqlCommand(@"SELECT * FROM Books", connection);
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            //DataTable table = new DataTable("Books");
            //dataAdapter.Fill(table);

            //ListViewItem iItem;
            //connection.Open();
            //SqlDataReader rReader = cmd.ExecuteReader();
            //while (rReader.Read())
            //{
            //    iItem = new ListViewItem(rReader["book_title"].ToString());
            //    booksListView.Items.Add(iItem);
            //}
            //connection.Close();

            //booksDataGrid.DataSource = null;


            //dataAdapter.SelectCommand = new SqlCommand("Select book_title, publisher_id, book_id, pub_date, language from Books", connection);

            //String id = parentList.CurrentRow.Cells[0].Value.ToString();

            String publisher_id = publishersDataGrid.CurrentRow.Cells[0].Value.ToString();
            String query = "SELECT * FROM Books where publisher_id=" + publisher_id;
            dataAdapter.SelectCommand = new SqlCommand(query, connection);
            dataSet2.Clear();
            dataAdapter.Fill(dataSet2, "Books");
            booksDataGrid.DataSource = dataSet2.Tables["Books"];
            booksBindingSource.DataSource = dataSet2.Tables["Books"];
            //bookTitleBox.DataBindings.Add(new Binding("Text", booksBindingSource, "book_title"));

            dgUpdateBooks();

            //disable the buttons for navigating
            nextButton.Enabled = false;
            prevButton.Enabled = false;
            firstButton.Enabled = false;
            lastButton.Enabled = false;
            label6.Text = "";

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //enable the navigation buttons
            nextButton.Enabled = true;
            prevButton.Enabled = true;
            firstButton.Enabled = true;
            lastButton.Enabled = true;
            addRecordButton.Enabled = true;

            //display all the records from the Publishers table

            //dg.DataSource = null;

            

            dataAdapter.SelectCommand = new SqlCommand("SELECT publisher_name, city, country, publisher_id FROM Publishers", connection);
            dataSet1.Clear();
            dataAdapter.Fill(dataSet1, "Publishers");
            publishersDataGrid.DataSource = dataSet1.Tables["Publishers"];
            publishersBindingSource.DataSource = dataSet1.Tables["Publishers"];

            dgUpdatePublishers();

            records();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //booksBindingSource.MoveNext();
            publishersBindingSource.MoveNext();
            dgUpdateBooks();
            dgUpdatePublishers();
            records();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            //booksBindingSource.MovePrevious();
            publishersBindingSource.MovePrevious();
            dgUpdateBooks();
            dgUpdatePublishers();
            records();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            //booksBindingSource.MoveLast();
            publishersBindingSource.MoveLast();
            dgUpdatePublishers();
            dgUpdateBooks();
            records();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            //booksBindingSource.MoveFirst();
            publishersBindingSource.MoveFirst();
            dgUpdatePublishers();
            dgUpdateBooks();
            records();
            
        }

        //private void updateBooksList()
        //{
        //    SqlCommand cmd = new SqlCommand(@"SELECT * FROM Books WHERE ", connection);
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        //    DataTable table = new DataTable("Books");
        //    dataAdapter.Fill(table);

        //    ListViewItem iItem;
        //    connection.Open();
        //    SqlDataReader rReader = cmd.ExecuteReader();
        //    while (rReader.Read())
        //    {
        //        iItem = new ListViewItem(rReader["book_title"].ToString());
        //        booksListView.Items.Add(iItem);
        //    }
        //    connection.Close();

        //    booksBindingSource.MoveFirst();
        //    bookTitleBox.DataBindings.Add(new Binding("Text", booksBindingSource, "book_title"));

        //}

        private void dgUpdatePublishers()
        {
            //publishersDataGrid.ClearSelection();//clear datagrid selection
            //dg.Rows[booksBindingSource.Position].Selected = true;
            publishersDataGrid.Rows[masterBindingSource.Position].Selected = true;

            pubIdTextBox.DataBindings.Add(new Binding("Text", masterBindingSource, "publisher_id"));
            pubNameBox.DataBindings.Add(new Binding("Text", masterBindingSource, "publisher_name"));
            pubCityBox.DataBindings.Add(new Binding("Text", masterBindingSource, "city"));
            pubCountryBox.DataBindings.Add(new Binding("Text", masterBindingSource, "country"));

            //string query = null;
            //if (publisherIDBox.Text == "")
            //{
            //    query = "SELECT * FROM Books";
            //}
            //else
            //{
            //    query = "SELECT * FROM Books WHERE publisher_id=" + publisherIDBox.Text;
            //}
            //dataSet2.Clear();

            //dataAdapter.SelectCommand = new SqlCommand("Select book_title, publisher_id, book_id, pub_date, language from Books", connection);
            //dataAdapter.SelectCommand = new SqlCommand(query, connection);
            //dataAdapter.Fill(dataSet2, "Books");
            //booksDataGrid.DataSource = dataSet2.Tables["Books"];
            //booksBindingSource.DataSource = dataSet2.Tables["Books"];

            //dgUpdateBooks();

            pubNameBox.DataBindings.Clear();
            pubCityBox.DataBindings.Clear();
            pubCountryBox.DataBindings.Clear();
            pubIdTextBox.DataBindings.Clear();

            records();
        }
        private void dgUpdateBooks()
        {
            booksDataGrid.ClearSelection();//clear datagrid selection
            booksDataGrid.Rows[booksBindingSource.Position].Selected = true;

            bookTitleBox.DataBindings.Add(new Binding("Text", booksBindingSource, "book_title"));
            pubDateBox.DataBindings.Add(new Binding("Text", booksBindingSource, "pub_date"));
            publisherIDBox.DataBindings.Add(new Binding("Text", booksBindingSource, "publisher_id"));
            languageBox.DataBindings.Add(new Binding("Text", booksBindingSource, "language"));

            bookTitleBox.DataBindings.Clear();
            pubDateBox.DataBindings.Clear();
            publisherIDBox.DataBindings.Clear();
            languageBox.DataBindings.Clear();

        }
        private void records()
        {
            label6.Text = "Record" + publishersBindingSource.Position + " of " + (publishersBindingSource.Count - 1);
        }

        private void prevBook_Click(object sender, EventArgs e)
        {
            booksBindingSource.MovePrevious();
            dgUpdateBooks();
        }
        private void nextBook_Click(object sender, EventArgs e)
        {
            booksBindingSource.MoveNext();
            dgUpdateBooks();
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
