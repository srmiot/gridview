using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Dynamic_GriedView
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Sem 5\AWP\Dynamic_GriedView\App_Data\Database1.mdf"";Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            c.Open();
            SqlCommand cmd2= new SqlCommand("select Name,Village from SD",c);
            GridView1.DataSource = cmd2.ExecuteReader();
            GridView1.DataBind();
            c.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Sem 5\AWP\Dynamic_GriedView\App_Data\Database1.mdf"";Integrated Security=True");
            c.Open();
            SqlCommand cmd = new SqlCommand("insert into SD values('"+TextBox1.Text+"','"+TextBox2.Text+"')",c);
            cmd.ExecuteNonQuery();
            c.Close();

            //SqlConnection c3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Sem 5\AWP\Dynamic_GriedView\App_Data\Database1.mdf"";Integrated Security=True");
            c.Open();
            SqlCommand cmd3 = new SqlCommand("Select Name,Village from SD",c);
            GridView1.DataSource=cmd3.ExecuteReader();
            GridView1.DataBind();
            c.Close();
        }
    }
}