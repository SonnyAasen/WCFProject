using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentalCarWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CarService.CarServiceClient client = new CarService.CarServiceClient("BasicHttpBinding_ICarService");
            client.RemoveCar(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            CarService.Car car = new CarService.Car
            {
                Id = Convert.ToInt32(TextBox2.Text),
                Brand = TextBox3.Text,
                Model = TextBox4.Text,
                Year = Convert.ToInt32(TextBox5.Text),
                RegNr = TextBox6.Text
            };

            CarService.CarServiceClient client = new CarService.CarServiceClient("BasicHttpBinding_ICarService");
            client.AddCar(car);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CarService.Customer customer = new CarService.Customer
            {
                Id = Convert.ToInt32(TextBox7.Text),
                Firstname = TextBox8.Text,
                Lastname = TextBox9.Text,
                Telephone = TextBox10.Text,
                Email = TextBox11.Text
            };

            CarService.CarServiceClient client = new CarService.CarServiceClient("BasicHttpBinding_ICarService");
            client.AddCustomer(customer);
        }
    }
}