using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCarWindowsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarRentalWCFService.CarRentalWCFServiceClient client = new
            CarRentalWCFService.CarRentalWCFServiceClient("NetTcpBinding_ICarRentalWCFService");
            client.RemoveCar(textBox1.Text);
        }
    }
}
