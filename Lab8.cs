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

namespace DDL_and_DML
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Siri' table. You can move, or remove it, as needed.
            this.SiriTableAdapter.Fill(this.masterDataSet.Siri);
           // this.SiriTableAdapter.Fill(this.masterDataSet.emp);
            DataSet ds = new DataSet();
            connection = new SqlConnection("Data Source=HT1-48;Initial Catalog=master;User ID=sa;Password=rvr");
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Narendra", connection);
            da.Fill(ds, "Siri");
            textBox1.DataBindings.Add("text", ds, "Siri.eno");
            textBox2.DataBindings.Add("text", ds, "Siri.ename");
            textBox3.DataBindings.Add("text", ds, "Siri.esal");
            textBox4.DataBindings.Add("text", ds, "Siri.edep");
            textBox5.DataBindings.Add("text", ds, "Siri.dno");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmdinsert = new SqlCommand("insert into Siri values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "'," + textBox5.Text + ")", connection);
            cmdinsert.CommandType = CommandType.Text;
            cmdinsert.ExecuteNonQuery();
            MessageBox.Show("Data Inserted");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmdupdate = new SqlCommand("Update emp SET ename='" + textBox2.Text + "' where eno='" + textBox1.Text + "'", connection);
            cmdupdate.CommandType = CommandType.Text;
            cmdupdate.ExecuteNonQuery();
            MessageBox.Show("Data Upadated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                SqlCommand cmddel = new SqlCommand("Delete emp where eno=" + textBox1.Text + "", connection);
                cmddel.CommandType = CommandType.Text;
                cmddel.ExecuteNonQuery();
                MessageBox.Show("Data deleted");
            }

        }
    }
}
