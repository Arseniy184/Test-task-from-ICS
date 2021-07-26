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
    public partial class Form2 : Form
    {
        private SqlConnection SqlConnection = null;
        //private Form1 form;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(SqlConnection SqlConnection)
        {
            InitializeComponent();
            this.SqlConnection = SqlConnection;
            //if (SqlConnection.State == ConnectionState.Open)
            //{
            //MessageBox.Show("Подключение установлено");
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Workers] (Name, Surname, Position, Year_of_birth, Salary) VALUES (@Name, @Surname, @Position, @Year_of_birth, @Salary)", SqlConnection);

            try
            {
                DateTime date = DateTime.Parse(textBox4.Text);

                command.Parameters.AddWithValue("Name", textBox1.Text);
                command.Parameters.AddWithValue("Surname", textBox2.Text);
                command.Parameters.AddWithValue("Position", textBox3.Text);
                command.Parameters.AddWithValue("Year_of_birth", $"{date.Month}/{date.Day}/{date.Year}");
                command.Parameters.AddWithValue("Salary", textBox5.Text);

                command.ExecuteNonQuery();

                this.Close();

                ((Form1)this.Tag).Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                textBox6.Text = $"Исключение: {ex.Message}";
                MessageBox.Show($"Исключение: {ex.Message}");
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
