using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    class DAL
    {
        const string CONNECTION_STRING = @"Data Source=PADMA;Initial Catalog=Practives;Integrated Security=True;User Instance=True";
        public string InsertUserInformation(BusinessLayer objUserDetails)
        {
            return "tct";
        }
    }
}
