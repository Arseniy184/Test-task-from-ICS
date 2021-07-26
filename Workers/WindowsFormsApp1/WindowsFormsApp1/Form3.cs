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
    public partial class Form3 : Form
    {
        private SqlConnection SqlConnection = null;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(SqlConnection SqlConnection)
        {
            InitializeComponent();
            this.SqlConnection = SqlConnection;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE Workers WHERE Id = @Id OR Name = @Name", SqlConnection);

            try
            {
                command.Parameters.AddWithValue("Id", textBox1.Text);
                command.Parameters.AddWithValue("Name", textBox2.Text);

                command.ExecuteNonQuery();

                this.Close();

                ((Form1)this.Tag).Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Исключение: {ex.Message}");
            }

        }
    }
  
}
