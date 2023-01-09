using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Student_Record
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["root"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "select firstName from records";
            connection.Open();

            SqlDataReader datareader = command.ExecuteReader();

            while (datareader.Read())
            {
                string firstName;
                firstName = (string)datareader["firstName"];

                this.LstResult.Items.Add(firstName);
            }
            datareader.Close();
            connection.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LstResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = this.LstResult.SelectedItem.ToString();

            string connectionString = ConfigurationManager.ConnectionStrings["root"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "select firstName,lastName,city,state,country,nationality from records where firstName= '" + selectedItem +"'";

            connection.Open();

            SqlDataReader datareader = command.ExecuteReader();

            while (datareader.Read())
            {
                txtFirstName.Text = datareader.GetString(0);
                txtLastNmae.Text = datareader.GetString(1);
                txtCity.Text = datareader.GetString(2);
                txtState.Text = datareader.GetString(3);
                txtCountry.Text = datareader.GetString(4);
                txtNationality.Text = datareader.GetString(5);
            }
            datareader.Close();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string selectedItem = this.LstResult.SelectedItem.ToString();

            string connectionString = ConfigurationManager.ConnectionStrings["root"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "update records set firstName='" + txtFirstName.Text +"',lastName='" + txtLastNmae.Text +
                ",city=" + txtCity.Text +
                ",state=" + txtState.Text +
                ",country=" + txtCountry.Text +
                ",nationality=" + txtNationality+
                "where firstName="+selectedItem;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();*/

        }

        private void AddNewRe(object sender, EventArgs e)
        {

            String connectionString = ConfigurationManager.ConnectionStrings["root"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;



           command.CommandText= "insert into records(firstName,lastName,city,state,country,nationality) values('" + this.txtFirstName.Text + "','" + this.txtLastNmae.Text + "','" + this.txtCity.Text + "','" + this.txtState.Text + "','" + this.txtCountry.Text + "','"+this.txtNationality.Text+"');";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            this.LstResult.Items.Add(txtFirstName.Text);
            MessageBox.Show("New Record Added "+txtFirstName.Text);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string selectedItem = this.LstResult.SelectedItem.ToString();

            String connectionString = ConfigurationManager.ConnectionStrings["root"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;


            command.CommandText = "update records set firstName='" + this.txtFirstName.Text + "',lastName='" + this.txtLastNmae.Text + "',city='" + this.txtCity.Text + "',state='" + this.txtState.Text + "',country='" + this.txtCountry.Text + "',nationality='" + this.txtNationality.Text + "' where firstName='" + selectedItem + "';";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record Updated "+txtFirstName.Text);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string selectItem = this.LstResult.SelectedItem.ToString();
            String connectionString = ConfigurationManager.ConnectionStrings["root"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            

            command.CommandText = "Delete from records where firstName = '" + selectItem + "'";

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            this.LstResult.Items.Clear();
            LoadData();
            this.txtFirstName.Clear();
            this.txtLastNmae.Clear();
            this.txtCity.Clear();
            this.txtState.Clear();
            this.txtCountry.Clear();
            this.txtNationality.Clear();
            MessageBox.Show("Deleted Record is " + selectItem);
        }

        private void clear_Click(object sender, EventArgs e)
        {

            this.LstResult.Items.Clear();
            this.txtFirstName.Clear();
            this.txtLastNmae.Clear();
            this.txtCity.Clear();
            this.txtState.Clear();
            this.txtCountry.Clear();
            this.txtNationality.Clear();
            MessageBox.Show("Record is CLeared");
        }
    }
}
