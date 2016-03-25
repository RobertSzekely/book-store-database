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


            //Configure the details in DataGridView so that its columns 
            //automatically ajust their widths when the data changes
            booksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }
        private void GetData()
        {
            try
            {
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
                UpdatePublishersDataGridView();

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


        private void nextButton_Click(object sender, EventArgs e)
        {
            masterBindingSource.MoveNext();
            UpdateBooksDataGridView();
            UpdatePublishersDataGridView();
            records();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            masterBindingSource.MovePrevious();
            UpdateBooksDataGridView();
            UpdatePublishersDataGridView();
            records();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            masterBindingSource.MoveLast();
            UpdatePublishersDataGridView();
            UpdateBooksDataGridView();
            records();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            masterBindingSource.MoveFirst();
            UpdatePublishersDataGridView();
            UpdateBooksDataGridView();
            records();
            
        }


        private void UpdatePublishersDataGridView()
        {

            publishersDataGrid.ClearSelection();
            publishersDataGrid.Rows[masterBindingSource.Position].Selected = true;

            pubNameBox.DataBindings.Add(new Binding("Text", masterBindingSource, "publisher_name"));
            pubCityBox.DataBindings.Add(new Binding("Text", masterBindingSource, "city"));
            pubCountryBox.DataBindings.Add(new Binding("Text", masterBindingSource, "country"));


            pubNameBox.DataBindings.Clear();
            pubCityBox.DataBindings.Clear();
            pubCountryBox.DataBindings.Clear();

            records();
        }

        private void UpdateBooksDataGridView()
        {
            booksDataGrid.ClearSelection();//clear datagrid selection
            booksDataGrid.Rows[detailsBindingSource.Position].Selected = true;

            bookTitleBox.DataBindings.Add(new Binding("Text", detailsBindingSource, "book_title"));
            pubDateBox.DataBindings.Add(new Binding("Text", detailsBindingSource, "pub_date"));
            publisherIDBox.DataBindings.Add(new Binding("Text", detailsBindingSource, "publisher_id"));
            languageBox.DataBindings.Add(new Binding("Text", detailsBindingSource, "language"));

            bookTitleBox.DataBindings.Clear();
            pubDateBox.DataBindings.Clear();
            publisherIDBox.DataBindings.Clear();
            languageBox.DataBindings.Clear();

        }
        private void records()
        {
            label6.Text = "Record" + masterBindingSource.Position + " of " + (masterBindingSource.Count - 1);
        }

        private void prevBook_Click(object sender, EventArgs e)
        {
            detailsBindingSource.MovePrevious();
            UpdateBooksDataGridView();
        }
        private void nextBook_Click(object sender, EventArgs e)
        {
            detailsBindingSource.MoveNext();
            UpdateBooksDataGridView();
        }

        private void firstBookButton_Click(object sender, EventArgs e)
        {
            detailsBindingSource.MoveFirst();
            UpdateBooksDataGridView();
        }

        private void lastBookButton_Click(object sender, EventArgs e)
        {
            detailsBindingSource.MoveLast();
            UpdateBooksDataGridView();
        }
    }
}
