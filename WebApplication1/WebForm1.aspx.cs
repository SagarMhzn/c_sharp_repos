using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            string username= tb1.Text;
            string password= tb2.Text;
            string repassword = tb3.Text;
            string gender = "";
            string course = "";
            string country = "";

            if (rb1.Checked)
            {
                dis_gender.Text += rb1.Text;
            }
            else
            {
                dis_gender.Text += rb2.Text;
            }

            if(cb1.Checked)
            {
                dis_course.Text += cb1.Text+", ";
            }
            if (cb2.Checked)
            {
                dis_course.Text += cb2.Text+", ";
            }
            if (cb3.Checked)
            {
                dis_course.Text += cb3.Text;
            }

            if(dl1.SelectedValue =="")
            {
                dis_country.Text = "no country selected"; 
            }
            else
            {
                dis_country.Text = dl1.SelectedValue;
            }

            dis_uname.Text = username;
            dis_pass.Text = password;
            dis_repass.Text = repassword;

            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            rb1.Checked = false;
            rb2.Checked = false;
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            dl1.SelectedValue = "";



        }

        protected void bt2_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            rb1.Checked = false;
            rb2.Checked = false;
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            dl1.SelectedValue = "";
        }
    }
}