using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\MISKAT JAHAN\\Documents\\Hospital.mdf\";Integrated Security=True;Connect Timeout=30");

        private void Reset()
        {
            IDTb.Text = "";
            NameTb.Text = "";
            AddressTb.Text = "";
            EmailTb.Text = "";


        }
        private void populate()
        {
            con.Open();
            string query = "select * from HospitalTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void EmailTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            if (IDTb.Text == "" || NameTb.Text == "" || AddressTb.Text == "" || EmailTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                string query = "insert into HospitalTable values('" + IDTb.Text + "', '" + NameTb.Text + "', '" + AddressTb.Text + "', '" + EmailTb.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information Saved");
                con.Close();
                populate();
                Reset();

            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update HospitalTable set Hospital_ID=@Hospital_ID, Name=@Name, Address=@Address, Email=@Email", con);
            cmd.Parameters.AddWithValue("@Hospital_ID", IDTb.Text);
            cmd.Parameters.AddWithValue("@Name", NameTb.Text);
            cmd.Parameters.AddWithValue("@Address", AddressTb.Text);
            cmd.Parameters.AddWithValue("@Email", EmailTb.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Information Successfully Updated");
            populate();
            Reset();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from HospitalTable where Hospital_ID=@Hospital_ID", con);
            cmd.Parameters.AddWithValue("@Hospital_ID", IDTb.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information Successfully deleted");
            populate();
            Reset();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
