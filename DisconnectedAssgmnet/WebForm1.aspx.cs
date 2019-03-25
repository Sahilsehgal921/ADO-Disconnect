using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisconnectedAssgmnet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Class1 bal = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnInsertAdress_Click(object sender, EventArgs e)
        {
            Address address = new Address()
            {
                First_name = txtFirstName.Text,
                Phonenumber = txtPhonenumber.Text,
                age = Convert.ToInt32(txtage.Text),
                Last_name = txtLastname.Text,
                Email = txtEmail.Text
            };
            bal.InsertAddress(address);
        }       

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            bal.DeleteAddress(Convert.ToInt32(txtAdressId.Text));
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Address address = bal.SearchAdress(txtAdressId.Text);
            if (address != null)
            {
                txtage.Text = (address.age).ToString(); ;
                txtFirstName.Text = address.First_name;
                txtLastname.Text = address.Last_name;
            }
            else
            {
                lblMessage.Text = "Such address do not exist";
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            Address address = new Address()
            {
                First_name = txtFirstName.Text,
                Phonenumber = txtPhonenumber.Text,
                age = Convert.ToInt32(txtage.Text),
                Last_name = txtLastname.Text,
                Email = txtEmail.Text
            };
            bal.UpdateAddress(Convert.ToInt32(txtAdressId.Text), address);
        }
    }
}