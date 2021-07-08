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

            submit_btn.Enabled = false;
        }
        private void enter_btn_Click(object sender, EventArgs e)
        {
            ImportantInfo(firstName_bx.Text, middleName_bx.Text, surName_bx.Text, byte.Parse(age_bx.Text));

            dataCompleted_message();
        }
        private void ContactTracing_form_Load(object sender, EventArgs e)
        {
            travel_options.Items.Clear();
            travel_options.Items.Add("Yes");
            travel_options.Items.Add("No");

            sex_options.Items.Clear();
            sex_options.Items.Add("Female");
            sex_options.Items.Add("Male");
            sex_options.Items.Add("prefer not to say");
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
            outputFile.WriteLine($"Sex: {sex_options.SelectedItem}");
            outputFile.WriteLine($"Did the customer travelled?: {travel_options.SelectedItem}");
            outputFile.WriteLine($"(if YES) Place(s): {place_trvl_bx.Text}");
            outputFile.WriteLine("Customer not experiencing any COVID 19 symptoms: Checked");
            outputFile.WriteLine("=======================================================");
            outputFile.Close();
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
            EnableSubmitbtn();
        }
        private void redHighlight()
        {
            if (surName_bx.Text == "" || firstName_bx.Text == "")
            {
                MessageBox.Show("Please input your complete name");
            }
            if (age_bx.Text == "" || phone_bx.Text == "" || add_bx.Text == "")
            {
                MessageBox.Show("Please input all the required fields");
            }
            if (checkBox_confirm.CheckState == CheckState.Indeterminate)
            {
                checkBox_confirm.ForeColor = Color.Red;
            }
        }
        private void view_btn_click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Join(Environment.NewLine,
                                                     label_name.Text + " " + (firstName_bx).Text + " " + (middleName_bx).Text + " " + (surName_bx).Text,
                                                     "Age: " + (age_bx).Text,
                                                     "Phone Number: " + phone_bx.Text,
                                                     "Email: " + email_bx.Text,
                                                     "Address: " + add_bx.Text,
                                                     $"Sex: {sex_options.SelectedItem}",
                                                     $"Did the customer travelled?: {travel_options.SelectedItem}",
                                                     $"(if YES) Place(s): {place_trvl_bx.Text}"));
        }
        private void dataCompleted_message()
        {
            string message = "Thank you for filling up " + firstName_bx.Text + "!";
            MessageBox.Show(message);
            Application.Exit();
        }

        private void EnableSubmitbtn()
        {
            if (checkBox_confirm != null)
            {
                //all necesaary box is not filled up
                if (travel_options.SelectedItem == "Yes") //will see if the place travel is empty
                {
                    if (place_trvl_bx.Text != "")
                    {
                        if (firstName_bx.Text != "" || middleName_bx.Text != "" || surName_bx.Text != "" || age_bx.Text != "" || sex_options.SelectedItem != null || temp_bx.Text != "" ||
                            add_bx.Text != "" || phone_bx.Text != "" || travel_options.SelectedItem != null)
                        {
                            submit_btn.Enabled = true;
                        }
                    }
                }
                if (travel_options.SelectedItem == "No")
                {
                    if (firstName_bx.Text != "" || middleName_bx.Text != "" || surName_bx.Text != "" || age_bx.Text != "" || sex_options.SelectedItem != null || temp_bx.Text != "" ||
                        add_bx.Text != "" || phone_bx.Text != "" || travel_options.SelectedItem != null)
                    {
                        submit_btn.Enabled = true;
                    }
                    else
                        submit_btn.Enabled = false;
                }
            }
        }
    }
}

