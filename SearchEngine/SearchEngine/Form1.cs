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


namespace SearchEngine
{
    public class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ConnectDatabase a = new ConnectDatabase();

            a.connection();


/*            SqlConnection con = new SqlConnection("Data Source=Ruchit-PC;Initial Catalog=MetaSearchEngine;Integrated Security=True");

            con.Open();
            SqlCommand sc=new SqlCommand("insert into Context values("+ textBox1.Text +",'"+ textBox2.Text +"','"+ textBox3.Text +"',"+ textBox4.Text +");", con);
               
            sc.ExecuteNonQuery();


            MessageBox.Show ("The Context has been Added");
            con.Close();

 */
        }

        public static void main (String[] args)
        {
            Application.Run(new Form1());

        }

    }
}
