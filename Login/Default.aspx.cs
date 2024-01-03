using System;
using System.Collections.Generic;
using system.linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    SqlConnection SQLConn = new SqlConnection("Data Source=LAPTOP-AMM1MQ8C; Initial Catalog=Login; Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        lblmsg.Text = "";
        SqlDataAdapter SQLAdapter = new SqlDataAdapter("Select * from LoginMst where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", SQLConn);
        DataTable DT = new DataTable();
        SQLAdapter.Fill(DT);

        if (DT.Rows.Count > 0)
        {
            lblmsg.Text = "Welcome to System";
            lblmsg.ForeColor = System.Drawing.Color.Green;
        }

        else
        {
            lblmsg.Text = "Invalid username or password";
            lblmsg.ForeColor = System.Drawing.Color.Red;
        }
    }
}