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

namespace adoinsert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = null;
            result = DatabaseConnection1.InsertRecord(textBox1.Text, textBox2.Text);
            label3.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = null;
            result = DatabaseConnection1.UpdateUsers(textBox1.Text, textBox2.Text);
            label3.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = null;
            result = DatabaseConnection1.DeleteUsers(textBox1.Text  );
            label3.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
