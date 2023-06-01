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
namespace update_delete_ado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = DatabaseConnection.InsertRecord(textBox1.Text, textBox2.Text);
            clearall();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }
        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

    }
}
