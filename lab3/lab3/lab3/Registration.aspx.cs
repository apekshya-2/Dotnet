using System;

namespace Lab3Examples
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblMessage.Text = $"Registered: {txtName.Text}, {txtEmail.Text}";
            }
        }
    }
}