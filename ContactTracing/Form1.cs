using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactTracing
{
    public partial class ContactTracing_form : Form
    {
        public ContactTracing_form()
        {
            InitializeComponent();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            ImportantInfo(firstName_bx.Text, middleName_bx.Text, surName_bx.Text, byte.Parse(age_bx.Text));
            string message = "Thank you for filling up "+ firstName_bx.Text + "!";
            MessageBox.Show(message);
            Application.Exit();

        }

        private void ContactTracing_form_Load(object sender, EventArgs e)
        {
            confirmbx_dropdown.Items.Add("Yes");
            confirmbx_dropdown.Items.Add("No");
            confirmbx_dropdown.Items.Add("I am not sure");
        }

        private void ImportantInfo(string firstName, string middleName, string surName, byte age)
        {
            int x = 0;
            StreamWriter outputFile = File.AppendText("customerDetails.txt");
            outputFile.WriteLine(DateTime.Now);
            outputFile.WriteLine("Customer No.: " + x+1 +"==============================");
            outputFile.WriteLine(label_name.Text + " " + firstName + " " + middleName + " " + surName);
            outputFile.WriteLine("Age: " + age);
            outputFile.WriteLine("Phone Number: " + phone_bx.Text);
            outputFile.WriteLine("Email: " + email_bx.Text);
            outputFile.WriteLine("Address: " + add_bx.Text);
            outputFile.WriteLine("Zip Code: " + zipCode_bx.Text);
            outputFile.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
