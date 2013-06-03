using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SearchEngine
{
    class ConnectDatabase
    {
        public void connection()
        {
            Form1 b = new Form1();
            SqlConnection con = new SqlConnection("Data Source=Ruchit-PC;Initial Catalog=MetaSearchEngine;Integrated Security=True");

            con.Open();


            string insert = "INSERT INTO Context VALUES(" + b.textBox1.Text + ",'" + b.textBox2.Text + "','" + b.textBox3.Text + "'," + b.textBox4.Text + ");";
            //            string modify = "UPDATE Context SET ID_Context='', Name='', Description='', Relation='';";
            //            string delete = "DELETE FROM Context WHERE";

            //            if insert_click
            //           {
            SqlCommand sc = new SqlCommand(insert, con);
            sc.ExecuteNonQuery();
            MessageBox.Show("The Context has been Added");
            //           }

            /*            if modify_click
                        {
                            SqlCommand sc = new SqlCommand( modify, con);
                            sc.ExecuteNonQuery();
                            MessageBox.Show("The Context has been Updated");
                        }

                        if delete_click
                        {
                            SqlCommand sc = new SqlCommand( delete, con);
                            sc.ExecuteNonQuery();
                            MessageBox.Show("The Context has been Deleted");
                        }
            */
            con.Close();
        }


    }
}
             
