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
    public partial class borrowers_user_control : UserControl
    {
        private static borrowers_user_control _instance;

        public static borrowers_user_control Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new borrowers_user_control();
                }
                return _instance;
            }
        }
        public borrowers_user_control()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllBorrowersData_SP", con);
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
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void add_new_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BorrowersAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@brid", borrower_id_input.Text);
            cmd.Parameters.AddWithValue("@name", name_input.Text);
            cmd.Parameters.AddWithValue("@address", address_input.Text);
            cmd.Parameters.AddWithValue("@phone", phone_input.Text);

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

        private void borrowers_user_control_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BorrowersDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@brid", borrower_id_input.Text);
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

        private void search_borrowers_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BorrowersSearch_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@brid", borrower_id_input_search.Text);

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
            borrower_id_input_search.Text = "";
            borrower_id_input.Text = "";
            name_input.Text = "";
            address_input.Text = "";
            phone_input.Text = "";
        }
    }
}
