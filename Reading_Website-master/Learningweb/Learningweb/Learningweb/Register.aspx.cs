using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Learningweb
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string dat ="Insert into [Table](FULLNAME,USERNAME,PASSWORD) Values('"+fullname.Text+"','"+username.Text+"','"+password.Text+"')";
            SqlCommand com = new SqlCommand(dat,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            Label7.ForeColor = System.Drawing.Color.Green;
            Label7.Text = "You can log in now";
        }
    }
}