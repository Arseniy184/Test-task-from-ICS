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
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SqlConnection SqlConnection = null;
        private Form2 newForm2 = null;
        private Form3 newForm3 = null;

        //private List<string[]> FiltredList = null;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Workers"].ConnectionString);

            SqlConnection.Open();
            //if (SqlConnection.State == ConnectionState.Open)
            //{
                //MessageBox.Show("Подключение установлено");
            //}

            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "Select * from Workers",
                SqlConnection);
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:

                    (dataGridView1.DataSource as DataTable).DefaultView.Sort = $"Position ASC";

                    break;
                case 1:

                    (dataGridView1.DataSource as DataTable).DefaultView.Sort = $"Position DESC";

                    break;
                case 2:

                    (dataGridView1.DataSource as DataTable).DefaultView.Sort = $"Salary ASC";

                    break;
                case 3:

                    (dataGridView1.DataSource as DataTable).DefaultView.Sort = $"Salary DESC";

                    break;
                case 4:

                    (dataGridView1.DataSource as DataTable).DefaultView.Sort = "Id ASC";

                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newForm2 = new Form2(this.SqlConnection);
            newForm2.Tag = this;
            newForm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4();
            newForm4.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Position LIKE '%{textBox1.Text}%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3(this.SqlConnection);
            newForm3.Tag = this;
            newForm3.Show();
        }
    }
}
