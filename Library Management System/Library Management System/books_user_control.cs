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

namespace Library_Management_System
{
    public partial class books_user_control : UserControl
    {
        private static books_user_control _instance;

        public static books_user_control Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new books_user_control();
                }
                return _instance;
            }
        }
        public books_user_control()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllBooksData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("INVALID SQL OPERATION:\n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];

            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BooksAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accNo", accession_num_input.Text);
            cmd.Parameters.AddWithValue("@ibsn", ibsn_input.Text);
            cmd.Parameters.AddWithValue("@name", name_input.Text);
            cmd.Parameters.AddWithValue("@author", author_input.Text);
            cmd.Parameters.AddWithValue("@publisher", publisher_input.Text);
            cmd.Parameters.AddWithValue("dId", department_id_input.Text);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("INVALID SQL OPERATION:\n" + ex);
            }

            con.Close();

            refresh_DataGridView();
        }

        private void books_user_control_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BooksDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo", accession_num_input.Text);
                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("INVALID SQL OPERATION:\n" + ex);
                }

                con.Close();

                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void search_books_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BooksSearch_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNo", book_id_input.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("INVALID SQL OPERATION:\n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            book_id_input.Text = "";
            accession_num_input.Text = "";
            name_input.Text = "";
            publisher_input.Text = "";
            ibsn_input.Text = "";
            author_input.Text = "";
            department_id_input.Text = "";
        }
    }
}
