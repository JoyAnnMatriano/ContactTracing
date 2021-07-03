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
            place_trvl.Visible = false;
            place_trvl_bx.Visible = false;
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

            travel_options.Items.Add("Yes");
            travel_options.Items.Add("No");

            sex_options.Items.Add("Female");
            sex_options.Items.Add("Male");
            sex_options.Items.Add("prefer not to say")


        }

        private void ImportantInfo(string firstName, string middleName, string surName, byte age)
        {
            StreamWriter outputFile = File.AppendText("customerDetails.txt");
            outputFile.WriteLine(DateTime.Now);
            outputFile.WriteLine("======================================================");
            outputFile.WriteLine(label_name.Text + " " + firstName + " " + middleName + " " + surName);
            outputFile.WriteLine("Age: " + age);
            outputFile.WriteLine("Phone Number: " + phone_bx.Text);
            outputFile.WriteLine("Email: " + email_bx.Text);
            outputFile.WriteLine("Address: " + add_bx.Text);
            outputFile.WriteLine($"Sex: {sex_options.SelectedItem});
            outputFile.WriteLine($"Travelled: {travel_options.SelectedItem}");
            outputFile.WriteLine($"Place(s): {place_trvl_bx}");
            outputFile.WriteLine($"Customer not experiencing any COVID 19 symptoms: {confirmbx_dropdown.SelectedItem}");
            outputFile.WriteLine("=======================================================");
            outputFile.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void travel_options_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (travel_options.SelectedItem == "Yes")
            {
                place_trvl.Visible = true;
                place_trvl_bx.Visible = true;
            }
            else
            {
                place_trvl.Visible = false;
                place_trvl_bx.Visible = false;
            }
        }

        private void confirmbx_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBox()
        {
            if (surName_bx.Text == "" || firstName_bx.Text == "")
            {
                MessageBox.Show("Please input your complete name");
            }
            else if (age_bx.Text == "" || phone_bx.Text == "" || add_bx.Text == "" || )
            {
                MessageBox.Show("Please input all the required fields");
            }
        }

        private void label_confirmation6_Click(object sender, EventArgs e)
        {

        }
    }
}
