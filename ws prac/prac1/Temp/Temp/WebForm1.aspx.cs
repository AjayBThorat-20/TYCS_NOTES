using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            double result;
            try
            {
                ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();

                result = client.celsius_to_farhenheit(Convert.ToDouble(TextBox1.Text));

                if (DropDownList1.SelectedValue.Equals("Celsius"))
                {
                    Label2.Text = result.ToString();
                    Label4.Text = "&deg;Farhenheit";
                }
                if (DropDownList1.SelectedValue.Equals("Farhenheit"))
                {
                    Label2.Text = "Already in Farhenheit";
                    Label4.Text = "";
                }
            }
            catch (System.FormatException)
            {
                Label2.Text = "Invalid Inputs";
                Label4.Text = "";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double result;
            try
            {
                ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
                result = client.farhenheit_to_celsius((Convert.ToDouble(TextBox1.Text)));
                if (DropDownList1.SelectedValue.Equals("Celsius"))
                {
                    Label2.Text = "Already in Celsius";
                    Label4.Text = "";
                }
                if (DropDownList1.SelectedValue.Equals("Farhenheit"))
                {
                    Label2.Text = result.ToString();
                    Label4.Text = "&deg;celsius";
                }
            }
            catch (System.FormatException)
            {
                Label2.Text = "Invalid Inputs";
                Label4.Text = "";

            }
        }
    }
}